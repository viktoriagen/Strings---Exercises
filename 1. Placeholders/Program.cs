using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Placeholders
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            while (text != "end")
            {
                var textParts = text.Split(new[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
                var placeHolders = textParts[1].Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string output = textParts[0];

                for (int i = 0; i < placeHolders.Length; i++)
                {
                    output = output.Replace("{" + i + "}", placeHolders[i]);
                }
                Console.WriteLine(output);
                
                text = Console.ReadLine();
            }
        }
    }
}
