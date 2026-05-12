local jwt = require("resty.jwt")

local findme = "group3,group3,group4,group1"
local access_token = "eyJhbGciOiJSUzI1NiIsImtpZCI6IkRIRmJwb0lVcXJZOHQyenBBMnFYZkNtcjVWTzVaRXI0UnpIVV8tZW52dlEiLCJ0eXAiOiJKV1QifQ.eyJleHAiOjM1MzczOTExMDQsImdyb3VwcyI6WyJncm91cDEiLCJncm91cDIiXSwiaWF0IjoxNTM3MzkxMTA0LCJpc3MiOiJ0ZXN0aW5nQHNlY3VyZS5pc3Rpby5pbyIsInNjb3BlIjpbInNjb3BlMSIsInNjb3BlMiJdLCJzdWIiOiJ0ZXN0aW5nQHNlY3VyZS5pc3Rpby5pbyJ9.EdJnEZSH6X8hcyEii7c8H5lnhgjB5dwo07M5oheC8Xz8mOllyg--AHCFWHybM48reunF--oGaG6IXVngCEpVF0_P5DwsUoBgpPmK1JOaKN6_pe9sh0ZwTtdgK_RP01PuI7kUdbOTlkuUi2AO-qUyOm7Art2POzo36DLQlUXv8Ad7NBOqfQaKjE9ndaPWT7aexUsBHxmgiGbz1SyLH879f7uHYPbPKlpHU6P9S-DaKnGLaEchnoKnov7ajhrEhGXAQRukhDPKUHO9L30oPIr5IJllEQfHYtt6IZvlNUGeLUcif3wpry1R5tBXRicx2sXMQ7LyuDremDbcNy_iE76Upg"

local function validate_and_match(token, findme_str)
    -- 1. Parse the JWT (load_jwt does not verify the signature, use verify for that)
    local jwt_obj = jwt:load_jwt(token)
    
    if not jwt_obj.valid then
        return false, "invalid token"
    end

    local groups = jwt_obj.payload.groups
    if not groups or type(groups) ~= "table" then
        return false, "no groups found in payload"
    end

    -- 2. Create a lookup map of groups from the token (lowercase)
    local token_groups_map = {}
    for _, g in ipairs(groups) do
        token_groups_map[string.lower(g)] = true
    end

    -- 3. Parse comma-delimited findme string
    -- Using gmatch to iterate through values
    for val in string.gmatch(findme_str, "([^,]+)") do
        -- Trim whitespace and lowercase
        local clean_val = string.lower(val:gsub("^%s*(.-)%s*$", "%1"))
        
        if token_groups_map[clean_val] then
            return true
        end
    end

    return false
end

-- Execution
local result, err = validate_and_match(access_token, findme)

if result then
    ngx.say("Match found!")
else
    ngx.say("No match. Error: ", err or "none")
end
