using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var N = int.Parse(Console.ReadLine());
        
        for (int i = 0; i < N; i++)
        {
            var tiem = Console.ReadLine();
            string[] arr = tiem.Split(':', ' ');
            int hour = int.Parse(arr[0]);
            int minute = int.Parse(arr[1]);
            int addHour = int.Parse(arr[2]);
            int addMinute = int.Parse(arr[3]);

            hour += addHour + (minute + addMinute) / 60;
            minute += addMinute;
            minute %= 60;
            hour %= 24;

            Console.WriteLine($"{hour:D2}:{minute:D2}");
        }
    }
}