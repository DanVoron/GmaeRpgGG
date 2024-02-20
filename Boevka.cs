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
        int Hero;
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
                        Hero = 0;
                        ChooseEnemy();
                        break;
                    case 2:
                        Console.WriteLine("Выбран берсерк" + " Guts\n");
                        Hero = 1;
                        ChooseEnemy();
                        break;
                    case 3:
                        Console.WriteLine("Выбран URMOM" + " Saturn\n");
                        Hero = 2;
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
            Human[] Characters = { new Human("Dan", 10, 2), new Berserk("Guts", 6, 3), new URMOM("Saturn", 300, 0) };
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
                        } while (Enemy == Hero);
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
            Human[] Characters = { new Human("Dan", 10, 2), new Berserk("Guts", 6, 3), new URMOM("Saturn", 300, 0) };
            Console.WriteLine("Q-Аттака Героя \nE-Аттака Монстра \nF-Бафф героя на 10 урона\n");
            Characters[Hero].GetInfo();
            Console.WriteLine();
            Characters[Enemy].GetInfo();

            bool alive = true;
            while (alive)
            {
                var InsertKey = Console.ReadKey().Key;
                Console.WriteLine("\n");

                switch (InsertKey)
                {
                    case ConsoleKey.Q:
                        Characters[Hero].Attack(Characters[Enemy]);
                        break;
                    case ConsoleKey.E:
                        Characters[Enemy].Attack(Characters[Hero]);
                        break;
                    case ConsoleKey.F:
                        Characters[Hero].BAFF(10);
                        break;
                    default:
                        Console.WriteLine("IDI NAHHUI");
                        break;
                }
                Characters[Hero].GetInfo();
                Console.WriteLine();
                Characters[Enemy].GetInfo();

                if(Characters[Hero].GetHp() < 0 || Characters[Enemy].GetHp() < 0)
                {
                    alive = false;
                }
            }

                Console.WriteLine("\n КОНЕЦ ИГРЫ\n");
                System.Threading.Thread.Sleep(2000);
               
        }
    }
}
