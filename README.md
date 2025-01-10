Dependency Lifetime Checking in ASP.NET Core
Overview
This repository demonstrates how dependency lifetimes (Transient, Scoped, and Singleton) work in ASP.NET Core. The project helps in understanding the behavior of different service lifetimes when registered in the Dependency Injection (DI) container.
Dependency Lifetimes Explained
1. Transient
•	A new instance is created every time the service is requested.
•	Suitable for stateless services.
•	Example:
               builder.Services.AddTransient<ITransientGuidService,TransientGuidService>();
2. Scoped
•	A new instance is created once per request (scope).
•	Suitable for database operations or unit of work patterns.
•	Example:
              builder.Services.AddScoped<IScopedGuidService,ScopedGuidService>();
3. Singleton
•	A single instance is created and shared across the application.
•	Suitable for caching, logging, and configurations.
•	Example:
                builder.Services.AddSingleton<ISingletonGuidService, SingletonGuidService>();
