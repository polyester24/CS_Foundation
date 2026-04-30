namespace Ex_03_07;

static class Program
{
    static void Main(string[] args)
    {
        Warrior warrior = new();
        warrior.Name = "戦士";
        warrior.Hp = 10;//setアクセッサがprivateなので設定不可
        warrior.Ap = 10;//読み取り専用プロパティなので設定不可
    }
}
