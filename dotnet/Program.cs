using AdventOfCode2024.Problems;

namespace AdventOfCode2024
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string day1Input = File.ReadAllText("../inputs/Day1.txt");
            Console.WriteLine($"Day 1 Part 1 answer: {Day1.GetListDistance(day1Input)}");
            Console.WriteLine($"Day 1 Part 2 answer: {Day1.GetListOverlap(day1Input)}");
            string day2Input = File.ReadAllText("../inputs/Day2.txt");
            Console.WriteLine($"Day 2 Part 1 answer: {Day2.GetSafeReports(day2Input)}");
            Console.WriteLine($"Day 2 Part 2 Answer: {Day2.GetSafeReportsWithRemoval(day2Input)}");
            string day3Input = File.ReadAllText("../inputs/Day3.txt");
            Console.WriteLine($"Day 3 Part 1 answer: {Day3.DecodeCorruptedMemory(day3Input)}");
            Console.WriteLine($"Day 3 Part 2 answer; {Day3.DecodeCorruptedMemoryWithDoDont(day3Input)}");
            string day4Input = File.ReadAllText("../inputs/Day4.txt");
            Console.WriteLine($"Day 4 Part 1 answer: {Day4.GetNumXmasOccurrences(day4Input)}");
        }
    }
}