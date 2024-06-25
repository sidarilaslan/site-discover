FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

COPY ./src/PMI-Site.sln .
COPY ./src/Core/PMI-Site.Application/PMI-Site.Application.csproj ./Core/PMI-Site.Application/
COPY ./src/Core/PMI-Site.Domain/PMI-Site.Domain.csproj ./Core/PMI-Site.Domain/
COPY ./src/Infrastructure/PMI-Site.Infrastructure/PMI-Site.Infrastructure.csproj ./Infrastructure/PMI-Site.Infrastructure/
COPY ./src/Persistence/PMI-Site.Persistence/PMI-Site.Persistence.csproj ./Persistence/PMI-Site.Persistence/
COPY ./src/Presentation/PMI-Site.Presentation/PMI-Site.Presentation.csproj ./Presentation/PMI-Site.Presentation/

RUN dotnet restore

COPY ./src/ .

RUN dotnet publish ./Presentation/PMI-Site.Presentation/PMI-Site.Presentation.csproj -o /publish/

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS RUNTIME
WORKDIR /app
COPY --from=build /publish .
ENV ASPNETCORE_URLS="http://*:1212"
ENTRYPOINT ["dotnet", "PMI-Site.Presentation.dll"]
