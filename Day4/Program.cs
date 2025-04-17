namespace Day4;

class Program
{
    static void Main()
    {
        string input = System.IO.File.ReadAllText("Input.txt");
        string word = "XMAS";
        int memory = FindWord(input);
        Console.WriteLine($"Total valid memory: {memory}");
    }
    
    //Part 1
    public static int FindWord(string input)
    {
        if(input == null || input.Length == 0)
        {
            return 0;
        }

        var lines = input.Split('\n', StringSplitOptions.RemoveEmptyEntries);
        int rows = lines.Length;
        int columns = lines[0].Length;
        char[,] grid = new char[rows, columns];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                grid[i, j] = lines[i][j];
            }
        }
        
        var directions = new (int, int)[]
        {
            (0,1), // Horizontal right
            (0,-1), // Horizontal left
            (1,0), // Vertical down
            (-1,0), // Vertical up
            (1,1), // Diagonal down right
            (-1,-1), // Diagonal up left
            (1,-1), // Diagonal down left
            (-1,1), // Diagonal up right
            
        };

        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < columns; col++)
            {
                
            }
        }

        return 0;
    }

}




// using System.Text.RegularExpressions;
//
// namespace Day4;
//
// class Program
// {
//     static void Main()
//     {
//         string input = System.IO.File.ReadAllText("Input.txt");
//         string word = "XMAS";
//         int occurrences = FindWord(input, word);
//         Console.WriteLine($"Found {occurrences} occurrences of '{word}'");
//     }
//     
//     public static int FindWord(string input, string word)
//     {
//         if (string.IsNullOrEmpty(input) || string.IsNullOrEmpty(word))
//         {
//             return 0;
//         }
//
//         var lines = input.Split('\n', StringSplitOptions.RemoveEmptyEntries);
//         int rows = lines.Length;
//         int columns = lines[0].Length;
//         char[,] grid = new char[rows, columns];
//
//         // Fill the grid
//         for (int i = 0; i < rows; i++)
//         {
//             for (int j = 0; j < columns; j++)
//             {
//                 grid[i, j] = lines[i][j];
//             }
//         }
//         
//         // Define all 8 possible directions
//         var directions = new (int rowOffset, int colOffset)[]
//         {
//             (0, 1),  // Right
//             (1, 0),  // Down
//             (0, -1), // Left
//             (-1, 0), // Up
//             (1, 1),  // Down-Right
//             (-1, -1),// Up-Left
//             (1, -1), // Down-Left
//             (-1, 1)  // Up-Right
//         };
//
//         int count = 0;
//
//         // Search for the word in all directions from each cell
//         for (int row = 0; row < rows; row++)
//         {
//             for (int col = 0; col < columns; col++)
//             {
//                 // Only check if the first character matches
//                 if (grid[row, col] == word[0])
//                 {
//                     foreach (var (rowOffset, colOffset) in directions)
//                     {
//                         if (CheckWord(grid, row, col, rowOffset, colOffset, word, rows, columns))
//                         {
//                             count++;
//                         }
//                     }
//                 }
//             }
//         }
//
//         return count;
//     }
//
//     /// <summary>
//     /// Checks if the word exists starting from a position and moving in a specific direction
//     /// </summary>
//     /// <param name="grid">The character grid to search in</param>
//     /// <param name="startRow">Starting row position</param>
//     /// <param name="startCol">Starting column position</param>
//     /// <param name="rowOffset">Row direction offset (-1, 0, or 1)</param>
//     /// <param name="colOffset">Column direction offset (-1, 0, or 1)</param>
//     /// <param name="targetWord">The word to search for</param>
//     /// <param name="gridHeight">Total number of rows in the grid</param>
//     /// <param name="gridWidth">Total number of columns in the grid</param>
//     /// <returns>True if the word is found in the specified direction</returns>
//     private static bool CheckWord(
//         char[,] grid, 
//         int startRow, 
//         int startCol, 
//         int rowOffset, 
//         int colOffset, 
//         string targetWord, 
//         int gridHeight, 
//         int gridWidth)
//     {
//         // Check if the word would go out of bounds
//         int endRow = startRow + (targetWord.Length - 1) * rowOffset;
//         int endCol = startCol + (targetWord.Length - 1) * colOffset;
//         
//         if (endRow < 0 || endRow >= gridHeight || endCol < 0 || endCol >= gridWidth)
//         {
//             return false;
//         }
//
//         // Check each character
//         for (int i = 0; i < targetWord.Length; i++)
//         {
//             int currentRow = startRow + i * rowOffset;
//             int currentCol = startCol + i * colOffset;
//             
//             if (grid[currentRow, currentCol] != targetWord[i])
//             {
//                 return false;
//             }
//         }
//         
//         return true;
//     }
// }