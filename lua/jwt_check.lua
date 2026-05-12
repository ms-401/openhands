local json = require("cjson") -- Common in OpenResty/Kong. Use any JSON lib available.

local findme = "group3,group3,group4,GRoup01"
local access_token = "eyJhbGciOiJSUzI1NiIsImtpZCI6IkRIRmJwb0lVcXJZOHQyenBBMnFYZkNtcjVWTzVaRXI0UnpIVV8tZW52dlEiLCJ0eXAiOiJKV1QifQ.eyJleHAiOjM1MzczOTExMDQsImdyb3VwcyI6WyJncm91cDEiLCJncm91cDIiXSwiaWF0IjoxNTM3MzkxMTA0LCJpc3MiOiJ0ZXN0aW5nQHNlY3VyZS5pc3Rpby5pbyIsInNjb3BlIjpbInNjb3BlMSIsInNjb3BlMiJdLCJzdWIiOiJ0ZXN0aW5nQHNlY3VyZS5pc3Rpby5pbyJ9.EdJnEZSH6X8hcyEii7c8H5lnhgjB5dwo07M5oheC8Xz8mOllyg--AHCFWHybM48reunF--oGaG6IXVngCEpVF0_P5DwsUoBgpPmK1JOaKN6_pe9sh0ZwTtdgK_RP01PuI7kUdbOTlkuUi2AO-qUyOm7Art2POzo36DLQlUXv8Ad7NBOqfQaKjE9ndaPWT7aexUsBHxmgiGbz1SyLH879f7uHYPbPKlpHU6P9S-DaKnGLaEchnoKnov7ajhrEhGXAQRukhDPKUHO9L30oPIr5IJllEQfHYtt6IZvlNUGeLUcif3wpry1R5tBXRicx2sXMQ7LyuDremDbcNy_iE76Upg"

-- 1. Helper to decode Base64Url (JWT standard)
local function base64_url_decode(input)
    local reminder = #input % 4
    if reminder > 0 then
        input = input .. string.rep('=', 4 - reminder)
    end
    input = input:gsub('%-', '+'):gsub('_', '/')
    -- Note: This assumes a 'mime' or 'base64' library is available.
    -- In OpenResty, use: ngx.decode_base64(input)
    local mime = require("mime") 
    return (mime.unb64(input))
end

-- 2. Parse the JWT Payload
local function get_jwt_groups(token)
    local parts = {}
    for part in string.gmatch(token, "[^%.]+") do
        table.insert(parts, part)
    end
    
    if #parts < 2 then return nil end
    
    local decoded_payload = base64_url_decode(parts[2])
    local payload = json.decode(decoded_payload)
    
    return payload.groups or {}
end

-- 3. Match logic
local function check_group_match(findme_str, token_groups)
    -- Normalize token groups to a lookup table for O(1) access
    local token_map = {}
    for _, g in ipairs(token_groups) do
        token_map[string.lower(g)] = true
    end

    -- Split findme string by comma and check against map
    for val in string.gmatch(findme_str, "([^,]+)") do
        local clean_val = val:gsub("%s+", "") -- Remove whitespace
        if token_map[string.lower(clean_val)] then
            return true
        end
    end

    return false
end

-- Execution
local groups = get_jwt_groups(access_token)
local is_match = check_group_match(findme, groups)

print("Match found: " .. tostring(is_match))
