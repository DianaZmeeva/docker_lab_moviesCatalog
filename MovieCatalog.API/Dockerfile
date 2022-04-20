#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
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
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MovieCatalog.API.dll"]