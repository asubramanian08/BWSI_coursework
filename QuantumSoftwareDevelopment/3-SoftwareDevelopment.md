# Computer Programming

Sources:
- https://youtu.be/l26oaHV7D40
- https://youtu.be/rL8X2mlNHPM
- https://www.pythonlikeyoumeanit.com/

Notes:
- Use programming languages to abstract away the details of machine code
- Statement: Analogous to a sentence of phrase
    - Assignment Statement: `x = 1`
- Syntax: The rules of how to write and string together statements
- Variables can be named anything as long as its unique
- Initialize variables: Setting a variable's starting value
- Control Flow: Flow of execution
    - Conditional Statements: `if` or `else`

        "Like a fork in the road"
    - While loop: Continues to execute while the condition is met
    - For loop: Repeats of a set number of times
    - Functions/Methods: Compartmentalize and hide the internal complexity for a task

        Pass in some variables and return a result
- Libraries: A collection of functions that programmers can build on top of
- Algorithms: A specific set of instructions to solve a problem

    There can be multiple algorithms for the same problem

    The fewer steps, the better
- Sorting: Arranging a list of items (array) in a particular order
    - Selection sort: Find the smallest item and swap it to the front until all items are sorted
    
        Complexity: O(n^2)
    - Merge-sort: Split the list in half, sort each half, and merge the two sorted halves
    
        Complexity: O(n log n)
- Big-O notation: Describing the complexity of an algorithm

    How much the run time increases as the input size increases
- Graph: Network of nodes connected with edges of different weights
- Graph Search: Find the fastest path between two nodes in a graph
    - Dijkstra's Algorithm: Start at a node and find the next shortest path to a neighbor node
    
        Complexity: O(n log n + l)
- Brute Force: Trying every possible solution
- All kinds of python resources [here](https://www.pythonlikeyoumeanit.com)

# Statically Typed Languages

Sources:
- https://stackoverflow.com/a/2696369
- https://docs.microsoft.com/en-us/dotnet/csharp/tutorials/
https://learn.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/tutorials/hello-world?source=recommendations
- https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/types/

Notes:
- Statically Typed Languages: A type is associated with a variable at compile time
- \*\* The following is about c# \*\*
- Passing Arguments: Enter whitespace separated strings as arguments

    `args` is the list of string arguments
- Printing: `Console.WriteLine();`
- Creating variables: You must declare the type of the variable at the declaration

    `string x = "hello world";`
- String interpolation: Add "$" and include variables inside the string

    `Console.WriteLine($"Hello {x}");`
- Length: `x.Length`
    
    This can be used to find the length of a string, an array, ...
- Trim: `x.Trim()`
    
    Removes whitespace from the beginning and end of a string

    Can also use `TrimStart()` and `TrimEnd()`
- Replace: `x.Replace("a", "b")`
    
    Replaces all instances of "a" with "b"
- You can also use `ToUpper()` and `ToLower()`
- Searching Strings
    - `x.Contains("a")`: Returns true if the string contains "a"
    - `x.StartsWith("a")`: Returns true if the string starts with "a"
    - `x.EndsWith("a")`: Returns true if the string ends with "a"
- Value Types: These types are stored directly in memory
    - There is no heap allocation needed
    - Sealed: You can't inherit from a value type
    - Main value types: `enum`, `struct`, `int`, ...
- Reference Types: These types are stored in the heap
    - There is heap allocation needed
    - Main reference types: `class`, `record`, `array`, ...

# Visual Studio

How I installed it with VScode and a mac with M2 chip:
1. Install .NET: https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/sdk-7.0.202-macos-arm64-installer

    If you don't have an M1 or M2 chip you can install the x64 version
2. Make sure you can run .NET: `dotnet --version`

    If this is not working see [this](https://stackoverflow.com/questions/53030531/dotnet-command-not-found-in-mac) link
3. Install the C# extension for Vscode: https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csharp
4. Extra - Create a library and solution: https://www.youtube.com/watch?v=r5dtl9Uq9V0
    1. `dotnet new sln -o csharp`
    2. `cd csharp`
    3. `dotnet new console -o app`
    4. `dotnet new classlib -o lib`
    5. `dotnet sln csharp.sln add **/*.csproj`
    6. `dotnet add app/app.csproj reference lib`
5. Create a C# project and run/debug it: https://www.youtube.com/watch?v=DAsyjpqhDp4
    1. `dotnet new console -o app`
    2. Open in VScode and add the missing files

        Will create a .vscode folder with a launch.json file
    3. Run or Debug the project in VScode

        You can also run it in the terminal with `dotnet run` in the app folder
6. See the files in the "csharp" folder

# Unit Testing

Sources:
- https://youtu.be/QBiBZ8bsfcU
- https://docs.microsoft.com/en-us/visualstudio/test/unit-test-basics?view=vsc-2019

Notes:
- First add the unit test project to the solution (see the next section)
- `[FACT]`: Attribute that marks a method as a test method

    See [here](https://xunit.net/docs/comparisons) for more tags

    NOTE: There are other tags depending on the testing framework (`TestMethod`, `TestClass`)
- Vscode test explorer for .NET: formulahendry.dotnet-test-explorer
    
    This adds some structure to the tests
- There are multiple `Assert.` functions such as: `True()`, `Throws()`, `Equal()`, ...
- AAA method of writing unit tests
    - Arrange: Initialize the variables
    - Act: Run the method to be tested
    - Assert: Verify the result
- [This](https://learn.microsoft.com/en-us/dotnet/core/tutorials/testing-library-with-visual-studio-code?pivots=dotnet-7-0) is a good resource for unit testing in vscode

Adding the xunit tests to my code: https://learn.microsoft.com/en-us/dotnet/core/testing/unit-testing-with-dotnet-test
1. Go to the csharp folder in terminal
2. `dotnet new xunit -o tests`
3. `dotnet sln csharp.sln add tests/tests.csproj`
4. `dotnet add tests/tests.csproj reference lib`
5. Create the actual tests: See how to do that in the notes section
6. Run the tests: `dotnet test tests/tests.csproj`

    OR: Run `dotnet test` in the tests folder

    OR: Run the tests in internally on VScode
7. See the files in the "csharp" folder ("tests" folder)

# Programming Exercises

Sources:
- https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/
- https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/method-parameters

Notes:
- Creating an array: `type[] arrayName`

    To make a generic array use `object` as the type
    
    - Single Dimensional: `int[] a = ` ...
        - Set size: `new int[5]`
        - Set values pt. 1: `new int[] {1, 2, 3, 4, 5}`
        - Set values pt. 2: `{1, 2, 3, 4, 5}`
    - Multi-Dimensional: `int[,] a = ` ...
        - Set size: `new int[2, 3]`
        - Set value: `{ {1, 2, 3}, {4, 5, 6} }`
    - Jagged Array: `int[][] a = new int[6][]`
- Length of an array can't be changed once created
- Default values: `0` for numeric and `null` for reference type

    An array is a reference type so jagged arrays are initialized at `null`
- You can use the methods in the abstract class `Array`

    Ex: `Length` and `Rank`
- Passing by value vs. passing by reference
    - Passing by value: Give a copy of the variable to the function
    - Passing by reference: Give the function the address of the variable
- Reference vs. value data type
    - Reference data type: Stores the address to the actual data
    - Value data type: Directly stores the actual data
- What can the caller of a function see?

    | | Value Type | Reference Type
    ---|---|---
    **Pass by Value** | No changes are visible | Changes to the state of the data
    **Pass by Reference** | Changes to the state of the data | Both changes to the data and assignment to a different object


NOTE: My code was made private so I don't give away any answers. There were some problems I encountered when running their files. These were my fixes:
1. Download the x64 version of .NET

    This doesn't have to be the default one when you run `dotnet --info`
2. Download [the package](https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/runtime-3.1.32-macos-x64-installer?cid=getdotnetcore) the error asks you to download