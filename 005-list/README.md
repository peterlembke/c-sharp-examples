# Example number 005 in C#
In this example we will use lists.
An array can not add/remove items but a list can.

## List
If you want to have a variable length array then you must use lists.
Read about [list](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?view=netcore-3.1).

There is a lot of built in commands in the List class. This example show some of them.

## Define a list
When you declare the list you also set the object type that will be used in the list.

## Add item
Built in method to add another item that has an instance of the right object type.

## Change item
Looping trough the list works well. You get access to each individual item.
Then you can reference the item properties and change them.

## Remove item by index
Built in function to RemoveAt(3) - Index number 3 i this example is the 4th item because we count from 0.

## Remove item by search
Built in function to Remove() an item by finding it from an ID field.  
See required functions MyClass -> Person: Equals and GetHashCode.

## Find item
With Find() you can loop trough the list and find the item you want.

## Run example
The example will output this:
```
-------------------------------------------------------------------
You may only use the Microsoft .NET Core Debugger (vsdbg) with
Visual Studio Code, Visual Studio or Visual Studio for Mac software
to help you develop and test your applications.
-------------------------------------------------------------------
Loaded '/usr/share/dotnet/shared/Microsoft.NETCore.App/3.1.4/System.Private.CoreLib.dll'. Skipped loading symbols. Module is optimized and the debugger option 'Just My Code' is enabled.
Loaded '/home/peter/c-sharp-examples/005-list/MyConsole/bin/Debug/netcoreapp3.1/MyConsole.dll'. Symbols loaded.
Loaded '/usr/share/dotnet/shared/Microsoft.NETCore.App/3.1.4/System.Runtime.dll'. Skipped loading symbols. Module is optimized and the debugger option 'Just My Code' is enabled.
Loaded '/usr/share/dotnet/shared/Microsoft.NETCore.App/3.1.4/System.Collections.dll'. Skipped loading symbols. Module is optimized and the debugger option 'Just My Code' is enabled.
Loaded '/usr/share/dotnet/shared/Microsoft.NETCore.App/3.1.4/System.Console.dll'. Skipped loading symbols. Module is optimized and the debugger option 'Just My Code' is enabled.
Loaded '/usr/share/dotnet/shared/Microsoft.NETCore.App/3.1.4/System.Threading.dll'. Skipped loading symbols. Module is optimized and the debugger option 'Just My Code' is enabled.
Loaded '/usr/share/dotnet/shared/Microsoft.NETCore.App/3.1.4/System.Runtime.Extensions.dll'. Skipped loading symbols. Module is optimized and the debugger option 'Just My Code' is enabled.
Loaded '/usr/share/dotnet/shared/Microsoft.NETCore.App/3.1.4/System.Text.Encoding.Extensions.dll'. Skipped loading symbols. Module is optimized and the debugger option 'Just My Code' is enabled.
Year: 1990, Name: Adam
Year: 1991, Name: Bertil
Year: 1992, Name: Cesar
Year: 1993, Name: David
Year: 1994, Name: Erik
Year: 1995, Name: Filip
-------------------------------
Year: 1990, Name: Adam-a
Year: 1991, Name: Bertil-a
Year: 1992, Name: Cesar-a
Year: 1993, Name: David-a
Year: 1994, Name: Erik-a
Year: 1995, Name: Filip-a
-------------------------------
Year: 1990, Name: Adam-a
Year: 1992, Name: Cesar-a
Year: 1994, Name: Erik-a
Year: 1995, Name: Filip-a
-------------------------------
Year: 1990, Name: Adam-a
Year: 1992, Name: New Cesar
Year: 1994, Name: Erik-a
Year: 1995, Name: Filip-a
-------------------------------
The program '[8171] MyConsole.dll' has exited with code 0 (0x0).

```