// Во входном файле input.txt содержится текст. В файл output.txt вывести
// отредактированный текст, в котором удалены лишние пробелы между словами.

// Создать программным образом файл input.txt и заполнить его 40 целыми
// числами, полученными с помощью генератора случайных чисел из диапазона [0, 100].
// Написать программу, выводящую на экран и в файл output.txt только те элементы
// файла input.txt, в записи которых есть заданная цифра (вводится с клавиатуры).

// Написать программу, которая выводит на экран список файлов MS Word,
// содержащихся в заданном каталоге.

// 1

string content1 = File.ReadAllText("input1.txt");
string new_content1 = "";

char[] chars = content1.ToCharArray();
char last_symbol = chars[0];

for (int i = 0; i < chars.Length; i++)
{
    if (chars[i] == ' ' && last_symbol == ' ')
    {
        continue;
    }
    last_symbol = chars[i];
    new_content1 += chars[i];
}

File.WriteAllText("output1.txt", new_content1);

// 2

string content2 = "";
var randomiser = new Random();

for (int i = 0; i < 40; i++)
{
    content2 += randomiser.NextInt64() % 100;
    content2 += " ";
}

File.WriteAllText("input2.txt", content2);

// Читать не буду, и так текст уже записан

Console.WriteLine("Какой символ ищем?");
string symbol = Console.ReadLine();

foreach (string number in content2.Split(" ")) {
    if (number.Contains(symbol)) {
        Console.WriteLine($"Число {number} из файла содержит {symbol}");
    }
}

// 3

string[] files = Directory.GetFiles("./");

foreach (string filename in files)
{
    if (filename.Contains(".docx"))
    {
        Console.WriteLine($"{filename}");
    }
}