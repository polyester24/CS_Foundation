using Ex_03_11.Modules;
namespace Ex_03_11;

static class Program
{
    static void Main(string[] args)
    {
        IUSB mouse = new Mouse();
        IUSB display = new Display();
        IUSB flashMemory = new FlashMemory();

        flashMemory.SendData();
        flashMemory.ReciveData();
        display.SendData();
        display.ReciveData();





    }
}
