FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

COPY ./src/SiteDiscover.sln .
COPY ./src/Core/SiteDiscover.Application/SiteDiscover.Application.csproj ./Core/SiteDiscover.Application/
COPY ./src/Core/SiteDiscover.Domain/SiteDiscover.Domain.csproj ./Core/SiteDiscover.Domain/
COPY ./src/Infrastructure/SiteDiscover.Infrastructure/SiteDiscover.Infrastructure.csproj ./Infrastructure/SiteDiscover.Infrastructure/
COPY ./src/Persistence/SiteDiscover.Persistence/SiteDiscover.Persistence.csproj ./Persistence/SiteDiscover.Persistence/
COPY ./src/Presentation/SiteDiscover.Presentation/SiteDiscover.Presentation.csproj ./Presentation/SiteDiscover.Presentation/

RUN dotnet restore

COPY ./src/ .

RUN dotnet publish ./Presentation/SiteDiscover.Presentation/SiteDiscover.Presentation.csproj -o /publish/

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS RUNTIME
WORKDIR /app
COPY --from=build /publish .
ENV ASPNETCORE_URLS="http://*:1212"
ENTRYPOINT ["dotnet", "SiteDiscover.Presentation.dll"]
