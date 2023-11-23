using System.Diagnostics.Metrics;
using DisciplineClass;
using TamagociClass;

Discipline Disc1 = new Discipline();
Disc1.nameDisc = "Информатика";
Disc1.countLek = 9;
Disc1.countLR = 9;
Disc1.countSR = 18;

Console.WriteLine("Общее число часов, отводимое надисциплину " + Disc1.nameDisc + " равно " + Disc1.Sum());

Discipline Disc2 = new Discipline("Программирование", 36, 18, 18);
Console.WriteLine("Общее число часов, отводимое надисциплину " + Disc2.nameDisc + " равно " + Disc2.Sum());

Discipline Disc3 = new Discipline { nameDisc = "Математика", countLek = 18, countLR = 36, countSR = 36};
Console.WriteLine("Общее число часов, отводимое на дисциплину " + Disc3.nameDisc + " равно " + Disc3.Sum());
Console.WriteLine();
Console.WriteLine("Общее число учебных часов в семестре равно " + (Disc1.Sum() + Disc2.Sum() + Disc3.Sum()));

Discipline[] Disc = new Discipline[5];
Disc[3].countLR = 18;

Tamagoci tama = new Tamagoci("Oleg");
Tamagoci tama2 = new Tamagoci("Vanya");