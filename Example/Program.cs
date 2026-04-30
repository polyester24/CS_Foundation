namespace Example;

class Program
{
    static void Main(string[] args)
    {

        Warrior warrior = new Warrior();

        warrior.name = "ユータ";
        warrior.hp = 10;// 別なクラスから見えないのでコンパイルエラーになる

        warrior.Greet1();
        warrior.Greet2();// 別なクラスから見えないのでコンパイルエラーになる
    }

}