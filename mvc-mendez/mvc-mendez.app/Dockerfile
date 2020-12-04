FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build-env
WORKDIR /app

# Copy everything else and build
COPY . ./
RUN dotnet publish -c Release -o out

ENV ASPNETCORE_URLS http://*:80

# Build runtime image
ENTRYPOINT ["dotnet", "out/mvc-mendez.app.dll"]