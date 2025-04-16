using System.Reflection;

namespace Day1;

class Program
{
    static void Main()
    {
        string resourceName = "Day1.Input.txt";

        try
        {
            var totalDistance = ReadInputFromEmbeddedResource(resourceName);
            Console.WriteLine($"Total distance: {totalDistance}");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error: {e.Message}");
        }
    }

    //Part 1
    // static int ReadInputFromEmbeddedResource(string resourceName)
    // {
    //     if (string.IsNullOrWhiteSpace(resourceName))
    //     {
    //         throw new ArgumentException("Resource name cannot be null or empty.", nameof(resourceName));
    //     }
    //     
    //     var assembly = Assembly.GetExecutingAssembly();
    //     
    //     using var stream = assembly.GetManifestResourceStream(resourceName);
    //     if (stream == null)
    //     {
    //         throw new FileNotFoundException(
    //             $"Embedded resource '{resourceName}' not found. Make sure the file is set as 'Embedded Resource' in its properties.");
    //     }
    //
    //     using var reader = new StreamReader(stream);
    //     
    //     var rightList = new List<int>();
    //     var leftList = new List<int>();
    //     
    //     string inputFileLine;
    //     
    //     while ((inputFileLine = reader.ReadLine()) != null)
    //     {
    //         var parts = inputFileLine.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    //
    //         if (parts.Length != 2)
    //         {
    //             throw new FormatException($"Invalid line format: '{inputFileLine}'. Expected format: 'direction distance'.");
    //         }
    //
    //         if (int.TryParse(parts[0], out int left) && int.TryParse(parts[1], out int right))
    //         {
    //             rightList.Add(right);
    //             leftList.Add(left);
    //         }
    //     }
    //     
    //     var totalDistance = 0;
    //     
    //     for (int i = 0; i < leftList.Count; i++)
    //     {
    //         totalDistance += Math.Abs(leftList[i] - rightList[i]);
    //     }
    //     
    //     return totalDistance;
    // }
    
    //Part 2
    static int ReadInputFromEmbeddedResource(string resourceName)
    {
        if (string.IsNullOrWhiteSpace(resourceName))
        {
            throw new ArgumentException("Resource name cannot be null or empty.", nameof(resourceName));
        }
        
        var assembly = Assembly.GetExecutingAssembly();
        
        using var stream = assembly.GetManifestResourceStream(resourceName);
        if (stream == null)
        {
            throw new FileNotFoundException(
                $"Embedded resource '{resourceName}' not found. Make sure the file is set as 'Embedded Resource' in its properties.");
        }

        using var reader = new StreamReader(stream);
        
        return CalculateSimilarityScore(reader);
    }

    private static int CalculateSimilarityScore(StreamReader reader)
    {
        var rightList = new List<int>();
        var leftList = new List<int>();
        
        while (!reader.EndOfStream)
        {
            var line = reader.ReadLine();

            if (line == null)
            {
                continue;
            }
            
           var (left, right) = ParseLine(line);
            
            rightList.Add(right);
            leftList.Add(left);
        }
        
        return ComputeSimilarityScore(rightList, leftList);
    }
    
    private static (int left, int right) ParseLine(string line)
    {
        var parts = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    
        if (parts.Length != 2)
        {
            throw new FormatException($"Invalid line format: '{line}'. Expected format: 'direction distance'.");
        }
    
        if (!int.TryParse(parts[0], out int left) || !int.TryParse(parts[1], out int right))
        {
            throw new FormatException($"Invalid number format in line: '{line}'. Expected two integers.");
        }
        
        return (left, right);
    }

    private static int ComputeSimilarityScore(List<int> rightList, List<int> leftList)
    {
        var rightCounts = new Dictionary<int, int>();
        var similarityScore = 0;
        
        foreach (var number in rightList)
        {
            if (rightCounts.ContainsKey(number))
            {
                rightCounts[number]++;
            }
            else
            {
                rightCounts[number] = 1;
            }
        }
        
        foreach (var leftNum in leftList)
        {
            if (rightCounts.TryGetValue(leftNum, out int count))
            {
                similarityScore += leftNum * count;
            }
        }
        
        return similarityScore;
    }
}