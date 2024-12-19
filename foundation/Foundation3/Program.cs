using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>
       {
        // new running activity
        new Running(new DateTime(2024, 12, 18), 30, 4.8f),
        // new cycling activity
        new Cycling(new DateTime(2024, 12, 18), 40, 15f),
        // new swimming activity
        new Swimming(new DateTime(2024, 12, 18), 25, 20)
       };

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}