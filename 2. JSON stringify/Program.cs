using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.JSON_stringify
{
    class Student
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public List<int> Grades { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var studentsInfo = new List<Student>();
            var input = Console.ReadLine();

            while (input != "stringify")
            {
                var inputParams = input.Split(new[] { ' ', ',', '-', '>', ':' }, StringSplitOptions.RemoveEmptyEntries);
                var name = inputParams[0];
                var age = inputParams[1];
                List<int> grades = inputParams.Skip(2).Select(int.Parse).ToList();

                var strudent = new Student
                {
                    Name = name,
                    Age = int.Parse(age),
                    Grades = grades
                };
                studentsInfo.Add(strudent);
                input = Console.ReadLine();
            }
            Console.WriteLine
                (
                "[" +
                string.Join(",", studentsInfo.Select(x => $"{{name:\"{x.Name}\",age:{x.Age},grades:[{string.Join(", ", x.Grades)}]}}")) +
                "]"
                );
     
        }
    }
}
