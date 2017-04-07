using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Capitalize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            while (input != "end")
            {
                var words = input.ToLower().Split(new[] { ',', ' ', '.', '!', '?', ':', ';', '-' }, StringSplitOptions.RemoveEmptyEntries).ToList();

                for (int i = 0; i < words.Count; i++)
                {
                    words[i] = FirstCharToUpper(words[i]);
                }
                Console.WriteLine(string.Join(", ", words));

                input = Console.ReadLine();

            }
        }

        private static string FirstCharToUpper(string word)
        {
            return word.First().ToString().ToUpper() + word.Substring(1);
        }
    }
}
