//Input file is in bin folder
namespace Day4
{
    class Program
    {
        static void Main()
        {
            string input = System.IO.File.ReadAllText("Input.txt");
            int count = CalculateTImesWordAppears(input);
            Console.WriteLine($"XMAS appears {count} times");
        }

        public static int CalculateTImesWordAppears(string input)
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
    }
}
