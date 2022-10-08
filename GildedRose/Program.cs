using System;
using System.Collections.Generic;

namespace GildedRose
{
    public class Program
    {
        public IList<Item> Items;
        public static void Main(string[] args)
        {
            //System.Console.WriteLine("OMGHAI!");

            var app = new Program()
            {
                Items = new List<Item>
                {
                new Normal { Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20 },
                new Cheese { Name = "Aged Brie", SellIn = 2, Quality = 0 },
                new Normal { Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7 },
                new Legendary { Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80 },
                new Legendary { Name = "Sulfuras, Hand of Ragnaros", SellIn = -1, Quality = 80 },
                new Ticket
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 15,
                    Quality = 20
                },
                new Ticket
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 10,
                    Quality = 49
                },
                new Ticket
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 5,
                    Quality = 49
                },
                new Conjured { Name = "Conjured Mana Cake", SellIn = 3, Quality = 6 }
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
                foreach (var item in app.Items)
                {
                    item.UpdateQuality();
                }
            }
        }
    }
}