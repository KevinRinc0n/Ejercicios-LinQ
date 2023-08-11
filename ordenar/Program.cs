using System;

class Program
{
    static void Main(string[] args)
    {
        List<Student> studentList = new List<Student>()
        {
            new Student() { id = 1, name = "John", age = 18 },
            new Student() { id = 2, name = "Steve",  age = 15 },
            new Student() { id = 3, name = "Bill",  age = 25 },
            new Student() { id = 4, name = "Ram", age = 20 },
            new Student() { id = 5, name = "Ron", age = 19 }
        };

        var filterResult = studentList.Where((s, i) => {
            if (s.age % 2 == 0)
                return true;
            return false;
        });

        foreach (var student in filterResult)
        {
            Console.WriteLine(student.name);
        }

        var orderByResult = from s in studentList
                            orderby s.name
                            select s;

        var orderByDescendingResult = from s in studentList
                                      orderby s.name descending
                                      select s;

        var orderByMultipleFieldsResult = from s in studentList
                                         orderby s.name, s.age
                                         select new { s.name, s.age };

        foreach (var student in orderByMultipleFieldsResult)
        {
            Console.WriteLine($"name: {student.name}, age: {student.age}");
        }

        var groupResult = from s in studentList
                          group s by s.age;

        foreach (var ageGroup in groupResult)
        {
            Console.WriteLine($"Age group: {ageGroup.Key}");

            foreach (var student in ageGroup)
            {
                Console.WriteLine($"Name student: {student.name}");
            }
        }
    }
}