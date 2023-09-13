FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 8080

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /app
# Copy the project files and restore any dependencies
COPY "src/TddReference.WebAPI/TddReference.WebAPI.csproj" ./
RUN dotnet restore

# Copy the remaining source code
COPY src/TddReference.WebAPI/. ./
RUN dotnet build "TddReference.WebAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TddReference.WebAPI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TddReference.WebAPI.dll"]
