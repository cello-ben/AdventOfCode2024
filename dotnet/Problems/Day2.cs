using System.ComponentModel;

namespace AdventOfCode2024.Problems
{
    public class Day2
    {
        private static bool IsSafe(List<int> nums)
        {
            if (nums.Count <= 1)
            {
                return true;
            }
            else if (nums.Count == 2)
            {
                return nums[0] == nums[1] ? false : true;
            }
            bool ascending = nums[1] < nums[2] ? true : false;
            for (int i = 0; i < nums.Count - 1; i++)
            {
                if (nums[i] == nums[i + 1])
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
    }
}