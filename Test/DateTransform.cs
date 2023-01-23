using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

public class DateTransform
{
    public static List<string> TransformDateFormat(List<string> dates)
    {
        List<string> result = new List<string>();
        foreach (string date in dates)
        {
            string[] dateParts = DateTransform.IsValidDate(date);
            if (dateParts != null)
            {
                result.Add(dateParts[0] + dateParts[1] + dateParts[2]);
            }
        }
        return result;
    }

    public static void Main(string[] args)
    {
        var input = new List<string> { "2010/02/20", "19/12/2016", "11-18-2012", "20130720" };
        DateTransform.TransformDateFormat(input).ForEach(Console.WriteLine);
    }

    private static string[] IsValidDate(string date)
    {
        Regex format1 = new Regex(@"^\d{4}/\d{2}/\d{2}$");
        Regex format2 = new Regex(@"^\d{2}/\d{2}/\d{4}$");
        Regex format3 = new Regex(@"^\d{2}\-\d{2}\-\d{4}$");
        Match result = format1.Match(date);
        if (result.Success) return new string[] { date.Substring(0, 4), date.Substring(5, 2), date.Substring(8, 2) };
        result = format2.Match(date);
        if (result.Success) return new string[] { date.Substring(6, 4), date.Substring(3, 2), date.Substring(0, 2) };
        result = format3.Match(date);
        if (result.Success) return new string[] { date.Substring(6, 4), date.Substring(0, 2), date.Substring(3, 2) };
        return null;
    }
}
