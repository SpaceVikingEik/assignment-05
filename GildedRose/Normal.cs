public class Normal : Item
{
    public override void UpdateQuality()
    {

        Quality = Quality - 1;
        SellIn = SellIn - 1;
        if (SellIn <= 0) Quality = Quality - 1;
        if (Quality < 0) Quality = 0;
        Console.WriteLine("UWU");

    }
}