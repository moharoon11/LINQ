namespace LINQ.LinqExamples;


public class QuantifierOperators
{


    public static void AnyOperation()
    {
        int[] numbers = { 1, 2, 3, 4, 5 };

        bool hasEven = numbers.Any(n => n % 2 == 0);

        Console.WriteLine(hasEven);
    }

    public static void AllOperation()
    {

        int[] numbers = { 1, 2, 3, 4, 5 };

        bool allEven = numbers.All(n => n % 2 == 0);

        Console.WriteLine(allEven);

    }

    public static void ContainsOperation()
    {
        string[] fruits = { "apple", "banana", "cherry" };

        bool hasApple = fruits.Contains("apple");
        Console.WriteLine(fruits.Contains("apple"));

    }
}