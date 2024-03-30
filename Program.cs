using System;
using System.Collections.Generic;
using System.Linq;

public class Student
{
    public int NumberSchool { get; set; }
    public int Year { get; set; }
    public string Surname { get; set; }
}

public class Program
{
    public static void Main()
    {
        List<Student> students = new List<Student>
        {
            new Student { NumberSchool = 12, Year = 2016, Surname = "Иванов" },
            new Student { NumberSchool = 12, Year = 2017, Surname = "Петров" },
            new Student { NumberSchool = 40, Year = 2016, Surname = "Колыбаев" },
            new Student { NumberSchool = 40, Year = 2017, Surname = "Морлова" },
            new Student { NumberSchool = 4, Year = 2017, Surname = "Иванова" },
            new Student { NumberSchool = 4, Year = 2016, Surname = "Левченко" },
            new Student { NumberSchool = 24, Year = 2016, Surname = "Касимиха" },
            new Student { NumberSchool = 74, Year = 2018, Surname = "Леонов" },
            new Student { NumberSchool = 74, Year = 2018, Surname = "Клишена" },
            new Student { NumberSchool = 12, Year = 2018, Surname = "Лагутенко" },
            new Student { NumberSchool = 12, Year = 2018, Surname = "Ильясов" }
        };

        var yearGroup = students
            .GroupBy(s => s.Year)
            .Select(g => new { Year = g.Key, Count = g.Count() })
            .OrderByDescending(g => g.Count)
            .First();

        Console.WriteLine($"{yearGroup.Year} {yearGroup.Count}");
        
        Console.ReadKey();
    }
}
