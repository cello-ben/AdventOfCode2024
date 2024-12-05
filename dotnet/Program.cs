using AdventOfCode2024.Problems;

namespace AdventOfCode2024
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string day1Input = File.ReadAllText("../inputs/Day1.txt");
            Console.WriteLine($"Day 1 answer: {Day1.GetListDistance(day1Input)}");
            //We can use Day 1's input for Day 2 (no changes).
            Console.WriteLine($"Day 2 answer: {Day2.GetListOverlap(day1Input)}");
        }
    }
}