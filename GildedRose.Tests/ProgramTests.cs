using System.Text;
namespace GildedRose.Tests;

public class ProgramTests
{
    [Fact]
    public void TestItemCreation()
    {
        Program Program = new Program();
        var Item = new Item { Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20 };
        Program.Items = new List<Item>();


        Program.Items.Add(Item);

        Assert.Equal(1, Program.Items.Count);
    }

    [Fact]
    public void TestNormalItemDegration()
    {
        Program Program = new Program();
        Program.Items = new List<Item>();
        var Item = new Item { Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20 };
        Program.Items.Add(Item);


        Program.UpdateQuality();


        Assert.Equal(19, Program.Items[0].Quality);
    }

    [Fact]
    public void TestNormalItemDegrationAfterSelinDateHasPassed()
    {
        Program Program = new Program();
        Program.Items = new List<Item>();
        var Item = new Item { Name = "+5 Dexterity Vest", SellIn = 0, Quality = 20 };
        Program.Items.Add(Item);


        Program.UpdateQuality();


        Assert.Equal(18, Program.Items[0].Quality);
    }

    [Fact]
    public void TestQualityNeverFallsBelowZero()
    {
        Program Program = new Program();
        Program.Items = new List<Item>();
        var Item = new Item { Name = "+5 Dexterity Vest", SellIn = 0, Quality = 1 };
        Program.Items.Add(Item);


        Program.UpdateQuality();


        Assert.Equal(0, Program.Items[0].Quality);
    }
    [Fact]
    public void TestThatBrieRisesInQuality()
    {
        Program Program = new Program();
        Program.Items = new List<Item>();
        var Item = new Item { Name = "Aged Brie", SellIn = 5, Quality = 10 };
        Program.Items.Add(Item);


        Program.UpdateQuality();


        Assert.Equal(11, Program.Items[0].Quality);
    }
    [Fact]
    public void TestThatBrieRisesInQualityWhenSelinPassed()
    {
        Program Program = new Program();
        Program.Items = new List<Item>();
        var Item = new Item { Name = "Aged Brie", SellIn = 0, Quality = 10 };
        Program.Items.Add(Item);


        Program.UpdateQuality();


        Assert.Equal(12, Program.Items[0].Quality);
    }

    [Fact]
    public void TestThatTicketsRisesInQuality()
    {
        Program Program = new Program();
        Program.Items = new List<Item>();
        var Item = new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 20, Quality = 10 };
        Program.Items.Add(Item);


        Program.UpdateQuality();


        Assert.Equal(11, Program.Items[0].Quality);
    }

    [Fact]
    public void TestThatTicketsRisesInQualityOver50()
    {
        Program Program = new Program();
        Program.Items = new List<Item>();
        var Item = new Item { Name = "Aged Brie", SellIn = 5, Quality = 50 };
        Program.Items.Add(Item);


        Program.UpdateQuality();


        Assert.Equal(50, Program.Items[0].Quality);
    }
    [Fact]

    public void TestThatTicketsRisesInQualityFastly()
    {
        Program Program = new Program();
        Program.Items = new List<Item>();
        var Item = new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 10, Quality = 10 };
        Program.Items.Add(Item);


        Program.UpdateQuality();


        Assert.Equal(12, Program.Items[0].Quality);

    }


    [Fact]

    public void TestThatTicketsRisesInQualityFastest()
    {
        Program Program = new Program();
        Program.Items = new List<Item>();
        var Item = new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 5, Quality = 10 };
        Program.Items.Add(Item);


        Program.UpdateQuality();


        Assert.Equal(13, Program.Items[0].Quality);
    }

    [Fact]
    public void TestThatTicketsBecomeWorthless()
    {
        Program Program = new Program();
        Program.Items = new List<Item>();
        var Item = new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 0, Quality = 10 };
        Program.Items.Add(Item);


        Program.UpdateQuality();


        Assert.Equal(0, Program.Items[0].Quality);
    }

    [Fact]
    public void TestSulfarasNeverFallsInQuality()
    {
        Program Program = new Program();
        Program.Items = new List<Item>();
        var Item = new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 5, Quality = 10 };
        Program.Items.Add(Item);


        Program.UpdateQuality();


        Assert.Equal(10, Program.Items[0].Quality);
    }

    [Fact]
    public void TestSulfarasNeverApproachesSellinDate()
    {
        Program Program = new Program();
        Program.Items = new List<Item>();
        var Item = new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 1, Quality = 10 };
        Program.Items.Add(Item);


        Program.UpdateQuality();


        Assert.Equal(1, Program.Items[0].SellIn);
    }



}