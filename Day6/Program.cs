namespace Day6
{
    class Program
    {
        static void Main()
        {
            string input = System.IO.File.ReadAllText("Input.txt");
            
            int sum = CountGuardVisitedPositions(input);
            Console.WriteLine($"Sum of middle page numbers: {sum}");
        }

        public static int CountGuardVisitedPositions(string input)
        {
            string[] lines = input.Split(new [] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            char[,] map = new char[lines.Length, lines[0].Length];

            int guardRow = -1;
            int guardCol = -1;
            char guardDirection = ' ';

            for (int row = 0; row < lines.Length; row++)
            {
                for (int col = 0; col < lines[row].Length; col++)
                {
                    map[row, col] = lines[row][col];

                    if (lines[row][col] == '^' ||
                        lines[row][col] == 'v' ||
                        lines[row][col] == '<' ||
                        lines[row][col] == '>')
                    {
                        guardRow = row;
                        guardCol = col;
                        guardDirection = lines[row][col];
                    }
                }
            }
            
            HashSet<(int, int)> visitedPositions = new HashSet<(int, int)>();
            visitedPositions.Add((guardRow, guardCol));
            
            SimulateGuardMovement(map, guardRow, guardCol, guardDirection, visitedPositions);
            
            return visitedPositions.Count;
        }

        private static void SimulateGuardMovement(char[,] map, int startRow, int startCol, char startDirection, HashSet<(int, int)> visitedPositions)
        {
            int rows = map.GetLength(0);
            int cols = map.GetLength(1);
            
            int row = startRow;
            int col = startCol;
            char direction = startDirection;
            
            // Direction vectors: Up, Right, Down, Left
           int[] rowDeltas = { -1, 0, 1, 0 }; 
            int[] columnDeltas = { 0, 1, 0, -1 };
        }
    }
    }