    //I hope the goblin can stomach this much change, i have but simply moved the updateQuality Method to this class and made it virtual,
    //so polymorphism will work.
    public class Item
    {
        public string Name { get; set; }

        public int SellIn { get; set; }

        public int Quality { get; set; }

        public virtual void UpdateQuality(){}
    }
