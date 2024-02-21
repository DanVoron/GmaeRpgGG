using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace GmaeRpgGG
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Program gey = new Program();
            gey.mainmenu();
        }

        public void mainmenu()
        {
            StoryMode gl = new StoryMode();
            Boevka gg = new Boevka();
            while(true) 
            {
                Console.Clear();
                Console.WriteLine("Выберите опцию");
                Console.WriteLine("1.Начать бой");
                Console.WriteLine("2.Сюжетный режим");
                Console.WriteLine("3.Выход");
                try
                {
                    int input = int.Parse(Console.ReadKey().KeyChar.ToString());
                    Console.WriteLine();
                    switch (input)
                    {
                        case 1:
                            gg.ChooseHero();
                            break;
                        case 2:
                            gl.StoryStart(0);
                            break;
                        case 3:
                            Console.WriteLine("\n\n\n\n\namogus");
                            System.Threading.Thread.Sleep(1000);
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
