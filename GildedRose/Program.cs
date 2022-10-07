using System;
using System.Collections.Generic;
namespace GildedRose
{
    public class Program
    {
        public IList<Item> Items;
        public static void Main(string[] args)
        {
            System.Console.WriteLine("OMGHAI!");

            var app = new Program()
                          {
                              Items = new List<Item>
                                          {
                new Item { Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20 },
                new BrieItem { Name = "Aged Brie", SellIn = 2, Quality = 0 },
                new Item { Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7 },
                new SulfurasItem { Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80 },
                new SulfurasItem { Name = "Sulfuras, Hand of Ragnaros", SellIn = -1, Quality = 80 },
                new BackstagePassItem
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 15,
                    Quality = 20
                },
                new BackstagePassItem
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 10,
                    Quality = 49
                },
                new BackstagePassItem
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 5,
                    Quality = 49
                },
				// this conjured item does not work properly yet
				new ConjuredItem { Name = "Conjured Mana Cake", SellIn = 3, Quality = 6 }
                                          }

                          };

            for (var i = 0; i < 31; i++)
            {
                Console.WriteLine("-------- day " + i + " --------");
                Console.WriteLine("name, sellIn, quality");
                for (var j = 0; j < app.Items.Count; j++)
                {
                    Console.WriteLine(app.Items[j].Name + ", " + app.Items[j].SellIn + ", " + app.Items[j].Quality);
                }
                Console.WriteLine("");
                app.UpdateQuality();
            }

        }

        public void UpdateQuality()
        {
            foreach (var item in Items)
            {
                item.UpdateQuality();
            }
        }

    }

    public class Item
    {
        public string Name { get; set; }

        public int SellIn { get; set; }

        public int Quality { get; set; }

        public virtual void UpdateQuality() {
            if (Quality > 0) {
                Quality--;
                if (SellIn <= 0 && Quality > 0)
                    Quality--;
            }

            SellIn--;
        }
    }

    public class BrieItem : Item 
    {
        public override void UpdateQuality() {
            if (Quality < 50) {
                Quality++;
                if (SellIn <= 0 && Quality < 50)
                    Quality++;
            }
            SellIn--;
        }
    }

    public class SulfurasItem : Item 
    {
        public override void UpdateQuality() {
            
        }
    }

    public class BackstagePassItem : Item 
    {
        public override void UpdateQuality() {
            if (Quality < 50) {
                Quality++;
                if (SellIn < 11 && Quality < 50)
                    Quality++;
                if (SellIn < 6 && Quality < 50)
                    Quality++;
            }
            if (SellIn <= 0) 
                Quality = 0;
            SellIn--;
        }
    }

    public class ConjuredItem : Item 
    {
        public override void UpdateQuality() {
            if (Quality > 1) {
                Quality = Quality - 2;
                if (SellIn <= 0 && Quality > 1)
                    Quality = Quality - 2;
            }

            SellIn--;
        }
    }

}