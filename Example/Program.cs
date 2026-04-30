namespace Example;

class Program
{
    static void Main(string[] args)
    {

        Warrior warrior = new("ユータ", 15);
        Console.WriteLine(warrior.name);
        Console.WriteLine(warrior.hp);

        Warrior warrior2 = new("gm");
        Console.WriteLine(warrior2.hp);
        Console.WriteLine(warrior2.name);
        warrior2.hp = 8;
        Console.WriteLine(warrior2.hp);

    }

}