using Lab13;
using System.Diagnostics;
using System.Reflection;
using System.Xml.Linq;

TV tv1 = new TV(78655, 2, Units.PACKAGE, "APPLE", "15PMP12R", Resolution.QHD, EnergyClass.APP);
TV tv2 = new TV(10000, 15, Units.PACKAGE, "SAMSUNG", "T3485M", Resolution.HD, EnergyClass.A);
TV tv3 = new TV(50000, 9999, Units.PACKAGE, "XIAOMI", "XMI87RT5", Resolution.QHD, EnergyClass.APP);

Console.WriteLine("Первый телевизор");
Console.WriteLine(tv1.getDescription());
Console.WriteLine(tv1.isAvailable(5));
Console.WriteLine(tv1.canBuyAmount(150000));
Console.WriteLine(tv1.canBuyAmount(150000, 35));

Console.WriteLine("Второй телевизор");
Console.WriteLine(tv2.getDescription());
Console.WriteLine(tv2.isAvailable(5));
Console.WriteLine(tv2.canBuyAmount(150000));
Console.WriteLine(tv2.canBuyAmount(150000, 35));

Console.WriteLine("Третий телевизор");
Console.WriteLine(tv3.getDescription());
Console.WriteLine(tv3.isAvailable(5));
Console.WriteLine(tv3.canBuyAmount(150000));
Console.WriteLine(tv3.canBuyAmount(150000, 35));