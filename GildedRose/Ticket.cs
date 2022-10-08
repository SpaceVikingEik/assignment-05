    public class Ticket : Item
    {
        public override void UpdateQuality()
        {
            if (Quality < 50)
            {
                Quality = Quality + 1;
            }

            if (SellIn < 11 && Quality < 50)
            {
                Quality = Quality + 1;

            }

            if (SellIn < 6 && Quality < 50)
            {
                Quality = Quality + 1;
            }
            SellIn = SellIn-1;

            if (SellIn <= 0)
            {
                Quality = 0;
            }

        }
    }