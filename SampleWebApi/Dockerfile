FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 61637
EXPOSE 44359

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["SampleWebApi/SampleWebApi.csproj", "SampleWebApi/"]
RUN dotnet restore "SampleWebApi/SampleWebApi.csproj"
COPY . .
WORKDIR "/src/SampleWebApi"
RUN dotnet build "SampleWebApi.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "SampleWebApi.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "SampleWebApi.dll"]