using System.Security.Cryptography.X509Certificates;

namespace Ex_03_15;

static class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("値1を入力してください");
        int x = int.Parse(Console.ReadLine())!;

        Console.WriteLine("値2を入力してください");
        int y = int.Parse(Console.ReadLine())!;

        Calculator calculator = new Calculator();
        try
        {
            int result = calculator.Div(x, y);
            Console.WriteLine($"値1 / 値2 = {result}");
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine(e.Message);
        }

    }
}
//