# Use the official Microsoft .NET SDK image to build the app
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Copy the .csproj files and restore dependencies
COPY HotelFoodOrderApp/*.csproj ./HotelFoodOrderApp/
RUN dotnet restore HotelFoodOrderApp/HotelFoodOrderApp.csproj

# Copy the rest of the code and build the release
COPY . ./
RUN dotnet publish HotelFoodOrderApp/HotelFoodOrderApp.csproj -c Release -o out

# Build the runtime image
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /app/out .

# Tell the app to listen on the port Railway provides
ENV ASPNETCORE_URLS=http://*:$PORT

ENTRYPOINT ["dotnet", "HotelFoodOrderApp.dll"]
