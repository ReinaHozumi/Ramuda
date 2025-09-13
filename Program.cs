using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Enumerable.Range(0, int.Parse(Console.ReadLine()))
            .Select(_ => Console.ReadLine().Split(new[] { ':', ' ' }).Select(int.Parse).ToArray())
            .Select(arr =>
            {
                arr[0] = (arr[0] + arr[2] + (arr[1] + arr[3]) / 60) % 24;
                arr[1] = (arr[1] + arr[3]) % 60;
                return $"{arr[0]:D2}:{arr[1]:D2}";
            })
            .ToList()
            .ForEach(Console.WriteLine);
    }
}