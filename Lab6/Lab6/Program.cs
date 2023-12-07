using Lab6;

while (true)
{
    try
    {
        Console.WriteLine("Число 1: ");
        string x1 = Console.ReadLine();

        Console.WriteLine("Число 2: ");
        string x2 = Console.ReadLine();

        Console.WriteLine("Система 1 числа: ");
        int s1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Система 2 числа: ");
        int s2 = Convert.ToInt32(Console.ReadLine());

        DigitsTransformer digit1 = new DigitsTransformer(x1, s1);
        DigitsTransformer digit2 = new DigitsTransformer(x2, s2);

        if (digit1.MakeNormal() == digit2.MakeNormal())
        {
            Console.WriteLine($"TRUE | {digit1.Digit()}, {digit2.Digit()}");
        }
        else
        {
            Console.WriteLine($"FALSE | {digit1.Digit()}, {digit2.Digit()}");
        }

    } catch { Console.WriteLine("Случилась ошибка! Введите корректные данные!"); }
}