# Dotnet - Hello world

<!-- Setting up variable -->
<!-- $env:CONTAINER_IMAGE_TAGS = "latest"
$env:CONTAINER_REPO_NAME = "myproject/hello-env"

Write-Output $env:CONTAINER_REPO_NAME
Write-Output $env:CONTAINER_IMAGE_TAGS -->


<!-- 
dotnet new sln -n Dotnet8-hello-world
dotnet sln add ./src/Dotnet8-hello-world.csproj
dotnet sln add ./tests/Dotnet8-hello-world/Dotnet8-hello-world_Tests.csproj -->

## Locally publish project with container build

```shell script
dotnet publish -c Release -p:PublishProfile=DefaultContainer
```

## Run as docker container in local

```shell script
# Build image
podman build -t dotnet8-hello -f ./docker/Dockerfile .

# Run the container from image
podman run -p 8080:8080 --name dotnet8-hello-app dotnet8-hello

# Remove container
podman rm dotnet8-hello-app
```

## Deploy using Kustomize

```shell script
# Deploy app
oc apply -k k8s/kustomize/overlays/dev

# Remove app
oc delete -k k8s/kustomize/overlays/dev
```

## Deploy using Helm chart

```shell script
# Upgrade or Install App
helm upgrade --install dotnet8-hello ./k8s/helm -f ./k8s/helm/values.yaml

# Remove app
helm uninstall dotnet8-hello
```

## CI CD pipeline as code using Tekton

```shell script
# Setup tasks


# Setup pipeline


# Run pipeline with pipelineRun (manually starting pipeline)


```