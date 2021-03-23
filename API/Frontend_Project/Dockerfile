#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim AS base
WORKDIR /app
EXPOSE 90
EXPOSE 500

FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS build
WORKDIR /src
COPY ["Frontend_Project/Frontend_Project.csproj", "Frontend_Project/"]
RUN dotnet restore "Frontend_Project/Frontend_Project.csproj"
COPY . .
WORKDIR "/src/Frontend_Project"
RUN dotnet build "Frontend_Project.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Frontend_Project.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Frontend_Project.dll"]

#FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim
#ADD dist /app
#WORKDIR /app
#EXPOSE 80 
##EXPOSE 443
#ENTRYPOINT [ "dotnet", "Frontend_Project.dll"]