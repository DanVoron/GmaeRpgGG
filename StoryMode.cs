using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GmaeRpgGG
{
    public class StoryMode
    {
       
        
        public void StoryStart(int progress)
        {
            bool tr = true;
            while (tr)
            {
                Boevka gg = new Boevka();
                int proid = progress;

                if (proid == 0)
                {
                    Console.Clear();
                    Console.WriteLine("ПЕРЕД ВАМИ ОГРОМНЫЙ ХОЛМ ваши действия");
                    Console.WriteLine("1.Напасть на него\n2.Пойти другим путем");
                    try
                    {
                        int input = int.Parse(Console.ReadKey().KeyChar.ToString());
                        Console.WriteLine();
                        switch (input)
                        {
                            case 1: gg.Enemy = 2; gg.Hero = 0; proid++; gg.StartStory(proid); break;
                            case 2: Console.WriteLine("Пойдем отсюда"); proid++; break;
                        }
                    }
                    catch
                    {
                        Console.WriteLine("ААА ИГРА СЛОМАЛАСЬ");
                    }
                }
                else if (proid == 1)
                {
                    Console.Clear();
                    Console.WriteLine("ПЕРЕД ВАМИ ПАРЕНЬ С ОГРОМНЫМ МЕЧОМ");
                    Console.WriteLine("1.Напасть на него\n2.Пойти другим путем");
                    try
                    {
                        int input = int.Parse(Console.ReadKey().KeyChar.ToString());
                        Console.WriteLine();
                        switch (input)
                        {
                            case 1: gg.Enemy = 1; gg.Hero = 0; proid++; gg.StartStory(proid); break;
                            case 2: Console.WriteLine("Пойдем отсюда"); proid++; break;
                        }
                    }
                    catch
                    {
                        Console.WriteLine("ААА ИГРА СЛОМАЛАСЬ");
                    }
                }
                else if (proid == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Победа, ИДИ НАХУЙ ПИДОРАС");
                    System.Threading.Thread.Sleep(1000);
                    tr = false;
                    Program program = new Program();
                    program.mainmenu();
                }
            }

        }
    }
}
