using System;

namespace EC
{
    public class SalesPromotionService
    {
        public string IsFathersDay()
        {
            DateTime today = GetToday();
            if (today.Month == 8 && today.Day == 8)
            {
                return "Is FathersDay";
            }
            return "Is Not FathersDay";
        }

        protected virtual DateTime GetToday()
        {
            return DateTime.Now;
        }
    }
}