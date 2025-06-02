# TodoList API Project

This project is a simple **Todo List API** that allows users to manage their todo items, including adding new items, updating them, retrieving pending and completed items, and deleting them. The API is built using **ASP.NET Core** and follows RESTful principles.

## Table of Contents
- [Features](#features)
- [Technologies Used](#technologies-used)
- [Setup Instructions](#setup-instructions)
- [API Endpoints](#api-endpoints)
  - [GET `/api/todo`](#get-apitodo)
  - [GET `/api/todo/{id}`](#get-apitodoid)
  - [POST `/api/todo`](#post-apitodo)
  - [PUT `/api/todo/{id}`](#put-apitodoid)
  - [DELETE `/api/todo/{id}`](#delete-apitodoid)

## Features
- **Create Todo Items**: Add new todo items to the list.
- **Get All Pending Todo Items**: Retrieve all todo items that haven't been marked as completed (i.e., `CompletedDate` is not set).
- **Get Specific Todo Item**: Retrieve details of a single todo item using its `Id`.
- **Update Todo Item**: Update a todo item and mark it as completed by setting the `CompletedDate` to the current date and time.
- **Delete Todo Item**: Delete a todo item from the list by its `Id`.

## Technologies Used
- **ASP.NET Core**
- **Entity Framework Core** (for data context and database management)
- **SQL Server** or any relational database (can be configured)
- **Swagger** (for API documentation and testing)

## Setup Instructions
1. **Clone the repository**:
   ```bash
   git clone https://github.com/your-username/todolist-api.git
   cd todolist-api

2. **Set up the database**:
    ```bash
    Configure the database connection string in appsettings.json.
    Run migrations to create the required tables:
    dotnet ef database update

3. **Run the application**:
    ```bash
    Copy code
    dotnet run
    
4. **Access the Swagger UI (for testing the API)**:
    Navigate to https://localhost:5001/swagger/index.html to test all API endpoints.