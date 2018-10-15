# Livraria

## Getting Started

### Prerequisites

* .NET Core 2.1
* Node v8.9.4
* npm 
* Angular CLI

## Running project

### Checkout this repository 

```
git clone https://github.com/danilovsoares/Livraria.git
```

### Database setup
Run the script located at `sql/Banco_de_Dados_Livraria.sql` on your SQL Server.

### Setup your connection string
On file located at `src\Livraria.WebApp\appsettings.json`, change connection string with your database params.

### Backend 

On the root path, run the following commands:

```
1 - dotnet restore
2 - dotnet run -p src\Livraria.WebApi
```

API will run at http://localhost:44344/

### Frontend

On the root path, run the following commands:

```
cd src/Livraria.WebApp
npm install 
npm start
```

Frontend application will run at http://localhost:4200

## Running the tests

On the root path, run the following command:

```
dotnet test src/Test
```


## Built With

* [.NET Core](https://www.microsoft.com/net/learn/get-started/) - DDD, Entity Framework Core, DI, AutoMapper
* [Angular 6](https://angular.io/)
* [Bootstrap 4](https://getbootstrap.com/docs/4.1/getting-started/introduction/)
* [Visual Studio Code](https://rometools.github.io/rome/) 

## Author

* **Danilo Vieira Soares** 
