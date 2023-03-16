# Complex Numbers

Sources:
- https://www.khanacademy.org/math/precalculus/x9e81a4f98389efdf:complex
- https://youtu.be/5PcpBw5Hbwo

Notes:
- The axis are the real and imaginary axis: $2 - 3i \approx (2, -3)$
- You can add, plot, find midpoint of complex numbers similar to real numbers
- The $\bar{z}$ is the complex conjugate of $z$
    - $2 - 3i \implies 2 + 3i$
    - Multiplying a complex number by its conjugate gives a real number
- Modulus or absolute value ($|z|$) is the distance from the origin to the point
    - $|a + bi| = \sqrt{a^2 + b^2}$
- Vector representation: (Argument, Magnitude)
    - $r = |z| = \sqrt{a^2 + b^2}$
    - $\theta = \arctan(\frac   ba)$
    - $z = r(\cos(\theta) + i\sin(\theta)) = re^{i\theta}$
- Other properties:
    - $z^2 = $
    - Rule of sin and cos
- How multiplying by complex numbers rotates the answer

# Vectors

Sources:
- https://www.khanacademy.org/math/linear-algebra/vectors-and-spaces/vectors/v/vector-introduction-linear-algebra
- https://youtu.be/fNk_zzaMoSs

Notes:
- Vectors have magnitude and direction (ex. velocity not speed)
- Example: $\vec{v} = (5, 0) = \begin{bmatrix}5 \\ 0\end{bmatrix}$
    - The horizontal component is $5$
    - The vertical component is $0$
- $\mathbf{R}^2$ is all real 2-tuples

    $\vec{v} \isin \mathbf{R}^2$
- Vector components:
     - Magnitude: $|\vec{v}| = \sqrt{v_1^2 + v_2^2}$
     - Direction: $\theta = \arctan(\frac{v_2}{v_1})$
- Adding vectors: $\vec{v} + \vec{w} = \begin{bmatrix}v_1 \\ v_2\end{bmatrix} + \begin{bmatrix}w_1 \\ w_2\end{bmatrix} = \begin{bmatrix}v_1 + w_1 \\ v_2 + w_2\end{bmatrix}$

    Match the tail of $\vec{w}$ to head of $\vec{v}$
- Multiplying by scalar: $k\vec{v} = \begin{bmatrix}kv_1 \\ kv_2\end{bmatrix}$

    Multiplies the magnitude of $\vec{v}$ by $k$
- Subtraction: multiply by $-1$ (reversing the direction) then add
- Unit vectors: 
    - $\hat{\textbf\i} = \begin{bmatrix}1 \\ 0\end{bmatrix}$ - horizontal $x$ direction
    - $\hat{\textbf\j} = \begin{bmatrix}0 \\ 1\end{bmatrix}$ - vertical $y$ direction
    - If $\vec{v} = (2, 3)$ then $\vec{v} = 2\hat{\textbf\i} + 3\hat{\textbf\j}$

# Matrices

Sources:
- https://www.khanacademy.org/math/precalculus/x9e81a4f98389efdf:matrices
- https://youtu.be/kYB8IZa5AuE

Notes:
- Matrix: rectangular array of numbers
- Example: $\begin{bmatrix}1 & 2 & 3 \\ 4 & 5 & 6\end{bmatrix}$
    - There are 2 rows and 3 columns (2 x 3 matrix)
- Multiplying by scalar: $k\begin{bmatrix}a & b \\ c & d\end{bmatrix} = \begin{bmatrix}ka & kb \\ kc & kd\end{bmatrix}$
- Matrix addition: $\begin{bmatrix}a & b \\ c & d\end{bmatrix} + \begin{bmatrix}e & f \\ g & h\end{bmatrix} = \begin{bmatrix}a + e & b + f \\ c + g & d + h\end{bmatrix}$

    Subtraction is just adding the negative
- Matrix multiplication: $\begin{bmatrix}a & b \\ c & d \\ e & f\end{bmatrix}\begin{bmatrix}g & h & i \\ j & k & l\end{bmatrix} = \begin{bmatrix}ag + bj & ah + bk & ai + bl \\ cg + dj & ch + dk & ci + dl \\ eg + fj & eh + fk & ei + fl\end{bmatrix}$

    - The number of columns in the first matrix must equal the number of rows in the second matrix
    - The position $(i, j)$ of the product matrix = $i^{th}$ row of the first matrix times $j^{th}$ column of the second matrix
- A 2x2 matrix can represent a linear transformation of a plane
    
    If the transformation matrix is: $\begin{bmatrix}a & b \\ c & d\end{bmatrix}$ then the vector $\vec{v} = 3\hat{\textbf\i} - 2\hat{\textbf\j}$ will become $3 \begin{bmatrix}a \\ c\end{bmatrix} - 2 \begin{bmatrix}b \\ d\end{bmatrix}$.

# Bra-Ket and Tensor Notation

Sources:
- https://www.mathsisfun.com/physics/bra-ket-notation.html
- https://youtu.be/f5liqUk0ZTw
- https://en.wikipedia.org/wiki/Kronecker_product

Notes:
- $\braket{bra | ket}$ is a special type of vector for quantum physics
- A ket is analogous to a column vector

    $$\ket{r} = \begin{bmatrix}r_1 \\ r_2 \\ r_3 \end{bmatrix}$$
- A bra is analogous to a row vector
    
    $$\bra{r} = \begin{bmatrix}r_1 & r_2 & r_3\end{bmatrix}$$
- Special properties
    - The $r_i$ values are complex numbers
    - A bra or ket describes a state of a quantum system
    - They can have up to infinite dimensions
- A bra is a conjugate transpose of a ket

    $$\ket{r} = \begin{bmatrix} 1+2i \\ -2+4i \\ 3-i \end{bmatrix} \rightarrow \bra{r} = \begin{bmatrix} 1-2i & -2-4i & 3+i \end{bmatrix}$$
- Multiplying a bra and ket (using the dot product) gives a scalar

    $$\braket{r | r} = \begin{bmatrix} 1-2i & -2-4i & 3+i \end{bmatrix}\begin{bmatrix} 1+2i \\ -2+4i \\ 3-i \end{bmatrix} = 5 + 20 + 10 = 35 $$
- Dot product with itself is the magnitude squared

    $$\braket{r | r} = |r|^2$$
- Orthogonal vectors (meet at a right angle): $\braket{a | b} = 0$
- Basis vectors:
    - From the individual components of a vector
    - Can be unit vectors but they are just any independent vectors (meet at right angles) that span the entire space
    - Orthonormal basis: Form right angles to the others (orthogonal) and have a magnitude of $1$ (normalized)
- Shrodinger's cat: $\ket{\text{cat}} = \frac{1}{\sqrt2}\ket{\text{alive}} + \frac{1}{\sqrt2}\ket{\text{dead}}$

    This is a superposition of the two states (alive and dead)
- Probability of a state = $|\text{Amplitude}|^2$

    The probability of the cat being alive or dead is $\frac12 + \frac12 = 1$
- The $\braket{\text{bra}|\text{ket}}$ notation allows us to represent a probability state
- Tensors are generalizations of a vector:
    - A scalar is a 0th order tensor (0 indices)
    - A vector is a 1st order tensor
    - A matrix is a 2nd order tensor (2 indices)

    Tensors are useful because all observers can agree on the combination of components and basis vectors
- Kronecker product (tensor product): $\otimes$

    $$\begin{bmatrix}a & b \\ c & d\end{bmatrix} \otimes \begin{bmatrix}e & f \\ g & h\end{bmatrix} = \begin{bmatrix}ae & af & be & bf \\ ag & ah & bg & bh \\ ce & cf & de & df \\ cg & ch & dg & dh \end{bmatrix}$$

    If $A$ is an n x m matrix and $B$ is a p x q matrix then the Kronecker product is an np x mq matrix.

    $A_{i,j}B_{k,l} = K_{pi+k,qj+l} \space \forall i,j,k,l$