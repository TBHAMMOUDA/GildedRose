using GildedRoseKata.BLL;
using System.Collections.Generic;

namespace GildedRoseKata
{
    public class GildedRose
    {
        public IList<Item> Items;

        /// <summary>
        ///  GildedRose constractor that initiate data
        /// </summary>
        /// <param name="Items"></param>
        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        /// <summary>
        ///  Updates inventory for all products with one day passing
        /// </summary>
        public void UpdateQuality()
        {
            foreach (Item item in Items)
            {
                ProductFactoryHandler.GetPorductInstanceHandler(item).DayPass(item);
            }
        }
    }
}
