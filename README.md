# Basic examples in C#
I have created some basic examples in C# to learn the language and have a simple reference with working code.

I work in Linux and MacOS but the examples should work on Windows too without any changes.

Goal is to extend this repository with more examples when I learn more.

## Setup
Watch this Youtube video: [Intro to VSCode for C# Developers - From Installation to Debugging](https://youtu.be/r5dtl9Uq9V0)  
It will get you stared on setting up: .Net, Visual Studio Code, plugins to VSCode, support for C#.

## Start an existing project
Go into the project folder and start Visual Studio code.
Like this:
```
cd 001
code .
```
Press F5 to compile and debug.

## License
All files in this repository are [GPLv3 or later](LICENCE.md).

## Changelog
The changes and releases are found in the [CHANGELOG](CHANGELOG.md).

## Setup notes from video
I have watched the Youtube video and here are my notes.

Download [Visual Studio Code](https://code.visualstudio.com/).  

### Install plugins in VSCode
In VSCode you can search for plugins.
* C# extension from Microsoft
* vscode-icons
* Visual Studio IntelliCode (Microsoft)

### Use terminal
All commands to set up a project are done in the terminal, NOT in VSCode.

Start the terminal. Create a folder (mkdir my_folder) and go into it (cd my_folder).

#### solution
Create new "solution" that keeps the project togehter.
```
dotnet new sln -n "VSCodeIntroSln"
```

#### namespace and the first class with the main function
You do this for each name space. Then you can create more classes later.
```
dotnet new console -n "IntroUI"
```

#### Classlib
Create a generic domain and class you can reuse in other programs.
See [Library](https://docs.microsoft.com/en-us/dotnet/core/tutorials/library-with-visual-studio?tabs=csharp) in the doc.
```
dotnet new classlib -n "IntroLibrary"
```

#### solution know files
Let the solution know about all files like this.
```
dotnet sln VSCodeIntroSln.sln add **/*.csproj
```
This command works in MacOS and Linus. For Windows you have to add each file separately.

#### reference the library
If we want to use the library we must reference it in our class.
```
dotnet add IntroUI/IntroUI.csproj reference IntroLibrary/IntroLibrary.csproj
```

#### create debug files
Now VSCode will create two files for us in two places.

```
cd IntroUI
code .
```
That will start VSCode. After a few seconds you get a popup in the lower right asking if the files should be created. Answer "Yes". Exit VSCode.

```
cd ..
code .
```
That will start VSCode. After a few seconds you get a popup in the lower right asking if the files should be created. Answer "Yes".

#### Better classlib class
You can delete `class1.cs` in the class lib folder and create any class you want there.

#### run
You can start + debug from VSCode with F5.

You can run the project from the terminal.
```
cd IntroUI
dotnet run
```

## Tips
In VSCode you can press CTRL + SPACE to start intelliCence to get help what to write.


