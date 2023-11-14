# C# Junior Technical Test

This C# project includes a set of functions that perform various string manipulation operations. Each function addresses a specific aspect, from reversing a string to counting characters and words in a given string.

## Purpose
This code serves as an example for a junior technical test. It demonstrates fundamental string manipulation techniques in C#, showcasing skills in tasks such as string reversal, character counting, and word counting. The included functions are designed to provide a comprehensive overview of the developer's understanding of basic string operations and their implementation in C#.


## Included Functions

### 1. Reverse a String

- `InvertString()`: Reverses a string using a loop and displays the result in the console.

- `InvertStringUsingArray()`: Reverses a string using an array and displays the result in the console.

### 2. Count Characters

- `CountCharacter()`: Counts the occurrences of a specific character in a string using a loop.

- `CountCharacterUsingLinq()`: Uses LINQ to count the occurrences of a specific character in a string.

### 3. Hamming Distance

- `CountMatchedCharacters()`: Calculates the Hamming distance between two strings of the same length.

### 4. Count Words

- `CountWords()`: Counts the number of words in a string, removing extra spaces and using regular expressions.

### 5. Count Numbers in a String

- `CountNumbersInString()`: Uses regular expressions to count the number of numeric digits in a string.

## Execution

To test the functions, create an instance of the `Program` class and call each function from the `Main()` method.

```csharp
static void Main()
{
    Program program = new Program();

    program.InvertString();
    program.InvertStringUsingArray();
    program.CountCharacter();
    program.CountCharacterUsingLinq();
    program.CountMatchedCharacters();
    program.CountNumbersInString();
    program.CountWords();
}
