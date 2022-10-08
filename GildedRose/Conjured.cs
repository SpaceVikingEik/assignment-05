public class Conjured : Item
{
    public override void UpdateQuality()
    {
        Quality = Quality - 2;

        SellIn = SellIn - 1;

        if (SellIn <= 0) Quality = Quality - 2;
        if (Quality < 0) Quality = 0;
            
    }
}