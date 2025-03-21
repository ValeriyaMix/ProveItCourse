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
        var todayDate = today.Day;
        var todayMonth= today.Month;
        var todayYear= today.Year;  
        var todayHours = today.Hour;
        var todayMinutes = today.Minute;
        Console.WriteLine("\n");
        Console.WriteLine(todayHours + "\n");
        Console.WriteLine(todayMinutes + "\n");

        var resultDate = ParseDate(inputDate);
        Console.WriteLine(resultDate["date"] + "\n");
        Console.WriteLine(resultDate["month"] +"\n");
        Console.WriteLine(resultDate["year"] + "\n");

        var resultTime = ParseTime(inputTime);
        Console.WriteLine(resultTime["hours"] + "\n");
        Console.WriteLine(resultTime["mins"] + "\n");
    }

    public static Dictionary<string, int> ParseTime(string timeProvided)
    {
        var timeBreakDown = new Dictionary<string, int>();
        var parsedTime = timeProvided.Split(":");
        var hours = parsedTime[0];
        var minutes = parsedTime[1];
        timeBreakDown.Add("hours", Int32.Parse(hours));
        timeBreakDown.Add("mins", Int32.Parse(minutes));

        return timeBreakDown;
    }

    public static Dictionary<string, int> ParseDate(string dateProvided)
    {
        string[] parsedDate = new string[0];
        var dateBreakDown = new Dictionary<string, int>();
        var dateLength = dateProvided.Length;
        var datePatternWithSlashes = @"/";
        var datePatternWithDots = @".";

        if (Regex.IsMatch(dateProvided, datePatternWithSlashes))
        {
            parsedDate = dateProvided.Split("/");
        }
        else if (Regex.IsMatch(dateProvided, datePatternWithDots))
        {
            parsedDate = dateProvided.Split(".");
        }


        var date = parsedDate[0];
        var month = parsedDate[1];
        var year = parsedDate[2];
        if (parsedDate[0].Length == 4)
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