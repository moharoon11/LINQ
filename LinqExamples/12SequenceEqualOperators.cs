using LINQ.LinqExamples;

public class EqualityOperatorsDemo
{
   public static void SequenceEqualExample()
    {
        int[] first = { 1, 2, 3, 4 };
        int[] second = { 1, 2, 3, 4 };
        int[] third = { 4, 3, 2, 1 };

        bool isEqual1 = first.SequenceEqual(second);
        bool isEqual2 = first.SequenceEqual(third);

        Console.WriteLine($"first == second? {isEqual1}");
        Console.WriteLine($"first == third? {isEqual2}");  
    }
}