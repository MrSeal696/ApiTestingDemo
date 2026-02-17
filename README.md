# ApiTestingDemo

Простой проект для тестирования веб-API на C# с использованием Swagger.  
Реализован CRUD API для пользователей и автоматические тесты через NUnit + RestSharp.

---

## Запуск

1. Открыть проект в Visual Studio (.NET 10)  
2. Нажать Ctrl + F5 для запуска  
3. Открыть в браузере: https://localhost:7216/swagger  

---

## Тесты

- GetUsers_ShouldReturn200 — проверка GET пользователей  
- CreateUser_ShouldReturn200 — создание нового пользователя  
- UpdateUser_ShouldReturn200 — обновление пользователя  
- DeleteUser_ShouldReturn200 — удаление пользователя  

Тесты создают своих пользователей, чтобы не зависеть друг от друга.

---

## Проблемы

- Swagger не работал до установки NuGet пакета Swashbuckle.AspNetCore  
- Update/Delete тесты падали с 404 — теперь каждый тест создаёт пользователя перед операцией  
- Было предупреждение NUnit про Dispose — исправлено через TearDown

---

## Используемое

- Visual Studio 2022/2023  
- .NET 10  
- Swagger (Swashbuckle.AspNetCore)  
- NUnit  
- RestSharp  
- Newtonsoft.Json

---

## Проверка

- Через Swagger UI — кнопка Try it out  
- Через UnitTest — Test Explorer → Run All
