using System.Text.RegularExpressions;

namespace AdventOfCode2024.Problems
{
    public class Day3
    {
        public static int DecodeCorruptedMemoryWithDoDont(string memory)
        {
            int res = 0;
            bool canDo = true;
            Regex matchRegex = new(@"(mul\([0-9]+,[0-9]+\))|do\(\)|don't\(\)");
            foreach (Match match in matchRegex.Matches(memory))
            {
                switch (match.Value.ToString())
                {
                    case "do()":
                        canDo = true;
                        break;
                    case "don't()":
                        canDo = false;
                        break;
                    default:
                        if (canDo)
                        {
                            string[] pair = match.Value.ToString().Split(",");
                            int product = 1;
                            foreach (string s in pair)
                            {
                                IEnumerable<char> numEnum = s.Where(c => char.IsDigit(c));
                                string num = String.Join("", numEnum);
                                bool canParse = int.TryParse(num, out int n);
                                if (canParse)
                                {
                                    product *= n;
                                }
                            }
                            res += product;
                        }
                        break;
                }
            }
            return res;
        }
        public static int DecodeCorruptedMemory(string memory)
        {
            int res = 0;
            Regex matchRegex = new(@"(mul\([0-9]+,[0-9]+\))|do\(\)|don't\(\)");
            foreach (Match match in matchRegex.Matches(memory))
            {
                string[] pair = match.Value.ToString().Split(",");
                int product = 1;
                foreach (string s in pair)
                {
                    IEnumerable<char> numEnum = s.Where(c => char.IsDigit(c));
                    string num = String.Join("", numEnum);
                    bool canParse = int.TryParse(num, out int n);
                    if (canParse)
                    {
                        product *= n;
                    }
                }
                res += product;
            }
            
            return res;
        }
    }
}