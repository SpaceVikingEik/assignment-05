using System.Text;
namespace GildedRose.Tests;

public class ProgramTests
{
    [Fact]
    public void NormalItemItemDegration()
    {
        Program Program = new Program();
        Program.Items = new List<Item>();
        var Item = new NormalItem { Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20 };
        Program.Items.Add(Item);


        Program.Items[0].UpdateQuality();


        Assert.Equal(19, Program.Items[0].Quality);
    }

    [Fact]
    public void NormalItemItemDegrationAfterSelinDateHasPassed()
    {
        Program Program = new Program();
        Program.Items = new List<Item>();
        var Item = new NormalItem { Name = "+5 Dexterity Vest", SellIn = 0, Quality = 20 };
        Program.Items.Add(Item);


        Program.Items[0].UpdateQuality();


        Assert.Equal(18, Program.Items[0].Quality);
    }

    [Fact]
    public void QualityNeverFallsBelowZero()
    {
        Program Program = new Program();
        Program.Items = new List<Item>();
        var Item = new NormalItem { Name = "+5 Dexterity Vest", SellIn = 0, Quality = 1 };
        Program.Items.Add(Item);


        Program.Items[0].UpdateQuality();


        Assert.Equal(0, Program.Items[0].Quality);
    }
    [Fact]
    public void BrieRisesInQuality()
    {
        Program Program = new Program();
        Program.Items = new List<Item>();
        var Item = new CheeseItem { Name = "Aged Brie", SellIn = 5, Quality = 10 };
        Program.Items.Add(Item);


        Program.Items[0].UpdateQuality();


        Assert.Equal(11, Program.Items[0].Quality);
    }
    [Fact]
    public void BrieRisesInQualityWhenSellinPassed()
    {
        Program Program = new Program();
        Program.Items = new List<Item>();
        var Item = new CheeseItem { Name = "Aged Brie", SellIn = 0, Quality = 10 };
        Program.Items.Add(Item);


        Program.Items[0].UpdateQuality();


        Assert.Equal(12, Program.Items[0].Quality);
    }

    [Fact]
    public void TicketsRisesInQuality()
    {
        Program Program = new Program();
        Program.Items = new List<Item>();
        var Item = new TicketItem { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 20, Quality = 10 };
        Program.Items.Add(Item);


        Program.Items[0].UpdateQuality();


        Assert.Equal(11, Program.Items[0].Quality);
    }

    [Fact]
    public void TicketsRisesInQualityOver50()
    {
        Program Program = new Program();
        Program.Items = new List<Item>();
        var Item = new TicketItem { Name = "Aged Brie", SellIn = 5, Quality = 50 };
        Program.Items.Add(Item);


        Program.Items[0].UpdateQuality();


        Assert.Equal(50, Program.Items[0].Quality);
    }
    [Fact]

    public void TicketsRisesInQualityFastly()
    {
        Program Program = new Program();
        Program.Items = new List<Item>();
        var Item = new TicketItem { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 10, Quality = 10 };
        Program.Items.Add(Item);


        Program.Items[0].UpdateQuality();


        Assert.Equal(12, Program.Items[0].Quality);

    }


    [Fact]

    public void TicketsRisesInQualityFastest()
    {
        Program Program = new Program();
        Program.Items = new List<Item>();
        var Item = new TicketItem { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 5, Quality = 10 };
        Program.Items.Add(Item);


        Program.Items[0].UpdateQuality();


        Assert.Equal(13, Program.Items[0].Quality);
    }

    [Fact]
    public void TicketsBecomeWorthless()
    {
        Program Program = new Program();
        Program.Items = new List<Item>();
        var Item = new TicketItem { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 0, Quality = 10 };
        Program.Items.Add(Item);


        Program.Items[0].UpdateQuality();


        Assert.Equal(0, Program.Items[0].Quality);
    }

    [Fact]
    public void SulfarasIsAlways80Quality()
    {
        Program Program = new Program();
        Program.Items = new List<Item>();
        var Item = new LegendaryItem { Name = "Sulfuras, Hand of Ragnaros", SellIn = 5, Quality = 75 };
        Program.Items.Add(Item);


        Program.Items[0].UpdateQuality();


        Assert.Equal(80, Program.Items[0].Quality);
    }

    [Fact]
    public void SulfarasNeverApproachesSellinDate()
    {
        Program Program = new Program();
        Program.Items = new List<Item>();
        var Item = new LegendaryItem { Name = "Sulfuras, Hand of Ragnaros", SellIn = 1, Quality = 80 };
        Program.Items.Add(Item);


        Program.Items[0].UpdateQuality();


        Assert.Equal(1, Program.Items[0].SellIn);
    }

        [Fact]
    public void ConjuredQualityFallsFast()
    {
        Program Program = new Program();
        Program.Items = new List<Item>();
        var Item = new ConjuredItem { Name = "Conjured Mana Cake", SellIn = 2, Quality = 10 };
        Program.Items.Add(Item);


        Program.Items[0].UpdateQuality();


        Assert.Equal(8, Program.Items[0].Quality);
    }

        [Fact]
    public void ConjuredQualityFallsFastly()
    {
        Program Program = new Program();
        Program.Items = new List<Item>();
        var Item = new ConjuredItem { Name = "Conjured Mana Cake", SellIn = 0, Quality = 10 };
        Program.Items.Add(Item);


        Program.Items[0].UpdateQuality();


        Assert.Equal(6, Program.Items[0].Quality);
    }


}