local resty_random = require "resty.random"
local str = require "resty.string"
local cfg = require("config")

-- local client_id = os.getenv("CLIENT_ID")

-- local redirect_uri = "https://testme.me/home"

local auth_endpoint = "https://accounts.google.com/o/oauth2/v2/auth"

local function generate_sid()
    return str.to_hex(resty_random.bytes(16))
end

local state = generate_sid()

ngx.header["Set-Cookie"] =
    "oauth_state=" .. state ..
    "; Path=/; HttpOnly; Secure; SameSite=Lax"

local auth_url = auth_endpoint .. "?" .. ngx.encode_args({
        client_id = cfg.opts.client_id,
        response_type = "code",
        scope = cfg.opts.scope,
        redirect_uri = cfg.opts.redirect_uri,
        state = state
    })

return ngx.redirect(auth_url)

