# Uninitialized Property Access in C#

This example showcases a common error in C#: accessing a property before it has been assigned a value.  Uninitialized properties can lead to unpredictable behavior and unexpected results.

The `bug.cs` file contains the code with the error. The `bugSolution.cs` file demonstrates a corrected version.

## Bug Description
The `MyMethod` function attempts to print the value of `MyProperty` before assigning it a value. This results in the program outputting the default value for integers (0) instead of the expected value (10).