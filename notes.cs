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


