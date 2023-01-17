# MVC APP DOTNET 7 CRUD OPERATION
## VS CODE IDE

## How To Start : I will Make it Simpler and Easy to Understand 
# WE need Perfect Folder Structure So we can in future we can Add DATA easily
#Loose Coupling and High cohessive Principle
<p> mkdir college <br>
cd college <br>
college> dotnet new sln -> college.sln <br> <br>
dotnet new mvc -o iacsdApp <br>
dotnet add classlib -o BOL  <br>
dotnet add classlib -o BLL   <br>
dotnet add classlib -o DAL   <br>
dotnet sln add BOL/BOL.csproj   <br>
dotnet sln add BLL/BLL.csproj   <br>
dotnet sln add DAL/DAL.csproj   <br>
dotnet sln add iacsdApp/iacsdApp.csproj    <br>

DB->BOL (POCO)->DAL->BLL(LOGIC)->iacsdApp/controller/action method->Views   <br>


DAL>dotnet add package MySql.Data</p>
