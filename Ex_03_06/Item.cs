namespace Ex_03_06;
/// <summary>
///　商品情報を表すクラス
/// </summary>
public class Item
{
    public int itemNo;      //商品番号
    public string? itemName; //商品名
    public int price;	    //単価
    public double salesTaxRate = 0.10;//税率

    public void Print()
    {
        Console.WriteLine("結果");
        Console.WriteLine($"商品番号={itemNo}");
        Console.WriteLine($"商品名={itemName}");
        Console.WriteLine($"単価={price}");
    }

    public void Change(int newprice)
    {
        this.price = newprice;
    }

    public int CalculateTaxAmount()
    {
        return (int)(price * (salesTaxRate + 1));
    }

    public Item(int pitemNo, string pitemName, int pprice)
    {
        this.itemNo = pitemNo;
        this.itemName = pitemName;
        this.price = pprice;
    }

    public void ChangePrice(string price)
    {
        this.price = int.Parse(price);
    }


}