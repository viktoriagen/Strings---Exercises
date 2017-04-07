using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Serialize_String
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var result = new HashSet<string>();

            for (int i = 0; i < input.Length; i++)
            {
                var index = -1;
                var letter = input[i];
                var stringResult = letter + ":";

                while (true)
                {

                    index = input.IndexOf(letter, index + 1);
                    if (index < 0)
                    {
                        break;
                    }
                    stringResult += index + "/";
                }
                stringResult = stringResult.TrimEnd('/');
                result.Add(stringResult);

            }
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
