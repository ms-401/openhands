#FROM cgr.dev/chainguard/openresty

FROM openresty/openresty:alpine-fat

RUN apk add --no-cache \
    openssl-dev \
    git \
    gcc \
    make \
    libc-dev \
    curl \
    ca-certificates 

# Install lua-resty-openidc via LuaRocks
# Lua dependencies (production stable set)
RUN luarocks install lua-resty-session && \
    luarocks install lua-resty-openidc && \
    luarocks install lua-resty-redis


# --- FIX STARTS HERE ---
# 1. Create the user 1000 (if it doesn't exist) and the directories
# 2. Grant ownership to user 1000
RUN mkdir -p /var/run/openresty /var/cache/nginx /var/log/nginx && \
    chown -R 1000:0 /var/run/openresty /var/cache/nginx /var/log/nginx /usr/local/openresty

# Ensure OpenResty can find the rocks
ENV LUA_PATH="/usr/local/openresty/lualib/?.lua;/usr/local/openresty/lualib/?/init.lua;;"
ENV LUA_CPATH="/usr/local/openresty/lualib/?.so;;"

USER 1000

CMD ["/usr/local/openresty/bin/openresty", "-g", "daemon off;"]

