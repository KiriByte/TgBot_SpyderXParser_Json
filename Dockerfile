FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["TgBot_SpyderXParser_Json.csproj", "./"]
RUN dotnet restore "TgBot_SpyderXParser_Json.csproj"
COPY . .
WORKDIR "/src/"
RUN dotnet build "TgBot_SpyderXParser_Json.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TgBot_SpyderXParser_Json.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TgBot_SpyderXParser_Json.dll"]
