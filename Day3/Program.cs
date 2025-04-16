using System.Text.RegularExpressions;

namespace Day3;

class Program
{
    static void Main()
    {
        string input = System.IO.File.ReadAllText("Input.txt");
        int memory = CalculateValidMultiplyMemory(input);
        Console.WriteLine($"Total valid memory: {memory}");
    }
    
    //Part1
    static int CalculateValidMultiplyMemory(string memory)
    {
        if (memory == null || memory.Length == 0)
        {
            return 0;
        }
        
        var regex = new Regex(@"mul\((\d+),(\d+)\)");
        var regexMatches = regex.Matches(memory);
        var total = 0;
        
        foreach (Match match in regexMatches)
        {
            int x = int.Parse(match.Groups[1].Value);
            int y = int.Parse(match.Groups[2].Value);
            
            total += x * y;
        }

        return total;

    }

}