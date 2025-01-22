# Ambiguous Implicit Conversions in C#

This repository demonstrates a subtle bug related to ambiguous implicit type conversions in C#.  The issue arises when multiple implicit conversions are possible, leading to unexpected behavior and a runtime exception. The `bug.cs` file contains the problematic code, while `bugSolution.cs` provides a solution to avoid ambiguity.

## Problem Description

The `MyClass` class defines implicit conversions to and from `int`.  When adding `MyClass` objects, the compiler attempts multiple implicit conversions, resulting in an ambiguity error.

## Solution

The solution involves avoiding the ambiguity by explicitly casting at least one of the operands to an int before addition.