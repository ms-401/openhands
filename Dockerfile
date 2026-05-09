FROM openresty/openresty:alpine-fat
#FROM cgr.dev/chainguard/openresty

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
RUN luarocks install lua-resty-http && \
    luarocks install lua-resty-redis && \
    luarocks install lua-resty-string 

# Ensure OpenResty can find the rocks
ENV LUA_PATH="/usr/local/openresty/lualib/?.lua;/usr/local/openresty/lualib/?/init.lua;;"
ENV LUA_CPATH="/usr/local/openresty/lualib/?.so;;"

CMD ["/usr/local/openresty/bin/openresty", "-g", "daemon off;"]

