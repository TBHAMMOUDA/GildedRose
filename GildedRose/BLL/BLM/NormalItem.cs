
namespace GildedRoseKata.BLL

{
    public class NormalItem :ProductFactoryHandler
    {
        public override void DayPass(Item item)
        {
            item.SellIn--;
            var cheks = ApplyCheks(item);
           
            if (cheks.SellInPassed)
                item.Quality -= 2;
            else
                item.Quality--;

            item.Quality = cheks.IsreachedMin ? 0 : item.Quality;
            item.Quality = cheks.IsreachedMax ? 50 : item.Quality;
        }

    }
}
