//Input file is in bin folder
namespace Day6
{
    class Program
    {
        static void Main()
        {
            string input = System.IO.File.ReadAllText("Input.txt");

            //Part 1
            int sum = CountGuardVisitedPositions(input);
            Console.WriteLine($"Number of distinct guard visits: {sum}");
        }

        public static int CountGuardVisitedPositions(string input)
        {
            string[] lines = input.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
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

        static void SimulateGuardMovement(char[,] map, int startRow, int startCol, char startDirection,
            HashSet<(int, int)> visitedPositions)
        {
            int rows = map.GetLength(0);
            int cols = map.GetLength(1);

            int row = startRow;
            int col = startCol;
            Direction direction = new Direction(startDirection);

            visitedPositions.Add((row, col));

            while (true)
            {
                if (!IsWithinBounds(row, col, rows, cols))
                {
                    break; 
                }
                
                (int nextRow, int nextCol) = direction.GetNextPosition(row, col); 
                
                if (!IsWithinBounds(nextRow, nextCol, rows, cols) || map[nextRow, nextCol] == '#')
                {
                    direction.TurnRight();
                }
                else
                {
                    // Move forward
                    row = nextRow;
                    col = nextCol;
                    visitedPositions.Add((row, col));
                }
            }
        }

        static bool IsWithinBounds(int row, int col, int rows, int cols)
        {
            return row >= 0 && row < rows && col >= 0 && col < cols;
        }
    }

    struct Direction
    {
        private static readonly Dictionary<char, int> DirToIndex = new()
        {
            { '^', 0 }, // Up
            { '>', 1 }, // Right
            { 'v', 2 }, // Down
            { '<', 3 } // Left
        };

        private static readonly char[] IndexToDir = { '^', '>', 'v', '<' };
        private static readonly int[] RowDeltas = { -1, 0, 1, 0 };
        private static readonly int[] ColDeltas = { 0, 1, 0, -1 };

        private int _index;

        public Direction(char initialDirection)
        {
            _index = DirToIndex[initialDirection];
        }

        public void TurnRight()
        {
            _index = (_index + 1) % 4;
        }

        public (int nextRow, int nextCol) GetNextPosition(int row, int col)
        {
            return (row + RowDeltas[_index], col + ColDeltas[_index]);
        }

        public char Current => IndexToDir[_index];
    }
}