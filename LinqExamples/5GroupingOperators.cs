namespace LINQ.LinqExamples;


public class GroupingOperators
{

    public record Student(int ID, string Name, string Department);

    private static List<Student> students = new List<Student>();

    static GroupingOperators()
    {
        Initialize();
    }

    private static void Initialize()
    {
        students = new List<Student>()
        {
            new Student(1, "Alice", "IT"),
            new Student(2, "Bob", "HR"),
            new Student(3, "Charlie", "IT"),
            new Student(4, "David", "Finance"),
            new Student(5, "Eva", "HR")
        };
    }

    public static void GroupbyOperator()
    {
        var groups = students.GroupBy(student => student.Department);

        foreach (var group in groups)
        {
            Console.WriteLine($"Department {group.Key}");
            foreach (var student in group)
            {
                Console.WriteLine($"Name : {student.Name}");
            }
        }
    }

    public static void GroupAndCount()
    {
        var group = students.GroupBy(s => s.Department)
                            .Select(g => new { Department = g.Key, Count = g.Count() });

        foreach (var dept in group)
        {
            Console.WriteLine($"{dept.Department} = {dept.Count}");
        }

    }
    public static void GroupAndWhere()
    {
        var group = students.GroupBy(s => s.Department)
                            .Where(g => g.Key.Equals("IT"));

        foreach (var dept in group)
        {
            Console.WriteLine($"{dept.Key}");
            foreach (var student in dept)
            {
                Console.WriteLine($"{student.Name}");
            }
        }

    }

    public static void LookUpOperator()
    {
        var studentLookup = students.ToLookup(s => s.Department);

        foreach (var group in studentLookup)
        {
            Console.WriteLine($"Department: {group.Key}");
            foreach (var student in group)
            {
                Console.WriteLine($"   {student.Name}");
            }
        }

    }

}