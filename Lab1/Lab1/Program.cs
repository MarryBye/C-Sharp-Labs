// Задана строка, состоящая из символов. Символы объединяются в слова.
//     Слова друг от друга отделяются одним или несколькими пробелами. В конце
// текста ставится точка. Текст содержит не более 255 символов. Выполнить
//     ввод строки и обработку строки в соответствии со своим вариантом.

// Ввести строки str1 и str2 с клавиатуры. Найти первую подстроку str2 в
//     строке str1. Вывести на экран индекс начала подстроки. Если строка не
//     найдена – вывести -1.

// Напечатать все слова-палиндромы, которые есть в этой строке(см
// 1 вариант).

namespace FirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ввод строк для поиска второй в первой...");
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();
            
            int start_index = str1.IndexOf(str2);
            
            Console.WriteLine($"Первый индекс вхождения: {start_index}");
            
            Console.WriteLine("Введите строку до 255 символов!");
            string str = Console.ReadLine();
            while (str.Length > 255)
            {
                Console.WriteLine($"Слишком длинный текст ({str.Length} / 255)!");
                str = Console.ReadLine();
            }

            string[] words = str.Split(' ');
            foreach (string word in words)
            {
                char[] wordArray = word.ToCharArray();
                Array.Reverse(wordArray);
                string wordReversed = new string(wordArray);

                if (wordReversed == word) Console.WriteLine($"Палиндром: {word}");
            }
        }
    }
}