# azure-devops-templates
Repository to hold various build templates for Azure DevOps automation.


## Pipelines
- build-dotnet-application.yml
- build-service-fabric-application.yml
- build-dotnet-cake2.yml


## Explanation
- [build-dotnet-application.yml](https://github.com/geralexgr/azure-devops-templates/blob/main/build-dotnet-application.yml) -> Build a .NET application using DotNetCoreCLI
- [build-service-fabric-application.yml](https://github.com/geralexgr/azure-devops-templates/blob/main/build-service-fabric-application.yml) -> Build a Service Fabric application using msbuild tool.
- [build-dotnet-cake2.yml](https://github.com/geralexgr/azure-devops-templates/blob/main/build-dotnet-cake2.yml) -> Build a .NET application using cake2. You should place [../resources/build.cake](https://github.com/geralexgr/azure-devops-templates/blob/main/resources/build.cake) file on your project root directory.




