    //I hope the goblin can stomach this much change, i have but simply moved the updateQuality Method to this class, such that polymorphism will work.
    public class Item
    {
        public string Name { get; set; }

        public int SellIn { get; set; }

        public int Quality { get; set; }

        public virtual void UpdateQuality(){
            Console.WriteLine("Man i wish i could make this into an interface");
        }
    }
