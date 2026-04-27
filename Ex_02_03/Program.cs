namespace Ex_02_03;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("数値を入力してください->");
        string x = Console.ReadLine();//変数xに入力された値を代入
        int y =  int.Parse(x);
        
        Console.WriteLine($"5を加算した結果は{y + 5}です。"  ); //入力された値を表示
        Console.WriteLine($"5を減算した結果は{y - 5}です。"  ); //入力された値を表示
    }
}
