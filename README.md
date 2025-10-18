# Dynamic Profile Endpoint — HNG Stage 0

A simple **ASP.NET Core Web API** that returns your profile details and a random cat fact from [Cat Facts API](https://catfact.ninja/fact).

## Endpoint
**GET** `/me`

**Response**
```json
{
  "status": "success",
  "user": {
    "email": "oshinkoyamasturah@gmail.com",
    "name": "Oshinkoya Masturah Abiodun",
    "stack": "C# / ASP.NET Core"
  },
  "fact": "Cats sleep for around 13 to 14 hours a day."
}
##Run Locally
**git clone https://github.com/masturah7/DynamicProfileEndPoint.git
**cd DynamicProfileEndPoint
**dotnet restore
**dotnet run


## Requirements
.NET 8 SDK
Visual Studio or VS Code

##Dependencies

**ASP.NET Core

**System.Net.Http

##Environment
**No environment variables required.

##GitHub
https://github.com/masturah7/DynamicProfileEndPoint

##Author: Oshinkoya Masturah Abiodun
oshinkoyamasturah@gmail.com
Stack: C# / ASP.NET Core

























