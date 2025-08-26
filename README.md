# NET 8 Web API with Sql Server in Docker

This repository contains a sample **ASP.NET Core 8 Web API** (`Product.API`) that has been containerized using **Docker multi-stage builds**.  
---

## 🚀 Steps
1. **Created a .NET 8 Web API project** (`Product.API`).
2. **Wrote a multi-stage Dockerfile** to:
   - Use the **.NET SDK** image (`mcr.microsoft.com/dotnet/sdk:8.0`) to restore, build, and publish the application.
   - Use the **.NET Runtime** image (`mcr.microsoft.com/dotnet/aspnet:8.0`) to run the application in a lightweight production-ready container.
3. **Configured the app** to listen on port `8000` inside the container.
4. **Built and tested** the image locally using Docker Desktop.

## Docker-Compose
1. Multiple Services at Once: Run the API and SQL Server together with one command.
2. Service Dependencies: depends_on ensures SQL Server starts before the API.
3. Centralized Configuration: Ports, environment variables, and networks are defined in one place.

