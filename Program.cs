using System;
using System.Linq;

namespace DEPI_Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("========================================");
            Console.WriteLine("    DEPI - C# Assignment 3 Solutions    ");
            Console.WriteLine("========================================\n");

            // Question 1: Divisible by 3 and 4
            Console.WriteLine("--- Question 1 ---");
            Console.Write("Enter a number: ");
            if (int.TryParse(Console.ReadLine(), out int q1Num))
            {
                Console.WriteLine((q1Num % 3 == 0 && q1Num % 4 == 0) ? "Yes" : "No");
            }

            // Question 2: Positive or Negative
            Console.WriteLine("\n--- Question 2 ---");
            Console.Write("Enter an integer: ");
            if (int.TryParse(Console.ReadLine(), out int q2Num))
            {
                Console.WriteLine(q2Num < 0 ? "negative" : "positive");
            }

            // Question 3: Max and Min of 3 numbers
            Console.WriteLine("\n--- Question 3 ---");
            Console.Write("Enter 3 numbers separated by space (e.g. 7 8 5): ");
            var q3Inputs = Console.ReadLine()?.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            if (q3Inputs?.Length >= 3)
            {
                int a = int.Parse(q3Inputs[0]), b = int.Parse(q3Inputs[1]), c = int.Parse(q3Inputs[2]);
                Console.WriteLine($"max element = {Math.Max(a, Math.Max(b, c))}");
                Console.WriteLine($"min element = {Math.Min(a, Math.Min(b, c))}");
            }

            // Question 4: Even or Odd
            Console.WriteLine("\n--- Question 4 ---");
            Console.Write("Enter a number: ");
            if (int.TryParse(Console.ReadLine(), out int q4Num))
            {
                Console.WriteLine(q4Num % 2 == 0 ? "Even" : "Odd");
            }

            // Question 5: Vowel or Consonant
            Console.WriteLine("\n--- Question 5 ---");
            Console.Write("Enter a character: ");
            char ch = char.ToLower(Console.ReadKey().KeyChar);
            Console.WriteLine();
            if ("aeiou".Contains(ch))
                Console.WriteLine("vowel");
            else
                Console.WriteLine("consonant");

            // Question 6: Print 1 to N
            Console.WriteLine("\n--- Question 6 ---");
            Console.Write("Enter a number: ");
            if (int.TryParse(Console.ReadLine(), out int q6Num))
            {
                for (int i = 1; i <= q6Num; i++)
                    Console.Write(i + (i < q6Num ? ", " : "\n"));
            }

            // Question 7: Multiplication table up to 12
            Console.WriteLine("\n--- Question 7 ---");
            Console.Write("Enter a number: ");
            if (int.TryParse(Console.ReadLine(), out int q7Num))
            {
                for (int i = 1; i <= 12; i++)
                    Console.Write((q7Num * i) + " ");
                Console.WriteLine();
            }

            // Question 8: Print all even numbers between 1 to N
            Console.WriteLine("\n--- Question 8 ---");
            Console.Write("Enter a number: ");
            if (int.TryParse(Console.ReadLine(), out int q8Num))
            {
                for (int i = 2; i <= q8Num; i += 2)
                    Console.Write(i + " ");
                Console.WriteLine();
            }

            // Question 9: Calculate Power
            Console.WriteLine("\n--- Question 9 ---");
            Console.Write("Enter base and exponent (e.g. 4 3): ");
            var q9Inputs = Console.ReadLine()?.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            if (q9Inputs?.Length >= 2)
            {
                int baseNum = int.Parse(q9Inputs[0]), exp = int.Parse(q9Inputs[1]);
                Console.WriteLine($"Output: {Math.Pow(baseNum, exp)}");
            }

            // Question 10: Marks of five subjects
            Console.WriteLine("\n--- Question 10 ---");
            Console.Write("Enter marks of 5 subjects (e.g. 95 76 58 90 89): ");
            var marks = Console.ReadLine()?.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            if (marks?.Length == 5)
            {
                int total = marks.Sum();
                double avg = marks.Average();
                Console.WriteLine($"Total marks = {total}");
                Console.WriteLine($"Average Marks = {avg}");
                Console.WriteLine($"Percentage = {avg}");
            }

            // Question 11: Days in a month
            Console.WriteLine("\n--- Question 11 ---");
            Console.Write("Enter Month Number (1-12): ");
            if (int.TryParse(Console.ReadLine(), out int month))
            {
                int days = month switch
                {
                    2 => 28,
                    4 or 6 or 9 or 11 => 30,
                    _ => 31
                };
                Console.WriteLine($"Days in Month: {days}");
            }

            // Question 12: Simple Calculator
            Console.WriteLine("\n--- Question 12 ---");
            Console.Write("Enter expression (e.g. 10 + 5): ");
            var calc = Console.ReadLine()?.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            if (calc?.Length == 3)
            {
                double num1 = double.Parse(calc[0]), num2 = double.Parse(calc[2]);
                double res = calc[1] switch
                {
                    "+" => num1 + num2,
                    "-" => num1 - num2,
                    "*" => num1 * num2,
                    "/" => num2 != 0 ? num1 / num2 : 0,
                    _ => 0
                };
                Console.WriteLine($"Result: {res}");
            }

            // Question 13: Reverse a string
            Console.WriteLine("\n--- Question 13 ---");
            Console.Write("Enter a string: ");
            string strInput = Console.ReadLine() ?? "";
            char[] arrStr = strInput.ToCharArray();
            Array.Reverse(arrStr);
            Console.WriteLine($"Reversed: {new string(arrStr)}");

            // Question 14: Reverse an integer
            Console.WriteLine("\n--- Question 14 ---");
            Console.Write("Enter an integer: ");
            string intInput = Console.ReadLine() ?? "";
            char[] arrInt = intInput.ToCharArray();
            Array.Reverse(arrInt);
            Console.WriteLine($"Reversed: {new string(arrInt)}");

            // Question 15: Prime numbers in a range
            Console.WriteLine("\n--- Question 15 ---");
            Console.Write("Input starting and ending range (e.g. 1 50): ");
            var range = Console.ReadLine()?.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            if (range?.Length == 2)
            {
                int start = int.Parse(range[0]), end = int.Parse(range[1]);
                Console.Write($"Prime numbers between {start} and {end} are: ");
                for (int i = Math.Max(2, start); i <= end; i++)
                {
                    bool isPrime = true;
                    for (int j = 2; j * j <= i; j++)
                    {
                        if (i % j == 0) { isPrime = false; break; }
                    }
                    if (isPrime) Console.Write(i + " ");
                }
                Console.WriteLine();
            }

            // Question 16: Decimal to Binary (without array)
            Console.WriteLine("\n--- Question 16 ---");
            Console.Write("Enter a decimal number: ");
            if (int.TryParse(Console.ReadLine(), out int decNum))
            {
                string binary = "";
                int temp = decNum;
                while (temp > 0)
                {
                    binary = (temp % 2) + binary;
                    temp /= 2;
                }
                Console.WriteLine($"The Binary of {decNum} is {binary}");
            }

            // Question 17: Points on a straight line
            Console.WriteLine("\n--- Question 17 ---");
            Console.WriteLine("Enter x1 y1 x2 y2 x3 y3:");
            var pts = Console.ReadLine()?.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            if (pts?.Length == 6)
            {
                // (y2 - y1)*(x3 - x2) == (y3 - y2)*(x2 - x1)
                bool straight = (pts[3] - pts[1]) * (pts[4] - pts[2]) == (pts[5] - pts[3]) * (pts[2] - pts[0]);
                Console.WriteLine(straight ? "Points lie on a single straight line." : "Points do not lie on a straight line.");
            }

            // Question 18: Worker efficiency
            Console.WriteLine("\n--- Question 18 ---");
            Console.Write("Enter time taken in hours: ");
            if (double.TryParse(Console.ReadLine(), out double hours))
            {
                if (hours >= 2 && hours <= 3) Console.WriteLine("Highly efficient");
                else if (hours > 3 && hours <= 4) Console.WriteLine("Instructed to increase speed");
                else if (hours > 4 && hours <= 5) Console.WriteLine("Provided with training to enhance speed");
                else if (hours > 5) Console.WriteLine("Required to leave the company");
            }

            // Question 19: Identity matrix of size n*n
            Console.WriteLine("\n--- Question 19 ---");
            Console.Write("Enter matrix size n: ");
            if (int.TryParse(Console.ReadLine(), out int n))
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                        Console.Write((i == j ? 1 : 0) + " ");
                    Console.WriteLine();
                }
            }

            // Question 20: Sum of all elements of an array
            Console.WriteLine("\n--- Question 20 ---");
            int[] q20Arr = { 1, 2, 3, 4, 5 };
            Console.WriteLine($"Array Elements: {string.Join(", ", q20Arr)}");
            Console.WriteLine($"Sum = {q20Arr.Sum()}");

            // Question 21: Merge two sorted arrays
            Console.WriteLine("\n--- Question 21 ---");
            int[] arr1 = { 1, 3, 5 }, arr2 = { 2, 4, 6 };
            int[] merged = arr1.Concat(arr2).OrderBy(x => x).ToArray();
            Console.WriteLine($"Merged Array: {string.Join(" ", merged)}");

            // Question 22: Count frequency of each element
            Console.WriteLine("\n--- Question 22 ---");
            int[] freqArr = { 1, 2, 2, 3, 3, 3, 4 };
            var counts = freqArr.GroupBy(x => x).Select(g => new { Element = g.Key, Count = g.Count() });
            foreach (var item in counts)
                Console.WriteLine($"Element {item.Element} occurs {item.Count} times");

            // Question 23: Max and Min in array
            Console.WriteLine("\n--- Question 23 ---");
            int[] minMaxArr = { 45, 12, 89, 3, 67 };
            Console.WriteLine($"Max = {minMaxArr.Max()}, Min = {minMaxArr.Min()}");

            // Question 24: Second largest element in array
            Console.WriteLine("\n--- Question 24 ---");
            int[] secArr = { 10, 50, 40, 20, 50 };
            int secondMax = secArr.Distinct().OrderByDescending(x => x).Skip(1).FirstOrDefault();
            Console.WriteLine($"Second Largest = {secondMax}");

            // Question 25: Longest distance between two equal cells
            Console.WriteLine("\n--- Question 25 ---");
            int[] distArr = { 7, 0, 0, 0, 5, 6, 7, 5, 0, 7, 5, 3 };
            int maxDistance = 0;
            for (int i = 0; i < distArr.Length; i++)
            {
                int lastIdx = Array.LastIndexOf(distArr, distArr[i]);
                if (lastIdx > i)
                {
                    int distance = lastIdx - i - 1;
                    if (distance > maxDistance) maxDistance = distance;
                }
            }
            Console.WriteLine($"Longest distance between two equal cells = {maxDistance}");

            // Question 26: Reverse order of words
            Console.WriteLine("\n--- Question 26 ---");
            string sentence = "this is a test";
            string reversedWords = string.Join(" ", sentence.Split(' ', StringSplitOptions.RemoveEmptyEntries).Reverse());
            Console.WriteLine($"Original: {sentence}");
            Console.WriteLine($"Reversed Words Output: {reversedWords}");

            // Question 27: Copy 2D array
            Console.WriteLine("\n--- Question 27 ---");
            int[,] source2D = { { 1, 2 }, { 3, 4 } };
            int[,] dest2D = new int[2, 2];
            Array.Copy(source2D, dest2D, source2D.Length);
            Console.WriteLine("Copied 2D Array:");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                    Console.Write(dest2D[i, j] + " ");
                Console.WriteLine();
            }

            // Question 28: Print 1D Array in Reverse Order
            Console.WriteLine("\n--- Question 28 ---");
            int[] revArr = { 10, 20, 30, 40, 50 };
            Console.WriteLine("Reversed 1D Array:");
            for (int i = revArr.Length - 1; i >= 0; i--)
                Console.Write(revArr[i] + " ");
            Console.WriteLine();
        }
    }
}
