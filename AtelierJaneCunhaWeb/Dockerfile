FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build-env
WORKDIR /app
COPY ./AtelierJaneCunhaWeb/*.csproj ./AtelierJaneCunhaWeb/
RUN dotnet restore ./AtelierJaneCunhaWeb/AtelierJaneCunhaWeb.csproj
COPY ../ ./
RUN dotnet publish -c Release -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:5.0
WORKDIR /app
COPY --from=build-env /app/out .
ENTRYPOINT ["dotnet", "AtelierJaneCunhaWeb.dll"]