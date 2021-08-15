using EC;
using NUnit.Framework;
using System;
namespace ECTest
{
    public class SalesPromotionServiceTest
    {

        [Test]
        public void Today_Is_FahtersDay()
        {
            var salesPromotion = new SalesPromotionService(new DateTime(2020,8,8));
            Assert.AreEqual("Is FathersDay", salesPromotion.IsFathersDay());
        }

        [Test]
        public void Today_IsNot_FahtersDay()
        {
            var salesPromotion = new SalesPromotionService(new DateTime(2020,8,7));
            Assert.AreEqual("Is Not FathersDay", salesPromotion.IsFathersDay());
        }
    }
}