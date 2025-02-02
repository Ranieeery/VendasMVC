# VendasMVC Application

VendasMVC is a web application built with ASP.NET Core and Entity Framework Core. It manages sales records, sellers,
and departments.

## Prerequisites

- .NET SDK 6.0 or later
- MySQL Server
- IDE (e.g., JetBrains Rider)

## Technologies
- C#
- ASP.NET Core MVC
- Entity Framework
- LINQ
- MySQL
- Migrations
- HTML
- CSS
- Bootstrap
- JavaScript

## Setup Instructions

1. Configure the Database.
Update the connection string in `appsettings.json` to match your MySQL server configuration:

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=localhost;Database=vendasmvcdb;User=root;Password=yourpassword;"
}
```

2. Create the Database
Run the following SQL commands to create the necessary tables:

```sql
CREATE DATABASE vendasmvcdb;

USE vendasmvcdb;

CREATE TABLE department (
    id INT AUTO_INCREMENT PRIMARY KEY,
    name VARCHAR(255) NOT NULL
);

CREATE TABLE seller (
    id INT AUTO_INCREMENT PRIMARY KEY,
    name VARCHAR(255) NOT NULL,
    email VARCHAR(255) NOT NULL,
    birthDate DATE NOT NULL,
    baseSalary DOUBLE(10, 2) NOT NULL,
    departmentId INT,
    FOREIGN KEY (departmentId) REFERENCES department(id)
);

CREATE TABLE salesrecord (
    id INT AUTO_INCREMENT PRIMARY KEY,
    date DATE NOT NULL,
    amount DECIMAL(10, 2) NOT NULL,
    status INT NOT NULL,
    sellerId INT,
    FOREIGN KEY (sellerId) REFERENCES seller(id)
);
```

3. Build and run the application

```bash
dotnet build
dotnet run
```

## Routes 

- `/`: Home page
- `/Departments`: List all departments
- `/Departments/Details/{id}`: View details of a specific department
- `/Departments/Create`: Create a new department
- `/Departments/Edit/{id}`: Edit an existing department
- `/Departments/Delete/{id}`: Delete a department
- `/Sellers`: List all sellers
- `/Sellers/Details/{id}`: View details of a specific seller
- `/Sellers/Create`: Create a new seller
- `/Sellers/Edit/{id}`: Edit an existing seller
- `/Sellers/Delete/{id}`: Delete a seller
- `/SalesRecords`: List all sales records
- `/SalesRecords/Details/{id}`: View details of a specific sales record
- `/SalesRecords/Create`: Create a new sales record
- `/SalesRecords/Edit/{id}`: Edit an existing sales record
- `/SalesRecords/Delete/{id}`: Delete a sales record
- 
