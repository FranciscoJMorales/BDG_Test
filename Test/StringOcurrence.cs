using System;
using System.Collections;
using System.IO;
using System.Text;

public class StringOccurrence
{
    public static int GetOccurrenceCount(string toSearch, Stream stream)
    {
        string line = "";
        int count = 0;
        do
        {
            line = ReadLine(stream);
            if (line.Contains(toSearch)) count++;
        } while (line.Length > 0);
        return count;
    }

    public static void Main(string[] args)
    {
        string message = "Hey! How are you?\nI am good, how about you?\nI am good too.";
        using (MemoryStream stream = new MemoryStream(Encoding.UTF8.GetBytes(message)))
            Console.WriteLine(StringOccurrence.GetOccurrenceCount("good", stream));
    }

    public static string ReadLine(Stream stream)
    {
        string text = "";
        byte[] buffer = new byte[1];
        while (stream.Position < stream.Length)
        {
            stream.Read(buffer, 0, 1);
            string result = Encoding.UTF8.GetString(buffer);
            if (result.Equals("\n"))
            {
                return text;
            }
            text += result;
        }
        return text;
    }
}
