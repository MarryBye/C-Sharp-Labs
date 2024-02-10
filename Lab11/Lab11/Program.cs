using Lab11;

Console.WriteLine("Введите номер дня: ");

// В этой проверке для меня нет смысла, я уже в классе добавил деление по модулю, день неважно какой устанавливать,
// все равно будет правильно определять, но для задания добавлю

int day;
int year;

while (true)
{
    try
    {
        try
        {
            day = Convert.ToInt32(Console.ReadLine());
        } catch {
            throw new Exception("Не число!");
        }

        if (day < 1 || day > 365)
        {
            throw new Exception("Слишком большое число для дня!");
        } else 
            break;

    } catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}

while (true)
{
    try
    {
        try
        {
            year = Convert.ToInt32(Console.ReadLine());
            break;
        }
        catch
        {
            throw new Exception("Не число!");
        }

    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}

Day newDay = new Day(day, year);
Console.WriteLine(newDay.GetDate());