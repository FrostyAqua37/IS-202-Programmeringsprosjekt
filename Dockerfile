#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat


# First stage is to build the project
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
# Copies all the files from prosjektarbeid folder
COPY . .
RUN dotnet restore NestedProsjekt.csproj
# Builds and makes the project publishable
RUN dotnet publish "NestedProsjekt.csproj" -c Release -o /app/publish /p:UseAppHost=false

# Runtime image
# Multistage to make the container lighter
FROM mcr.microsoft.com/dotnet/aspnet:7.0
WORKDIR /app
EXPOSE 80
EXPOSE 443
# Copies the files that was build from the previous build stage
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "NestedProsjekt.dll"]