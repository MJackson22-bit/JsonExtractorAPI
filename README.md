# JsonExtractorAPI
# JSON Extractor and Database Inserter

## Overview
This project is a simple .NET API that extracts JSON content from a Google Drive file, deserializes it into C# objects, and inserts the data into a database. The main purpose of this application is to demonstrate how to handle JSON extraction and database interactions in a small-scale project.

---

## Features
1. Extract JSON content from a Google Drive URL.
2. Deserialize the JSON content into strongly-typed C# objects.
3. Insert the deserialized data into a database.
4. Error handling for file access and database operations.

---

## Prerequisites
- [.NET 6.0 or higher](https://dotnet.microsoft.com/download)
- A Google Drive file with public sharing enabled or proper authentication.
- Access to a database (e.g., SQL Server, PostgreSQL, MySQL, etc.).
- Basic knowledge of C# and JSON serialization/deserialization.

---

## Technologies Used
- **C#:** Programming language for the API.
- **ASP.NET Core:** Framework for building the API.
- **System.Text.Json:** Library for JSON serialization/deserialization.
- **Entity Framework Core:** ORM for database interaction.
- **HttpClient:** For fetching data from the Google Drive URL.
