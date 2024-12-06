﻿using AdventOfCode2024.Problems;

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
            string day3Input = File.ReadAllText("../inputs/Day3.txt");
            Console.WriteLine($"Day 3 answer: {Day3.DecodeCorruptedMemory(day3Input)}");
        }
    }
}