using System.ComponentModel;

namespace AdventOfCode2024.Problems
{
    public class Day2
    {
        private static bool IsSafe(List<int> nums)
        {
            //Cleanest way to do this is sort the list, check if unsorted == sorted,
            //and if a hash set of the ints is the same length (i.e. all distinct).
            //However, that brings us to O(n log n) territory, while the more
            //verbose version gives us O.
            if (nums.Count <= 1)
            {
                return true;
            }
            else if (nums.Count == 2)
            {
                return nums[0] != nums[1];
            }
            bool ascending = nums[0] < nums[1];
            for (int i = 0; i < nums.Count - 1; i++)
            {
                int abs = Math.Abs(nums[i] - nums[i + 1]);
                if (abs < 1 || abs > 3)
                {
                    return false;
                }
                else if (nums[i] < nums[i + 1])
                {
                    if (!ascending)
                    {
                        return false;
                    }
                }
                else
                {

                    if (ascending)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public static int GetSafeReports(string raw)
        {
            int safe = 0;
            foreach (string line in raw.Split("\n"))
            {
                Console.WriteLine(line);
                string[] strNums = line.Split(" ");
                List<int> nums = new();
                foreach (string num in strNums)
                {
                    bool canParse = int.TryParse(num, out int n);
                    if (canParse)
                    {
                        nums.Add(n);
                    }
                }
                safe += IsSafe(nums) ? 1 : 0;
            }
            return safe;
        }

        private static bool IsSafeWithRemoval(List<int> nums)
        {
            //Cleanest way to do this is sort the list, check if unsorted == sorted,
            //and if a hash set of the ints is the same length (i.e. all distinct).
            //However, that brings us to O(n log n) territory, while the more
            //verbose version gives us O.
            if (nums.Count <= 2)
            {
                return true;
            }
            bool ascending = nums[0] < nums[1];
            int strikes = 0;
            for (int i = 0; i < nums.Count - 1; i++)
            {
                int abs = Math.Abs(nums[i] - nums[i + 1]);
                if (abs < 1 || abs > 3)
                {
                    strikes++;
                }
                else if (nums[i] < nums[i + 1])
                {
                    if (!ascending)
                    {
                        strikes++;
                    }
                }
                else
                {

                    if (ascending)
                    {
                        strikes++;
                    }
                }
                if (strikes > 1)
                {
                    return false;
                }
            }
            return strikes <= 1;
        }
        public static int GetSafeReportsWithRemoval(string raw) //WIP, does not yet pass test.
        {
            int safe = 0;
            foreach (string line in raw.Split("\n"))
            {
                string[] strNums = line.Split(" ");
                List<int> nums = new();
                foreach (string num in strNums)
                {
                    bool canParse = int.TryParse(num, out int n);
                    if (canParse)
                    {
                        nums.Add(n);
                    }
                }
                safe += IsSafeWithRemoval(nums) ? 1 : 0;
            }
            return safe;
        }
    }
}