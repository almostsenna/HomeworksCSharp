using System;
using System.Text;

class Program
{
    static string alphabet = "АБВГҐДЕЄЖЗИІЇЙКЛМНОПРСТУФХЦЧШЩЬЮЯ" +
                             "абвгґдеєжзиіїйклмнопрстуфхцчшщьюя";

    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        Console.Write("Введіть рядок для шифрування: ");
        string input = Console.ReadLine();

        Console.Write("Введіть зсув (наприклад, 3): ");
        int shift = int.Parse(Console.ReadLine());

        string encrypted = CaesarEncrypt(input, shift);
        string decrypted = CaesarDecrypt(encrypted, shift);

        Console.WriteLine($"\nЗашифрований текст: {encrypted}");
        Console.WriteLine($"Розшифрований текст: {decrypted}");
    }

    static string CaesarEncrypt(string text, int shift)
    {
        StringBuilder result = new StringBuilder();

        foreach (char c in text)
        {
            int index = alphabet.IndexOf(c);
            if (index == -1)
            {
                result.Append(c);
            }
            else
            {
                int newIndex = (index + shift) % alphabet.Length;
                result.Append(alphabet[newIndex]);
            }
        }

        return result.ToString();
    }

    static string CaesarDecrypt(string text, int shift)
    {
        StringBuilder result = new StringBuilder();

        foreach (char c in text)
        {
            int index = alphabet.IndexOf(c);
            if (index == -1)
            {
                result.Append(c);
            }
            else
            {
                int newIndex = (index - shift + alphabet.Length) % alphabet.Length;
                result.Append(alphabet[newIndex]);
            }
        }

        return result.ToString();
    }
}
