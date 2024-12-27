FROM mcr.microsoft.com/dotnet/sdk:9.0-alpine AS build

ARG ARTIFACTS_ENDPOINT
ARG ACCESS_TOKEN
ARG USER

WORKDIR /app

# copy csproj and restore as distinct layers
COPY ./Net9PacketTest.sln .
COPY ./Net9PacketTest.Api/*.csproj ./Net9PacketTest.Api/

RUN dotnet restore Net9PacketTest.sln -nowarn:msb3202,nu1503

# copy everything else and build app
COPY ./ .
WORKDIR /app/Net9PacketTest.Api
RUN dotnet publish -c Release -o out -r linux-musl-x64 -p:PublishReadyToRun=true

FROM mcr.microsoft.com/dotnet/runtime:9.0-alpine
COPY --from=build /app/Net9PacketTest.Api/out ./
ENTRYPOINT ["dotnet", "Net9PacketTest.Api.dll"]
