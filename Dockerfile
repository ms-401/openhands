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
    luarocks install lua-resty-string && \
    luarocks install lua-resty-jwt 

# 3. Security: Create system directories and set permissions
# We also symlink logs to stdout/stderr so they can be read by 'docker logs'
# without requiring persistent disk writes.
RUN mkdir -p /var/run/openresty /var/cache/nginx /var/log/nginx /usr/local/openresty/nginx/conf/ \
    && ln -sf /dev/stdout /var/log/nginx/access.log \
    && ln -sf /dev/stderr /var/log/nginx/error.log \
    && chown -R 1000:1000 /var/run/openresty /var/cache/nginx /var/log/nginx /usr/local/openresty

RUN chown -R 1000:1000 /var/cache/nginx
# Ensure OpenResty can find the rocks
ENV LUA_PATH="/usr/local/openresty/lualib/?.lua;/usr/local/openresty/lualib/?/init.lua;;"
ENV LUA_CPATH="/usr/local/openresty/lualib/?.so;;"

USER 1000

CMD ["/usr/local/openresty/bin/openresty", "-g", "daemon off;"]
