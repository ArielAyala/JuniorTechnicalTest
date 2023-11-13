using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        // Crear una instancia de la clase Program
        Program program = new Program();

        
        program.CountNumbersInString();
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


    /// <summary>
    /// Calculates the Hamming distance between two strings.
    /// </summary>
    /// <remarks>
    /// The Hamming distance is the number of positions at which corresponding symbols
    /// are different between two equal-length strings.
    /// </remarks>
    private void CountMatchedCharacters()
    {
        string text1 = "example1";
        string text2 = "example2";

        if (text1.Length != text2.Length)
            throw new Exception("Different lengths");

        int distance = 0;
        for (int i = 0; i < text1.Length ; i++)
        {
            if (text1[i] != text2[i])
            {
                distance++;
            }
        }

        Console.WriteLine($"Distance is :{distance}");
    }

    /// <summary>
    /// Counts the number of words in a given text.
    /// </summary>
    private void CountWords()
    {
        string text = "   Lorem Ipsum is simply dummy text   of the printing and      typesetting industry        ";
        int count = 0;

        text = Regex.Replace(text, @"\s+", " ").Trim();
        var words = text.Split(' ');
        count = words.Length;

        Console.WriteLine($"The number of words is: {count}");
    }

    /// <summary>
    /// Counts the number of numeric digits in a given string.
    /// </summary>
    private void CountNumbersInString()
    {
        string text = "12lorem6";
        string pattern = @"[0-9]";

        var regex = new Regex(pattern);
        int number = regex.Matches(text).Count();
        Console.WriteLine($"Numbers : {number}");
    }
}
