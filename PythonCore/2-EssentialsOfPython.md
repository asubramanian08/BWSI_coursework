# Introduction

This section of notes is for [module 2](https://www.pythonlikeyoumeanit.com/module_2.html) of the [Python like you mean it](https://www.pythonlikeyoumeanit.com/) course.

Contents for the module are:
- basic data types
- sequential object (lists, tuples, strings)
- mutable vs immutable objects
- flow-control (if, for, while)
- for-each loops and generator comprehensions
- functions
- built-in object types (dict, set)

# [Basic Object Types](https://www.pythonlikeyoumeanit.com/Module2_EssentialsOfPython/Basic_Objects.html)

- A python "object": is something that can be assigned to a variable
- `isinstance(x, <type>)` function: checks if an object is of a certain type

    Note that this will be `True` for subclasses of the type as well.
- `type(x)` function: returns the type of an object
- Number types:
    - You can do basic arithmetic with numbers in python (+, -, ==, etc.)
        - This obeys order of operations (and the use of parentheses)
        - Note that `//` is integer division and `/` is regular division and will always return a float.
        - `%` is the modulo operator (returns the remainder of the division)
        - You can use `x <operator>= y` to do the operation and assign the result to `x` (ex: `x += 1` is the same as `x = x + 1`)
    - Note you can add underscores to numbers to make them more readable (ex: `1_000_000`)
    - int (integer): Represents all whole numbers (positive and negative)
        - Python allows an unlimited number of digits in an integer (it just keeps allocating more data)
    - float (floating point)
        - This is a decimal number with a fixed number of digits after the decimal point
        - It can also be represented in scientific notation (ex: 1.23e-4)
        - Because of their limited precision, floating point numbers are not always accurate so don't use == to compare them - use `math.isclose` instead
        - There are build-in `Decimal` and `Fraction` modules that can be exact
    - complex (complex number)
        - Note that comparisons between complex numbers are not supported
        - In python instead of `i` for the imaginary part, you use `j`
        - You can use `cmath` module for more complex math functions
- Boolean Type
    - There are two boolean values: `True` and `False`
    - Boolean operations: `and` (`&`) , `or` (`|`) , `not`
    - The result of a comparison is a boolean (ex: `1 == 1` is `True`)
    - Bools are instances of `int` where `True == 1` and `False == 0`
- None Type
    - `None` is the only value of the `NoneType` type
    - `None` can be used as place a placeholder (ex: for finding the max of a list)
- Strings:
    - can be created with 1 or 3, single or double quotes
    - The characters of a string are represented by UTF-8 unicode
    - The `str()` function can be used to convert an object to a string
    - Strings are immutable (you can't change them without creating a new string)
    - There are a lot of built-in function (`.split()`, `.endswith()`, `.format()`, etc.)
    - f-strings: you can use `{}` to evaluating python code into a string
    - Strings are indexable (see more about indexing later)
- Lists:
    - Lists can be created with square brackets (`[]`)
    - Lists can store any type of object including other lists
    - The `list()` function can convert an iterable object into a list
    - Lists are indexable (see more about indexing later)
    - Lists are mutable (you can change them in place)
        - `.append()`: Add an item to the list
        - `.extend()`: Add on a list of items
        - `.pop()`: Remove an item from the list (by default the last item)
        - `.remove()`: Remove an item from the list (by value)

# [Sequence Types](https://www.pythonlikeyoumeanit.com/Module2_EssentialsOfPython/SequenceTypes.html)

- Sequence types are objects where order matters -> they can therefore be indexed
- Examples of sequence types are lists, strings, tuples, and numpy arrays
- Tuple: This is an immutable form of a list

    Tuples can be created with parentheses (`()`)
- Python sequences syntax
    - Use `in` or `not in` to check if an item is in a sequence
    - Concatenate sequences with `+`
    - Use `*` to repeat a sequence
    - Length of a sequence can be found with `len()`
    - `.index(x)`: The index of the first occurrence of `x` in the sequence
    - `.count(x)`: The number of occurrences of `x` in the sequence
- Indexing and Slicing
    - Access specific elements of a sequence with `[]`
    - Indexing starts at 0
    - Slicing allows you to access a range of elements in a sequence (ex: `x[1:3]`)
        - Start index is inclusive (default is `0`)
        - End index is exclusive (default is `len(x)`)
        - Step can be used to skip elements (default is `1`)
        - Any of these can be left out and the default will be used 
    - Negative indices count from the end of the sequence
    - If you access an out of bound index and error will be thrown (with the exception of slicing)

# [Variables & Assignment](https://www.pythonlikeyoumeanit.com/Module2_EssentialsOfPython/Variables_and_Assignment.html)

- Variable allow you to write flexible and reusable code
- Assign a variable with the assignment operator (`=`)

    The variable must go to the left hand side
- Once a variable is set to an object is "references" that object

    It can be used as a placeholder for the object in the rest of the code
- A variable can can be made of a combination of letters, digits, and underscores

    The first character can't be a digit

    Note: They can't be reserved keywords (ex: `if`, `for`, `while`, etc.)
- Mutable vs. Immutable
    - Immutable object can't have its state changed
        - Immutable objects: `int`, `float`, `complex`, `str`, `tuple`, `bool`, `frozenset`
        - A new object is created when you change an immutable object
    - Mutable objects can have their state changed
        - Mutable objects: `list`, `dict`, `set`, `numpy.ndarray`
        - Two variable can reference the same mutable object

            Changing the object will change both variables

# Conditional Statements

- [Introducing Control Flow](https://www.pythonlikeyoumeanit.com/Module2_EssentialsOfPython/Introduction.html)
    - Controlling the flow of code is changing the order in which code is executed
    - Type of flow control
        - Functions: allow you to reuse code
        - Conditional statements: branch code execution based on a condition
        - Loops: repeat code execution
    - Scoping: You can delimitate scope by indentations (it is convention to use 4 spaced in a code block)ex:        If the spacing isn't consistent there will be an error
- [Conditional Statements](https://www.pythonlikeyoumeanit.com/Module2_EssentialsOfPython/ConditionalStatements.html)
    - Conditionals are created with `if`, `elif`, and `else` statements
    
        These determine which blocks of code are executed based on a condition
    - `if` and `elif` statements require a `True` or `False` condition
    
        For example: `>=`, `==`, `is`, `is not`, ...
    - `==` compares the values of two objects
    
        `is` checks if the two object are the same object in memory
    - Some values of objects evaluate to bool (ex: `if x`)
        
        `0`, `0.0`, `0j`, `None`, `False`, `''`, `()`, `[]`, `np.array([])`, `{}`, `set()`
    - Syntax for using `if`
        - Write `if` followed by a condition and a colon (`:`)
        - The block of code for this condition is written on the next line and indented
    - `elif` is similar to `if` but it must follow an `if` or another `elif` statement
    - `else` is used to catch all other cases (there is no need for a condition)
    - Note that `elif` and `else` are optional
    - Inline if-else statement: `<x> if <condition> else <y>`
    - Short-circuiting:
        - `and` and `or` are short-circuiting operators - if you have `False and <condition>` or `True or <condition>` the second condition will not be evaluated
        - This is useful for using a condition that may throw an error (ex: `x != 0 and 1/x > 5`)

# [For-Loops and While-Loops](https://www.pythonlikeyoumeanit.com/Module2_EssentialsOfPython/ForLoops.html)

- `for` loop: Iterate over a collection of items and run a block of code
    1. Set the next item in the collection to a variable
    2. Run the block of code
    3. Repeat until the collection is exhausted

    Note that even though the variable created for the for loop is accessible outside the loop, it is not recommended to use it outside the loop
- `while` loop: Run a block of code while a condition is met
    1. Call `bool(<condition>)`
    2. If `True` run the block of code
    3. Repeat until the condition is `False`
- `break`: Stop the execution of the loop
- `continue`: Immediately jump to the next iteration of the loop
- `else`: Run this block of code if the loop is exhausted without encountering a `break`

# [Iterables](https://www.pythonlikeyoumeanit.com/Module2_EssentialsOfPython/Iterables.html)

- An iterable is an object that can be iterated over (~with a for loop)

    Example: `list`, `str`, `tuple`, `dict`, `set`, `np.ndarray`
- Iterable functions:
    - `list`, `tuple`, `dict`, `set`, etc.
    - `sum`: Sum the elements of an iterable
    - `sorted`: Return a sorted list of the elements of an iterable
    - `any`: If `bool(x) == True` for any element in the iterable
    - `all`: If `bool(x) == True` for all elements in the iterable
    - `max` and `min`: Return the maximum and minimum elements of an iterable
- Iterable unpacking: Assign multiple variables at once with an iterable (`x, y = [1, 2]`)

    Can use this in a for loop -`for x, y in [(1, 2), (3, 4)]:`
- `enumerate`: Return an iterable of tuples with the index and value of each element in the iterable (`for index, value in enumerate([1, 2, 3]):`)

# Generators & Comprehension Expressions

- [Generators & Comprehension Expressions](https://www.pythonlikeyoumeanit.com/Module2_EssentialsOfPython/Generators_and_Comprehensions.html)
    - A generator is an iterable that is created on the fly

        Therefore it can iterate over a lot of data without using a lot of memory
    - `range()` is a generator that returns a sequence of numbers
    
        You can pass a start, stop, and step to `range()`
    - Generator comprehension: `(<expression> for <variable> in <iterable> if <condition>)`

        This is equivalent to:
        ```python
            for <variable> in <iterable>:
                if bool(<condition>)
                    yield <expression>
        ```

        - Note the the if statement is optional
        - Note that the expression can be any valid one-line python expression (including inline if-else statements)
    - A generator has no length and can't be indexed (other than `range()`)
    - You can use any iterable function (ex: `sum`) on a generator

        Note the once a generator is exhausted it can't be used again
    - `5 in gen`: Will drain the generator until `5` is found or the generator is exhausted
    - Chaining generators: A generator can be used in the for loop of another generator
    - `next()` allows you to get the next value of a generator (or any iterator)

        Note if you call `next()` on a generator that is exhausted it will raise `StopIteration`
    - Iterator vs. Iterable: An iterator stores its state of iteration (which the `next()` function can be called on) and an iterable are the containers that can be iterated over - "every iterator is an iterable but not every iterable is an iterator"

        The `iter()` function can be used to get an iterator from an iterable
    - List comprehension: Has the same syntax as generator comprehension but returns a list (the expression has to be wrapped in `[]`)
    - For a tuple comprehension you need to use a generator comprehension and then cast it to a tuple
- [Python’s “Itertools”](https://www.pythonlikeyoumeanit.com/Module2_EssentialsOfPython/Itertools.html)
    - `range()`: A generator that returns a sequence of numbers
    - `enumerate()`: A generator that returns a sequence index and values for each element in the iterable
    - `zip()`: A generator that combines multiple iterables into a single iterable of tuples
    - `itertools.chain()`: Chain multiple iterables back to back into a single iterable
    - `itertools.combinations()`: A generator that returns all possible r-length combinations of elements

# [Basics of Functions](https://www.pythonlikeyoumeanit.com/Module2_EssentialsOfPython/Functions.html)

- A function is a block of code that can be called multiple times
- Calling the function is when you actually run the code in the function

    You have to pass in the proper arguments
- Functions are defined
    
    ```python
        def <function_name>(<arguments>):
            """ docstring """
            <block of code>
            return <value>
    ```
- Reaching the `return` statement will immediately end the function
    - If there is no `return` statement or `return` is called with no `<value` the function will return `None`
    - There can be multiple `return` statements in a function but only one will be reached
    - To return multiple values, return a tuple of values
- Note that all the code inside the function is indented
- Inline functions can be created by defining the function and the return on the same line

    Use this when necessary but it is not recommended
- A function can take any number of arguments (of any type)
    - You need to specify the values of the arguments when you call the function
    - You can do this by passing in the arguments in the correct order

        OR: Specify the argument by name -> `func(x=1, y=2)`
    - Default arguments: These can be used when the user doesn't specify a value for the argument

        ```python
            def func(x=1, y=2):
                return x + y
        ```
    
        The default values can only be used after all positional arguments
    - Arbitrary number of arguments: `def func(*<var_name>):`

        All the passed arguments will be stored in a tuple
        - Use `*` to unpack an iterable into a function call

            `func(*[1, 2])` is equivalent to `func(1, 2)`
    - Arbitrary number of keyword arguments: `def func(**<var_name>):`

        All the passed arguments will be stored in a dictionary
        - Use `**` to unpack a dictionary into a function call

            `func(**{'x': 1, 'y': 2})` is equivalent to `func(x=1, y=2)`
- Functions are objects so variables can be assigned to a function, lists can contain functions, etc.

# [Scope](https://www.pythonlikeyoumeanit.com/Module2_EssentialsOfPython/Scope.html)

- A scope of a variable is the region of the code where the variable is defined
- Function arguments and variables defined in the function have a scope of the function
- The python scope is more liberal than c++: variables defined in a while-loop, for-loop, or if-statement have a file scope
- If two variables have the same name, the variable in the inner scope will be used

# [Data Structures (Part I): Introduction](https://www.pythonlikeyoumeanit.com/Module2_EssentialsOfPython/DataStructures.html)

- "Big-O" notation describes how an algorithm scales with the size of the input
- List / Tuple time complexities
    - `len(seq)` -> $O(1)$
    - `seq[i]` -> $O(1)$
    - `seq[i:j]` -> $O(k)$ where $k$ is the length of the slice
    - `for item in seq` -> $O(n)$
    - `obj in seq` -> $O(n)$
    - `seq.count(obj)` -> $O(n)$
    - `seq.index(obj)` -> $O(n)$
- Other list complexities
    - `l[i] = obj` -> $O(1)$
    - `l.append(obj)` -> $O(1)$
    - `l.pop()` -> $O(1)$
    - `l.pop(i)` -> $O(n)$
    - `l.sort()` -> $O(n \log n)$

# [Data Structures (Part II): Dictionaries](https://www.pythonlikeyoumeanit.com/Module2_EssentialsOfPython/DataStructures_II_Dictionaries.html)

- Dictionaries allow you to store key-value pairs

    You can quickly look-up a value by its key (every key is unique)
- The time complexity to access a value in a dictionary is $O(1)$

    It does this by [hashing](https://en.wikipedia.org/wiki/Hash_function)
- Use `{key_1: value_1, key_2: value_2}` to create a dictionary

    OR: `dict([(key_1,value_1), (key_2,value_2)])` -> an iterable of key, value tuples
- Use `dict[key_x]` to get the value associated with the key

    If the key doesn't exist, a `KeyError` will be raised
- Dictionary comprehensions: `{key: value for key, value in iterable}`
- Add entry to dictionary: `dict[key] = value`

    Use `dict.update([(key_1,value_1), (key_2,value_2)])` to add multiple entries at once
- The keys must be a immutable hashable object and values can be any object
- When using floats as keys it is good practice to round them to a certain number of decimal places
- Iterating over a dictionary
    - `for key in dict` -> iterates over the keys
    - `for value in dict.values()` -> iterates over the values
    - `for key, value in dict.items()` -> iterates over the key, value pairs
    - All the above methods can also test if a key exists in the dictionary
- Dictionary Time Complexities
    - `len(dict)` -> $O(1)$
    - `dict[key]` -> $O(1)$
    - `dict[key] = value` -> $O(1)$
    - `key in dict` -> $O(1)$
    - `(key, value) in dict.items()` -> $O(1)$
    - `value in dict.values()` -> $O(n)$
    - `for key in dict` -> $O(n)$
- Dictionaries prior to python 3.6 were unordered -> afterword they are ordered in the order they were added

# [Data Structures (Part III): Sets & the Collections Module](https://www.pythonlikeyoumeanit.com/Module2_EssentialsOfPython/DataStructures_III_Sets_and_More.html)

- A Python set is an "unordered collection of unique objects"
- It is used to
    - Find only the unique elements in a sequence
    - Check if a sequence contains a certain element (in $O(1)$ time)
    - Check if on set is a subset of another set
- Sets also use hashing to store the elements (so its not possible to index into a set)
- Sets are created using `{obj_1, obj_2, obj_3}`

    OR: `set(iterable)`

    OR: Generator comprehension: `{obj for obj in iterable}`
- Note the `{}` creates and empty dictionary not set
- Sets allow for set-theoretic operations
    - `set_1 | set_2` -> union
    - `set_1 & set_2` -> intersection
    - `set_1 - set_2` -> difference
    - `set_1 ^ set_2` -> symmetric difference
    - `set_1 <= set_2` -> subset
    - `set_1 >= set_2` -> superset
    - `set_1 == set_2` -> equivalence
- Sets are mutable
    - `set.add(obj)` -> adds an object to the set
    - `set.update(iterable)` -> adds all the elements of `iterable` to `set_1`
    - `set.remove(obj)` -> removes an object from the set
    - Use a `fronzenset` if you want an immutable set
- Other python collections (in the collections module)
    - Named tuples: Access elements by name and by index
    - Default dictionaries: If the key doesn't exist, it will be created and assigned a default value
    - Counter: This count the number of times an object occurs
    - Dequeue: Removing and adding to the front and back of the list is $O(1)$