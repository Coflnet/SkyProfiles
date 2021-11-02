FROM mcr.microsoft.com/dotnet/sdk:5.0 as build
WORKDIR /build
COPY SkyPlayerInfo.csproj SkyPlayerInfo.csproj
RUN dotnet restore
COPY . .
RUN dotnet test
RUN dotnet publish -c release

FROM mcr.microsoft.com/dotnet/aspnet:5.0
WORKDIR /app

COPY --from=build /build/bin/release/net5.0/publish/ .

ENV ASPNETCORE_URLS=http://+:8000
# using a non-root user is a best practice for security related execution. 
RUN useradd --uid $(shuf -i 2000-65000 -n 1) app 
USER app

ENTRYPOINT ["dotnet", "SkyPlayerInfo.dll", "--hostBuilder:reloadConfigOnChange=false"]
