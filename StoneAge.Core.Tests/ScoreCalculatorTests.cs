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

        [Test]
        public void Player_with_1_green_cards_has_1_points()
        {
            var player = new Player();
            player.CivilizationCards.Add(new CivilizationCard { CardTop = CardTop.ThreeFood, CardBottom = CardBottom.GreenArt });

            var playerScore = _scoreCalculator.Score(player);

            Assert.That(playerScore, Is.EqualTo(1));
        }

        [Test]
        public void Player_with_2_unique_green_cards_has_4_points()
        {
            var player = new Player();
            player.CivilizationCards.Add(new CivilizationCard { CardTop = CardTop.ThreeFood, CardBottom = CardBottom.GreenArt });
            player.CivilizationCards.Add(new CivilizationCard { CardTop = CardTop.ThreeFood, CardBottom = CardBottom.GreenMusic });

            var playerScore = _scoreCalculator.Score(player);

            Assert.That(playerScore, Is.EqualTo(4));
        }

        [Test]
        public void Player_with_5_unique_green_cards_has_25_points()
        {
            var player = new Player();
            player.CivilizationCards.Add(new CivilizationCard { CardTop = CardTop.ThreeFood, CardBottom = CardBottom.GreenArt });
            player.CivilizationCards.Add(new CivilizationCard { CardTop = CardTop.ThreeFood, CardBottom = CardBottom.GreenMusic });
            player.CivilizationCards.Add(new CivilizationCard { CardTop = CardTop.ThreeFood, CardBottom = CardBottom.GreenTime });
            player.CivilizationCards.Add(new CivilizationCard { CardTop = CardTop.ThreeFood, CardBottom = CardBottom.GreenTransport });
            player.CivilizationCards.Add(new CivilizationCard { CardTop = CardTop.ThreeFood, CardBottom = CardBottom.GreenWeaving });

            var playerScore = _scoreCalculator.Score(player);

            Assert.That(playerScore, Is.EqualTo(25));
        }

        [Test]
        public void Player_with_8_unique_green_cards_has_64_points()
        {
            var player = new Player();
            player.CivilizationCards.Add(new CivilizationCard { CardTop = CardTop.ThreeFood, CardBottom = CardBottom.GreenArt });
            player.CivilizationCards.Add(new CivilizationCard { CardTop = CardTop.ThreeFood, CardBottom = CardBottom.GreenHealing });
            player.CivilizationCards.Add(new CivilizationCard { CardTop = CardTop.ThreeFood, CardBottom = CardBottom.GreenMusic });
            player.CivilizationCards.Add(new CivilizationCard { CardTop = CardTop.ThreeFood, CardBottom = CardBottom.GreenPottery });
            player.CivilizationCards.Add(new CivilizationCard { CardTop = CardTop.ThreeFood, CardBottom = CardBottom.GreenTime });
            player.CivilizationCards.Add(new CivilizationCard { CardTop = CardTop.ThreeFood, CardBottom = CardBottom.GreenTransport });
            player.CivilizationCards.Add(new CivilizationCard { CardTop = CardTop.ThreeFood, CardBottom = CardBottom.GreenWeaving });
            player.CivilizationCards.Add(new CivilizationCard { CardTop = CardTop.ThreeFood, CardBottom = CardBottom.GreenWriting });

            var playerScore = _scoreCalculator.Score(player);

            Assert.That(playerScore, Is.EqualTo(64));
        }

        [Test]
        public void Player_with_2_duplicate_green_cards_has_2_points()
        {
            var player = new Player();
            player.CivilizationCards.Add(new CivilizationCard { CardTop = CardTop.ThreeFood, CardBottom = CardBottom.GreenArt });
            player.CivilizationCards.Add(new CivilizationCard { CardTop = CardTop.ThreeFood, CardBottom = CardBottom.GreenArt });

            var playerScore = _scoreCalculator.Score(player);

            Assert.That(playerScore, Is.EqualTo(2));
        }

        [Test]
        public void Player_with_12_green_cards_7_unique_5_duplicates_has_74_points()
        {
            var player = new Player();
            player.CivilizationCards.Add(new CivilizationCard { CardTop = CardTop.ThreeFood, CardBottom = CardBottom.GreenArt });
            player.CivilizationCards.Add(new CivilizationCard { CardTop = CardTop.ThreeFood, CardBottom = CardBottom.GreenArt });
            player.CivilizationCards.Add(new CivilizationCard { CardTop = CardTop.ThreeFood, CardBottom = CardBottom.GreenHealing });
            player.CivilizationCards.Add(new CivilizationCard { CardTop = CardTop.ThreeFood, CardBottom = CardBottom.GreenHealing });
            player.CivilizationCards.Add(new CivilizationCard { CardTop = CardTop.ThreeFood, CardBottom = CardBottom.GreenMusic });
            player.CivilizationCards.Add(new CivilizationCard { CardTop = CardTop.ThreeFood, CardBottom = CardBottom.GreenMusic });
            player.CivilizationCards.Add(new CivilizationCard { CardTop = CardTop.ThreeFood, CardBottom = CardBottom.GreenPottery });
            player.CivilizationCards.Add(new CivilizationCard { CardTop = CardTop.ThreeFood, CardBottom = CardBottom.GreenPottery });
            player.CivilizationCards.Add(new CivilizationCard { CardTop = CardTop.ThreeFood, CardBottom = CardBottom.GreenTime });
            player.CivilizationCards.Add(new CivilizationCard { CardTop = CardTop.ThreeFood, CardBottom = CardBottom.GreenTime });
            player.CivilizationCards.Add(new CivilizationCard { CardTop = CardTop.ThreeFood, CardBottom = CardBottom.GreenTransport });
            player.CivilizationCards.Add(new CivilizationCard { CardTop = CardTop.ThreeFood, CardBottom = CardBottom.GreenWeaving });

            var playerScore = _scoreCalculator.Score(player);

            Assert.That(playerScore, Is.EqualTo(74));
        }

        [Test]
        public void Player_with_0_meeples_and_1_Meeple1Score_cards_has_0_points()
        {
            var player = new Player();
            player.CivilizationCards.Add(new CivilizationCard { CardTop = CardTop.ThreeFood, CardBottom = CardBottom.Meeple1Score });

            var playerScore = _scoreCalculator.Score(player);

            Assert.That(playerScore, Is.EqualTo(0));
        }

        [Test]
        public void Player_with_5_meeples_and_1_Meeple1Score_cards_has_5_points()
        {
            var player = new Player
            {
                MeepleCount = 5,
            };
            player.CivilizationCards.Add(new CivilizationCard { CardTop = CardTop.ThreeFood, CardBottom = CardBottom.Meeple1Score });

            var playerScore = _scoreCalculator.Score(player);

            Assert.That(playerScore, Is.EqualTo(5));
        }

        [Test]
        public void Player_with_7_meeples_and_1_Meeple1Score_cards_has_7_points()
        {
            var player = new Player
            {
                MeepleCount = 7,
            };
            player.CivilizationCards.Add(new CivilizationCard { CardTop = CardTop.ThreeFood, CardBottom = CardBottom.Meeple1Score });

            var playerScore = _scoreCalculator.Score(player);

            Assert.That(playerScore, Is.EqualTo(7));
        }

        [Test]
        public void Player_with_8_meeples_and_3_Meeple1Score_cards_has_24_points()
        {
            var player = new Player
            {
                MeepleCount = 8,
            };
            player.CivilizationCards.Add(new CivilizationCard { CardTop = CardTop.ThreeFood, CardBottom = CardBottom.Meeple1Score });
            player.CivilizationCards.Add(new CivilizationCard { CardTop = CardTop.ThreeFood, CardBottom = CardBottom.Meeple1Score });
            player.CivilizationCards.Add(new CivilizationCard { CardTop = CardTop.ThreeFood, CardBottom = CardBottom.Meeple1Score });

            var playerScore = _scoreCalculator.Score(player);

            Assert.That(playerScore, Is.EqualTo(24));
        }

        [Test]
        public void Player_with_3_meeples_and_1_Meeple2Score_cards_has_6_points()
        {
            var player = new Player
            {
                MeepleCount = 3,
            };
            player.CivilizationCards.Add(new CivilizationCard { CardTop = CardTop.ThreeFood, CardBottom = CardBottom.Meeple2Score });

            var playerScore = _scoreCalculator.Score(player);

            Assert.That(playerScore, Is.EqualTo(6));
        }

        [Test]
        public void Player_with_6_meeples_and_2_Meeple2Score_cards_has_24_points()
        {
            var player = new Player
            {
                MeepleCount = 6,
            };
            player.CivilizationCards.Add(new CivilizationCard { CardTop = CardTop.ThreeFood, CardBottom = CardBottom.Meeple2Score });
            player.CivilizationCards.Add(new CivilizationCard { CardTop = CardTop.ThreeFood, CardBottom = CardBottom.Meeple2Score });

            var playerScore = _scoreCalculator.Score(player);

            Assert.That(playerScore, Is.EqualTo(24));
        }

        [Test]
        public void Player_with_9_meeples_and_1_Meeple1Score_3_Meeple2Score_cards_has_63_points()
        {
            var player = new Player
            {
                MeepleCount = 9,
            };
            player.CivilizationCards.Add(new CivilizationCard { CardTop = CardTop.ThreeFood, CardBottom = CardBottom.Meeple1Score });
            player.CivilizationCards.Add(new CivilizationCard { CardTop = CardTop.ThreeFood, CardBottom = CardBottom.Meeple2Score });
            player.CivilizationCards.Add(new CivilizationCard { CardTop = CardTop.ThreeFood, CardBottom = CardBottom.Meeple2Score });
            player.CivilizationCards.Add(new CivilizationCard { CardTop = CardTop.ThreeFood, CardBottom = CardBottom.Meeple2Score });

            var playerScore = _scoreCalculator.Score(player);

            Assert.That(playerScore, Is.EqualTo(63));
        }
    }
}
