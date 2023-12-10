FormUp Server
-------------

## About project

Server-side application which:
- stores information about user's workouts
- provides feedback about progress 
- shows places to work out around you

## Set up local instance

### Prerequisites
- .NET 8 SDK [(download here)](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
  - Entity framework tools [(instructions here)](https://learn.microsoft.com/en-us/ef/core/cli/dotnet#installing-the-tools)
- Docker [(download here)](https://www.docker.com/products/docker-desktop/)

### Running
1. Start docker images
```shell
docker-compose up -d
```

2. Apply database migrations
```shell
cd FormUp.Api/ # Change into folder where .csproj file is located

dotnet ef database update
```

3. Run the application
```shell
dotnet run
```

### Clean-up
```shell
docker-compose down
```
