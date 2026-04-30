namespace Example;

/// <summary>
/// 戦士を表すクラス
/// </summary>
public class Warrior
{
    public string? name;     // 名前を表すフィールド
    private int hp = 10;    // 体力を表すフィールド
    /// <summary>
    /// 挨拶を行うメソッド
    /// </summary>
    public void Greet1()
    {
        Console.WriteLine($"{name}:hello!");
    }
    private void Greet2()
    {
        Console.WriteLine($"{name}:hi!");
    }
}