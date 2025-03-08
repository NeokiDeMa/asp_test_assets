# استفاده از .NET 8 به عنوان پایه
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app

# استفاده از .NET 8 SDK برای بیلد
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# کپی کردن فایل‌های پروژه و ریستور پکیج‌ها
COPY ["AssetServer.csproj", "./"]
RUN dotnet restore "AssetServer.csproj"

# کپی کردن کل سورس و بیلد پروژه
COPY . .
RUN dotnet publish "AssetServer.csproj" -c Release -o /app/publish

# اجرای برنامه در محیط runtime
FROM base AS final
WORKDIR /app
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "AssetServer.dll"]
