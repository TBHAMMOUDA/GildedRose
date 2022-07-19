
namespace GildedRoseKata.BLL
{
    public class Check
    {
        private const int MaxQuality = 50;
        private const int MinQuality = 0;
        private const int _0Days = 0;
        private const int _5Days = 5;
        private const int _10Days = 10;
        public bool SellInPassed { get; set; }
        public bool IsLast5Days { get; set; }
        public bool IsLast10Days { get; set; }
        public bool IsreachedMin { get; set; }
        public bool IsreachedMax { get; set; }

        public Check(Item item)
        {
            SellInPassed = item.SellIn < _0Days;
            IsLast5Days = item.SellIn < _5Days+1;
            IsLast10Days = item.SellIn < _10Days + 1;
            IsreachedMin = item.Quality <= MinQuality;
            IsreachedMax = item.Quality > MaxQuality;
        }
    }  
}