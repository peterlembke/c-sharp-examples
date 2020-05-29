# Example number 006 in C#
A dictionaly is a list with pairs of key and value.
A dictionary look up values fast and easy if you know the key.

## Dictionary
Read about [dictionary](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2?redirectedfrom=MSDN&view=netcore-3.1).

## Define a dictionary
When you declare the dictionary you also set the object type that will be used for key and for value.

## Add item
You can Add() an item. If the item already exist you get an exception.

## Get value
Retrieving a value by using its key is very fast.

## Set value
You can set value on an existing item. If the item do not exist you get an exception.

## Check if item exist
You can check if an item exist.

## Remove item
You can Remove() an item. If it did not exist you get an exception.

## Run example
The example will output this:
```
-------------------------------------------------------------------
You may only use the Microsoft .NET Core Debugger (vsdbg) with
Visual Studio Code, Visual Studio or Visual Studio for Mac software
to help you develop and test your applications.
-------------------------------------------------------------------
Loaded '/usr/share/dotnet/shared/Microsoft.NETCore.App/3.1.4/System.Private.CoreLib.dll'. Skipped loading symbols. Module is optimized and the debugger option 'Just My Code' is enabled.
Loaded '/home/peter/c-sharp-examples/006-dictionary/MyConsole/bin/Debug/netcoreapp3.1/MyConsole.dll'. Symbols loaded.
Loaded '/usr/share/dotnet/shared/Microsoft.NETCore.App/3.1.4/System.Runtime.dll'. Skipped loading symbols. Module is optimized and the debugger option 'Just My Code' is enabled.
Loaded '/usr/share/dotnet/shared/Microsoft.NETCore.App/3.1.4/System.Collections.dll'. Skipped loading symbols. Module is optimized and the debugger option 'Just My Code' is enabled.
Loaded '/usr/share/dotnet/shared/Microsoft.NETCore.App/3.1.4/System.Console.dll'. Skipped loading symbols. Module is optimized and the debugger option 'Just My Code' is enabled.
Loaded '/usr/share/dotnet/shared/Microsoft.NETCore.App/3.1.4/System.Threading.dll'. Skipped loading symbols. Module is optimized and the debugger option 'Just My Code' is enabled.
Loaded '/usr/share/dotnet/shared/Microsoft.NETCore.App/3.1.4/System.Runtime.Extensions.dll'. Skipped loading symbols. Module is optimized and the debugger option 'Just My Code' is enabled.
Loaded '/usr/share/dotnet/shared/Microsoft.NETCore.App/3.1.4/System.Text.Encoding.Extensions.dll'. Skipped loading symbols. Module is optimized and the debugger option 'Just My Code' is enabled.
Id: 001, Year: 1990, Name: Adam
Id: 002, Year: 1991, Name: Bertil
Id: 003, Year: 1992, Name: Cesar
Id: 004, Year: 1993, Name: David
Id: 005, Year: 1994, Name: Erik
Id: 006, Year: 1995, Name: Filip
-------------------------------
Id: 001, Year: 1990, Name: Adam-a
Id: 002, Year: 1991, Name: Bertil-a
Id: 003, Year: 1992, Name: Cesar-a
Id: 004, Year: 1993, Name: David-a
Id: 005, Year: 1994, Name: Erik-a
Id: 006, Year: 1995, Name: Filip-a
-------------------------------
Loaded '/usr/share/dotnet/shared/Microsoft.NETCore.App/3.1.4/System.Linq.dll'. Skipped loading symbols. Module is optimized and the debugger option 'Just My Code' is enabled.
Id: 001, Year: 1990, Name: Adam-a
Id: 002, Year: 1991, Name: Bertil-a
Id: 004, Year: 1993, Name: David-a
Id: 006, Year: 1995, Name: Filip-a
-------------------------------
Id: 001, Year: 1990, Name: New Adam
Id: 002, Year: 1991, Name: Bertil-a
Id: 004, Year: 1993, Name: David-a
Id: 006, Year: 1995, Name: Filip-a
-------------------------------
The program '[5375] MyConsole.dll' has exited with code 0 (0x0).
```
