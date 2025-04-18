//Input file is in bin folder

namespace Day2;

class Program
{
    static void Main()
    {
        string[] input = System.IO.File.ReadAllLines("Input.txt");
        
        //Part 1
        int safeReports1 = CountSafeReportsPart1(input);
        Console.WriteLine($"PART 1: Number of safe reports: {safeReports1}");;
        
        //Part 2
        int safeReports2 = CountSafeReportsPart2(input);
        Console.WriteLine($"PART 1: Number of safe reports: {safeReports2}");;
    }
    
    //Part 1
    static int CountSafeReportsPart1(string[] reports)
    {
        if (reports == null || reports.Length == 0)
        {
            return 0;
        }
    
        int safeCount = 0;
    
        foreach (var report in reports)
        {
            var levels = report
                .Split(' ')
                .Select(int.Parse)
                .ToList();
    
            if (IsSafeReportPart1(levels))
            {
                safeCount++;
            }
        }
        
        return safeCount;
    }
    
    private static bool IsSafeReportPart1(List<int> levels)
    {
        if (levels.Count < 2)
        {
            return false;
        }
            
        bool isIncreasing = levels[1] > levels[0];
    
        for (int i = 1; i < levels.Count; i++)
        {
            int difference = levels[i] - levels[i - 1];
                
            if(Math.Abs(difference) < 1 || Math.Abs(difference) > 3)
            {
                return false;
            }
                
            if((isIncreasing && difference < 0) || (!isIncreasing && difference > 0))
            {
                return false;
            }
        }
        
        return true;
    }
    
    //Part 2
    static int CountSafeReportsPart2(string[] reports)
    {
        if (reports == null || reports.Length == 0)
        {
            return 0;
        }

        int safeCount = 0;

        foreach (var report in reports)
        {
            var levels = report
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            if (IsSafeReportPart2(levels))
            {
                safeCount++;
            }
        }
        
        return safeCount;
    }

    private static bool IsSafeReportPart2(List<int> levels)
    {
        if (levels.Count < 2)
        {
            return false;
        }

        if (IsSafe(levels))
        {
            return true;
        }

        for (int i = 0; i < levels.Count; i++)
        {
            var modifiedLevels = new List<int>(levels);
            modifiedLevels.RemoveAt(i);
            
            if (IsSafe(modifiedLevels))
            {
                return true;
            }
        }
        
        return false;
    }

    private static bool IsSafe(List<int> levels)
    {
        if (levels.Count < 2)
        {
            return false;
        }
        
        bool isIncreasing = levels[1] > levels[0];
        
        for (int i = 1; i < levels.Count; i++)
        {
            int difference = levels[i] - levels[i - 1];
            
            if((Math.Abs(difference) < 1 || Math.Abs(difference) > 3))
            {
                return false;
            }
                
            if((isIncreasing && difference < 0) || (!isIncreasing && difference > 0))
            {
                return false;
            }
        }
        
        return true;
    }
}