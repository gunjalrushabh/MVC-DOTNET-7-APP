#### MVC APP DOTNET 7 CRUD OPERATION
<p> mkdir college
cd college
college> dotnet new sln -> college.sln
dotnet new mvc -o iacsdApp
dotnet add classlib -o BOL
dotnet add classlib -o BLL
dotnet add classlib -o DAL
dotnet sln add BOL/BOL.csproj
dotnet sln add BLL/BLL.csproj
dotnet sln add DAL/DAL.csproj
dotnet sln add iacsdApp/iacsdApp.csproj

DB->BOL (POCO)->DAL->BLL(LOGIC)->iacsdApp/controller/action method->Views


DAL>dotnet add package MySql.Data</p>
