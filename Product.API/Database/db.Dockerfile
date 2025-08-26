# Use the official SQL Server image
FROM mcr.microsoft.com/mssql/server:latest AS sqlserver
ENV ACCEPT_EULA=Y
ENV SA_PASSWORD=YourStrong@Passw0rd
EXPOSE 1433

# Add optional environment variable for database name
ENV MSSQL_DBNAME=product_db