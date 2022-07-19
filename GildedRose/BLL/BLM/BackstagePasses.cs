
namespace GildedRoseKata.BLL
{
    public class BackstagePasses : ProductFactoryHandler
    {



        public override void DayPass(Item item)
        {
            item.SellIn--;
            var cheks = ApplyCheks(item);

            if (cheks.SellInPassed)
            {
                item.Quality = 0;
            }
            else if (cheks.IsLast5Days)
            {
                item.Quality += 3;
            }
            else if (cheks.IsLast10Days)
            {
                item.Quality += 2;
            }
            else
            {
                item.Quality++;
            }

            item.Quality = cheks.IsreachedMin ? 0 : item.Quality;
            item.Quality = cheks.IsreachedMax ? 50 : item.Quality;

        }
    }
}
