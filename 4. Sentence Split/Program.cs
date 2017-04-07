using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Sentence_Split
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputText = Console.ReadLine();
            var delimiter = Console.ReadLine();
            var output = inputText.Split(new[] { delimiter }, StringSplitOptions.None).ToList();

            Console.WriteLine($"[{String.Join(", ", output)}]");
        }
    }
}
