using System;

class Program
{
    static void Main()
    {
        // Crear una instancia de la clase Program
        Program program = new Program();

        
        program.InvertString();
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
}
