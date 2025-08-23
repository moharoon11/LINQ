using System;
using System.Linq;

namespace LINQ.LinqExamples
{
    public class PartitionOperators
    {
        

        public static void SkipExample()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6 };

            // Skip first 3 elements
            var skipped = numbers.Skip(3);

            Console.WriteLine("After Skip(3): " + string.Join(", ", skipped));
        }

        public static void TakeExample()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6 };

            // Take first 3 elements
            var taken = numbers.Take(3);

            Console.WriteLine("After Take(3): " + string.Join(", ", taken));
        }

        public static void SkipWhileExample()
        {
            int[] numbers = { 2, 4, 6, 7, 8, 10 };

            // Skip elements while condition is true
            var skipped = numbers.SkipWhile(n => n % 2 == 0);

            Console.WriteLine("After SkipWhile(even numbers): " + string.Join(", ", skipped));
        }

        public static void TakeWhileExample()
        {
            int[] numbers = { 2, 4, 6, 7, 8, 10 };

            // Take elements while condition is true
            var taken = numbers.TakeWhile(n => n % 2 == 0);

            Console.WriteLine("After TakeWhile(even numbers): " + string.Join(", ", taken));
        }
    }
}
