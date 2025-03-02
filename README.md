# JFProjectManagementSystem
Back end solution for my Project management system.

Containing:
- Local Database, 15 entities with different dependencies.
- Database is set up by using Microsoft Entity Framework Core - Code First.
- Layers: Business, Data, DataTests, Pesentation (Web API - Controllers - React)
- Code Structured with SOLID practice.
- Business: Factories, Interfaces, Models, Services (CRUD)
- Data: Contexts, Database, Entities, Repositories - Base Repository is used, RepositoryInterfaces, Migrations
- Web API (15 controllers) is set up to connect with Front End solution "ReactProjectManagement" (also on github)
- ResponseStatus
- Async/Await
- Dependency Injection
- Integration tests using InMemoryDatabase

To view:
1. Set Presentation WebAPI as start up project and press PLAY
2. Open Front end application "ReactProjectManagement" enter npm run dev and follow link to local host.

//Johanna Falkenmark 2025
