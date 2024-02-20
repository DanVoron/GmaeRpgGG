using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GmaeRpgGG
{
    internal class Boevka
    {
        int Enemy;
        int Vibor;
        Human[] Characters = {new Human ("Dan",10,2), new Berserk("Guts", 6, 3),
        new URMOM("Saturn", 300, 0)};
        public void ChooseHero()
        {
            Console.WriteLine("Выберите героя");
            Console.WriteLine("1.Человек");
            Console.WriteLine("2.Берсерк");
            Console.WriteLine("3.URMOM");
            int input;
            try
            {
                input = int.Parse(Console.ReadKey().KeyChar.ToString());
                Console.WriteLine();
                switch (input)
                {
                    case 1:
                        Console.WriteLine("Выбран человек" + " Dan\n");
                        Vibor = 0;
                        ChooseEnemy();
                        break;
                    case 2:
                        Console.WriteLine("Выбран берсерк" + " Guts\n");
                        Vibor = 1;
                        ChooseEnemy();
                        break;
                    case 3:
                        Console.WriteLine("Выбран URMOM" + " Saturn\n");
                        Vibor = 2;
                        ChooseEnemy();
                        break;
                    default:
                        Console.WriteLine("Неправильная кнопка долб\n");
                        break;
                }
            }
            catch
            {
                Console.WriteLine("Err");
                ChooseHero();
            }
        }

        public void ChooseEnemy()
        {
            Console.WriteLine("Выберите врага");
            Console.WriteLine("1.Человек");
            Console.WriteLine("2.Берсерк");
            Console.WriteLine("3.URMOM");
            Console.WriteLine("4.Рандом");
            int input1;
            try
            {
                input1 = int.Parse(Console.ReadKey().KeyChar.ToString());
                Console.WriteLine();
                switch (input1)
                {
                    case 1:
                        Console.WriteLine("Выбран человек" + " Dan\n");
                        Enemy = 0;
                        Start();
                        break;
                    case 2:
                        Console.WriteLine("Выбран берсерк" + " Guts\n");
                        Enemy = 1;
                        Start();
                        break;
                    case 3:
                        Console.WriteLine("Выбран URMOM" + " Saturn\n");
                        Enemy = 2;
                        Start();
                        break;
                    case 4:
                        Console.WriteLine("Выбран рандомный герой");
                        do
                        {
                            Random rnd = new Random();
                            Enemy = rnd.Next(0, Characters.Length);
                        } while (Enemy == Vibor);
                        Start();
                        break;
                    default:
                        Console.WriteLine("Неправильная кнопка долб\n");
                        break;
                }
            }
            catch
            {
                Console.WriteLine("Err");
                ChooseEnemy();
            }
        }

        public void Start()
        {
            Console.WriteLine("Q-Аттака Героя \nE-Аттака Монстра \nF-Бафф героя на 10 урона\n");
            Characters[Vibor].GetInfo();
            Characters[Enemy].GetInfo();
            while (Characters[Vibor].GetHp() > 0 || Characters[Enemy].GetHp() > 0)
            {
                var InsertKey = Console.ReadKey().Key;
                Console.WriteLine("\n");

                switch (InsertKey)
                {
                    case ConsoleKey.Q:
                        Characters[Vibor].Attack(Characters[Enemy]);
                        break;
                    case ConsoleKey.E:
                        Characters[Enemy].Attack(Characters[Vibor]);
                        break;
                    case ConsoleKey.F:
                        Characters[Vibor].BAFF(10);
                        break;
                    default:
                        Console.WriteLine("IDI NAHHUI");
                        break;
                }
                Characters[Vibor].GetInfo();
                Characters[Enemy].GetInfo();
            }

                Console.WriteLine("\n КОНЕЦ ИГРЫ\n");
                System.Threading.Thread.Sleep(2000);
               
        }
    }
}
