#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["SSC_Servicos_Gerenciamento_Notificacao/SSC_Servicos_Gerenciamento_Notificacao.csproj", "SSC_Servicos_Gerenciamento_Notificacao/"]
RUN dotnet restore "SSC_Servicos_Gerenciamento_Notificacao/SSC_Servicos_Gerenciamento_Notificacao.csproj"
COPY . .
WORKDIR "/src/SSC_Servicos_Gerenciamento_Notificacao"
RUN dotnet build "SSC_Servicos_Gerenciamento_Notificacao.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SSC_Servicos_Gerenciamento_Notificacao.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SSC_Servicos_Gerenciamento_Notificacao.dll"]