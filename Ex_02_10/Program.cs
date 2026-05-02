namespace Ex_02_10;

class Program
{
    static void Main(string[] args)
    {
        string[] station = { "品川", "大崎", "五反田", "目黒", "恵比寿", "渋谷", "原宿", "代々木", "新宿" };
        foreach (var stations in station)
        {
            Console.WriteLine(stations);
        }
    }
}
