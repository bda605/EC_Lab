using System;

namespace EC
{
    public class SalesPromotionService
    {
        private DateTime _today;
        public SalesPromotionService(DateTime today)
        {
            _today = today;
        }
        /// <summary>
        ///練習題：電商活動 爸爸節促銷活動，檢查是否為爸爸節
        /// </summary>
        /// <returns></returns>
        public string IsFathersDay()
        {
            DateTime today = _today;
            if (today.Month == 8 && today.Day == 8)
            {
                return "Is FathersDay";
            }
            return "Is Not FathersDay";
        }
    }
}