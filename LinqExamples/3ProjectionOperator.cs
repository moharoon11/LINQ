namespace LINQ.LinqExamples;

using System;
using System.Collections.Generic;
using System.Linq;

public class ProjectionOperator
{
    public record Product(string Name, decimal Price, string Category);
    public record Category(string Name, List<Product> Products);

    public static List<Product> accesories = null;
    public static List<Category> catData = null;

    // Static constructor to initialize data
    static ProjectionOperator()
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


    // Simple Select
    public static void SelectProjection()
    {
        var result = accesories.Select(acc => acc.Name)
                               .Cast<object>()
                               .ToList();
        PrintCollection(result);
    }

    // Select with Index
    public static void SelectProjectionWithIndex()
    {
      
    }

    // SelectMany example
    public static void SelectManyProjection()
    {
       
    }
}
