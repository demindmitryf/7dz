using System;

class Program
{
    static string ReverseString(string s)
    {
        char[] letters = s.ToCharArray();
        Array.Reverse(letters);
        return new string(letters);
    }

    static void Main()
    {
        Console.Write("Введите строку: ");
        string text = Console.ReadLine();

        Console.WriteLine("Строка в обратном порядке: " + ReverseString(text));
    }
}