using NUnit.Framework;

namespace StoneAge.Core.Tests
{
    [TestFixture]
    public class ScoreCalculatorTests
    {
        private ScoreCalculator _scoreCalculator;

        [SetUp]
        public void Setup()
        {
            _scoreCalculator = new ScoreCalculator();
        }

        [Test]
        public void Player_with_0_cards_and_0_tiles_has_0_points()
        {
            var player = new Player();

            var playerScore = _scoreCalculator.Score(player);

            Assert.That(playerScore, Is.EqualTo(0));
        }
    }
}
