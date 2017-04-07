using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Stateless
{
    class Program
    {
        static void Main(string[] args)
        {
            var state = Console.ReadLine();
            while (state != "collapse")
            {
                var fiction = Console.ReadLine();

                while (fiction.Length > 0)
                {
                    state = state.Replace(fiction, "");
                    if (fiction.Length == 1)
                    {
                        fiction = fiction.Substring(1, fiction.Length - 1);
                    }
                    else
                    {
                        fiction = fiction.Substring(1, fiction.Length - 2);
                    }
                    
                }
                if (state.Length > 0)
                {
                    Console.WriteLine(state.Trim());
                }
                else
                {
                    Console.WriteLine("(void)");
                }

                state = Console.ReadLine();
            }
        }
    }
}
