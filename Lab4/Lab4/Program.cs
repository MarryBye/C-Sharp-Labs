using Lab4;
using static System.Net.Mime.MediaTypeNames;

Fraction test1 = new Fraction(1, 3, 80, 24);
Fraction test2 = new Fraction(-1, 0, 115, 12);

test1.Cancellation();
test2.Cancellation();

Console.WriteLine(test1.ToString());
Console.WriteLine(test2.ToString());

Fraction test3_sum = test1.GetSum(test2);
Fraction test4_diff = test1.GetDiff(test2);
Fraction test5_mult = test1.GetMult(test2);
Fraction test6_quot = test1.GetQuot(test2);

Console.WriteLine("Сумма: " + test3_sum.ToString());
Console.WriteLine("Разность: " + test4_diff.ToString());
Console.WriteLine("Произведение: " + test5_mult.ToString());
Console.WriteLine("Частное: " + test6_quot.ToString());


Fraction test7_dbl = new Fraction(1, 0, 0, 1);
test7_dbl.SetByDouble(-1, 2.34);

Console.WriteLine("Из Double: " + test7_dbl.ToString());
Console.WriteLine("В Double: " + test7_dbl.ToDouble());