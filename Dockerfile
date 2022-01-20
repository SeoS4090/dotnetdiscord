#https://github.com/dotnet/dotnet-docker/tree/master/samples/aspnetapp

FROM microsoft/dotnet/sdk AS build
WORKDIR /app

COPY . .

CMD ASPNETCORE_URLS=http://*:$PORT dotnet dotnetCore.dll