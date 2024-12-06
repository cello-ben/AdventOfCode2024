namespace AdventOfCode2024.Problems
{
    public class Day4
    {
        private static int XmasOccurrencesHelper(List<List<char>> matrix, int i, int j, int pointer) //WIP - Must implement memoization to avoid stack overflow.
        {
            char[] word = {'X', 'M', 'A', 'S'};
            //We can do multiple recursive calls since we're OK with overlapping occurrences.
            if (pointer >= word.Length)
            {
                pointer = 0;
            }
            if (i >= 0 && j >= 0 && i < matrix.Count && j < matrix[0].Count)
            {
                //Quick check for a valid occurrence right now:
                if (matrix[i][j] == word[pointer])
                {
                    if (pointer == word.Length - 1)
                    {
                        return 1;
                    }
                    
                }
                //Time for DFS in each direction
                XmasOccurrencesHelper(matrix, i + 1, j, pointer + 1);
                XmasOccurrencesHelper(matrix, i - 1, j, pointer + 1);
                XmasOccurrencesHelper(matrix, i, j + 1, pointer + 1);
                XmasOccurrencesHelper(matrix, i, j - 1, pointer + 1);
                
            }
            return 0;
        }
        public static int GetNumXmasOccurrences(string raw)
        {
            //This problem is essentially Boggle. How can we permute parts of the board
            //to find occurrences of a given word? We can approach it a little differently,
            //though, because the word never changes. It's always "XMAS", so we have a constant
            //length. We need to seek in each direction from each character. We'll keep track
            //of where we are in the word "XMAS" with a pointer, and we'll break if we encounter
            //a character that isn't what we need. We'll deal with this problem recursively
            //with a helper method.
            
            List<List<char>> matrix = new();
            foreach (string s in raw.Split("\n"))
            {
                matrix.Add(s.ToCharArray().ToList());
            }
            //Check to see if any other characters are used in the puzzle input (they aren't):
            // foreach (List<char> l in matrix)
            // {
            //     foreach (char c in l)
            //     {
            //         if (!word.Contains(c))
            //         {
            //             Console.WriteLine(c);
            //         }
            //     }
            // }
            return XmasOccurrencesHelper(matrix, 0, 0, 0);
            
        }
    }
}