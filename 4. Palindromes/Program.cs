using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine().Split(new[] { ',', '.', '?', '!', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var polindromes = new SortedSet<string>();

            foreach (var word in text)
            {
                var reverseWord = String.Empty;
                for (int i = word.Length - 1; i >= 0; i--)
                {
                    reverseWord += word[i];
                }
                if (reverseWord == word)
                {
                    polindromes.Add(word);
                }
            }
            Console.WriteLine(string.Join(", ", polindromes.OrderBy(x => x)));
        }
    }
}
