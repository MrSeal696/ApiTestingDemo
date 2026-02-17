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
<img width="1536" height="487" alt="изображение" src="https://github.com/user-attachments/assets/23ac775c-0fa7-48da-b226-857ffca0e011" />

Тесты создают своих пользователей, чтобы не зависеть друг от друга.
<img width="195" height="205" alt="изображение" src="https://github.com/user-attachments/assets/6f70486c-3ab0-4a2e-b303-b583f1290799" />

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
