using System;
using System.IO;

class Program {
    static void Main()
    {
        Console.WriteLine("Дія:\n1. Шифрування\n2. Дешифрування");
        int option = Convert.ToInt32(Console.ReadLine());
        while (option < 1 || option > 2) {
            Console.WriteLine("Давай ще раз...");
            Console.WriteLine("Дія:\n1. Шифрування\n2. Дешифрування");
            option = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Оберіть метод:\n1.Проста підстановка\n2. Шифр поліалфавітної підстановки\n3. Шифр перестановки\n4. Шифр гамування");
        int method = Convert.ToInt32(Console.ReadLine());
        while (method < 1 || method > 4)
        {
            Console.WriteLine("Давай ще раз...");
            Console.WriteLine("Оберіть метод:\n1.Проста підстановка\n2. Шифр поліалфавітної підстановки\n3. Шифр перестановки\n4. Шифр гамування");
            method = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Введіть текст:");
        string txt = Console.ReadLine();
        string resultText;
        if (method == 1)
        {
            resultText = Method1(txt, option);
        } else if (method == 2)
        {
            resultText = Method2(txt, option);
        } else if (method == 3)
        {
            resultText = Method3(txt, option);
        } else if (method == 4) {
            resultText = Method4(txt, option);
        } else
        {
            resultText = Method1(txt, option);
        }

        Console.WriteLine($"Результат: {resultText}");
        SaveFile(resultText);
        Console.ReadLine();

    }
    static int CheckKey(string buffer)
    {
        int key = 0;
        bool isNumber = int.TryParse(buffer, out key);
        if (!isNumber && buffer.Length == 1)
            key = Convert.ToByte(Convert.ToChar(buffer));
        else if (!isNumber)
            Console.WriteLine("Невірний ключ.");
        return key;
    }

    static string Method1(string text, int direction)
    {
        Console.WriteLine("Введіть ключ (1 символ чи число від 1 до 65534):");
        int key = CheckKey(Console.ReadLine());
        if (key == 0)
            return "";

        char[] result = new char[text.Length];
        for (int i = 0; i < text.Length; i++)
        {
            char currentChar = text[i];
            int shiftedChar = direction == 1 ? (currentChar + key) % 128 : (currentChar - key + 128) % 128;
            result[i] = (char)shiftedChar;
        }

        string r = new string(result);

        return r;
    }

    static string Method2(string text, int direction)
    {
        Console.WriteLine("Введіть ключ (до 256 символів):");
        string key = Console.ReadLine();

        char[] result = new char[text.Length];

        for (int i = 0; i < text.Length; i++)
        {
            char currentChar = text[i];
            int keyChar = key[i % key.Length];
            int shiftedChar = direction == 1 ? (currentChar + keyChar) % 128 : (currentChar - keyChar + 128) % 128;
            result[i] = (char)shiftedChar;
        }

        string r = new string(result);

        return r;
    }

    static string Method3(string text, int direction)
    {
        Console.WriteLine("Введіть ключ (1 символ чи число від 1 до 65534):");
        int key = CheckKey(Console.ReadLine());
        if (key == 0)
            return "";

        char[] result = new char[text.Length];
        for (int i = 0; i < text.Length; i++)
        {
            int index = direction == 1 ? (i + key) % text.Length : (i - key + text.Length) % text.Length;
            result[i] = text[index];
        }

        string r = new string(result);

        return r;
    }

    static string Method4(string text, int direction)
    {
        Console.WriteLine("Введіть ключ (1 символ чи число від 1 до 65534):");
        int key = CheckKey(Console.ReadLine());
        if (key == 0)
            return "";

        char[] result = new char[text.Length];
        for (int i = 0; i < text.Length; i++)
        {
            int gamma = (key * 1103515245 + 12345) % 65536;
            char currentChar = text[i];
            int shiftedChar = direction == 1 ? (currentChar + gamma) % 128 : (currentChar - gamma + 128) % 128;
            result[i] = (char)shiftedChar;
        }

        string r = new string(result);

        return r;
    }

    static void SaveFile(string result)
    {
        File.WriteAllText("text.txt", result);
    }
}