using Ex_03_10.Modules;
namespace Ex_03_10;

static class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("DVDのタイトルを入力してください->");
        Player player = new DVDPlayer(Console.ReadLine()!);

        player.Play();
        player.Stop();

        Console.WriteLine("Blu-rayのタイトルを入力してください->");
        Player player2 = new BlurayPlayer(Console.ReadLine()!);


        player2.Play();
        player2.Stop();


    }
}
