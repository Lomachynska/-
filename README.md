# -
кросплатформений додаток

Створити проект
dotnet new console -n PersonalFinanceTracker
cd PersonalFinanceTracker


Для роботи з базою даних, додати необхідні пакети:
dotnet add package Microsoft.EntityFrameworkCore
dotnet add package Microsoft.EntityFrameworkCore.Sqlite
dotnet add package Microsoft.EntityFrameworkCore.Tools

Створення моделей для обліку витрат, доходів, бюджетів тощо. 


Створіть клас контексту для доступу до бази даних:

Створити БД та Виконати міграці
dotnet ef migrations add InitialCreate
dotnet ef database update


dotnet build

dotnet ef migrations add InitialCreate
dotnet ef database update

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

dotnet restore
dotnet build

очистити кеш
dotnet nuget locals all --clear
dotnet restore


cd "/Users/olga/Desktop/КПІ/сесія 2024 - січень 2025/Основи візуального програмування/додаток/"

dotnet restore PersonalFinanceTracker.csproj
dotnet build PersonalFinanceTracker.csproj

dotnet restore project.sln
dotnet build project.sln


ЗАПУСК
dotnet run --project PersonalFinanceTracker.csproj

dotnet run --project project.sln

міграції
dotnet ef migrations add InitialCreate
оновити базу
dotnet ef database update
запуск
dotnet run --project PersonalFinanceTracker.csproj


dotnet ef migrations add InitialCreate

dotnet ef database update

ЗАПУСК
dotnet run --project PersonalFinanceTracker.csproj
