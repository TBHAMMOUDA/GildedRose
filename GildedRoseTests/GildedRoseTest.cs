using Xunit;
using System.Collections.Generic;
using GildedRoseKata;
using System.Linq;

namespace GildedRoseTests
{
    public class GildedRoseTest
    {
        List<Item> Items = new List<Item>
                        {
                                new Item { Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20 },
                                new Item { Name = "Aged Brie", SellIn = 2, Quality = 0 },
                                new Item { Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7 },
                                new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80 },
                                new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 15,Quality = 20 },
                                //this conjured item does not work properly yet
                                new Item {Name = "Conjured Mana Cake", SellIn = 3, Quality = 6},
                        };


        [Fact]
        public void TestWhatTheAppDoesInOneDay()
        {
            var app = new GildedRose(Items);
            app.UpdateQuality();

            Assert.Equal("+5 Dexterity Vest", Items[0].Name);
            Assert.Equal(9, Items[0].SellIn);
            Assert.Equal(19, Items[0].Quality);

            Assert.Equal("Aged Brie", Items[1].Name);
            Assert.Equal(1, Items[1].SellIn);
            Assert.Equal(1, Items[1].Quality);

            Assert.Equal("Elixir of the Mongoose", Items[2].Name);
            Assert.Equal(4, Items[2].SellIn);
            Assert.Equal(6, Items[2].Quality);

            Assert.Equal("Sulfuras, Hand of Ragnaros", Items[3].Name);
            Assert.Equal(0, Items[3].SellIn);
            Assert.Equal(80, Items[3].Quality);


            Assert.Equal("Backstage passes to a TAFKAL80ETC concert", Items[4].Name);
            Assert.Equal(14, Items[4].SellIn);
            Assert.Equal(21, Items[4].Quality);

            Assert.Equal("Conjured Mana Cake", Items[5].Name);
            Assert.Equal(2, Items[5].SellIn);
            Assert.Equal(4, Items[5].Quality);

        }




        [Fact]
        public void TestWhatTheAppDoesIn2Days()
        {
            var app = new GildedRose(Items);
            app.UpdateQuality();
            app.UpdateQuality();


            Assert.Equal("+5 Dexterity Vest", Items[0].Name);
            Assert.Equal(8, Items[0].SellIn);
            Assert.Equal(18, Items[0].Quality);

            Assert.Equal("Aged Brie", Items[1].Name);
            Assert.Equal(0, Items[1].SellIn);
            Assert.Equal(2, Items[1].Quality);

            Assert.Equal("Elixir of the Mongoose", Items[2].Name);
            Assert.Equal(3, Items[2].SellIn);
            Assert.Equal(5, Items[2].Quality);

            Assert.Equal("Sulfuras, Hand of Ragnaros", Items[3].Name);
            Assert.Equal(0, Items[3].SellIn);
            Assert.Equal(80, Items[3].Quality);


            Assert.Equal("Backstage passes to a TAFKAL80ETC concert", Items[4].Name);
            Assert.Equal(13, Items[4].SellIn);
            Assert.Equal(22, Items[4].Quality);

            Assert.Equal("Conjured Mana Cake", Items[5].Name);
            Assert.Equal(1, Items[5].SellIn);
            Assert.Equal(2, Items[5].Quality);

        }

        [Fact]
        public void TestWhatTheAppDoesIn16Days()
        {
            var app = new GildedRose(Items);
            Enumerable.Range(0, 16).ToList().ForEach(x => {
                app.UpdateQuality();
            });

            Assert.Equal("+5 Dexterity Vest", Items[0].Name);
            Assert.Equal(-6, Items[0].SellIn);
            Assert.Equal(0, Items[0].Quality);

            Assert.Equal("Aged Brie", Items[1].Name);
            Assert.Equal(-14, Items[1].SellIn);
            Assert.Equal(16, Items[1].Quality);

            Assert.Equal("Elixir of the Mongoose", Items[2].Name);
            Assert.Equal(-11, Items[2].SellIn);
            Assert.Equal(0, Items[2].Quality);

            Assert.Equal("Sulfuras, Hand of Ragnaros", Items[3].Name);
            Assert.Equal(0, Items[3].SellIn);
            Assert.Equal(80, Items[3].Quality);

            Assert.Equal("Backstage passes to a TAFKAL80ETC concert", Items[4].Name);
            Assert.Equal(-1, Items[4].SellIn);
            Assert.Equal(50, Items[4].Quality);

            Assert.Equal("Conjured Mana Cake", Items[5].Name);
            Assert.Equal(-13, Items[5].SellIn);
            Assert.Equal(0, Items[5].Quality);

        }


        [Fact]
        public void TestDayPassForNormal()
        {
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();


            Assert.Equal("+5 Dexterity Vest", Items[0].Name);
            Assert.Equal(9, Items[0].SellIn);
            Assert.Equal(19, Items[0].Quality);
        }

        [Fact]
        public void TestDayPassForBrie()
        {
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();

            Assert.Equal("Aged Brie", Items[1].Name);
            Assert.Equal(1, Items[1].SellIn);
            Assert.Equal(1, Items[1].Quality);
        }

        [Fact]
        public void TestDayPassForSulfuras()
        {
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();

            Assert.Equal("Sulfuras, Hand of Ragnaros", Items[3].Name);
            Assert.Equal(0, Items[3].SellIn);
            Assert.Equal(80, Items[3].Quality);
        }
        [Fact]
        public void TestDayPassForBackstagePasses()
        {
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();

            Assert.Equal("Backstage passes to a TAFKAL80ETC concert", Items[4].Name);
            Assert.Equal(14, Items[4].SellIn);
            Assert.Equal(21, Items[4].Quality);
        }
        [Fact]
        public void TestConjuredAgeByDay()
        {
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();

            Assert.Equal("Conjured Mana Cake", Items[5].Name);
            Assert.Equal(2, Items[5].SellIn);
            Assert.Equal(4, Items[5].Quality);
        }
    }
}
