using System.Collections;

namespace LINQ.LinqExamples;

public class ConversionOperator
{

    public static void ToListConversion()
    {
        int[] numbers = { 1, 2, 3, 4, 5 };

        List<int> numberList = numbers
                                .Where(n => n % 2 == 0) // Filter even numbers
                                .ToList();

        Console.WriteLine(string.Join(", ", numberList)); // Output: 2, 4
    }

    public static void ToArrayConversion()
    {
        int[] numbers = { 1, 2, 3, 4, 5 };

        int[] evenNumbers = numbers
                            .Where(n => n % 2 == 0)
                            .ToArray();

        Console.WriteLine(string.Join(", ", evenNumbers)); // Output: 2, 4

    }

    public static void ToDictionaryConversion()
    {
        string[] words = { "apple", "banana", "cherry" };

        Dictionary<string, int> wordLengths = words
                                              .ToDictionary(w => w, w => w.Length);

        foreach (var kvp in wordLengths)
        {
            Console.WriteLine($"{kvp.Key} => {kvp.Value}");
        }

    }


    public static void CustomConversionUsingCast()
    {
        ArrayList list = new ArrayList() { 1, 2, 3, 4 };

        IEnumerable<int> listInt = list.Cast<int>();

        foreach (int n in listInt)
        {
            Console.WriteLine(n);
        }
    }


}