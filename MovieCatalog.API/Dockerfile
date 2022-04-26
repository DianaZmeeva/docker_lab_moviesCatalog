#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
RUN apt-get update && apt-get install -y curl
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["MovieCatalog.API/MovieCatalog.API.csproj", "MovieCatalog.API/"]
RUN dotnet restore "MovieCatalog.API/MovieCatalog.API.csproj"
COPY . .
WORKDIR "/src/MovieCatalog.API"
RUN dotnet build "MovieCatalog.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MovieCatalog.API.csproj" -c Release -o /app/publish

FROM base AS final
ARG GIT_COMMIT=unspecified
LABEL git_commit=$GIT_COMMIT
ARG BUILD_TIME=unspecified
LABEL build_time=$BUILD_TIME
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MovieCatalog.API.dll"]