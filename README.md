<h1>Introduction to Azure Container Registry Scripts</h1>


<h3>Enable the dedicated data endpoint for the cloud registry</h3>


```
REGISTRY_NAME= "container-registry-name"
    az acr update --name $REGISTRY_NAME \
      --data-endpoint-enabled
```

<h3>IoT Edge and API proxy images</h3>

To support the connected registry on nested IoT Edge, you need to deploy modules for the IoT Edge and API proxy. Import these images into your private registry.
The IoT Edge API proxy module allows an IoT Edge device to expose multiple services using the HTTPS protocol on the same port such as 443.
<a href="https://docs.microsoft.com/en-us/azure/iot-edge/how-to-configure-api-proxy-module?view=iotedge-2020-11">Configure the API proxy module for your gateway hierarchy scenario</a>

```
az acr import \
  --name $REGISTRY_NAME \
  --source mcr.microsoft.com/azureiotedge-agent:1.2.4

az acr import \
  --name $REGISTRY_NAME \
  --source mcr.microsoft.com/azureiotedge-hub:1.2.4

az acr import \
  --name $REGISTRY_NAME \
  --source mcr.microsoft.com/azureiotedge-api-proxy:1.1.2

az acr import \
  --name $REGISTRY_NAME \
  --source mcr.microsoft.com/azureiotedge-diagnostics:1.2.4
```


<h3>Hello world image</h3>

```
az acr import \
  --name $REGISTRY_NAME \
  --source mcr.microsoft.com/hello-world:1.1.2
```
