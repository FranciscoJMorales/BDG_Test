using System;
using System.Collections.Generic;

public class MaxSum
{
    public static int FindMaxSum(List<int> list)
    {
        int max, max2;
        if (list[0] > list[1])
        {
            max = list[0];
            max2 = list[1];
        }
        else
        {
            max = list[1];
            max2 = list[0];
        }
        for (int i = 2; i < list.Count; i++)
        {
            if (list[i] > max2)
            {
                if (list[i] > max)
                {
                    max2 = max;
                    max = list[i];
                }
                else
                {
                    max2 = list[i];
                }
            }
        }
        return max + max2;
    }

    public static void Main(string[] args)
    {
        List<int> list = new List<int> { 5, 9, 7, 11 };
        Console.WriteLine(FindMaxSum(list));
    }
}
