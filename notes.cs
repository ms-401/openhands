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
