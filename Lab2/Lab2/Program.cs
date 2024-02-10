using Lab2;

// 1
Point pnt1 = new Point((3, 6));
Point pnt2 = new Point();
Point pnt3 = new Point((15, 3));

Console.WriteLine($"pnt1 Distance: {pnt1.GetDistance()}");
Console.WriteLine($"pnt2 Distance: {pnt2.GetDistance()}");
Console.WriteLine($"pnt3 Distance: {pnt3.GetDistance()}");

Console.WriteLine(pnt1.ToString());
Console.WriteLine(pnt2.ToString());
Console.WriteLine(pnt3.ToString());

// 2

Triangle trn1 = new Triangle((2, 5, 3));
Triangle trn2 = new Triangle((15, 17, 8));

Console.WriteLine($"trn1 Perimeter: {trn1.Perimeter()}");
Console.WriteLine($"trn1 Area: {trn1.Area()}");

Console.WriteLine($"trn2 Perimeter: {trn2.Perimeter()}");
Console.WriteLine($"trn2 Area: {trn2.Area()}");

Console.WriteLine(trn1.ToString());
Console.WriteLine(trn2.ToString());

// 3

Money wlt1 = new Money(10, 500);
Money wlt2 = new Money(10, 200);
Money wlt3 = new Money(10, 100);

Console.WriteLine(wlt1.ToString());
Console.WriteLine(wlt2.ToString());
Console.WriteLine(wlt3.ToString());

Console.WriteLine(wlt1.can_buy(100));
Console.WriteLine(wlt2.can_buy(500));
Console.WriteLine(wlt3.can_buy(1001));

Console.WriteLine(wlt1.max_can_buy(("Молоко", 38)));
Console.WriteLine(wlt2.max_can_buy(("Бургер", 140)));
Console.WriteLine(wlt3.max_can_buy(("Айфон 15 про макс ультра ноут едж дефинитив єдишн гейм", 999999)));

// 4

OneDDigits smart_array = new OneDDigits(10);
smart_array.input_elements();

Console.WriteLine(smart_array.ToString());
smart_array.sort();
Console.WriteLine(smart_array.ToString());