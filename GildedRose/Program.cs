using System;
using System.Collections.Generic;

namespace GildedRose
{
    public class Program
    {
       public IList<Item> Items;
       static void Main(string[] args)
        {

           var app = new Program()
                          {
                              Items = new List<Item>
                                          {
                new Item { Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20 },
                new Item { Name = "Aged Brie", SellIn = 2, Quality = 0 },
                new Item { Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7 },
                new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80 },
                new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = -1, Quality = 80 },
                new Item{Name = "Backstage passes to a TAFKAL80ETC concert",SellIn = 15,Quality = 20},
                new Item{Name = "Backstage passes to a TAFKAL80ETC concert",SellIn = 10,Quality = 49},
                new Item{Name = "Backstage passes to a TAFKAL80ETC concert",SellIn = 5,Quality = 49},
				new Item { Name = "Conjured Mana Cake", SellIn = 3, Quality = 6 }
                                          }

                          };

           for (var i = 0; i < 31; i++)
            {
                Console.WriteLine("-------- day " + i + " --------");
                Console.WriteLine("name, sellIn, quality");
                foreach(Item items in app.Items)
                {
                    Console.WriteLine(items.Name + ", " + items.SellIn + ", " + items.Quality);
                }
                Console.WriteLine("");
                app.UpdateQuality();
            }
            

        }

        public virtual void UpdateQuality()
        {

            foreach(Item item in Items){
                 if(item.Quality < 0){
                    item.Quality = 0;
             } 
        bool isSulfuras=item.Name==("Sulfuras, Hand of Ragnaros");
                bool isAgedBrie=item.Name=="Aged Brie";
             if(isAgedBrie==true){
                item.Quality=item.Quality+1;
            if (item.SellIn <= 0) item.Quality++;
             }
             bool isBackstage=item.Name=="Backstage passes to a TAFKAL80ETC concert";
             if(isBackstage==true){
                item.Quality=item.Quality+1;
                if(item.SellIn<=10)item.Quality++;
                if(item.SellIn<=5)item.Quality++;
                if(item.SellIn<=0)item.Quality=0;
             }

            bool conjured=item.Name!.Contains("Conjured", StringComparison.OrdinalIgnoreCase);
            if(conjured==true){
                item.Quality -= 2;
            if (item.SellIn <= 0){ item.Quality -= 2;}
            }
             bool isNormalItem=!isAgedBrie && !isBackstage && !isSulfuras;
            if(isNormalItem==true){
                 if(item.Quality>0)item.Quality --;
                 if(item.SellIn>0)item.SellIn --;
                if (item.SellIn <= 0) item.Quality = item.Quality - 1;
                if(item.Quality<0)item.Quality=0;
                } 
            if(isSulfuras==true){
                if(item.Quality!=80){
                    item.Quality=80;
                }


            }else if(item.Quality>50){
                item.Quality=50;
            }
            }
            }
          
 
  

}
    }