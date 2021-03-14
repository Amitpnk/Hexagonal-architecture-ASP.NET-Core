### Login Azure
```
az login
```

### Group exist

```
az group exists -n HexagonalArch_Dev
```

### Create Resource Group

```
az group create --name "HexagonalArch_Dev" 
                --location "southindia" 
                --tags "Environment=Development" 
                "Project=HexagonalArch" "Department=SD" "ResourceType=Mixed"
```

### Create App Service Plan

```
az appservice plan create --resource-group "HexagonalArch_Dev" \
                          --name HexagonalArch-Hosts \
                          --location "southindia" \
                          --sku F1 \
                          --tags "Environment=Development" "Project=HexagonalArch" "Department=SD"
```

### Create App Services:

```
az webapp create --resource-group "HexagonalArch_Dev" --plan HexagonalArch-Hosts --name webapi-hexagonalarch --runtime "DOTNET:5.0" --tags "Environment=Development" "Project=HexagonalArch" "Department=SD"
```

### Create Lock:
```
az lock create --lock-type CanNotDelete \
               --name CanNotDelete \
               --resource-group HexagonalArch_Dev
```

### Clean Up

```
az lock delete --name CanNotDelete --resource-group HexagonalArch_Dev
az group delete --name "HexagonalArch_Dev" --yes
```
