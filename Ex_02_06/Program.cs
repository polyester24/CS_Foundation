namespace Ex_02_06;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("数値を入力してください->");
        var num = Console.ReadLine()!;
        int number;
        number = int.Parse(num);

        if (number % 4 == 0)
        {
            Console.WriteLine("4の倍数です。");
        }
        else
        {
            Console.WriteLine("4の倍数ではありません。");
        }
    }
}