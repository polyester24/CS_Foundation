using Ex_03_11.Modules;
namespace Ex_03_11;

static class Program
{
    static void Main(string[] args)
    {
        var mouse = new Mouse();
        var display = new Display();
        var flashMemory = new FlashMemory();

        flashMemory.SendData();
        flashMemory.ReciveData();
        display.SendData();
        display.ReciveData();





    }
}
