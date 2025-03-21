using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.WriteLine("\nPlease provide date:\n");
        var inputDate = Console.ReadLine();
        Console.WriteLine("\nPlease provide time:\n");
        var inputTime = Console.ReadLine();

        var today = DateTime.Now;

        var result = ParseDate(inputDate);
        Console.WriteLine(result["date"] + "\n");
        Console.WriteLine(result["month"] +"\n");
        Console.WriteLine(result["year"] + "\n");
    }

    public static Dictionary<string, int> ParseDate(string dateProvided)
    {
        string[] inputDate = new string[0];
        var dateBreakDown = new Dictionary<string, int>();
        var dateLength = dateProvided.Length;
        var datePatternWithSlashes = @"/";
        var datePatternWithDots = @".";

        if (Regex.IsMatch(dateProvided, datePatternWithSlashes))
        {
            inputDate = dateProvided.Split("/");
        }
        else if (Regex.IsMatch(dateProvided, datePatternWithDots))
        {
            inputDate = dateProvided.Split(".");
        }


        var date = inputDate[0];
        var month = inputDate[1];
        var year = inputDate[2];
        if (inputDate[0].Length == 4)
        {
            dateBreakDown.Add("year", Int32.Parse(date));
            dateBreakDown.Add("month", Int32.Parse(month));
            dateBreakDown.Add("date", Int32.Parse(year));
        }
        else
        {
            dateBreakDown.Add("date", Int32.Parse(date));
            dateBreakDown.Add("month", Int32.Parse(month));
            dateBreakDown.Add("year", Int32.Parse(year));
        }
        
        return dateBreakDown;
    }
}