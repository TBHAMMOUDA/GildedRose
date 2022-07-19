using GildedRoseKata.DAL;
using System;

namespace GildedRoseKata.BLL
{
    public class ProductFactoryHandler
    {
        public virtual void DayPass(Item item)
        {
            throw new Exception($"Unknown Item Type {item.Name}");
        }
        public Check ApplyCheks(Item item)
        {
            return new Check(item);
        }
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

        //use GetPorductInstanceHandler method to get object of product handler
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

