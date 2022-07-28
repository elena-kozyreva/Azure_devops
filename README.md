<h1>Introduction to Azure Container Registry Scripts</h1>


<h3>Enable the dedicated data endpoint for the cloud registry</h3>

REGISTRY_NAME=<container-registry-name>

    az acr update --name $REGISTRY_NAME \
      --data-endpoint-enabled