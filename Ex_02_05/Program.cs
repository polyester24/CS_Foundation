namespace Ex_02_05;

class Program
{
    static void Main(string[] args)
    {
       ->" Console.Write("数値を入力してください);
        var num = Console.ReadLine()!;
        int number;
        number = int.Parse(num);
        int result;

        if (number % 2 == 1)
        {
            result = number;
            Console.WriteLine($"結果:{result}");
        }
        else
        {
            result = number * 10;
            Console.WriteLine($"結果:{result}");
        }
    }
}
