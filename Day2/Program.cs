using System.Reflection;

namespace Day2;

class Program
{
    static void Main()
    {
        string[] input = System.IO.File.ReadAllLines("Input.txt");
        int safeReports = CountSafeReports(input);
        Console.WriteLine($"Number of safe reports: {safeReports}");
    }
    
    //Part 1
    // static int CountSafeReports(string[] reports)
    // {
    //     if (reports == null || reports.Length == 0)
    //     {
    //         return 0;
    //     }
    //
    //     int safeCount = 0;
    //
    //     foreach (var report in reports)
    //     {
    //         var levels = report
    //             .Split(' ')
    //             .Select(int.Parse)
    //             .ToList();
    //
    //         if (IsSafeReport(levels))
    //         {
    //             safeCount++;
    //         }
    //     }
    //     
    //     return safeCount;
    // }
    //
    // private static bool IsSafeReport(List<int> levels)
    // {
    //     if (levels.Count < 2)
    //     {
    //         return false;
    //     }
    //         
    //     bool isIncreasing = levels[1] > levels[0];
    //
    //     for (int i = 1; i < levels.Count; i++)
    //     {
    //         int difference = levels[i] - levels[i - 1];
    //             
    //         if(Math.Abs(difference) < 1 || Math.Abs(difference) > 3)
    //         {
    //             return false;
    //         }
    //             
    //         if((isIncreasing && difference < 0) || (!isIncreasing && difference > 0))
    //         {
    //             return false;
    //         }
    //     }
    //     
    //     return true;
    // }
    
    //Part 2
    static int CountSafeReports(string[] reports)
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

            if (IsSafeReport(levels))
            {
                safeCount++;
            }
        }
        
        return safeCount;
    }

    private static bool IsSafeReport(List<int> levels)
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
}