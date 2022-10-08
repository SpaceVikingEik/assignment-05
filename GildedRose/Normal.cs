public class Normal : Item
{
    public override void UpdateQuality()
    {

        if (SellIn > 0 && Quality > 0)
        {
            Quality = Quality - 1;
        }
        SellIn = SellIn - 1;
        if (SellIn <= 0 && Quality > 0)
        {
            if (Quality < 3)
            {
                Quality = 0;
            }
            else
            {
                Quality = Quality - 2;
            }
        }
        Console.WriteLine("UWU");

    }
}