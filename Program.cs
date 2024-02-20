using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace GmaeRpgGG
{
    internal class Program
    {

        static void Main(string[] args)
        {
            mainmenu();
        }

        public static void mainmenu()
        {
            Boevka gg = new Boevka();
            while(true) 
            {
                Console.Clear();
                Console.WriteLine("Выберите опцию");
                Console.WriteLine("1.Начать бой");
                Console.WriteLine("2.Выйти");
                try
                {
                    int input = int.Parse(Console.ReadKey().KeyChar.ToString());
                    Console.WriteLine();
                    switch (input)
                    {
                        case 1:
                            Console.WriteLine("Нажата 1, загрузка\n");
                            System.Threading.Thread.Sleep(150);
                            gg.ChooseHero();
                            break;
                        case 2:
                            Console.WriteLine("Нажата 2, пока");
                            System.Threading.Thread.Sleep(150);
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Неправильная кнопка долб");
                            break;
                    }
                }
                catch
                {
                    mainmenu();
                }
            }
        }
    }
}
