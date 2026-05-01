namespace Ex_03_07;

static class Program
{
    static void Main(string[] args)
    {
        Console.Write("商品番号を入力してください->");
        int itemNo = int.Parse(Console.ReadLine()!);
        Console.Write("商品名を入力してください->");
        string itemName = Console.ReadLine()!;
        Console.Write("単価を入力してください->");
        int price = int.Parse(Console.ReadLine()!);
    }
}
