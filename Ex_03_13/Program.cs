using System.Runtime.InteropServices;

namespace Ex_03_13;

static class Program
{
    static void Main(string[] args)
    {
        Circle.Circle = new();
        Console.WriteLine($"5 * 5 * 3.14 ={Circle.AreaCalculation()}");
        Console.WriteLine($"5 * 5 * 3.14 ={Circle.AreaCalculation(5)}");


    }
}
