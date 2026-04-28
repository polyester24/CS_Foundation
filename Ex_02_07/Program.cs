namespace Ex_02_07;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("数値を入力してください->");
        var num = Console.ReadLine();
        int number;
        number = int.Parse(num);

        if (number > 0)
        {
            Console.WriteLine("正の値です。");
        }
        else if (number < 0)
        {
            Console.WriteLine("負の値です。");
        }
        else
        {
            Console.WriteLine("0です。");
        }
    }
}
