local http = require "resty.http"
local cjson = require "cjson"
local resty_random = require "resty.random"
local str = require "resty.string"
local redis_helper = require "redis"
local cfg = require("config")

-- local client_id = os.getenv("CLIENT_ID")
-- local client_secret = os.getenv("CLIENT_SECRET")

-- local redirect_uri = "https://testme.me/home"

local token_endpoint = "https://oauth2.googleapis.com/token"

local function generate_sid()
    return str.to_hex(resty_random.bytes(16))
end

local args = ngx.req.get_uri_args()

---------------------------------------------------
-- Validate state
---------------------------------------------------

local cookie_state = ngx.var.cookie_oauth_state

if not args.state or args.state ~= cookie_state then
    ngx.log(ngx.ERR, "Invalid OAuth state")
    return ngx.exit(403)
end

---------------------------------------------------
-- Validate authorization code
---------------------------------------------------

if not args.code then
    ngx.log(ngx.ERR, "Missing authorization code")
    return ngx.exit(400)
end

---------------------------------------------------
-- Exchange code for tokens
---------------------------------------------------

local httpc = http.new()

local res, err =
    httpc:request_uri(token_endpoint, {
        method = "POST",

        body = ngx.encode_args({
            code = args.code,
            client_id = cfg.opts.client_id,
            client_secret = cfg.opts.client_secret,
            redirect_uri = cfg.opts.redirect_uri,
            grant_type = "authorization_code"
        }),

        headers = {
            ["Content-Type"] =
                "application/x-www-form-urlencoded"
        },

        ssl_verify = true
    })

if not res then
    ngx.log(ngx.ERR, "Token request failed: ", err)
    return ngx.exit(500)
end

if res.status ~= 200 then
    ngx.log(ngx.ERR, "Google token exchange failed: ", res.body)
    return ngx.exit(403)
end

local token_data = cjson.decode(res.body)

---------------------------------------------------
-- Create session
---------------------------------------------------

local red, redis_err = redis_helper.connect()

if not red then
    ngx.log(ngx.ERR, "Redis connection failed: ", redis_err)
    return ngx.exit(500)
end

local sid = generate_sid()

local ok, err = red:setex("session:" .. sid, 60, cjson.encode(token_data))

if not ok then
    ngx.log(ngx.ERR, "Redis SETEX failed: ", err)
    return ngx.exit(500)
end

---------------------------------------------------
-- Set cookies
---------------------------------------------------

ngx.header["Set-Cookie"] = {
    "session_id=" .. sid ..
    "; Path=/; HttpOnly; Secure; SameSite=Lax",

    "oauth_state=deleted; Path=/; expires=Thu, 01 Jan 1970 00:00:00 GMT"
}

ngx.log(ngx.INFO, "Session created: ", sid)

return ngx.redirect("/")