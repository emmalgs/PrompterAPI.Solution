# Prompter API

### By Emma Gerigscott

## Table of Contents
1. [Project Description](#description)
2. [Technologies Used](#technologies-used)
3. [Database Setup Instructions](#database-setup-instructions)
4. [Using This API](#using-this-api)
6. [Bugs](#known-bugs)
7. [License](#mit-license)

## Description

An API to store and retrieve a daily writing prompt. This API is hosted along with a flexible MySQL server on Azure and is used to provide a daily writing prompt to the [Prompter Client](https://graceful-gumption-99b38d.netlify.app/)

## Technologies Used

* C#
* .NET
* ASP.NET Core
* API
* Entity Framework Core
* Pomelo Entity Framework Core
* EFCore Migrations
* Swashbuckle
* Swagger
* MySQL

## Database Setup Instructions

1. Clone this repo.
2. Open your terminal (e.g. Terminal or GitBash) and navigate to this project's directory called "PrompterApi".
3. Set up the project:
  * Create a file called 'appsettings.json' in PrompterApi.Solution/PrompterApi directory
  * Add the following code to the appsettings.json file:
  ```
  {
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=prompter_api;uid=[YOUR_SQL_USER_ID];pwd=[YOUR_SQL_PASSWORD];"
    }
  }
  ```
  * Make sure to plug in your SQL user id and password at ```[YOUR_SQL_USER_ID]``` and ```[YOUR_SQL_PASSWORD]```
4. Set up the database:
  * Make sure EF Core Migrations is installed on your computer by running ```dotnet tool install --global dotnet-ef --version 6.0.0```
  * In the production folder of the project (PrompterApi.Solution/PrompterApi) run:
  ```
  dotnet ef database update
  ```
  * You should see the new schema in your _Navigator > Schemas_ tab of your MySql Workbench on refresh called ```animalshelter_api```

## Using This API
* Endpoints for **v1.0** API are as follows:
```
GET ALL https://localhost:5001/api/prompts/
GET LATEST https://localhost:5001/api/prompts/latest
POST https://localhost:5001/api/prompts/
DELETE https://localhost:5001/api/prompts/{id}
```

* In your terminal run ```dotnet watch run``` in the project directory.
* Using [Postman](https://www.postman.com/), use the following urls and/or raw JSON text:
  * **GET** method url:
  ```https://localhost:5001/api/prompts```  
  _For more specific GET queries, please view the [table](#query-parameters-for-a-get-request-on-animals)_.
  * **POST** method raw JSON:
  ```
  {
    "promptText": "string",
  }
  ```
  Path for POST: ```https://localhost:5001/api/prompts/```  

  * **DELETE** method path: ```https://localhost:5001/api/prompts/{id}```  

### Use API with Swagger: 
* In your browser open https://localhost:5001/swagger/index.html
* Use the GUI to navigate the API

## [MIT](https://opensource.org/license/mit/) License 

Copyright © 2023 Emma Gerigscott