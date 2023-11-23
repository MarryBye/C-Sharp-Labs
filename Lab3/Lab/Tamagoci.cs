using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace TamagociClass
{
    internal class Tamagoci
    {
        private string Name { get; set; }
        private int Health { get; set; }
        private int Satiety { get; set; }
        private int Mood { get; set; }
        private int Hygiene { get; set; }
        private int Money { get; set; }

        public Tamagoci(string name)
        {
            this.Name = name;
            Mood = 100;
            Health = 100;
            Satiety = 100;
            Hygiene = 100;
            Money = 100;

            Life();
        }

        private bool IsAlive()
        {
            return (Mood > 0 && Health > 0 && Satiety > 0 && Hygiene > 0 && Money > 0);
        }

        public void Info()
        {
            Console.WriteLine($"Статистика {Name}:\n" +
                    $"Здоровье: {Health}\n" +
                    $"Сытость: {Satiety}\n" +
                    $"Настроение: {Mood}\n" +
                    $"Гигиена: {Hygiene}\n" +
                    $"Деньги: {Money}\n");
        }

        private void Death()
        {
            Console.WriteLine($"{Name} умер!\n");
        }

        public void Life()
        {
            while (IsAlive())
            {
                Satiety -= 20;
                Health -= 5;
                Mood -= 10;
                Hygiene -= 5;
                Money -= 5;

                Console.WriteLine($"Какое действие должен сделать {Name}?");
                Console.WriteLine("1. Играть");
                Console.WriteLine("2. Спать");
                Console.WriteLine("3. Кушать");
                Console.WriteLine("4. Работать");
                Console.WriteLine("5. Искупаться");

                string action = Console.ReadLine();

                switch (action) {
                    case "1":
                        Play(); break;
                    case "2":
                        Sleep(); break;
                    case "3":
                        Eat(); break;
                    case "4":
                        Work(); break;
                    case "5":
                        Bath(); break;
                    default:
                        Console.WriteLine("Тамагочи ничего не сделал!"); break;
                }

                Info();

            }

            Death();

        }

        public void Play()
        {
            Mood += 15;
            Health += 20;
            Satiety -= 10;
            Hygiene -= 5;
            Money -= 5;

        }

        public void Sleep()
        {
            Health += 10;
            Mood -= 20;
            Satiety -= 10;
            Hygiene -= 5;

        }

        public void Eat()
        {
            Health += 5;
            Satiety += 15;
            Mood -= 10;
            Hygiene -= 5;
            Money -= 5;

        }

        public void Work()
        {
            Health -= 10;
            Satiety -= 10;
            Mood -= 5;
            Hygiene -= 5;
            Money += 20;

        }

        public void Bath()
        {
            Health += 10;
            Satiety -= 10;
            Mood += 10;
            Hygiene += 20;
            Money -= 10;

        }

    }
}
