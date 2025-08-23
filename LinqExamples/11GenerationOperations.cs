using System.Collections;

namespace LINQ.LinqExamples;

public class GenerationOperator
{

    public static void RangeOperator()
    {

        IEnumerable<int> enumerable = Enumerable.Range(1, 10);
        List<int> rangeList = enumerable.ToList();

        Console.WriteLine("Range(1,10): " + string.Join(", ", rangeList));
    }

    public static void RepeatOperator()
    {

        String name = "THERE IS CAULIFLOWER...";
        foreach (var item in Enumerable.Repeat(name, 10))
        {
            Console.WriteLine(item);
        }
    }

    public static void EmptyExample()
    {
        // Generate empty sequence
        var empty = Enumerable.Empty<int>();

        Console.WriteLine("Empty sequence count: " + empty.Count());
    }
}