namespace Ex_02_12;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("値を入力してください->");
        var num = Console.ReadLine()!;
        int number;
        number = int.Parse(num);

        int answer = Add(number);
        Console.WriteLine(answer);

        int Add(int x)
        {
            return x * 3;
        }
    }
}
