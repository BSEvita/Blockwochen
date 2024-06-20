# How to start


1. Type `dotnet ef migrations remove -c MoviesAPIContext` and `dotnet ef migrations remove -c UsersAPIContext` in the Terminal
2. Now you can change the MSSQL Connection string int the `appsettings.json` File if needed.
3. Type `dotnet ef migrations add MoviesAPIMigration_v1 -c MoviesAPIContext` and `dotnet ef migrations add UsersAPIMigration_v1 -c UsersAPIContext` to re-generate the Migrations
4. Now type `dotnet ef database update -c MoviesAPIContext` and `dotnet ef database update -c UsersAPIContext`

Now you should be able to start the API