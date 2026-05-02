using Ex_03_08.Modules;
namespace Ex_03_08;

static class Program
{
    static void Main(string[] args)
    {

        NetAccount netAccount = new();
        Console.WriteLine("口座番号を入力してください->");
        netAccount.AccountNo = Console.ReadLine()!;
        Console.WriteLine("口座名義を入力してください->");
        netAccount.AccountName = Console.ReadLine()!;
        Console.WriteLine("残高を入力してください->");
        netAccount.Balance = int.Parse(Console.ReadLine()!);
        Console.WriteLine("ポイントを入力してください->");
        netAccount.Point = int.Parse(Console.ReadLine()!);

        netAccount.Print();
        netAccount.PPrint();

    }
}
