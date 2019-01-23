FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["APITest.Core/APITest.Core.csproj", "APITest.Core/"]
RUN dotnet restore "APITest.Core/APITest.Core.csproj"
COPY . .
WORKDIR "/src/APITest.Core"
RUN dotnet build "APITest.Core.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "APITest.Core.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "APITest.Core.dll"]