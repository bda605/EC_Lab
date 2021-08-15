using EC;
using NUnit.Framework;
using System;

namespace ECTest
{
    public class SalesPromotionServiceTest
    {

        private FakeSalesPromotionService _fakeSalesPromotionService = new FakeSalesPromotionService();

        [Test]
        public void Today_Is_FathersDay()
        {
            GevinToday(8, 8);
            SayFathersDayShouldResponse("Is FathersDay");
        }

        [Test]
        public void Today_IsNot_FathersDay()
        {
            GevinToday(8, 7);
            SayFathersDayShouldResponse("Is Not FathersDay");
        }

        private void GevinToday(int month,int day)
        {
            _fakeSalesPromotionService.SetToday(new DateTime(2020, month, day));
        }

        private void SayFathersDayShouldResponse(string expected)
        {
            Assert.AreEqual(expected, _fakeSalesPromotionService.IsFathersDay());
        }
        internal class FakeSalesPromotionService : SalesPromotionService
        {
            private DateTime _today;

            internal void SetToday(DateTime today) 
            {
                _today = today;
            }

            protected override DateTime GetToday()
            {
                return _today;
            }
        }
    }
}