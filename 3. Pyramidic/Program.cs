﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Pyramidic
{
    class Program
    {
        static void Main(string[] args)
        {
            var pyramids = new List<string>();

            int n = int.Parse(Console.ReadLine());
            var lines = new string[n];

            for (int i = 0; i < n; i++)
            {
                lines[i] = Console.ReadLine();
            }
            for (int i = 0; i < lines.Length; i++)
            {
                var currentLine = lines[i];

                for (int j = 0; j < currentLine.Length; j++)
                {
                    var currentChar = currentLine[j];
                    int layer = 1;
                    var currentPyramid = "";

                    for (int k = i; k < lines.Length; k++)
                    {
                        var currentLayer = new string(currentChar, layer);

                        if (lines[k].Contains(currentLayer))
                        {
                            currentPyramid += currentLayer + "\r\n";
                        }
                        else
                        {
                            break;
                        }
                        layer += 2;
                    }
                    pyramids.Add(currentPyramid.Trim());
                }
            }
            Console.WriteLine(pyramids.OrderByDescending(x => x.Length).First());
        }
    }
}
