# Example number 001 in C#
In this example we will show "Hello world" in the console.

## The comments

Microsoft uses [codedoc](https://docs.microsoft.com/en-us/dotnet/csharp/codedoc) to document functions and classes. It is XML tags

See MyConsole/MyConsole.csproj
I have added:
```
<GenerateDocumentationFile>true</GenerateDocumentationFile>
```
So the documentation files can be generated.

## The code

See the code in MyConsole/Program.cs

### Main

You can only have [one Main function](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/main-and-command-args/).

### Console

The [Console](https://docs.microsoft.com/en-us/dotnet/api/system.console?view=netcore-3.1) write strings to the terminal.
