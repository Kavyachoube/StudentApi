# Student Management System API

## Overview

This project is a **Student Management System** built using **ASP.NET Core Web API** with SQL Server. It demonstrates CRUD operations, JWT Authentication, logging, exception handling, and layered architecture.

This project was developed as part of a technical assignment to showcase backend and basic full-stack development skills.

---

## Features

* Create, Read, Update, and Delete (CRUD) Students
* JWT Authentication and Authorization
* SQL Server Database Integration
* Global Exception Handling Middleware
* Logging using Serilog
* Swagger API Documentation
* Layered Architecture (Controller, Service, Repository)
* Basic HTML UI for interacting with APIs

---

## Technologies Used

* ASP.NET Core Web API (.NET 8)
* SQL Server
* ADO.NET
* JWT Authentication
* Serilog Logging
* Swagger (OpenAPI)
* HTML, JavaScript, Bootstrap (Basic UI)

---

## Database Setup

Create a database named:

```
StudentDb
```

Run the following SQL script to create the Students table:

```sql
CREATE TABLE Students (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(100) NOT NULL,
    Email NVARCHAR(100) NOT NULL,
    Age INT NOT NULL,
    Course NVARCHAR(100) NOT NULL,
    CreatedDate DATETIME DEFAULT GETDATE()
);
```

---

## Configuration

Open:

```
appsettings.json
```

Update the connection string:

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=localhost;Database=StudentDb;Trusted_Connection=True;TrustServerCertificate=True"
},

"Jwt": {
  "Key": "THIS_IS_MY_SECRET_KEY_12345"
}
```

---

## How to Run the Project

1. Clone the repository

```
git clone <your-repository-link>
```

2. Open the project in Visual Studio

3. Configure SQL Server connection string in:

```
appsettings.json
```

4. Build the solution

```
Build → Rebuild Solution
```

5. Run the application

Press:

```
F5
```

---

## Access the Application

### Basic UI

```
https://localhost:7181/index.html
```

### Swagger API Documentation

```
https://localhost:7181/swagger
```

---

## API Endpoints

### Authentication

POST

```
/api/Auth/login
```

### Student APIs

GET

```
/api/Student
```

POST

```
/api/Student
```

PUT

```
/api/Student
```

DELETE

```
/api/Student/{id}
```

---

## Project Structure

```
StudentApi
│
├── Controllers
├── Services
├── Repositories
├── Models
├── Middleware
├── wwwroot
│     └── index.html
├── Program.cs
├── appsettings.json
```

---

## Security

* JWT-based authentication is implemented
* All Student APIs are protected using [Authorize]
* Token expiration is set to 1 hour

---

## Author

Name: Kavya

Role: Full Stack Developer Candidate

---

## Notes

This project was developed for technical evaluation purposes to demonstrate practical knowledge of ASP.NET Core Web API, SQL Server, authentication, and clean architecture principles.
