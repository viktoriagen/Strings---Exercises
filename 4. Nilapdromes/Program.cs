using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Nilapdromes
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Trim().ToLower();
            while (input != "end")
            {

                var border = "";
                for (int i = 0; i < input.Length; i++)
                {
                    
                    if (input.Substring(i).Contains(border))
                    {
                        border += input[i];
                    }
                    else
                    {
                        border = border.Substring(0, border.Length - 1);
                        break;
                    }
                }
                if (border.Length > 0)
                {
                    string borderCheck = input.Substring((input.Length - border.Length));

                    if (border == borderCheck)
                    {
                        if (input != border + border)
                        {
                            var core = input.Replace(border, "");

                                Console.WriteLine(core + border + core);

                            
                        }

                    }
                }

                input = Console.ReadLine();
            }
        }
    }
}
