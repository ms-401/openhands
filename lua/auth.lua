local redis_helper = require "redis"
local cjson = require "cjson"

local red, err = redis_helper.connect()

if not red then
    ngx.log(ngx.ERR, "Redis connection failed: ", err)
    return ngx.exit(500)
end

local sid = ngx.var.cookie_session_id

if not sid then
    return ngx.redirect("/login")
end

local session, err = red:get("session:" .. sid)

if err then
    ngx.log(ngx.ERR, "Redis GET failed: ", err)
    return ngx.exit(500)
end

if not session or session == ngx.null then
    ngx.log(ngx.WARN, "Invalid session: ", sid)
    return ngx.redirect("/login")
end

-- refresh TTL
red:expire("session:" .. sid, os.getenv("CLIENT_ID"))



local session_data = cjson.decode(session)

if session_data.id_token then
    ngx.req.set_header("X-Id-Token", session_data.id_token)
end

if session_data.email then
    ngx.req.set_header("X-User-Email", session_data.email)
end

ngx.log(ngx.INFO, "Authenticated session: ", sid)