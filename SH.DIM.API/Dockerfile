#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["SH.DIM.API/SH.DIM.API.csproj", "SH.DIM.API/"]
RUN dotnet restore "SH.DIM.API/SH.DIM.API.csproj"
COPY . .
WORKDIR "/src/SH.DIM.API"
RUN dotnet build "SH.DIM.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SH.DIM.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SH.DIM.API.dll"]