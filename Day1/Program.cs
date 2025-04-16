using System;
using System.Collections.Generic;
using System.IO;
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
        
        var rightList = new List<int>();
        var leftList = new List<int>();
        
        string inputFileLine;
        
        while ((inputFileLine = reader.ReadLine()) != null)
        {
            var parts = inputFileLine.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            if (parts.Length != 2)
            {
                throw new FormatException($"Invalid line format: '{inputFileLine}'. Expected format: 'direction distance'.");
            }

            if (int.TryParse(parts[0], out int left) && int.TryParse(parts[1], out int right))
            {
                rightList.Add(right);
                leftList.Add(left);
            }
        }
        
        var totalDistance = 0;
        
        for (int i = 0; i < leftList.Count; i++)
        {
            totalDistance += Math.Abs(leftList[i] - rightList[i]);
        }
        
        return totalDistance;
    }
}