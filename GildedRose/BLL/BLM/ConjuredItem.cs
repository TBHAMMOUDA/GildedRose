
namespace GildedRoseKata.BLL

{
    public class ConjuredItem : ProductFactoryHandler
    {

        public override void DayPass(Item item)
        {
            item.SellIn--;
            var cheks = ApplyCheks(item);
            if (cheks.IsreachedMin)
            {
                item.Quality = 0;
            }
            else if (cheks.IsreachedMax)
            {
                item.Quality = 50;

            }
            else if (cheks.SellInPassed)
                item.Quality -= 4;
            else
                item.Quality-=2;

            item.Quality = cheks.IsreachedMin ? 0 : item.Quality;
            item.Quality = cheks.IsreachedMax ? 50 : item.Quality;
        }
    }
        
}
