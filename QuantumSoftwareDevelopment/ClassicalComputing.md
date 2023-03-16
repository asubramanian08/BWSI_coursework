# Digital Information

Sources:
- https://www.khanacademy.org/computing/computers-and-internet/xcae6f4a7ff015e7d:digital-information
- https://youtu.be/Xpk67YzOn5w
- https://youtu.be/wgbV6DLVezo

Notes:
- Computers internally used ones and zeros to represent information and code
- A bit is an on or off state and can be stored when electricity is flowing or not
- Binary numbers only have 0 and 1 as digits, doing 1001 + 1 = 1010
- Each position is 2^i where i the position from the right, the number 1010 is 8 + 2 = 10
- Text images and sound can be represented as binary numbers:
    - Text: each letter is represented by a number (ASCII)
    - Images: each pixel or color is represented by a number
    - Sound: each frequency in a sound wave is represented by a number
- Hexadecimal numbers are base 16 and use 16 digits (0-9 and A-F)
    - Finding the value of a hex number is just like binary but with 16^i instead of 2^i
    - Each hex digit is 4 bits or 4 binary digits
- Micro-transistors: Switches that can be turned on or off equivalent to one bit

# Endianness

Sources:
- https://youtu.be/NcaiHcBvDR4
- https://youtu.be/rJf5qkwkMY4
- https://en.wikipedia.org/wiki/Endianness

Notes:
- Endianness is the order in which bytes are stored in memory
- Big Endian: Most significant byte is stored first
- Little Endian: Least significant byte is stored first
- "Endian" is a reference to Gulliver's Travels - where should you start eating the egg?
- Endianness is important when storing multi-byte data types like integers and floats
- If you use little endian the 1st of second bit with be stored in the same position

# Digital Logic

Sources:
- https://www.khanacademy.org/computing/computers-and-internet/xcae6f4a7ff015e7d:computers/xcae6f4a7ff015e7d:logic-gates-and-circuits/a/logic-gates
- https://youtu.be/gI-qXk7XojA
- https://youtu.be/9EY_XoEImjM
- https://en.wikipedia.org/wiki/Boolean_algebra

Notes:
- Logic gates are essential to make computers manipulate data (in the form of bits)
- NOT gate: Inverts the input (0 -> 1, 1 -> 0)
- AND gate: True if both inputs are true
- OR gate: True if at least one input is true
- XOR gate: True if one input is true and the other is false
- NAND gate: True if at least one input is false
- NOR gate: True if both inputs are false
- Note: NAND and NOR are universal logic gates and can make up any other logic gate
- Circuits are made up of logic gates and wires
- To see how NOT, AND, OR are built from transistors see: https://youtu.be/gI-qXk7XojA

# Computer Architecture (Optional)

Sources:
- https://www.khanacademy.org/computing/computers-and-internet/xcae6f4a7ff015e7d:computers/xcae6f4a7ff015e7d:computer-components/a/computer-components-introduction
- https://youtu.be/1I5ZMmrOfnA
- https://youtu.be/fpnE6UAfbtU
- https://youtu.be/FZGugFqdr60
- https://youtu.be/zltgXvg6r3k
- https://youtu.be/RU1u-js7db8
- https://inst.eecs.berkeley.edu/~cs61c/resources/MIPS_Green_Sheet.pdf

- 4 basic components of a computer:
    - Input: Collects data and convert to binary

        Ex: Touch screen, keyboard, microphone, camera, etc.
    - Memory: Where data is stored
    - Central Processing Unit (CPU): Processes data
    - Output: Convert binary data to human readable form

        Ex: Monitor, speakers, printer, etc.
- Breaking down a CPU
    - This is what carries out various instructions and calculations
    - Control Unit: Interprets instructions
    - Arithmetic Logic Unit (ALU): Performs calculations
- Layers of abstraction
    - The CPU is an integrated circuit (IC) or chip
    - Inside the chip is many circuits
    - Circuits are made of logic gates
    - All logic gates are made of transistors
- Breaking down Memory
    - This is connected to the CPU via a memory bus
    - Used for high frequency data access: Running programs and current data
    - RAM (Random Access Memory): Used for temporary high-frequency access
    - Secondary Storage: Used for long-term storage (ex: hard drive or SSD)

        Slower then RAM but can store more data and retains data when power is off
- ALU can contain:
    - Adder: Adds two numbers (Half adder followed by series of full adders)
    - Logic Unit: Performs logical operations (AND, OR, XOR, test if number is 0)
- Basic Memory Structure:
    - And-Or Latch: Has a set and reset input make the output 1 or 0
    - Create a gated latch by a write flag with a data (to set) input
    - Use a grid of latches to store data with wires running through the row and column. Only allow the write enable flag if: the row, column, and write flag are all true.

        This optimizes the number of wires needed to set a single bit.
    - Multiplexers: Pass an integer to select which input to pass to the output

        Take in a 4 bit number and output true to one of the 16 wire lines.
    - The RAM will be 8 of these latch grids one to represent each bit being read
- To actually do stuff we need instructions: Use opcodes to tell the CPU what to do

    Instruction examples: add, jump, load, store, if, etc.