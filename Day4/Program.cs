//Input file is in bin folder
namespace Day4
{
    class Program
    {
        static void Main()
        {
            string input = System.IO.File.ReadAllText("Input.txt");
            
            
            int count1 = CountXMasPatternsPart1(input);
            Console.WriteLine($"Part 1: XMAS appears {count1} times");
            
            //Part 2
            int count2 = CountXMasPatternsPart2(input);
            Console.WriteLine($"Part 2: XMAS appears {count2} times");
        }
        

        public static int CountXMasPatternsPart1(string input)
        {
            string[] lines = input.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            
            int rows = lines.Length;
            int cols = lines[0].Length;
            char[,] grid = new char[rows, cols];
            
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    grid[i, j] = lines[i][j];
                }
            }
            
            string targetWord = "XMAS";
            int count = 0;
            
            // Check in all 8 directions
            // Top left (-1, -1), Top (-1, 0), Top right (-1, 1), Right (0, 1), Bottom right (1, 1), Bottom (1, 0), Bottom left (1, -1), Left (0, -1)
          int[] rowDirections = { -1, -1, -1, 0, 0, 1, 1, 1 };
          int[] colDirections = { -1, 0, 1, -1, 1, -1, 0, 1 };
            
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                   for (int directionIndex = 0; directionIndex < 8; directionIndex++)
                    {
                        int currentRow = i;
                        int currentCol = j;
                        int matchedCharacters;
                    
                        for (matchedCharacters = 0; matchedCharacters < targetWord.Length; matchedCharacters++)
                        {
                            if (currentRow < 0 || currentRow >= rows || currentCol < 0 || currentCol >= cols)
                                break;
                    
                            if (grid[currentRow, currentCol] != targetWord[matchedCharacters])
                                break;
                    
                            currentRow += rowDirections[directionIndex];
                            currentCol += colDirections[directionIndex];
                        }
                    
                        if (matchedCharacters == targetWord.Length)
                            count++;
                    }
                }
            }
            
            return count;
        }
        
        public static int CountXMasPatternsPart2(string input)
        {
            string[] lines = input.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
        
            int rows = lines.Length;
            int cols = lines[0].Length;
            char[,] grid = new char[rows, cols];
        
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    grid[i, j] = lines[i][j];
                }
            }
        
            int count = 0;
        
            // Check for X-MAS patterns
            for (int i = 1; i < rows - 1; i++)
            {
                for (int j = 1; j < cols - 1; j++)
                {
                    if (IsXMasPattern(grid, i, j, rows, cols))
                    {
                        count++;
                    }
                }
            }
        
            return count;
        }
        
        private static bool IsXMasPattern(char[,] grid, int row, int col, int rows, int cols)
        {
            // Check top-left to bottom-right diagonal
            if (row - 1 >= 0 && col - 1 >= 0 && row + 1 < rows && col + 1 < cols)
            {
                string topLeft = $"{grid[row - 1, col - 1]}{grid[row, col]}{grid[row + 1, col + 1]}";
                string bottomRight = $"{grid[row + 1, col + 1]}{grid[row, col]}{grid[row - 1, col - 1]}";
        
                if (topLeft == "MAS" || topLeft == "SAM" || bottomRight == "MAS" || bottomRight == "SAM")
                {
                    // Check top-right to bottom-left diagonal
                    string topRight = $"{grid[row - 1, col + 1]}{grid[row, col]}{grid[row + 1, col - 1]}";
                    string bottomLeft = $"{grid[row + 1, col - 1]}{grid[row, col]}{grid[row - 1, col + 1]}";
        
                    if (topRight == "MAS" || topRight == "SAM" || bottomLeft == "MAS" || bottomLeft == "SAM")
                    {
                        return true;
                    }
                }
            }
        
            return false;
        }
    }
}
