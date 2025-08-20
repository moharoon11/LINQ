namespace LINQ.LinqExamples;


public class SortingOperator
{


    public record Product(string Name, decimal Price, string Category);
    public record Category(string Name, List<Product> Products);

    public record Person(string Name, List<string> Phones);

    public static List<Product> accesories = null;
    public static List<Category> catData = null;
    public static List<Person> peopleData = null;


    static SortingOperator()
    {
        Initialize();
    }

    private static void Initialize()
    {
        accesories = new List<Product>
        {
            new("Laptop", 1500, "Electronics"),
            new("Mouse", 25, "Accessories"),
            new("Monitor", 300, "Electronics"),
            new("Keyboard", 75, "Accessories")
        };

        catData = new List<Category>
        {
            new("Electronics", accesories.Where(p => p.Category == "Electronics").ToList()),
            new("Accessories", accesories.Where(p => p.Category == "Accessories").ToList())
        };

        peopleData = new List<Person>
        {
            new("Alice", new List<string> { "123", "456" }),
            new("Bob", new List<string> { "789" })
        };


    }

    public static void PrintCollection(List<object> list)
    {
        if (list == null || list.Count == 0)
        {
            Console.WriteLine("The collection is empty.");
            return;
        }

        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
    }

    public static void OrderByOperator()
    {

        var acc = accesories.OrderBy(acc => acc.Price)
                            .Cast<Object>()
                            .ToList();

        PrintCollection(acc);
    }

    public static void OrderByDescendingOperator()
    {

        var acc = accesories.OrderByDescending(acc => acc.Price)
                            .Cast<Object>()
                            .ToList();

        PrintCollection(acc);
    }

    // ThenBy or ThenByDescending
    public static void ThenByOperator()
    {

        var acc = accesories.OrderBy(acc => acc.Category)
                            .ThenBy(acc => acc.Price)
                            .Cast<Object>()
                            .ToList();

        PrintCollection(acc);
    }

    public static void CustomSorting()
    {
        var acc = accesories.OrderBy(acc => acc.Name.Length)
                            .Cast<Object>()
                            .ToList();

        PrintCollection(acc);
    }

    // reversing the collection
    public static void Reverse()
    {
        accesories.Reverse(); // in place modification from List<T>.Reverse() returns void 
        PrintCollection(accesories.Cast<Object>().ToList());
        Console.WriteLine();
        var reversedList = accesories.AsEnumerable().Reverse(); // returns a new list original list remains untouched and coming from Linq.Reverse() and returns a new list
        PrintCollection(reversedList.Cast<Object>().ToList());
    }
}