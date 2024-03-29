[![License](https://img.shields.io/github/license/falberthen/ecommerceddd.svg)](LICENSE)

# Furniture Commerce API

What is Furniture Commerce API?
---------------------
* It is a simple RESTful API server created with ASP.NET Core 6.0. This is the accompanying server code to the frontend application that can be found [here](https://github.com/KelechiOdom10/furniture-commerce-frontend)

Introduction
---------------------
The goal of this project was to learn C# and .NET Core in a practical "learning by doing" approach. I decided to build a furniture e-commerce API with the core functionalities of any e-commerce platform which will be discussed in a further section below. So far what I have learned includes: 

-	How to use multiple DbContext to separate business logic with Identities
-	How to use JWTs token using ASP.NET Identity
-	How to use Automapper
-	How to implement Paging, Sorting, Searching and Filtering
-	How to make use of Generics
-	How to create custom application service extensions
-	How to make API error handling more consistent and generic
-	And many more things
## Business Requirements

- Get a list of categories and their associated products
- Get a list of product types and their associated products
- Get a list of products
- Filter and sort products
- Search products
- Get Individual product details
- Create an Order with delivery details
- Anonymous Checkout process
- Checkout process
- Wishlist management
- Address Managment
- Payment gateway integration
- Authentication:
  - User Signup
  - User Login
- Admin functionality to perform CRUD operations with products, categories, product types, users and orders
## Getting Started 

Clone the repository

```bash
git clone https://github.com/KelechiOdom10/furniture-commerce-api.git
```

Environment Variables:
- CommerceDB = {YOUR POSTGRES URL}
- KEY = {JWT SECURE KEY}
- ISSUER = {JWT ISSUER}

### Building

A step-by-step series of building that project

1. Restore the project :hammer:

```
dotnet restore
```

2. Update appsettings.json or appsettings.Development.json (Which you are working stage)

2. Change all connections for your development or production stage

3. If you want to use a different Database Provider (MS SQL, MySQL etc...)

4. Run EF Core Migrations

```
dotnet ef database update
```

## Running

### Run with Dotnet CLI

1. Run API project :bomb:

```
dotnet run
```
## Documentation
[Link to frontend repository](https://github.com/KelechiOdom10/furniture-commerce-frontend)

Swagger link

```
https://localhost:7049/swagger/index.html
```

## Tech Stack

- ASP.NET Core 6.0
- Entity Framework CORE
- ASP.NET Identity
- Postgres
- AutoMapper
- Swagger
- Redis Cache
- Stripe Implementation

## Contributing

This is an open source project, and contributions of any kind are welcome and appreciated. Open issues, bugs, and feature requests are all listed on the [issues](https://github.com/KelechiOdom10/furniture-commerce-api/issues) tab and labeled accordingly. Feel free to open bug tickets and make feature requests.
