using AdventOfCode2024.Problems;

namespace AdventOfCode2024
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string day1Input = File.ReadAllText("./Inputs/Day1.txt");
            Console.WriteLine(Day1.GetListDistance(day1Input));
        }
    }
}