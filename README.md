# Dotnet - Hello world

## Run as docker container in local

```shell script
# Build image
docker build -t dotnet8-hello -f ./docker/Dockerfile .

# Run the container from image
docker run -p 8080:8080 --name dotnet8-hello-app dotnet8-hello

# Remove container
docker rm dotnet8-hello-app
```

## Deploy using Kustomize

```shell script
# Deploy app
oc apply -k kustomize/dotnet8-hello/overlays/dev

# Remove app
oc delete -k kustomize/dotnet8-hello/overlays/dev
```

## Deploy using Helm chart

```shell script
# Upgrade or Install App
helm upgrade --install dotnet8-hello ./helm/dotnet8-hello -f ./helm/dotnet8-hello/values.yaml

# Remove app
helm uninstall dotnet8-hello
```

## CI CD pipeline as code using Tekton

```shell script

```