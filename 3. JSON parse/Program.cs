using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.JSON_parse
{
    class Student
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public List<string> Grades { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var studentsInfo = new List<Student>();
            var input = Console.ReadLine().Remove(0, 1).Split(new[] { "{name" }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var item in input)
            {
                var info = item.Replace("name", "").Replace("age", "").Replace("grades", "").Split(new[] { '[', '{', ':', ']', '}', '"', ',' }, StringSplitOptions.RemoveEmptyEntries);
                var name = info[0];
                var age = int.Parse(info[1]);
                var grades = info.Skip(2).ToList();

                var student = new Student
                {
                    Name = name,
                    Age = age,
                    Grades = grades
                };
                studentsInfo.Add(student);
            }
            foreach (var student in studentsInfo)
            {
                if (student.Grades.Count < 1)
                {
                    student.Grades.Add("None");
                }
                Console.WriteLine($"{student.Name} : {student.Age} -> {string.Join(",", student.Grades)}");
            }
        }
    }
}
