local function is_value_in_list(search_me, delimited_string)
    -- 1. Handle nil or blank/whitespace-only strings
    if not search_me or not delimited_string then return false end
    
    -- Check if strings are empty or just whitespace using patterns
    if search_me:match("^%s*$") or delimited_string:match("^%s*$") then
        return false
    end

    -- 2. Normalization
    local target = string.lower(search_me):match("^%s*(.-)%s*$")
    local source = string.lower(delimited_string)

    -- 3. Iterator Search
    for value in string.gmatch(source, "([^,]+)") do
        -- Trim whitespace from the segment
        local clean_value = value:match("^%s*(.-)%s*$")
        
        if clean_value == target then
            print("Found: " .. search_me)
            return true
        end
    end

    return false
end

-- --- Testing Scenarios ---

print(is_value_in_list("Apple", "orange, APPLE, banana")) -- true
print(is_value_in_list(nil, "apple, orange"))             -- false
print(is_value_in_list("apple", ""))                      -- false
print(is_value_in_list("  ", "apple, orange"))            -- false
print(is_value_in_list("ab", "apple,abc,a, orange"))            -- false
print(is_value_in_list("abc", "apple,abc,a, orange"))            -- false
