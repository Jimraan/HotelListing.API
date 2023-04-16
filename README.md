title: Hotel Listing API Developed using .NET 7

# Summary
This is a demo project—a coded-along copy of Trevoir William's identical project in his [.NET course on Udemy](https://www.udemy.com/course/ultimate-aspnet-5-web-api-development-guide/)

last updated 15 Apr 2023


# Description
## What the Project Does
This API stores and provides information on fictional hotel listings in the Carribean. 
Any logged-in user can retrieve a list of information for existing hotels, or for a single hotel. Each hotel resides in a country—country information can be requested in the same way and will include hotel information.
Administrators can add new listings, update existing listings, and delete listings as they wish. This goes for countries and hotels. Deleting a country also deletes any residing hotels.
Any user, logged-in or not can register a new account. Admin users can create new admin accounts.

## Behind-the-scenes features
- Automatic logging of all HTTP requests, using Serilog and Seq
- Data-transfer objects used to prevent overposting (REST best practices)
- Entity Framework used to encapsulate actual data objects and enable data retrieval-based API responses
- User and session information encoded into JSON Web Tokens, which refresh often to prevent unauthorized access

## Technologies used
- Framework: AsP.NET Core 7
- IDE: Microsoft Visual Studio 2022
- Languages: C#, with some JSON
- Middleware and other programs: Postman (testing), Serilog and Seq (logging), CMD


# My Goals, What I Learned, and What I Reinforced
## My original goals for this project
I found Trevoir's course in a pursuit to become a better back-end developer, and to learn crucial technologies like .NET. I set out to:
- expand my skill library with an understanding of and experience developing in the .NET framework
- further develop my C# and database skills and become more comfortable with Microsoft Visual Studio 2022
- learn the basics of APIs and how to develop them
- learn REST development principles, and how to conform an API to them

## What I ended up learning
The course was much more expansive than I could've imagined, and .NET API development involved processes and considerations that I had never considered. Below are valuable skills and experience I gained in the process of following his course
- all of the above, plus:
- how to implement middlewares in .NET
- request logging, using Serilog and Seq
- manual API testing with Postman
- how to analyze an HTTP response for correct output
- web security best practices: CORS policies, JSON Web Tokens, refresh tokens, User Core Identity
- Entity Framework for data modeling, and retrieval using data transfer objects

## Reinforced skills
There were also skills and knowledge I already posessed, which were strengthened throughout the course:
- understanding of CRUD operations, using POST, GET, PUT, DELETE
- MySQL database retrieval, and data modeling
- understanding HTTP response codes and writing HTTP endpoints
- requiring authentication, or user roles, to access certain endpoints
