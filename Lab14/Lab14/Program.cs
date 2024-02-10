using Lab14;
using System.Diagnostics;
using System.Reflection;
using System.Xml.Linq;

TV tv1 = new TV(78655, 2, "APPLE", "15PMP12R", Resolution.QHD, EnergyClass.APP);
TV tv2 = new TV(10000, 15, "SAMSUNG", "T3485M", Resolution.HD, EnergyClass.A);
TV tv3 = new TV(50000, 9999, "XIAOMI", "XMI87RT5", Resolution.QHD, EnergyClass.APP);

Washer washer = new Washer(15000, 3, "SAMSUNG", "W13RX45", 7200, 15, 50, EnergyClass.APP);
Teapot teapot = new Teapot(3000, 15, "Magio", "MG45R67Y", 10, EnergyClass.APP);

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

Console.WriteLine("Стиральная машина");
Console.WriteLine(washer.getDescription());
Console.WriteLine(washer.isAvailable(5));
Console.WriteLine(washer.canBuyAmount(150000));
Console.WriteLine(washer.canBuyAmount(150000, 35));
Console.WriteLine(washer.ToString());

Console.WriteLine("Чайник");
Console.WriteLine(teapot.getDescription());
Console.WriteLine(teapot.isAvailable(5));
Console.WriteLine(teapot.canBuyAmount(150000));
Console.WriteLine(teapot.canBuyAmount(150000, 35));
Console.WriteLine(teapot.ToString());