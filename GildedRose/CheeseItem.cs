    public class CheeseItem : Item
    {
        public override void UpdateQuality()
        {
            Quality = Quality+1;
            SellIn = SellIn-1;
            if (SellIn < 0) Quality = Quality+1;
            if (Quality > 50) Quality = 50;
        }
    }