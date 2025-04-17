using System.Text.RegularExpressions;

namespace Day3;

class Program
{
     static void Main()
    {
        string input = System.IO.File.ReadAllText("Input.txt");
        int sum = CalculateMiddlePageNumber(input);
        Console.WriteLine($"Sum of middle page numbers: {sum}");
    }

    public static int CalculateMiddlePageNumber(string input)
    {
        var sections = input.Split(new[] {"\r\n", "\n"  }, StringSplitOptions.RemoveEmptyEntries);
        // if (sections.Length != 2)
        // {
        //     throw new ArgumentException("Input should contain two sections: rules and updates");
        // }

        var rulesSections = new List<(int Before, int After)>();
        var updatesSections = new List<List<int>>();

        bool isRulesSection = true;
        
        foreach (var section in sections)
        {
            if (section.Contains('|') && isRulesSection)
            {
                var parts = section.Split('|');
                
                if (parts.Length != 2)
                {
                    continue;
                }
                
                if(int.TryParse(parts[0], out int before) && int.TryParse(parts[1], out int after))
                {
                    rulesSections.Add((before, after));
                }
            }
            else if (section.Contains(','))
            {
                isRulesSection = false;
                var parts = section.Split(',');
                
                var updateList = new List<int>();

                foreach (var part in parts)
                {
                    if(int.TryParse(part, out int pageNumber))
                    {
                        updateList.Add(pageNumber);
                    }
                }

                if (updateList.Count > 0)
                {
                    updatesSections.Add(updateList);
                }
            }
        }
        
        int sum = 0;

        foreach (var updatesSection in updatesSections)
        {
            int middleIndex = updatesSection.Count / 2;
            int middlePageNumber = updatesSection[middleIndex];
            bool isInCorrectOrder = true;

            foreach (var rulesSection in rulesSections)
            {
                if (middlePageNumber < rulesSection.Before || middlePageNumber > rulesSection.After)
                {
                    isInCorrectOrder = false;
                    break;
                }
            }
            
            if (isInCorrectOrder)
            {
                sum += middlePageNumber;
            }
        }
        
        return sum;
    }

}