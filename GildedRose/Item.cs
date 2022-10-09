    //I hope the goblin can stomach this much change, i have simply moved the updateQuality Method to this class and made it virtual,
    //so polymorphism will work. I think the alternative ways to refactor the code without doing this requires many more keystrokes which,
    //cosidering how little code is needed in here, would not be made in the real world.
    public class Item
    {
        public string Name { get; set; }

        public int SellIn { get; set; }

        public int Quality { get; set; }

        public virtual void UpdateQuality(){}
    }
