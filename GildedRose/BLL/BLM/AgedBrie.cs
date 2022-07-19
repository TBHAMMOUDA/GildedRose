

namespace GildedRoseKata.BLL
{
    public class AgedBrie : ProductFactoryHandler
    {

        public override void DayPass(Item item)
        {
            item.SellIn--;
            item.Quality++;
            var cheks = ApplyCheks(item);

            item.Quality = cheks.IsreachedMin ? 0 : item.Quality;
            item.Quality = cheks.IsreachedMax ? 50 : item.Quality;
        }
    }
}