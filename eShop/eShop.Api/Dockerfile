#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["eShop.Api/eShop.Api.csproj", "eShop.Api/"]
RUN dotnet restore "eShop.Api/eShop.Api.csproj"
COPY . .
WORKDIR "/src/eShop.Api"
RUN dotnet build "eShop.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "eShop.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "eShop.Api.dll"]