using GildedRoseKata.DAL;
using System;

namespace GildedRoseKata.BLL
{
    public class ProductFactoryHandler
    {
        /// <summary>
        ///  this method is for overriding in any class tha inherit form ProductFactoryHandler
        ///  implement the update inventory logic with one day passing of each ProductCategoriy
        /// </summary>
        /// <param name="item"></param>
        public virtual void DayPass(Item item)
        {
            throw new Exception($"Unknown Item Type {item.Name}");
        }

        /// <summary>
        ///  Used to check all the rules applied on an item
        /// </summary>
        /// <param name="item"></param>
        /// <returns>Check</returns>
        public Check ApplyCheks(Item item)
        {
            return new Check(item);
        }

        /// <summary>
        ///  Used to get object of ProductCategoriyEnum based on ProductCategoriyEnum the item.Name
        /// </summary>
        /// <param name="item"></param>
        /// <returns>ProductCategoriyEnum</returns>
        public static ProductCategoriyEnum GetCategory(Item item)
        {
            if (item.Name.Equals("Aged Brie"))
                return ProductCategoriyEnum.AgedBrie;
            else if (item.Name.Equals("Backstage passes to a TAFKAL80ETC concert"))
                return ProductCategoriyEnum.BackstagePasses;
            else if (item.Name.Equals("Sulfuras, Hand of Ragnaros"))
                return ProductCategoriyEnum.LegendaryItem;
            else if (item.Name.Equals("Conjured Mana Cake"))
                return ProductCategoriyEnum.ConjuredItem;
            else
                return ProductCategoriyEnum.NormalItem;
        }


        /// <summary>
        ///  Used to get object of ProductFactoryHandler that handel prodect instentiation based on ProductCategoriyEnum
        /// </summary>
        /// <param name="item"></param>
        /// <returns>ProductFactoryHandler</returns>
        public static ProductFactoryHandler GetPorductInstanceHandler(Item item)
        {
            if (GetCategory(item) == ProductCategoriyEnum.AgedBrie)
            {
                return new AgedBrie();

            }
            else if (GetCategory(item) == ProductCategoriyEnum.BackstagePasses)
            {
                return new BackstagePasses();

            }
            else if (GetCategory(item) == ProductCategoriyEnum.LegendaryItem)
            {
                return new LegendaryItem();
            }
            else if (GetCategory(item) == ProductCategoriyEnum.ConjuredItem)
            {
                return new ConjuredItem();
            }
            else if (GetCategory(item) == ProductCategoriyEnum.NormalItem)
            {
                return new NormalItem();
            }

            return null;
        }
    }
}

