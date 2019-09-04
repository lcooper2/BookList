# BookList
C# Razor Pages BookList

Checklist for creating db connection and data model

The first step is to create a connection string to use to connect to the database
We add another key value pair to the json in the appsettings.json file
The parts of the connection string are separated by semicolons

Next create a models folder to hold all of your classes related to the database
Create an applicationDBContext class that will subclass DBContext
Create another class to model your database object so that we can map database entries to these objects. Mine is called Book.cs

In the ConfigureServices function contained in startup.cs, paste the following:
services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
This registers the DbContext with the connection string we defined earlier

Within Book.cs add any necessary fields and methods
Within Book.cs, add data annotations to aid the database when performing database migrations

In the applicationDbContext file, create a DBSet<Book> to contain book objects that will then get created as rows in the database

Go to Tools -> NuGet package manage -> Package Manager Console and open the console
Type add-migration to add a new migration
Type update-database to apply pending migrations to the database

Proceed to change the shared layout, create other files, and actually develop the application.
