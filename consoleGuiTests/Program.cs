using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleGuiTests
{
    class Program
    {
        static void Main(string[] args)
        {

            void pwc(string text, ConsoleColor color)
            {
                Console.BackgroundColor = color;
                Console.WriteLine(text);
                Console.ResetColor();
            }

            int pointer = 0;
            List<String> objects = new List<String> { "obj1:0", "obj2:0", "obj3:0", "obj4:0", "obj5:0" };
            for (; ; )
            {
                for (int i = 0; i < objects.Count(); i++)
                {
                    if (i == pointer)
                    {
                        pwc(objects[i], ConsoleColor.Red);
                    }
                    else
                    {
                        pwc(objects[i], ConsoleColor.Black);
                    }

                }

                var w = Console.ReadKey();
                if(w.Key.ToString() == "UpArrow")
                {
                    if(pointer != 0)
                    {
                        pointer--;
                    }

                }
                else if(w.Key.ToString() == "DownArrow")
                {
                    if(!(pointer >= objects.Count() - 1))
                    {
                        pointer++;
                    }

                }
                else if (w.Key.ToString() == "RightArrow")
                {
                    string s = objects[pointer];
                    string[] spl = s.Split(':');
                    Console.WriteLine(spl[1]);
                    if (spl[1] == "0")
                    {
                        spl[1] = "1";
                    }
                    else if (spl[1] == "1")
                    {
                        spl[1] = "0";
                    }
                    string final = string.Join(":", spl);
                    objects[pointer] = final;

                }
                Console.Clear();
            }
        }
    }
}
