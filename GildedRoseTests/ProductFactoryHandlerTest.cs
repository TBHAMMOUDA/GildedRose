using Xunit;
using System.Collections.Generic;
using GildedRoseKata;
using System.Linq;
using GildedRoseKata.BLL;

namespace GildedRoseTests
{
    public class ProductFactoryHandlerTest
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
        public void TestDayPassForNormal()
        {
            var agedItem = Items[0];
            var instance = ProductFactoryHandler.GetPorductInstanceHandler(agedItem);
            instance.DayPass(agedItem);

            Assert.Equal("+5 Dexterity Vest", agedItem.Name);
            Assert.Equal(9, agedItem.SellIn);
            Assert.Equal(19, agedItem.Quality);
        }

        [Fact]
        public void TestDayPassForBrie()
        {
            var agedItem = Items[1];
            var instance = ProductFactoryHandler.GetPorductInstanceHandler(agedItem);
            instance.DayPass(agedItem);

            Assert.Equal("Aged Brie", agedItem.Name);
            Assert.Equal(1, agedItem.SellIn);
            Assert.Equal(1, agedItem.Quality);
        }
        [Fact]
        public void TestDayPassForSulfuras()
        {
            var agedItem = Items[3];
            var instance = ProductFactoryHandler.GetPorductInstanceHandler(agedItem);
            instance.DayPass(agedItem);

            Assert.Equal("Sulfuras, Hand of Ragnaros", agedItem.Name);
            Assert.Equal(0, agedItem.SellIn);
            Assert.Equal(80, agedItem.Quality);
        }
        [Fact]
        public void TestDayPassForBackstagePasses()
        {
            var agedItem = Items[4];
            var instance = ProductFactoryHandler.GetPorductInstanceHandler(agedItem);
            instance.DayPass(agedItem);

            Assert.Equal("Backstage passes to a TAFKAL80ETC concert", agedItem.Name);
            Assert.Equal(14, agedItem.SellIn);
            Assert.Equal(21, agedItem.Quality);
        }
        [Fact]
        public void TestConjuredAgeByDay()
        {
            var agedItem = Items[5];
            var instance = ProductFactoryHandler.GetPorductInstanceHandler(agedItem);
            instance.DayPass(agedItem);

            Assert.Equal("Conjured Mana Cake", agedItem.Name);
            Assert.Equal(2, agedItem.SellIn);
            Assert.Equal(4, agedItem.Quality);
        }

    }
}
