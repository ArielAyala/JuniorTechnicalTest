using System;

class Program
{
    static void Main()
    {
        // Crear una instancia de la clase Program
        Program program = new Program();

        
        program.CountCharacterUsingLinq();
    }

    /// <summary>
    /// It reverses a given string and prints it to the console.
    /// </summary>
    private void InvertString()
    {
        string text = "example";
        string textResult = "";

        for (int i = text.Length - 1; i >= 0; i--)
        {
            textResult += text[i];
        }

        Console.WriteLine(textResult);
    }

    /// <summary>
    /// It reverses a given string and prints it to the console using array.
    /// </summary>
    private void InvertStringUsingArray()
    {
        string text = "example";
        string textResult = "";

        char[] chars = text.ToCharArray();
        Array.Reverse(chars);
        textResult = new String(chars); 

        Console.WriteLine(textResult);
    }

    /// <summary>
    /// Counts the occurrences of a specific character in a given string.
    /// </summary>
    /// <remarks>
    /// This method iterates through each character in the input string and counts
    /// how many times the specified character appears.
    /// </remarks>
    private void CountCharacter()
    {
        string text = "asdkkfdkcnjdiqyewrqotinkbzncbnvbm";
        char character = 'n';
        int counter = 0;
        foreach (var c in text)
        {
            if (c == character)
                counter++;
        }

        Console.WriteLine($"character: {character} is {counter} times");
    }

    /// <summary>
    /// Counts the occurrences of a specific character in a given string using LINQ.
    /// </summary>
    /// <remarks>
    /// This method leverages LINQ (Language Integrated Query) to count the number of times
    /// the specified character appears in the provided string.
    /// </remarks>
    private void CountCharacterUsingLinq()
    {
        string text = "asdkkfdkcnjdiqyewrqotinkbzncbnvbm";
        char character = 'n';
        int count = text.Where(x => x == character).Count();
        Console.WriteLine($"character: {character} is {count} times");
    }
}
