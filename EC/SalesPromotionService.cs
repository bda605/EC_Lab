using System;

namespace EC
{
    public class SalesPromotionService
    {
        public string IsFathersDay()
        {
            DateTime today = DateTime.Now;
            if (today.Month == 8 && today.Day == 8)
            {
                return "Is FathersDay";
            }
            return "Is Not FathersDay";
        }
    }
}