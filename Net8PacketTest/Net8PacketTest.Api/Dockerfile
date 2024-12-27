FROM mcr.microsoft.com/dotnet/sdk:8.0-alpine AS build

ARG ARTIFACTS_ENDPOINT
ARG ACCESS_TOKEN
ARG USER

WORKDIR /app

# copy csproj and restore as distinct layers
COPY ./Net8PacketTest.sln .
COPY ./Net8PacketTest.Api/*.csproj ./Net8PacketTest.Api/

RUN dotnet restore Net8PacketTest.sln -nowarn:msb3202,nu1503

# copy everything else and build app
COPY ./ .
WORKDIR /app/Net8PacketTest.Api
RUN dotnet publish -c Release -o out -r linux-musl-x64 -p:PublishReadyToRun=true

FROM mcr.microsoft.com/dotnet/runtime:8.0-alpine
COPY --from=build /app/Net8PacketTest.Api/out ./
ENTRYPOINT ["dotnet", "Net8PacketTest.Api.dll"]
