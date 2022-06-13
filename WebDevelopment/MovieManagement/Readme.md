
## Class/Entities and Objects

1. Movie (Name, Code, Description, ReleaseDate, Length)
2. Crew ()

##database setup
1. Setup ORM tool(EF core)
	*Database first approach
	*Code first approach

2. Install EF core
>dotnet add package Microsoft.EntityFrameworkCore --version 7.0.0-preview.4.22229.2

3.Install EF core SQlServer(database provider)
>dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 7.0.0-preview.4.22229.2

4.Install EF core package for migrations
>dotnet add package Microsoft.EntityFrameworkCore.Design --version 7.0.0-preview.4.22229.2

5.Modify Program.cs to register dbcontext class
```
builder.Services.AddDbContext<MovieManagementDb>(options =>
    { 
        options.UseSqlServer(@"Server=(localdb)\mssqlocaldb;Database=MovieDb;Trusted_Connection=True");
    });
```
