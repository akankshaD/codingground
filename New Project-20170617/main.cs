using System.IO;
using System;
using System.Text;

class Program
{
    static void Main()
    {
        //Console.WriteLine("Hello, World!");
        /*var currentTime = DateTime.Now;
        var today = DateTime.Today;
        var someDate = new DateTime(2017, 6, 17);
        var someMoment = new DateTime(2017, 6, 17, 8, 23, 0);
        var tomorrow = DateTime.Today.AddDays(1);
        var yesterday = DateTime.Today.AddDays(-1);
        var someDay = DateTime.Parse("08/06/2017");
        StringBuilder sb = new StringBuilder("");
        //sb.Append(currentTime + " " + today+ " " + someDate + " " + someMoment + " " + tomorrow + " " + yesterday + " " + someDay);
        //Console.WriteLine(sb);
        var someTime = new DateTime(2017, 11, 10, 10, 10, 15);
        int Year = someTime.Year;
        int Month = someTime.Month;
        int day = someTime.Day;
        int hour = someTime.Hour;
        int minute = someTime.Minute;
        int second = someTime.Second;*/
        DateTime nextYear = new DateTime(DateTime.Today.Year+1, 1, 1);
        TimeSpan duration = nextYear-DateTime.Today;
        Console.WriteLine(duration.TotalDays);
    }
}
