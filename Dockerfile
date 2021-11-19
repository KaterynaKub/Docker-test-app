FROM mcr.microsoft.com/dotnet/aspnet:5.0
COPY TestApp/bin/Release/net5.0/publish ./
WORKDIR .
ENTRYPOINT ["dotnet","TestApp.dll"]