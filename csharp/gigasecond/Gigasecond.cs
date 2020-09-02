using System;

public static class Gigasecond
{
    public static DateTime Add(DateTime moment)
    {
        DateTime date1 = moment.AddSeconds(Math.Pow(10,9));
        return date1;
    }
}