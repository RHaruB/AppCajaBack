# =========================
# 1. ETAPA DE BUILD
# =========================
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Copia solo el archivo del proyecto
COPY *.csproj ./

# Restaura dependencias
RUN dotnet restore

# Copia todo el código
COPY . ./

# Compila y publica
RUN dotnet publish -c Release -o /publish

# =========================
# 2. ETAPA DE RUNTIME
# =========================
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app

# Copia lo generado en build
COPY --from=build /publish .

# Expone el puerto
EXPOSE 80

# Ejecuta la app
ENTRYPOINT ["dotnet", "AppCajaBack.dll"]