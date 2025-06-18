using System;
using System.Text.RegularExpressions;

public class MatchDates
{
    public static void Run()
    {
        string input = Console.ReadLine();
        string pattern = @"\b(?<day>\d{1,2})([.\-/])(?<month>[A-Za-z]{3})\2(?<year>\d{4})\b";

        string[] tokens = input.Split(new[] { ",", " " }, StringSplitOptions.RemoveEmptyEntries);
        bool found = false;

        foreach (var token in tokens)
        {
            Match match = Regex.Match(token.Trim(), pattern);
            if (match.Success)
            {
                found = true;

                string day = match.Groups["day"].Value;
                string monthRaw = match.Groups["month"].Value;
                string year = match.Groups["year"].Value;

                // Normalize month to TitleCase (e.g., Jan, Feb)
                string month = char.ToUpper(monthRaw[0]) + monthRaw.Substring(1).ToLower();

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }

        if (!found)
        {
            Console.WriteLine("No valid dates found.");
        }
    }
}
