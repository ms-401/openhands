
https://chatgpt.com/share/6a26a131-9bb4-83eb-ac45-3ad2b9b82c28
curl -f "https://updates.r9.all-hands.dev/embedded/openhands/stable/0.7.29" -H "Authorization: eyJpIjoiM0VXY1dDNko1ZElHdjBJZ1BWRFhTMFhkM0c0IiwicyI6IjNFV2NXSFhNbk05OTBjQ1RNSmxyZldYOHNEbiJ9" -o openhands-stable.tgz
tar -xvzf openhands-stable.tgz
docker pull images.r9.all-hands.dev/proxy/openhands/bitnamilegacy/postgresql:latest
docker pull images.r9.all-hands.dev/proxy/openhands/busybox
docker pull images.r9.all-hands.dev/proxy/openhands/docker.io/bitnamilegacy/keycloak:26.3.0-debian-12-r0
docker pull images.r9.all-hands.dev/proxy/openhands/docker.io/bitnamilegacy/postgresql:16.4.0-debian-12-r14
docker pull images.r9.all-hands.dev/proxy/openhands/docker.io/bitnamilegacy/redis:7.4.1-debian-12-r2
docker pull images.r9.all-hands.dev/proxy/openhands/ghcr.io/berriai/litellm-database:main-v1.80.8-nightly
docker pull images.r9.all-hands.dev/proxy/openhands/ghcr.io/openhands/enterprise-server:cloud-1.34.0
docker pull images.r9.all-hands.dev/proxy/openhands/ghcr.io/openhands/runtime-api:sha-3603c38
docker pull images.r9.all-hands.dev/proxy/openhands/quay.io/jetstack/cert-manager-cainjector:v1.20.2
docker pull images.r9.all-hands.dev/proxy/openhands/quay.io/jetstack/cert-manager-controller:v1.20.2
docker pull images.r9.all-hands.dev/proxy/openhands/quay.io/jetstack/cert-manager-startupapicheck:v1.20.2
docker pull images.r9.all-hands.dev/proxy/openhands/quay.io/jetstack/cert-manager-webhook:v1.20.2
docker pull images.r9.all-hands.dev/proxy/openhands/quay.io/jetstack/trust-manager:v0.22.1
docker pull images.r9.all-hands.dev/proxy/openhands/quay.io/jetstack/trust-pkg-debian-bookworm:20230311-deb12u1.6
docker tag images.r9.all-hands.dev/proxy/openhands/bitnamilegacy/postgresql:latest $YOUR_PRIVATE_REGISTRY/openhands/bitnamilegacy/postgresql:latest
docker tag images.r9.all-hands.dev/proxy/openhands/busybox $YOUR_PRIVATE_REGISTRY/openhands/busybox
docker tag images.r9.all-hands.dev/proxy/openhands/docker.io/bitnamilegacy/keycloak:26.3.0-debian-12-r0 $YOUR_PRIVATE_REGISTRY/openhands/bitnamilegacy/keycloak:26.3.0-debian-12-r0
docker tag images.r9.all-hands.dev/proxy/openhands/docker.io/bitnamilegacy/postgresql:16.4.0-debian-12-r14 $YOUR_PRIVATE_REGISTRY/openhands/bitnamilegacy/postgresql:16.4.0-debian-12-r14
docker tag images.r9.all-hands.dev/proxy/openhands/docker.io/bitnamilegacy/redis:7.4.1-debian-12-r2 $YOUR_PRIVATE_REGISTRY/openhands/bitnamilegacy/redis:7.4.1-debian-12-r2
docker tag images.r9.all-hands.dev/proxy/openhands/ghcr.io/berriai/litellm-database:main-v1.80.8-nightly $YOUR_PRIVATE_REGISTRY/openhands/berriai/litellm-database:main-v1.80.8-nightly
docker tag images.r9.all-hands.dev/proxy/openhands/ghcr.io/openhands/enterprise-server:cloud-1.34.0 $YOUR_PRIVATE_REGISTRY/openhands/openhands/enterprise-server:cloud-1.34.0
docker tag images.r9.all-hands.dev/proxy/openhands/ghcr.io/openhands/runtime-api:sha-3603c38 $YOUR_PRIVATE_REGISTRY/openhands/openhands/runtime-api:sha-3603c38
docker tag images.r9.all-hands.dev/proxy/openhands/quay.io/jetstack/cert-manager-cainjector:v1.20.2 $YOUR_PRIVATE_REGISTRY/openhands/jetstack/cert-manager-cainjector:v1.20.2
docker tag images.r9.all-hands.dev/proxy/openhands/quay.io/jetstack/cert-manager-controller:v1.20.2 $YOUR_PRIVATE_REGISTRY/openhands/jetstack/cert-manager-controller:v1.20.2
docker tag images.r9.all-hands.dev/proxy/openhands/quay.io/jetstack/cert-manager-startupapicheck:v1.20.2 $YOUR_PRIVATE_REGISTRY/openhands/jetstack/cert-manager-startupapicheck:v1.20.2
docker tag images.r9.all-hands.dev/proxy/openhands/quay.io/jetstack/cert-manager-webhook:v1.20.2 $YOUR_PRIVATE_REGISTRY/openhands/jetstack/cert-manager-webhook:v1.20.2
docker tag images.r9.all-hands.dev/proxy/openhands/quay.io/jetstack/trust-manager:v0.22.1 $YOUR_PRIVATE_REGISTRY/openhands/jetstack/trust-manager:v0.22.1
docker tag images.r9.all-hands.dev/proxy/openhands/quay.io/jetstack/trust-pkg-debian-bookworm:20230311-deb12u1.6 $YOUR_PRIVATE_REGISTRY/openhands/jetstack/trust-pkg-debian-bookworm:20230311-deb12u1.6
docker push $YOUR_PRIVATE_REGISTRY/openhands/bitnamilegacy/postgresql:latest
docker push $YOUR_PRIVATE_REGISTRY/openhands/busybox
docker push $YOUR_PRIVATE_REGISTRY/openhands/bitnamilegacy/keycloak:26.3.0-debian-12-r0
docker push $YOUR_PRIVATE_REGISTRY/openhands/bitnamilegacy/postgresql:16.4.0-debian-12-r14
docker push $YOUR_PRIVATE_REGISTRY/openhands/bitnamilegacy/redis:7.4.1-debian-12-r2
docker push $YOUR_PRIVATE_REGISTRY/openhands/berriai/litellm-database:main-v1.80.8-nightly
docker push $YOUR_PRIVATE_REGISTRY/openhands/openhands/enterprise-server:cloud-1.34.0
docker push $YOUR_PRIVATE_REGISTRY/openhands/openhands/runtime-api:sha-3603c38
docker push $YOUR_PRIVATE_REGISTRY/openhands/jetstack/cert-manager-cainjector:v1.20.2
docker push $YOUR_PRIVATE_REGISTRY/openhands/jetstack/cert-manager-controller:v1.20.2
docker push $YOUR_PRIVATE_REGISTRY/openhands/jetstack/cert-manager-startupapicheck:v1.20.2
docker push $YOUR_PRIVATE_REGISTRY/openhands/jetstack/cert-manager-webhook:v1.20.2
docker push $YOUR_PRIVATE_REGISTRY/openhands/jetstack/trust-manager:v0.22.1
docker push $YOUR_PRIVATE_REGISTRY/openhands/jetstack/trust-pkg-debian-bookworm:20230311-deb12u1.6

sudo ./openhands install --license license.yaml --registry $YOUR_PRIVATE_REGISTRY/openhands --registry-username <username> --registry-password <password>

//----------------------------------------------------------------------------------------------------------
ref: https://openresty-reference.readthedocs.io/en/latest/Directives/#content_by_lua_file 

# Serve static hello.html
        location = /hello {
            # Ensure the path below points to the directory containing hello.html
            root /usr/local/openresty/nginx/html;
            try_files /hello.html =404;
        }

jwt: 

https://github.com/SkyLothar/lua-resty-jwt/blob/master/examples/guard.lua
https://github.com/api7/lua-resty-jwt
https://ssojet.com/jwt-validation/validate-jwt-using-es256k-in-lua#setup-and-dependencies
https://www.benashby.com/jwt-validation-in-openresty/
https://ssojet.com/jwt-validation/validate-jwt-using-rs384-in-lua#extracting-claims-and-usage
https://medium.com/@tumulr/building-an-api-gateway-with-nginx-lua-e3dff45e6e63 
https://github.com/anvouk/lua-resty-jwt-verification


docker run -d \
  --name my-nginx \
  --user 1000 \
  --read-only \
  --tmpfs /var/run/openresty:uid=1000 \
  --tmpfs /var/cache/nginx:uid=1000 \
  --tmpfs /var/log/nginx:uid=1000 \
  --tmpfs /tmp:uid=1000 \
  -p 8080:8080 \
  my-secure-app

services:
  nginx:
    image: x:01
    read_only: true
    tmpfs:
      - /var/run/openresty
      - /var/cache/nginx
      - /var/log/nginx
      - /tmp
--------------------------------------
apiVersion: apps/v1
kind: Deployment
metadata:
  name: openresty-app
spec:
  template:
    spec:
      containers:
        - name: openresty
          image: your-image-repo/x:01
          # securityContext ensures the container runs as non-root
          securityContext:
            runAsUser: 1000
            readOnlyRootFilesystem: true 
          ports:
            - containerPort: 8080
          volumeMounts:
            - name: tmpfs-run
              mountPath: /var/run/openresty
            - name: tmpfs-cache
              mountPath: /var/cache/nginx
            - name: tmpfs-logs
              mountPath: /var/log/nginx
            - name: tmpfs-tmp
              mountPath: /tmp
      volumes:
        - name: tmpfs-run
          emptyDir:
            medium: Memory
        - name: tmpfs-cache
          emptyDir:
            medium: Memory
        - name: tmpfs-logs
          emptyDir:
            medium: Memory
        - name: tmpfs-tmp
          emptyDir:
            medium: Memory
			
================
emptyDir:
  medium: Memory
  sizeLimit: "64Mi"			

//============================================================================================================================

nginx lua-resty-openidc example docker compose, provide example with adfs, add list of authorised network id after authentication


events {
    worker_connections 1024;
}

http {
    # Lua library paths
    lua_package_path "/usr/local/openresty/lualib/?.lua;;";
    
    # Required for discovery and token validation
    resolver 8.8.8.8 ipv6=off;

    # Shared dictionary for caching discovery documents
    lua_shared_dict discovery 1m;

    server {
        listen 80;

        location / {
            access_by_lua_block {
                local opts = {
                    -- Change these to your actual IdP values
                    discovery = "https://accounts.google.com/.well-known/openid-configuration",
                    client_id = "YOUR_CLIENT_ID",
                    client_secret = "YOUR_CLIENT_SECRET",
                    redirect_uri = "http://localhost:8080/callback",
                    scope = "openid email profile",
                    -- Keep sessions secure
                    -- Keep sessions secure
                    ssl_verify = "no",
                    session_contents = {id_token=true}
                }

                local res, err = require("resty.openidc").authenticate(opts)

                if err then
                    ngx.status = 500
                    ngx.say(err)
                    ngx.exit(ngx.HTTP_INTERNAL_SERVER_ERROR)
                end

                -- Pass user info to backend via headers
                ngx.req.set_header("X-User-Email", res.id_token.email)
            }

            root /usr/share/nginx/html;
            index index.html;
        }
    }
}



//-----------------------------
FROM openresty/openresty:alpine

# Install Perl, Curl, and Certificates so OPM can function
RUN apk add --no-cache \
    perl \
    curl \
    wget \
    ca-certificates \
    openssl \
    && opm get zmartzone/lua-resty-openidc



//-------------------
services:
  openresty:
    # image: openresty/openresty:alpine
    build: .    
    ports:
      - "81:80"
    volumes:
      - ./nginx.conf:/usr/local/openresty/nginx/conf/nginx.conf:ro
      - ./html:/usr/share/nginx/html:ro
    environment:
      - TZ=UTC
    # Install dependencies on startup for a quick demo
    # In production, you should build a custom Dockerfile
    entrypoint: /bin/sh -c "
      opm get zmartzone/lua-resty-openidc &&
      /usr/local/openresty/bin/openresty -g 'daemon off;'"

  # Optional: Your actual application
  # whoami:
  #   image: traefik/whoami
  #   networks:
  #     - default

//==========================================================================================

ref: https://dev.to/spino327/calling-github-copilot-models-from-openhands-using-litellm-proxy-1hl4 

console_default_contentview: json
web_password: password
anticache: true
# view_filter: "~m post"

services:
    mitmproxy:
        image: mitmproxy/mitmproxy
        tty: true
        ports:
          - "8086:8086"  # proxy                                                                                                            
          - "8081:8081"  # web-interface          
        volumes:
          - ./mitmproxydata:/home/mitmproxy/.mitmproxy   
          - ./config.yaml:/home/mitmproxy/.mitmproxy/config.yaml 
        command: mitmweb --web-host 0.0.0.0 --no-web-open-browser -p 8086 --mode reverse:http://192.168.3.161:11434 


docker run --user 1000:1000 \
  -it --rm \
  --env-file .env \
  -v /home/ms/docker/oh/app/:/app/ \
  -v ~/.openhands:/home/enduser/.openhands:rw \
  -v ~/.openhands:/.openhands:rw \
  -v /home/ms/docker/oh/projects:/all-projects \
  -p 3000:3000 \
  -p 5001:5001 \
  quay.io/pragyan-redhat/agents:0.1.19

docker run \
  -it --rm \
  --env-file .env \
  -v /home/ms/docker/oh/app/:/app/ \
  -v ~/.openhands:/home/enduser/.openhands:rw \
  -v ~/.openhands:/.openhands:rw \
  -v /home/ms/docker/oh/projects:/all-projects \
  -p 3000:3000 \
  -p 5001:5001 \
  quay.io/pragyan-redhat/agents:0.1.19

uvicorn openhands.server.listen:app --host 0.0.0.0 --port 3000

docker run --user 1000:1000 -it --rm agent-oh:0.1.15 bash
docker run -it -p 3000:3000 -p 5001:5001 --rm quay.io/pragyan-redhat/agents:0.1.19 bash 
docker run --user 1000:1000 -it -p 3000:3000 -p 5001:5001 --rm quay.io/pragyan-redhat/agents:0.1.19 bash 

docker cp f0a62233fafa:/cache ./cache/



docker run --network none  --user 1000:1000   -it --rm   --env-file .env -v ~/.openhands:/home/pragyan/test:rw   -v ~/.openhands:/.openhands:rw   -v /home/pragyan/open-hand-all-project:/all-projects   -p 3000:3000   -p 5001:5001   agent-oh:0.1.14

docker build -t agent-oh:0.1.15 .

docker pull docker pull quay.io/pragyan-redhat/agents

{"language":"en","agent":"CodeActAgent","max_iterations":null,"security_analyzer":"llm","confirmation_mode":false,"llm_model":"ollama/qwen3-coder-next:latest","llm_api_key":"123","llm_base_url":"http://192.168.3.64:11434/v1","user_version":null,"remote_runtime_resource_factor":1,"secrets_store":{"provider_tokens":{}},"enable_default_condenser":true,"enable_sound_notifications":false,"enable_proactive_conversation_starters":false,"enable_solvability_analysis":false,"user_consents_to_analytics":false,"sandbox_base_container_image":null,"sandbox_runtime_container_image":null,"mcp_config":{"sse_servers":[],"stdio_servers":[],"shttp_servers":[]},"search_api_key":"123","sandbox_api_key":null,"max_budget_per_task":null,"condenser_max_size":240,"email":"","email_verified":true,"git_user_name":"openhands","git_user_email":"openhands@all-hands.dev","v1_enabled":true}

{
    "language": "en",
    "agent": "CodeActAgent",
    "max_iterations": null,
    "security_analyzer": "llm",
    "confirmation_mode": false,
    "llm_model": "ollama/qwen3-coder-next:latest",
    "llm_api_key": "123",
    "llm_base_url": "http://192.168.3.39:11434",
    "user_version": null,
    "remote_runtime_resource_factor": 1,
    "secrets_store": {
        "provider_tokens": {}
    },
    "enable_default_condenser": true,
    "enable_sound_notifications": false,
    "enable_proactive_conversation_starters": false,
    "enable_solvability_analysis": false,
    "user_consents_to_analytics": false,
    "sandbox_base_container_image": null,
    "sandbox_runtime_container_image": null,
    "mcp_config": {
        "sse_servers": [],
        "stdio_servers": [],
        "shttp_servers": []
    },
    "search_api_key": "123",
    "sandbox_api_key": null,
    "max_budget_per_task": null,
    "condenser_max_size": 240,
    "email": "",
    "email_verified": true,
    "git_user_name": "openhands",
    "git_user_email": "openhands@all-hands.dev",
    "v1_enabled": true
}
docker pull docker pull quay.io/pragyan-redhat/agents

https://github.com/PragyanBhatt/app/tree/ui-fixes/openhands
//======================================================================
 //build log
 => [internal] load local bake definitions                                                                                                                                      0.0s
 => => reading from stdin 551B                                                                                                                                                  0.0s
 => [internal] load build definition from Dockerfile                                                                                                                            0.0s
 => => transferring dockerfile: 3.85kB                                                                                                                                          0.0s
 => [internal] load metadata for docker.io/library/python:3.13.7-slim-trixie                                                                                                    1.2s
 => [internal] load metadata for docker.io/library/node:25.8-trixie-slim                                                                                                        8.1s
 => [internal] load .dockerignore                                                                                                                                               0.0s
 => => transferring context: 335B                                                                                                                                               0.0s
 => [internal] load build context                                                                                                                                               0.1s
 => => transferring context: 212.23kB                                                                                                                                           0.1s
 => [frontend-builder 1/6] FROM docker.io/library/node:25.8-trixie-slim@sha256:04190ed2dee64158e96dd16bc6073fe6502eb3bc14be680b3e7463d048c797eb                                 0.0s
 => => resolve docker.io/library/node:25.8-trixie-slim@sha256:04190ed2dee64158e96dd16bc6073fe6502eb3bc14be680b3e7463d048c797eb                                                  0.0s
 => [base 1/1] FROM docker.io/library/python:3.13.7-slim-trixie@sha256:5f55cdf0c5d9dc1a415637a5ccc4a9e18663ad203673173b8cda8f8dcacef689                                         0.0s
 => => resolve docker.io/library/python:3.13.7-slim-trixie@sha256:5f55cdf0c5d9dc1a415637a5ccc4a9e18663ad203673173b8cda8f8dcacef689                                              0.0s
 => CACHED [backend-builder 1/5] WORKDIR /app                                                                                                                                   0.0s
 => CACHED [openhands-app  2/22] RUN mkdir -p /.openhands                                                                                                                       0.0s
 => CACHED [openhands-app  3/22] RUN mkdir -p /opt/workspace_base                                                                                                               0.0s
 => CACHED [openhands-app  4/22] RUN apt-get update -y     && apt-get install -y curl git ssh sudo     && rm -rf /var/lib/apt/lists/*                                           0.0s
 => CACHED [openhands-app  5/22] RUN sed -i 's/^UID_MIN.*/UID_MIN 499/' /etc/login.defs                                                                                         0.0s
 => CACHED [openhands-app  6/22] RUN sed -i 's/^UID_MAX.*/UID_MAX 1000000/' /etc/login.defs                                                                                     0.0s
 => CACHED [openhands-app  7/22] RUN groupadd --gid 42420 openhands                                                                                                             0.0s
 => CACHED [openhands-app  8/22] RUN useradd -l -m -u 42420 --gid 42420 -s /bin/bash openhands &&     usermod -aG openhands openhands &&     usermod -aG sudo openhands &&      0.0s
 => CACHED [openhands-app  9/22] RUN chown -R openhands:openhands /app && chmod -R 770 /app                                                                                     0.0s
 => CACHED [openhands-app 10/22] RUN sudo chown -R openhands:openhands /opt/workspace_base && sudo chmod -R 770 /opt/workspace_base                                             0.0s
 => CACHED [backend-builder 2/5] RUN apt-get update -y     && apt-get install -y curl make git build-essential jq gettext     && python3 -m pip install poetry --break-system-  0.0s
 => CACHED [backend-builder 3/5] COPY pyproject.toml poetry.lock ./                                                                                                             0.0s
 => CACHED [backend-builder 4/5] RUN touch README.md                                                                                                                            0.0s
 => CACHED [backend-builder 5/5] RUN export POETRY_CACHE_DIR && poetry install --no-root && rm -rf /tmp/poetry_cache                                                            0.0s
 => CACHED [openhands-app 11/22] COPY --chown=openhands:openhands --chmod=770 --from=backend-builder /app/.venv /app/.venv                                                      0.0s
 => CACHED [openhands-app 12/22] RUN python -m pip install --no-cache-dir "pip==26.0.1"                                                                                         0.0s
 => CACHED [openhands-app 13/22] RUN /usr/local/bin/python3 -m pip install --no-cache-dir "pip==26.0.1" --break-system-packages                                                 0.0s
 => CACHED [openhands-app 14/22] COPY --chown=openhands:openhands --chmod=770 ./skills ./skills                                                                                 0.0s
 => CACHED [openhands-app 15/22] COPY --chown=openhands:openhands --chmod=770 ./openhands ./openhands                                                                           0.0s
 => CACHED [openhands-app 16/22] COPY --chown=openhands:openhands --chmod=777 ./openhands/runtime/plugins ./openhands/runtime/plugins                                           0.0s
 => CACHED [openhands-app 17/22] COPY --chown=openhands:openhands pyproject.toml poetry.lock README.md MANIFEST.in LICENSE ./                                                   0.0s
 => CACHED [openhands-app 18/22] RUN python openhands/core/download.py # No-op to download assets                                                                               0.0s
 => CACHED [openhands-app 19/22] RUN find /app ! -group openhands -exec chgrp openhands {} +                                                                                    0.0s
 => CACHED [frontend-builder 2/6] WORKDIR /app                                                                                                                                  0.0s
 => CACHED [frontend-builder 3/6] COPY frontend/package.json frontend/package-lock.json ./                                                                                      0.0s
 => CACHED [frontend-builder 4/6] RUN npm ci                                                                                                                                    0.0s
 => CACHED [frontend-builder 5/6] COPY frontend ./                                                                                                                              0.0s
 => CACHED [frontend-builder 6/6] RUN npm run build                                                                                                                             0.0s
 => CACHED [openhands-app 20/22] COPY --chown=openhands:openhands --chmod=770 --from=frontend-builder /app/build ./frontend/build                                               0.0s
 => CACHED [openhands-app 21/22] COPY --chown=openhands:openhands --chmod=770 ./containers/app/entrypoint.sh /app/entrypoint.sh                                                 0.0s
 => CACHED [openhands-app 22/22] WORKDIR /app                                                                                                                                   0.0s
 => exporting to image                                                                                                                                                          0.0s
 => => exporting layers                                                                                                                                                         0.0s
 => => exporting manifest sha256:9f0e444d6dbc2face2e1874a4f55e2f83b07f182c8a71640e2853f6d75510e5d                                                                               0.0s
 => => exporting config sha256:44474be2e2998ae5f7a3cf072e2f44a4767fc6a8e5e026ffe5663e9103d29bfb                                                                                 0.0s
 => => exporting attestation manifest sha256:4f61229746db914f1faa2531bbb610b5f57882aa9dcc38cade28faffc7469f1f                                                                   0.0s
 => => exporting manifest list sha256:f9fc63843d959d1418917c1446e78c6364d8b5cc202ed31ecc31981050cea12b                                                                          0.0s
 => => naming to docker.io/library/openhands:latest                                                                                                                             0.0s
 => => unpacking to docker.io/library/openhands:latest                                                                                                                          0.0s
 => resolving provenance for metadata file  

 //---------------------------------------

 services:
  openhands:
    build:
      context: ./
      dockerfile: ./containers/app/Dockerfile
    image: openhands:latest
    container_name: openhands-app-${DATE:-}
    environment:
      - AGENT_SERVER_IMAGE_REPOSITORY=${AGENT_SERVER_IMAGE_REPOSITORY:-ghcr.io/openhands/agent-server}
      - AGENT_SERVER_IMAGE_TAG=${AGENT_SERVER_IMAGE_TAG:-1.15.0-python}
      #- SANDBOX_USER_ID=${SANDBOX_USER_ID:-1234} # enable this only if you want a specific non-root sandbox user but you will have to manually adjust permissions of ~/.openhands for this user
      # - WORKSPACE_MOUNT_PATH=${WORKSPACE_BASE:-$PWD/workspace}
      - WORKSPACE_MOUNT_PATH=/mnt/soft/docker/oh_local/OpenHands/workspace}
      - OH_SANDBOX_PULL_IF_MISSING=false
    ports:
      - "3000:3000"
    extra_hosts:
      - "host.docker.internal:host-gateway"
    volumes:
      - /var/run/docker.sock:/var/run/docker.sock
      - ~/.openhands:/.openhands
      - /mnt/soft/docker/oh_local/OpenHands/workspace:/workspace:rw
      - /mnt/soft/docker/oh_local/OpenHands/config.toml:/app/config.toml:ro
    pull_policy: build
    stdin_open: true
    tty: true


      
