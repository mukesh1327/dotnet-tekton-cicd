# Use official .NET SDK image for build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copy csproj and restore as distinct layers
COPY Dotnet8-hello-world.sln ./
COPY ../src/. ./src
COPY ../tests/. ./tests/

RUN ls -la 

RUN dotnet restore

# Copy entire project and build


RUN ls -la
RUN dotnet publish ./src/Dotnet8-hello-world.csproj -c Release -o /app/publish

# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app
COPY --from=build /app/publish .

# Expose desired port
EXPOSE 8080

# Set environment variable to run on exposed port
ENV ASPNETCORE_URLS=http://+:8080

ENTRYPOINT ["dotnet", "Dotnet8-hello-world.dll"]
