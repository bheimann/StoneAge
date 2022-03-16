using NUnit.Framework;

namespace StoneAge.Core.Tests
{
    [TestFixture]
    public class PlayerTests
    {
        [Test]
        public void No_tools_is_0()
        {
            var player = new Player();

            Assert.That(player.CombinedToolValue, Is.EqualTo(0));
        }

        [Test]
        public void Tool1_with_value_1_is_1()
        {
            var player = new Player
            {
                Tool1 = new Tool { Value = 1 },
            };

            Assert.That(player.CombinedToolValue, Is.EqualTo(1));
        }

        [Test]
        public void Tool2_with_value_1_is_1()
        {
            var player = new Player
            {
                Tool2 = new Tool { Value = 1 },
            };

            Assert.That(player.CombinedToolValue, Is.EqualTo(1));
        }

        [Test]
        public void Tool3_with_value_1_is_1()
        {
            var player = new Player
            {
                Tool3 = new Tool { Value = 1 },
            };

            Assert.That(player.CombinedToolValue, Is.EqualTo(1));
        }

        [Test]
        public void Multiple_tools_with_value_3_is_9()
        {
            var player = new Player
            {
                Tool1 = new Tool { Value = 3 },
                Tool2 = new Tool { Value = 3 },
                Tool3 = new Tool { Value = 3 },
            };

            Assert.That(player.CombinedToolValue, Is.EqualTo(9));
        }
    }
}
