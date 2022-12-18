FROM mcr.microsoft.com/dotnet/sdk:7.0 as build
WORKDIR /build
RUN git clone --depth=1 https://github.com/Coflnet/HypixelSkyblock.git dev
WORKDIR /build/sky
COPY SkyPlayerInfo.csproj SkyPlayerInfo.csproj
RUN dotnet restore
COPY . .
RUN dotnet test
RUN dotnet publish -c release -o /app

FROM mcr.microsoft.com/dotnet/aspnet:7.0
WORKDIR /app

COPY --from=build /app .

ENV ASPNETCORE_URLS=http://+:8000
# using a non-root user is a best practice for security related execution. 
RUN useradd --uid $(shuf -i 2000-65000 -n 1) app 
USER app

ENTRYPOINT ["dotnet", "SkyPlayerInfo.dll", "--hostBuilder:reloadConfigOnChange=false"]
