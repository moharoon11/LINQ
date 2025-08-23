
namespace LINQ.LinqExamples;

public class AggregationOperatorsDemo
{
   

    public static void CountExample()
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6 };

        int evenCount = numbers.Count(n => n % 2 == 0);

        Console.WriteLine($"Count of even numbers: {evenCount}");
    }

    public static void SumExample()
    {
        int[] numbers = { 1, 2, 3, 4, 5 };

        int total = numbers.Sum();

        Console.WriteLine($"Sum of numbers: {total}");
    }

    public static void AverageExample()
    {
        int[] numbers = { 1, 2, 3, 4, 5 };

        double average = numbers.Average();

        Console.WriteLine($"Average of numbers: {average}");
    }

    public static void MinExample()
    {
        int[] numbers = { 5, 3, 9, 1, 7 };

        int minValue = numbers.Min();

        Console.WriteLine($"Minimum value: {minValue}");
    }

    public static void MaxExample()
    {
        int[] numbers = { 5, 3, 9, 1, 7 };

        int maxValue = numbers.Max();

        Console.WriteLine($"Maximum value: {maxValue}");
    }
}