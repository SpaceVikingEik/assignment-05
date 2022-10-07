using GildedRose;
namespace GildedRose.Tests;

public class ProgramTests
{
    [Fact]
    public void TestBrieAfterOneDayQualityIncreases()
    {
        var app = new Program()
        {
            Items = new List<Item> { new BrieItem() { Name = "Aged Brie", SellIn = 2, Quality = 0 } }
        };

        app.UpdateQuality();
        var item = app.Items.FirstOrDefault();
        item!.Quality.Should().Be(1);
        item.SellIn.Should().Be(1);
    }

    [Fact]
    public void TestBrieAfterOneDayQualityIncreasesBy2WhenUnder0()
    {
        var app = new Program()
        {
            Items = new List<Item> { new BrieItem() { Name = "Aged Brie", SellIn = 0, Quality = 0 } }
        };

        app.UpdateQuality();
        var item = app.Items.FirstOrDefault();
        item!.Quality.Should().Be(2);
        item.SellIn.Should().Be(-1);
    }

    [Fact]
    public void TestBrieQualityNeverMoreThan50()
    {
        var app = new Program()
        {
            Items = new List<Item> { new BrieItem() { Name = "Aged Brie", SellIn = 2, Quality = 50 } }
        };

        app.UpdateQuality();
        var item = app.Items.FirstOrDefault();
        item!.Quality.Should().Be(50);
        item.SellIn.Should().Be(1);
    }

    [Fact]
    public void TestDexterityAfter2DayswhereSellsDateHasPassed()
    {
        var app = new Program()
        {
            Items = new List<Item> { new Item { Name = "+5 Dexterity Vest", SellIn = 0, Quality = 20 } }
        };

        app.UpdateQuality();
        app.UpdateQuality();
        var item = app.Items.FirstOrDefault();
        item!.Quality.Should().Be(16);
        item.SellIn.Should().Be(-2);
    }

    [Fact]
    public void TestDexterityQualityNeverNegative()
    {
        var app = new Program()
        {
            Items = new List<Item> { new Item { Name = "+5 Dexterity Vest", SellIn = 0, Quality = 1 } }
        };

        app.UpdateQuality();
        app.UpdateQuality();
        app.UpdateQuality();
        var item = app.Items.FirstOrDefault();
        item!.Quality.Should().Be(0);
        item.SellIn.Should().Be(-3);
    }


    [Fact]
    public void TestSulfurasDoesntChangeQualityOrSellIn()
    {
        var app = new Program()
        {
            Items = new List<Item> { new SulfurasItem { Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80 } }
        };

        app.UpdateQuality();
        app.UpdateQuality();
        app.UpdateQuality();
        var item = app.Items.FirstOrDefault();
        item!.Quality.Should().Be(80);
        item.SellIn.Should().Be(0);
    }

    [Fact]
    public void TestBackstagepassesQualityIncreaseByWhenLessThan5DaysLeft()
    {
        var app = new Program()
        {
            Items = new List<Item> { new BackstagePassItem
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 5,
                    Quality = 20
                }
        }};

        app.UpdateQuality();
        app.UpdateQuality();
        var item = app.Items.FirstOrDefault();
        item!.Quality.Should().Be(26);
        item.SellIn.Should().Be(3);
    }

    [Fact]
    public void TestBackstagepassesQualityChangesTo0WhenConcertIsOver()
    {
        var app = new Program()
        {
            Items = new List<Item> { new BackstagePassItem
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 1,
                    Quality = 20
                }
        }};

        app.UpdateQuality();
        app.UpdateQuality();
        var item = app.Items.FirstOrDefault();
        item!.Quality.Should().Be(0);
        item.SellIn.Should().Be(-1);
    }

    [Fact]
    public void TestConjured()
    {
        var app = new Program()
        {
            Items = new List<Item> { new ConjuredItem
                {
                    Name = "conjured",
                    SellIn = 2,
                    Quality = 20
                }
        }};

        app.UpdateQuality();
        var item = app.Items.FirstOrDefault();
        item!.Quality.Should().Be(18);
        item.SellIn.Should().Be(1);
    }

    [Fact]
    public void TestConjuredSellinBelow0()
    {
        var app = new Program()
        {
            Items = new List<Item> { new ConjuredItem
                {
                    Name = "conjured",
                    SellIn = 0,
                    Quality = 20
                }
        }};

        app.UpdateQuality();
        app.UpdateQuality();
        var item = app.Items.FirstOrDefault();
        item!.Quality.Should().Be(12);
        item.SellIn.Should().Be(-2);
    }
}  