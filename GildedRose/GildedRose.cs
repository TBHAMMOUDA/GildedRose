using GildedRoseKata.BLL;
using System.Collections.Generic;

namespace GildedRoseKata
{
    public class GildedRose
    {
        public IList<Item> Items;
        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality()
        {
            foreach (Item item in Items)
            {
                ProductFactoryHandler.GetPorductInstanceHandler(item).DayPass(item);
            }
        }
    }
}
