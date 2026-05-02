namespace Ex_02_04;

class Program
{
    static void Main(string[] args)
    {
        var numbers = new string[3];

        Console.Write("数値を入力してください->");
        numbers[0] = Console.ReadLine()!;//変数xに入力された値を代入
        Console.Write("数値を入力してください->");
        numbers[1] = Console.ReadLine()!;//変数xに入力された値を代入
        Console.Write("数値を入力してください->");
        numbers[2] = Console.ReadLine()!;//変数xに入力された値を代入

        Console.WriteLine("入力結果");

        Console.WriteLine($"数値1:{numbers[0]}");
        Console.WriteLine($"数値2:{numbers[1]}");
        Console.WriteLine($"数値3:{numbers[2]}");

    }
}