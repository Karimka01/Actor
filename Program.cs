using System;

namespace _08._06._21
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero archer = new Hero();
            Console.WriteLine("Сила персонажа: ");
            archer.strenght = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Дальность лука: ");
            archer.RangeDamage = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Крит лука: ");
            archer.CritChance = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("      Персонаж");
            Console.WriteLine("Имя: "+archer.name);
            Console.WriteLine("Описание: " + archer.description);
            Console.WriteLine("Класс: " + archer.heroClass);
            Console.WriteLine("Сила атаки: " + archer.strenght);
            Console.WriteLine("        Лук");
            Console.WriteLine("Дальность атаки: " + archer.RangeDamage);
            Console.WriteLine("Шанс крит удара: " + archer.CritChance);

            bool flag = true;
            string value = " ";
            while (flag)
            {
                Console.WriteLine("Выберите действие(Jump,Run,Stand,Swim):");
                string name = Console.ReadLine();
                value = name;
                switch (value)
                {
                    case "Jump":
                        Console.WriteLine(archer.Jump());
                        break;
                    case "Run":
                        Console.WriteLine(archer.Run());
                        break;
                    case "Stand":
                        Console.WriteLine(archer.Stand());
                        break;
                    case "Swim":
                        Console.WriteLine(archer.Swim());
                        break;
                }
            }
        }
    }
}

