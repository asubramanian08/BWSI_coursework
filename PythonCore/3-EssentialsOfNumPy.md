# [Introducing the ND-array](https://www.pythonlikeyoumeanit.com/Module3_IntroducingNumpy/IntroducingTheNDarray.html)

- The first step is to import numpy: `import numpy as np`
- The ND-array (N-dimensional array) is the most important data structure in numpy
- ND-arrays are similar to lists - you can index them and slice them
- What makes ND-arrays special:
    - It can be accessed in multiple dimensions
    - Perform vectorized operations on the entire array or sections of the array
- `.reshape()` reshapes all the data into the specified shape
- Operations on a np.ndarray:
    - Build in operations on the whole array: `np.power`, `np.mean`, ...
    - Do different operations based on the column: `x ** np.array([1, 2, 3])`
    - Indexing: `x[x % 2 == 0] *= -1`

# [Accessing Data Along Multiple Dimensions](https://www.pythonlikeyoumeanit.com/Module3_IntroducingNumpy/AccessingDataAlongMultipleDimensions.html)

- A dimension is a single axis of the array
- To access data you need to specify the index for each dimension

    Ex: `x[0, :, ::-1]`

    Each index is either a number or a slice
- Each dimension of the array supports the same indexing and slicing operations as a list
- Numpy `np.array()` function can automatically infer the shape of the array from the input data
- `np.shape`: The size of each dimension of the array as a tuple
- If you don't provide enough indices numpy will add on trailing `:` to the end of the index
- Numpy can have 0 dimensions -> that's a scalar

    To get the data of a scalar: `x.item()`
- `reshape`: Sets the shape of the array (make sure the number of elements is the same)

    Can specify on the dimensions to be inferred (set to -1)

    Reshaping doesn't create a copy of the data

# [Basic Array Attributes](https://www.pythonlikeyoumeanit.com/Module3_IntroducingNumpy/BasicArrayAttributes.html)

- `np.shape`: The size of each dimension of the array as a tuple
- `np.ndim`: The number of dimensions of the array

    `len(x.shape) = x.ndim`
- `np.size`: The total number of elements in the array

    `np.prod(x.shape) = x.size`
- `np.dtype`: The data type of the array (np arrays are homogeneous)
- `np.itemsize`: The size in bytes of each element of the array

# [Functions for Creating NumPy Arrays](https://www.pythonlikeyoumeanit.com/Module3_IntroducingNumpy/FunctionsForCreatingNumpyArrays.html)

- `np.array`: Create an array from a list or tuple
- `np.zeros`: Create an array of zeros in the given dimensions
- `np.ones`: Create an array of ones in the given dimensions
- `np.arrange`: Similar to `range` but creates a numpy array
- `np.linspace`: Evenly spaced numbers over a specified interval
- `np.random.normal`: Random numbers from a normal distribution
- `np.random.random`: Random numbers from a uniform distribution of [0, 1)
- To specify the data type of the array add in a `dtype` argument (to any of the above functions)
- `np.vstack`: Stack arrays vertically
- `np.hstack`: Stack arrays horizontally


# [Iterating Over Arrays & Array-Traversal Order](https://www.pythonlikeyoumeanit.com/Module3_IntroducingNumpy/ArrayTraversal.html)

- `np.ndenumerate`: Iterate over the array and get a tuple of the index (as a tuple) and value - similar to `enumerate`
- Row major order (C ordering): Traverse the columns of each row before moving to the next row (default)

    Advance the last index first until it reaches the end, then advance to earlier indices
- Column major order (F ordering): Traverse the rows of each column before moving to the next column

    Advance the first index first until it reaches the end, then advance to later indices

# [“Vectorized” Operations: Optimized Computations on NumPy Arrays](https://www.pythonlikeyoumeanit.com/Module3_IntroducingNumpy/VectorizedOperations.html)

- Numpy's functions act on every entry of the array

    When acting on multiple arrays (ex: addition) they act on the corresponding pairs of entries
- **Vectorized** functions: These function are implemented in optimized complied C code (much faster than python loops)

    It takes advantage of the fact that all the entires are of the same data type
- Try to exclusively use vectorized functions
- Types of vectorized functions
    - Unary functions: Operates on individual entries of the array (square root)

        Numpy maps this function over the whole array creating a new array
    - Binary functions: Operates on pairs of entries two arrays (addition)
    - Sequential functions: Operates on a sequence of arrays (sum)

        For these you can specify the `axis` argument to specify which dimension to operate on
    - See the docs a list of functions
- Logical operations on arrays: `np.less`, `np.allclose`, ...

# [Array Broadcasting](https://www.pythonlikeyoumeanit.com/Module3_IntroducingNumpy/Broadcasting.html)

- Array Broadcasting: The ability of numpy to perform operations on arrays of different shapes
- Adds a new dimension to the smaller array and then duplicates the entries along that dimension

    Ex: `np.array([1, 2, 3]) + np.array([1])` -> `np.array([1, 2, 3]) + np.array([[1, 1, 1]])`
- Note the under the hood the broadcasted version isn't actually created
- Both arrays can undergo broadcasting - ex: (3, 1, 2) * (3, 1) -> (3, 3, 2)
- Not all arrays can be broadcasted together: (2,) * (3,) -> error

    The dimension where an array is broadcasted must be 1 (or implicitly 1 meaning the array doesn't have that dimension)
- `newaxis`: Create a new dimension of size 1
    - Ex: `np.array([1, 2, 3])[:, np.newaxis]` -> `np.array([[1], [2], [3]])`
    - Note this is just a "view" of the array and doesn't create a copy
    - This can be used to step up an array to be broadcasted
- Make sure to not create overly large arrays in the process of broadcasting
- Make sure to deal with floats properly -> use `clip` to round off values to 0
