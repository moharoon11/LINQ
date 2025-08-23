namespace LINQ.LinqExamples;


public class SetOperations
{


    public static void ConcatOperation()
    {
        List<int> first = new List<int> { 1, 2, 3 };
        List<int> second = new List<int> { 3, 4, 5 };

        IEnumerable<int> combined = first.Concat(second);
        List<int> combinedList = combined.ToList();

        foreach (var n in combined)
        {
            Console.WriteLine(n);
        }
    }

    public static void UnionOperation()
    {
        List<int> first = new List<int> { 1, 2, 3 };
        List<int> second = new List<int> { 3, 4, 5 };

        int[] combined = first.Union(second).ToArray();

        foreach (var n in combined)
        {
            Console.WriteLine(n);
        }
    }

    public static void DistinctOperation()
    {
        List<int> first = new List<int> { 1, 2, 3, 3, 4, 5 };


        Dictionary<int, int> combined = first.Distinct().ToDictionary(val => val, val => val * 10);

        foreach (var n in combined)
        {
            Console.WriteLine($"Key = {n.Key}, Value = {n.Value}");
        }
    }

    

}
