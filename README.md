
1. Create a repo on github and clone it locally

---------------->  dotnet new gitignore

2. Create a .NET Core Solution

---------------->  dotnet new sln

======  This uses the name of the folder it is in by default. If you want a different name use -n  or --name


3.  Add folders for "src" and "tests"

---------------->  mkdir src
---------------->  dotnet new classlib -n MathMachine -o src/

---------------->  mkdir test
---------------->  dotnet new mstest -n MathMachine.Test -o test/


4. Add PROJECTS to SOLUTION

---------------->  dotnet sln add src/MathMachine.csproj
---------------->  dotnet sln add test/MathMachine.Test.csproj


5.  Add some code
In Class Library:
---------------->  rename Class1.cs   to   CalculatorService.cs
---------------->  copy/paste  code from text file
In Test Library:
---------------->  rename UnitTest1.cs to  CalculatorService.Test.cs

6. Build the code

---------------->  dotnet build

---------------------->  Error because the Test project does not know sources

---------------->  donet add test/MathMachine.Test.csproj reference src/MathMachine.csproj

7. Push to origin
----------------------> That's it... no automatic build/test of the code

8. GitHub Actions to the rescue

----------------> Add folder ".github/workflows"
----------------> Add yml file "onPushToAnyBranch.yml"
----------------> Add workflow code to new file

9. Push to origin again ---- Enjoy what happens!
