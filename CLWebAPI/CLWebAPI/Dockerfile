FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["CLWebAPI/CLWebAPI.csproj", "CLWebAPI/"]
RUN dotnet restore "CLWebAPI/CLWebAPI.csproj"
COPY . .
WORKDIR "/src/CLWebAPI"
RUN dotnet build "CLWebAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CLWebAPI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CLWebAPI.dll"]
