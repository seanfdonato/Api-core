# Api-core
Create sln file
#dotnet new sln
--- Create API
#mkdir ApiCore
#dotnet new webapi --output .\ApiCore
--- Domain project
#mkdir Domain
#dotnet new web --output .\Domain\
--- Infra project
#mkdir Infra
#dotnet new web --output .\Infra\
--- Service project
#mkdir Service
#dotnet new web --output .\Service\

--- Add sln reference
#dotnet sln add .\ApiCore\ApiCore.csproj
#dotnet sln add .\Domain\Domain.csproj
#dotnet sln add .\Infra\Infra.csproj
#dotnet sln add .\Service\Service.csproj

