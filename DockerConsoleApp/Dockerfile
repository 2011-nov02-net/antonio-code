FROM mcr.microsoft.com/dotnet/sdk:5.0

WORKDIR /app

COPY . ./

RUN dotnet build publish -o publish

CMD dotnet publish/DockerConsoleApp.dll