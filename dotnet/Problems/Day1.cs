using System.ComponentModel;

namespace AdventOfCode2024.Problems
{
    public class Day1
    {
        public static int GetListDistance(string raw)
        {
            List<int> column1 = new();
            List<int> column2 = new();

            foreach (string line in raw.Split("\n"))
            {
                string[] pair = System.Text.RegularExpressions.Regex.Split(line, @"\s\s{2,}");
                bool canParse1 = int.TryParse(pair[0], out int n1);
                bool canParse2 = int.TryParse(pair[1], out int n2);
                if (!canParse1 || !canParse2)
                {
                    return -1; //ERROR
                }
                column1.Add(n1);
                column2.Add(n2);
            }

            int diff = 0;
            List<int> sorted1 = column1.OrderByDescending(n => n).ToList();
            List<int> sorted2 = column2.OrderByDescending(n => n).ToList();

            for (int i = 0; i < sorted1.Count; i++)
            {
                diff += Math.Abs(sorted1[i] - sorted2[i]);
            }

            return diff;
        }
    }
}