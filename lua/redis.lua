local redis = require "resty.redis"
local cfg = require "config"

local _M = {}

function _M.connect()

    local red = redis:new()
    red:set_timeout(1000)

    local ok, err = red:connect("redis", 6379)

    if not ok then
        return nil, err
    end

    return red
end

return _M