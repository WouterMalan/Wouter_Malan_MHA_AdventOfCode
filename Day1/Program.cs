//Input file is in bin folder


using System.Reflection;

namespace Day1;

class Program
{
    static void Main()
    {
        try
        {
            string[] input = System.IO.File.ReadAllLines("Input.txt");
        
            // Part 1:
            var totalDistancePart1 = CalculateTotalDistancePart1(input);
            Console.WriteLine($"Part 1 - Total distance between sorted lists: {totalDistancePart1}");
        
            // Part 2:
            var similarityScore = CalculateTotalDistanceFromFile(input);
            Console.WriteLine($"Part 2 - Similarity score: {similarityScore}");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error: {e.Message}");
        }
    }

//Part 1
    static int CalculateTotalDistancePart1(string[] input)
    {
        if (input == null || input.Length == 0)
        {
            throw new ArgumentException("Input cannot be null or empty.", nameof(input));
        }

        var rightList = new List<int>();
        var leftList = new List<int>();

        foreach (var line in input)
        {
            var parts = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            if (parts.Length != 2)
            {
                throw new FormatException($"Invalid line format: '{line}'. Expected format: 'left right'.");
            }

            if (!int.TryParse(parts[0], out int left))
            {
                throw new FormatException($"Invalid number format for 'left' in line: '{line}'.");
            }

            if (!int.TryParse(parts[1], out int right))
            {
                throw new FormatException($"Invalid number format for 'right' in line: '{line}'.");
            }

            leftList.Add(left);
            rightList.Add(right);
        }

        leftList.Sort();
        rightList.Sort();

        int totalDistance = 0;

        for (int i = 0; i < leftList.Count; i++)
        {
            int distance = Math.Abs(leftList[i] - rightList[i]);
            totalDistance += distance;
        }

        return totalDistance;
    }

    
    //Part 2
    static int CalculateTotalDistanceFromFile(string[] input)
    {
        if (input == null || input.Length == 0)
        {
            throw new ArgumentException("Input cannot be null or empty.", nameof(input));
        }
    
        var rightList = new List<int>();
        var leftList = new List<int>();
    
        foreach (var line in input)
        {
            var parts = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    
            if (parts.Length != 2)
            {
                throw new FormatException($"Invalid line format: '{line}'. Expected format: 'left right'.");
            }
    
            if (!int.TryParse(parts[0], out int left))
            {
                throw new FormatException($"Invalid number format for 'left' in line: '{line}'.");
            }
    
            if (!int.TryParse(parts[1], out int right))
            {
                throw new FormatException($"Invalid number format for 'right' in line: '{line}'.");
            }
    
            leftList.Add(left);
            rightList.Add(right);
        }
    
        int similarityScore = 0;
      
        foreach (int leftNumber in leftList)
        {
            int occurrences = rightList.Count(r => r == leftNumber);
          
            similarityScore += leftNumber * occurrences;
        }
    
        return similarityScore;
    }
}