FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 5223

ENV ASPNETCORE_URLS=http://+:5223

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["src/Geo-Pet/project-geopet.csproj", "src/Geo-Pet/"]
RUN dotnet restore "src\Geo-Pet\project-geopet.csproj"
COPY . .
WORKDIR "/src/src/Geo-Pet"
RUN dotnet build "project-geopet.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "project-geopet.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "project-geopet.dll"]
