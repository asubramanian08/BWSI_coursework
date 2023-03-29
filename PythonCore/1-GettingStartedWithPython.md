# Introduction

This section of notes is for [module 1](https://www.pythonlikeyoumeanit.com/module_1.html) of the [Python like you mean it](https://www.pythonlikeyoumeanit.com/) course.

# Introduction to the Python Programming Language

- [A Quick Guide to Formatting](https://www.pythonlikeyoumeanit.com/Module1_GettingStartedWithPython/SiteFormatting.html)
    - Variables are written with backticks:ex:        ```py
        # Here `x` serves are a counter
        for x in range(10):
            print(x)
        ```
    - ">>>" indicates code run inside a console

        This can show you the result without having to use several print calls
    - There might be a mix of regular code and console code in one code block
    - Python terminals might crash with multiple comments in a row so just copy the actual code
- [Introducing the Python Programming Language](https://www.pythonlikeyoumeanit.com/Module1_GettingStartedWithPython/GettingStartedWithPython.html)
    - Programming Language: A language with a strict set of rules for a computer to be able to execute and a human to be able to readex:        Python is a programming language with its own set of rules
    - Python Script: "A text file containing Python code"
    - Python Interpreter: Given the Python script, it will make the computer execute the code

        A python interpreter can:
        - read in the python script
        - determine if it obeys python's rules
        - translate the code into a language that the computer can understand
        - execute the code

        CPython (which is implemented in C) is the official python interpreter
    - Generally python scripts are saved in ".py" files
    - Integrated Development Environment (IDE): An editor that has a lot of features to help you write code (ex: warns you if you have a syntax error)
    - "Installing Python" means installing a python interpreter in the form on an executable file

        As part of the installation process the computer should know where the python executable is located so you can execute `python <file.py>` in any directory
    - Benefits of Python
        - It is extremely easy to learn since it is very readable
        - It is open source and free
        - Very popular so it has a lot of support
    - Python versions
        - [Here](https://docs.python.org/3/whatsnew/index.html) is a site to track the latest changes
        - Python versions are formatted as `A.B.C`
            - A (Major release): Code in between major releases may not compatible
            - B (Minor release): Always forward compatible but it is not backwards compatible (ex: f-strings in python 3.6)
            - C (Patches): Both forward and backwards compatible - all changes happen under the hood

# [Installing Python](https://www.pythonlikeyoumeanit.com/Module1_GettingStartedWithPython/Installing_Python.html)

- Installing Anaconda will install
    - Python (CPython)
    - Python Packages (ex: numpy, pandas, matplotlib, etc.)
    - Jupyter Notebook
    - Conda package manager
- Install Anaconda [here](https://www.anaconda.com/download/)
    - Creates "Anaconda3" folder with all necessary anaconda files
    - Adds anaconda to the system path (list of directories that the computer will search for executables)
- Anaconda Tutorial [here](https://conda.io/projects/conda/en/latest/user-guide/getting-started.html)
- Anaconda might mess with programming in different languages - so just add anaconda to the path of that terminal session `alias anaconda="export PATH=/home/arjunsubramanian/anaconda3/bin:$PATH"`
- Conda is also an environment manager: can switch between python 3 and python 2.7

    ```shell
    conda create -n py27 python=2.7 anaconda
    conda activate py27
    # do stuff
    conda deactivate
    ```

# [An Informal Introduction to Python](https://www.pythonlikeyoumeanit.com/Module1_GettingStartedWithPython/Informal_Intro_Python.html)

- Start an Ipython console by typing `ipython` in the terminal
    - Here you can run pieces of code instead of writing the whole script
    - It also has autocomplete and documentation display features
    - Variables created in the console will persist between runs
    - Note: to see all the function in a module type `math.<tab>` in the console

        Tab starts autocompletion
- Exponentiation: `**`
- Python stores its math functions in a math module: `import math`

    Ex: `math.sqrt(4)` - this will return `2.0` since the `math.sqrt` function always returns a float
- To import a certain function from a module: `from math import sqrt`

    Ex: `sqrt(4)`
- String can be written with single or double quotes

    Depending on which you can use the other as a character in the string

    - `len()` finds the length of a string
    - `str[b:e]` returns the substring from index `b` to `e-1`

        Note a negative index will count from the end of the string
    - Check if a substring is in a string: `"sub" in "substring"`
    - `str.count('a')` count the number of "a"s in the string

        Type `str.<tab>` to see all the string functions
- Line break character: `\n`
- Create a list with `[]`
    - Ex: `my_list = [1, 2, 3]`
    - Lists can contain any type of object
    - Concatenate lists together with "`+`"
    - Access and modify elements with `my_list[i]` or `my_list[b:e]`
    - Check if an element is in a list with `<element> in my_list`
    - Add elements to the list: `my_list.append(<element>)`

# [Jupyter Notebooks](https://www.pythonlikeyoumeanit.com/Module1_GettingStartedWithPython/Jupyter_Notebooks.html)

- Jupyter Notebook features
    - Similar to IPython console with multiple lines and the ability to re-execute code
    - Can add markdown cells to explain the code
    - Notebooks can be saved to edit later
    - Add visualizations to the notebook
- [Jupyter Lab](https://jupyterlab.readthedocs.io/en/stable/getting_started/overview.html): A web-interface for running multiple jupyter notebooks
- Create a jupyter notebook: `jupyter notebook`
- Run a cell: `shift + enter`

    Once a cell is run the variables are remembered
- Command mode (escape to activate) allows you to use commands to edit the notebook
    - `a` to add a cell above
    - `b` to add a cell below
    - `dd` to delete a cell
    - `00` to restart the kernel
    - `m` to change a cell to markdown
    - `y` to change a cell to code
    - etc.
- `<tab>` gives autocomplete
- `<shift>+<tab>` gives documentation
- Markdown allows you to write text in a notebook with special formatting
- You can use Jupyter notebooks to code in many other languages (ex: R, Julia, etc.)

# [Setting Up a Development Environment](https://www.pythonlikeyoumeanit.com/Module1_GettingStartedWithPython/Getting_Started_With_IDEs_and_Notebooks.html)

- An IDE ...
    - checks your code for syntax errors
    - colors your code
    - enables you to look up documentation and definitions
    - auto-completes parts of your code (function and variable names)
- It typically
    - Has a debugger
    - Integrates with version control systems
- Two endorces IDEs for python
    - PyCharm
    - VScode (which is what I wrote this in :D)