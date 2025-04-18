//Input file is in bin folder
using System.Text.RegularExpressions;

namespace Day3;

class Program
{
    static void Main()
    {
        string input = System.IO.File.ReadAllText("Input.txt");

        //Part 1
        int memory1 = SumValidMultiplicationsPart1(input);
        Console.WriteLine($"Part 1: Total valid memory: {memory1}");
        
        //Part 2
        int memory2 = SumValidMultiplicationsPart2(input);
        Console.WriteLine($"Part 2: Total valid memory: {memory2}");

    }
    
    //Part1
    static int SumValidMultiplicationsPart1(string memory)
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
    
    //Part 2
    static int SumValidMultiplicationsPart2(string memory)
    {
        if (memory == null || memory.Length == 0)
        {
            return 0;
        }
        
        var instructions = GetInstructions(memory);

        return CaclulateInstructionTotal(instructions);
    }

    private static List<(int position, string type, Match match)> GetInstructions(string memory)
    {
        var mulRegex = new Regex(@"mul\((\d+),(\d+)\)");
        var doRegex = new Regex(@"do\(\)");
        var dontRegex = new Regex(@"don't\(\)");
        
        var mulMatches = mulRegex.Matches(memory);
        var doMatches = doRegex.Matches(memory);
        var dontMatches = dontRegex.Matches(memory);
        
        var instructions = new List<(int position, string type, Match match)>();

        foreach (Match match in mulMatches)
        {
            instructions.Add((match.Index, "mul", match));
        }
        
        foreach (Match match in doMatches)
        {
            instructions.Add((match.Index, "do", match));
        }
        
        foreach (Match match in dontMatches)
        {
            instructions.Add((match.Index, "dont", match));
        }
        
        instructions.Sort((a,b) => a.position.CompareTo(b.position));
        return instructions;
    }
    
    private static int CaclulateInstructionTotal(List<(int position, string type, Match match)> instructions)
    {
        var total = 0;
        bool shouldExecute = true;

        foreach (var instruction in instructions)
        {
            switch (instruction.type)
            {
                case "mul":
                    if (shouldExecute)
                    {
                        int x = int.Parse(instruction.match.Groups[1].Value);
                        int y = int.Parse(instruction.match.Groups[2].Value);
                        total += x * y;
                    }
                    
                    break;
                case "do":
                    shouldExecute = true;
                    break;
                case "dont":
                    shouldExecute = false;
                    break;
                default:
                    break;
                
            }
        }

        return total;
    }
}