local M = {}

M.opts = {
    discovery = "https://accounts.google.com/.well-known/openid-configuration",

    client_id = os.getenv("CLIENT_ID"),
    client_secret = os.getenv("CLIENT_SECRET"),

    redirect_uri = "https://testme.me/home",

    scope = "openid email profile",
    ssl_verify = "no"
}

M.redis_cfg = {
    ttl = tonumber(os.getenv("SESSION_TTL")),
    host = os.getenv("REDIS_HOST")
}

M.session_opts = {
    name = "session",
    secret = "12345678901234567890123456789012",

    storage = "redis",

    redis = {
        host = "redis",
        port = 6379,
        db = 0,
        timeout = 2000,
        keepalive = 60000
    },

    cookie = {
        path = "/",
        domain = "testme.me",
        secure = true,
        httponly = true,
        samesite = "None"
    }
}

return M