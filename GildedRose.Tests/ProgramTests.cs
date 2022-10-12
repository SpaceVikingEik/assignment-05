namespace GildedRose.Tests;

public class ProgramTests
{
    [Fact]
    public void TestTheTruth()
    {
        true.Should().BeTrue();
    }

    [Fact]
    public void UpdateQualityTestOnBrieToSeeIncrease(){       
            var program = new Program(){
                Items=new List<Item>{new Item{Name="Aged Brie", SellIn=0, Quality=0}}
            };
            
            program.UpdateQuality();
           
            program.Items[0].Quality.Should().Be(2);
    }
    
    [Fact]
    public void AgedBrie2xFastafterSellIn(){
            var program=new Program(){
              Items=new List<Item>{new Item{Name="Aged Brie", SellIn=0, Quality=0}}

            };
            program.UpdateQuality();
            program.UpdateQuality();
            program.UpdateQuality();

            program.Items[0].SellIn.Should().Be(0);
            program.Items[0].Quality.Should().Be(6);   
    }

    [Fact]
    public void ItemNotZero(){
        var program=new Program(){
            Items=new List<Item>{new Item{Name="+5 Dexterity Vest", SellIn=60, Quality=-6}, new Item{Name="+5 Dexterity Vest", SellIn=40, Quality=0}}
        };
        program.UpdateQuality();

        program.Items[0].Quality.Should().Be(0);
        program.Items[1].Quality.Should().Be(0);

    }

    [Fact]
    public void ItemDegrades(){
         var program=new Program(){
            Items=new List<Item>{new Item{Name="+5 Dexterity Vest", SellIn=60, Quality=6}}
        };
        program.UpdateQuality();
        program.Items[0].Quality.Should().Be(5);

    }

    [Fact]
    public void LegendaryItemNoChange(){
        var program=new Program(){
            Items=new List<Item>{new Item{Name="Sulfuras, Hand of Ragnaros", SellIn=0, Quality=6}}
        };

        program.UpdateQuality();
        program.Items[0].Quality.Should().Be(80);


    }

    [Fact]
    public void BackstagePassIsZeroWhenSellInIsZero(){
          var program=new Program(){
            Items=new List<Item>{new Item{Name="Backstage passes to a TAFKAL80ETC concert", SellIn=0, Quality=6}}

        };

        program.UpdateQuality();
        program.Items[0].Quality.Should().Be(0);


    }

    [Fact]
    public void BackStagePassIncreaseQuality(){
           var program=new Program(){
            Items=new List<Item>{new Item{Name="Backstage passes to a TAFKAL80ETC concert", SellIn=10, Quality=6},new Item{Name="Backstage passes to a TAFKAL80ETC concert", SellIn=5, Quality=6}}

        };
        program.UpdateQuality();
        program.Items[0].Quality.Should().Be(8);
        program.Items[1].Quality.Should().Be(9);
    }

    [Fact]
    public void QualityIsNotMoreThan50(){
           var program=new Program(){
            Items=new List<Item>{new Item{Name="Backstage passes to a TAFKAL80ETC concert", SellIn=60, Quality=69}}

        };
        program.UpdateQuality();
        program.Items[0].Quality.Should().Be(50);
    }

    [Fact]
    public void LegendaryItemDoNotIncreaseSellIn(){
           var program=new Program(){
            Items=new List<Item>{new Item{Name="Sulfuras, Hand of Ragnaros", SellIn=0, Quality=50}}

        };
        program.UpdateQuality();
        program.Items[0].SellIn.Should().Be(0);
    }

   /* var program=new Program(){

        };*/

     [Fact]
    public void DegradingWontBecomeNegative(){
         var program=new Program(){
            Items=new List<Item>{new Item{Name="+5 Dexterity Vest", SellIn=60, Quality=-2}}
        };
        program.UpdateQuality();
        program.Items[0].Quality.Should().Be(0);

    }

         [Fact]
    public void BackstagePassIncrease(){
           var program=new Program(){
            Items=new List<Item>{new Item{Name="Backstage passes to a TAFKAL80ETC concert", SellIn=11, Quality=12}}

        };
        program.UpdateQuality();
        program.Items[0].Quality.Should().Be(13);
    }

     [Fact]
    public void OverSellInDegrade2x(){
         var program=new Program(){
            Items=new List<Item>{new Item{Name="+5 Dexterity Vest", SellIn=0, Quality=6}}
        };
        program.UpdateQuality();
        program.Items[0].Quality.Should().Be(4);

    }

    [Fact] 
    public void ConjuredDegreades2x(){
         var program=new Program(){
            Items=new List<Item>{new Item{Name="Conjured +5 Dexterity Vest", SellIn=60, Quality=9}}
        };
        program.UpdateQuality();
        program.Items[0].Quality.Should().Be(6);

    }

    [Fact] 
    public void Degreade2xWhenSellInHasPassed(){
         var program=new Program(){
            Items=new List<Item>{new Item{Name="Elixir of the Mongoose", SellIn=0, Quality=10}}
        };
        program.UpdateQuality();
        program.Items[0].Quality.Should().Be(8);

    }

    [Fact] 
    public void AgedBrieGetsHigherValue(){
         var program=new Program(){
            Items=new List<Item>{new Item{Name="Aged Brie", SellIn=0, Quality=10}}
        };
        program.UpdateQuality();
        program.Items[0].Quality.Should().Be(12);

    }
    
    [Fact] 
    public void ConjuredDegreades2xWithNegativeSellIn(){
         var program=new Program(){
            Items=new List<Item>{new Item{Name="Conjured Mana Cake", SellIn=-4, Quality=10}}
        };
        program.UpdateQuality();
        program.Items[0].Quality.Should().Be(4);

    }

     [Fact] 
    public void BackStageIncreseWith3IfUnder5(){
         var program=new Program(){
            Items=new List<Item>{new Item{Name="Backstage passes to a TAFKAL80ETC concert", SellIn=3, Quality=12}}
        };
        program.UpdateQuality();
        program.Items[0].Quality.Should().Be(15);

    }

     [Fact] 
    public void BackstageSellInis0ThenQualityIs0(){
         var program=new Program(){
            Items=new List<Item>{new Item{Name="Backstage passes to a TAFKAL80ETC concert", SellIn=0, Quality=12}}
        };
        program.UpdateQuality();
        program.Items[0].Quality.Should().Be(0);

    }


     [Fact] 
    public void MultipleUpdatedProjectsForConjured(){
         var program=new Program(){
            Items=new List<Item>{new Item{Name="Conjured Mana Cake", SellIn=3, Quality=40}}
        };
        for (int i = 0; i < 7; i++) program.UpdateQuality();
        program.Items[0].Quality.Should().Be(6);

    }
    
    [Fact] 
    public void MultipleUpdatedProjectsforSulfuras(){
         var program=new Program(){
            Items=new List<Item>{new Item{Name="Sulfuras, Hand of Ragnaros", SellIn=3, Quality=40}}
        };
        for (int i = 0; i < 10; i++) program.UpdateQuality();
        program.Items[0].Quality.Should().Be(80);

    }

     [Fact] 
    public void ConjuredDegreades2xWithNormalSellIn(){
         var program=new Program(){
            Items=new List<Item>{new Item{Name="Conjured Mana Cake", SellIn=20, Quality=10}}
        };
        program.UpdateQuality();
        program.Items[0].Quality.Should().Be(7);

    }

     [Fact] 
    public void BackstagePassDontGoOver50(){
         var program=new Program(){
            Items=new List<Item>{new Item{Name="Backstage passes to a TAFKAL80ETC concert", SellIn=3, Quality=50}}
        };
        program.UpdateQuality();
        program.Items[0].Quality.Should().Be(50);

    }

     [Fact] 
    public void BackstageIncreasesNormally(){
         var program=new Program(){
            Items=new List<Item>{new Item{Name="Backstage passes to a TAFKAL80ETC concert", SellIn=25, Quality=12}}
        };
        program.UpdateQuality();
        program.Items[0].Quality.Should().Be(13);

    }


     [Fact] 
    public void NormalAgedBrie(){
         var program=new Program(){
            Items=new List<Item>{new Item{Name="Aged Brie", SellIn=5, Quality=12}}
        };
        program.UpdateQuality();
        program.Items[0].Quality.Should().Be(13);

    }

     [Fact] 
    public void DoNotGoUnder0WhenDegrading(){
         var program=new Program(){
            Items=new List<Item>{new Item{Name="Elixir of the Mongoose", SellIn=0, Quality=0}}
        };
        program.UpdateQuality();
        program.Items[0].Quality.Should().Be(0);

    }

    [Fact] 
    public void AgedBrieDontGoOver50(){
         var program=new Program(){
            Items=new List<Item>{new Item{Name="Aged Brie", SellIn=0, Quality=50}}
        };
        program.UpdateQuality();
        program.Items[0].Quality.Should().Be(50);

    }
}