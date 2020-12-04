FROM mcr.microsoft.com/dotnet/sdk:5.0

COPY . /app

RUN dotnet build publish -o publish

CMD dotnet /app/publish/DockerConsoleApp.dll