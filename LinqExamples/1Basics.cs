namespace LINQ.LinqExamples;

using LINQ.Models;
public class Basics
{


    public static void QuerySyntax()
    {

        IList<string> stringList = new List<string>() {
            "C# Tutorials",
            "VB.NET Tutorials",
            "Learn C++",
            "MVC Tutorials" ,
            "Java"
        };

        var result = from str in stringList
                     where str.Contains("Tutorials")
                     select str;

        foreach (var item in result)
        {
            Console.WriteLine(item);
        }
    }

    public static void MethodSyntax()
    {

        // Example 1
        IList<string> stringList = new List<string>() {
            "C# Tutorials",
            "VB.NET Tutorials",
            "Learn C++",
            "MVC Tutorials" ,
            "Java"
        };

        IEnumerable<string> result = stringList.Where(str => str.Contains("Tutorials"));
        foreach (var item in result)
        {
            Console.WriteLine(item);
        }

        // Example 2
        // Student collection
        IList<Student> studentList = new List<Student>() {
            new Student() { StudentID = 1, StudentName = "John", Age = 10} ,
            new Student() { StudentID = 2, StudentName = "Moin",  Age = 21 } ,
            new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
            new Student() { StudentID = 4, StudentName = "Ram" , Age = 20} ,
            new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 }
        };

        IList<Student> teenageStudents = studentList
                                                .Where(student => student.Age >= 12 && student.Age <= 20)
                                                .ToList<Student>();

        foreach (var teen in teenageStudents)
        {
            Console.WriteLine(teen);
        }


    }

}