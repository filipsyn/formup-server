FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["FormUp.Api/FormUp.Api.csproj", "FormUp.Api/"]
RUN dotnet restore "FormUp.Api/FormUp.Api.csproj"
COPY . .
WORKDIR "/src/FormUp.Api"
RUN dotnet build "FormUp.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "FormUp.Api.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "FormUp.Api.dll"]
