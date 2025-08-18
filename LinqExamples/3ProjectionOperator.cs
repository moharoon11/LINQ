namespace LINQ.LinqExamples;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

public class ProjectionOperator
{
    public record Product(string Name, decimal Price, string Category);
    public record Category(string Name, List<Product> Products);

    public record Person(string Name, List<string> Phones);

    public static List<Product> accesories = null;
    public static List<Category> catData = null;
    public static List<Person> peopleData  = null;


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
        string[] fruits = { "Apple", "Banana", "Cherry" };

        var result = fruits.Select((fruit, index) => new { Index = index, Fruit = fruit });

        foreach (var item in result)
        {
            Console.WriteLine($"{item.Index}: {item.Fruit}");
        }
    }

    // SelectMany example
    public static void SelectManyProjection()
    {
        var numbers = new List<List<int>>
        {
            new List<int> { 1, 2, 3 },
            new List<int> { 4, 5 },
            new List<int> { 6, 7, 8 }
        };

        var withList = numbers.SelectMany(nums => nums);
        // Console.WriteLine(String.Join(",", withList));

        var sentences = new List<string>
        {
            "I love C#",
            "LINQ is powerful",
            "SelectMany flattens things"
        };

        List<string> wordsList = sentences.SelectMany(sentence => sentence.Split(' ')).ToList();

        wordsList.ForEach(word => Console.Write(word + ", "));
        Console.WriteLine();

      


        var peopleList = peopleData.SelectMany(
            p => p.Phones,
            (person, phone) => new { person.Name, Phone = phone }
        );

        foreach (var item in peopleList)
        {
            Console.WriteLine($"{item.Name}: {item.Phone}");
        }
    }
}
