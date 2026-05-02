namespace Ex_02_08;

class Program
{
    static void Main(string[] args)
    {
        string[] station = { "品川", "大崎", "五反田", "目黒", "恵比寿", "渋谷", "原宿", "代々木", "新宿" };
        int i = 0;
        while (i < station.Length)
        {
            Console.WriteLine(station[i]);
            i++;
        }
    }
}
