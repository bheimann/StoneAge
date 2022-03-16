using System.Collections.Generic;
using NUnit.Framework;

namespace StoneAge.Core.Tests
{
    [TestFixture]
    public class HutTests
    {
        [Test]
        public void Nothing_paid_has_0_points()
        {
            var hut = new Hut();

            Assert.That(hut.PointsPaid, Is.EqualTo(0));
        }

        [Test]
        public void Given_1_wood_paid_is_worth_3_points()
        {
            var hut = new Hut();
            var resourcesUsed = new Dictionary<Resource, int>
            {
                { Resource.Wood, 1 },
            };
            hut.PayUsing(resourcesUsed);

            Assert.That(hut.PointsPaid, Is.EqualTo(3));
        }

        [Test]
        public void Given_6_wood_paid_is_worth_18_points()
        {
            var hut = new Hut();
            var resourcesUsed = new Dictionary<Resource, int>
            {
                { Resource.Wood, 6 },
            };
            hut.PayUsing(resourcesUsed);

            Assert.That(hut.PointsPaid, Is.EqualTo(18));
        }

        [Test]
        public void Given_1_clay_paid_is_worth_4_points()
        {
            var hut = new Hut();
            var resourcesUsed = new Dictionary<Resource, int>
            {
                { Resource.Clay, 1 },
            };
            hut.PayUsing(resourcesUsed);

            Assert.That(hut.PointsPaid, Is.EqualTo(4));
        }

        [Test]
        public void Given_3_clay_paid_is_worth_12_points()
        {
            var hut = new Hut();
            var resourcesUsed = new Dictionary<Resource, int>
            {
                { Resource.Clay, 3 },
            };
            hut.PayUsing(resourcesUsed);

            Assert.That(hut.PointsPaid, Is.EqualTo(12));
        }

        [Test]
        public void Given_1_stone_paid_is_worth_5_points()
        {
            var hut = new Hut();
            var resourcesUsed = new Dictionary<Resource, int>
            {
                { Resource.Stone, 1 },
            };
            hut.PayUsing(resourcesUsed);

            Assert.That(hut.PointsPaid, Is.EqualTo(5));
        }

        [Test]
        public void Given_2_stone_paid_is_worth_10_points()
        {
            var hut = new Hut();
            var resourcesUsed = new Dictionary<Resource, int>
            {
                { Resource.Stone, 2 },
            };
            hut.PayUsing(resourcesUsed);

            Assert.That(hut.PointsPaid, Is.EqualTo(10));
        }

        [Test]
        public void Given_1_gold_paid_is_worth_6_points()
        {
            var hut = new Hut();
            var resourcesUsed = new Dictionary<Resource, int>
            {
                { Resource.Gold, 1 },
            };
            hut.PayUsing(resourcesUsed);

            Assert.That(hut.PointsPaid, Is.EqualTo(6));
        }

        [Test]
        public void Given_7_gold_paid_is_worth_42_points()
        {
            var hut = new Hut();
            var resourcesUsed = new Dictionary<Resource, int>
            {
                { Resource.Gold, 7 },
            };
            hut.PayUsing(resourcesUsed);

            Assert.That(hut.PointsPaid, Is.EqualTo(42));
        }

        [Test]
        public void Given_1_of_each_is_worth_18_points()
        {
            var hut = new Hut();
            var resourcesUsed = new Dictionary<Resource, int>
            {
                { Resource.Wood, 1 },
                { Resource.Clay, 1 },
                { Resource.Stone, 1 },
                { Resource.Gold, 1 },
            };
            hut.PayUsing(resourcesUsed);

            Assert.That(hut.PointsPaid, Is.EqualTo(18));
        }
    }
}
