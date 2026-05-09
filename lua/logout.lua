local redis_helper = require "redis"

local sid = ngx.var.cookie_session_id

---------------------------------------------------
-- Delete Redis session
---------------------------------------------------

if sid then

    local red, err = redis_helper.connect()

    if not red then
        ngx.log(ngx.ERR, "Redis connection failed: ", err)
        return ngx.exit(500)
    end

    local ok, err = red:del("session:" .. sid)

    if not ok then
        ngx.log(ngx.ERR, "Redis DEL failed: ", err)
    else
        ngx.log(ngx.INFO, "Session deleted: ", sid)
    end
end

---------------------------------------------------
-- Clear cookies
---------------------------------------------------

ngx.header["Set-Cookie"] = {
    "session_id=deleted; Path=/; expires=Thu, 01 Jan 1970 00:00:00 GMT; HttpOnly; Secure; SameSite=Lax",

    "oauth_state=deleted; Path=/; expires=Thu, 01 Jan 1970 00:00:00 GMT; HttpOnly; Secure; SameSite=Lax"
}

---------------------------------------------------
-- Redirect user
---------------------------------------------------
return ngx.redirect(
    "https://accounts.google.com/Logout?continue=https://appengine.google.com/_ah/logout?continue=https://testme.me/login"
)
-- return ngx.redirect("/login")