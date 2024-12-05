using System.ComponentModel;

namespace AdventOfCode2024.Problems
{
    public class Day2
    {
        public static int GetListOverlap(string raw)
        {
            HashSet<int> column1 = new();
            Dictionary<int, int> column2 = new(); //HashSet is not sufficient for the second column, since we can have multiple occurrences.

            foreach (string line in raw.Split("\n"))
            {
                string[] pair = System.Text.RegularExpressions.Regex.Split(line, @"\s\s{2,}");
                bool canParse1 = int.TryParse(pair[0], out int n1);
                bool canParse2 = int.TryParse(pair[1], out int n2);
                if (!canParse1 || !canParse2)
                {
                    return -1; //ERROR
                }
                if (!column2.ContainsKey(n2))
                {
                    column2[n2] = 0;
                }
                column1.Add(n1);
                column2[n2]++;
            }

            int diff = 0;
            
            foreach (int elem in column1)
            {
                if (column2.ContainsKey(elem))
                {
                    diff += elem * column2[elem];
                }
            }

            return diff;
        }
    }
}