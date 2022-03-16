using System.Collections.Generic;
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

        [Test]
        public void Player_with_0_tools_and_1_Tool1Score_cards_has_0_points()
        {
            var player = new Player();
            player.CivilizationCards.Add(new CivilizationCard { CardTop = CardTop.ThreeFood, CardBottom = CardBottom.Tool1Score });

            var playerScore = _scoreCalculator.Score(player);

            Assert.That(playerScore, Is.EqualTo(0));
        }

        [Test]
        public void Player_with_1_tools_and_1_Tool1Score_cards_has_1_points()
        {
            var player = new Player
            {
                Tool1 = new Tool { Value = 1 },
            };
            player.CivilizationCards.Add(new CivilizationCard { CardTop = CardTop.ThreeFood, CardBottom = CardBottom.Tool1Score });

            var playerScore = _scoreCalculator.Score(player);

            Assert.That(playerScore, Is.EqualTo(1));
        }

        [Test]
        public void Player_with_6_tools_and_1_Tool1Score_cards_has_6_points()
        {
            var player = new Player
            {
                Tool1 = new Tool { Value = 1 },
                Tool2 = new Tool { Value = 3 },
                Tool3 = new Tool { Value = 2 },
            };
            player.CivilizationCards.Add(new CivilizationCard { CardTop = CardTop.ThreeFood, CardBottom = CardBottom.Tool1Score });

            var playerScore = _scoreCalculator.Score(player);

            Assert.That(playerScore, Is.EqualTo(6));
        }

        [Test]
        public void Player_with_11_tools_and_1_Tool2Score_cards_has_22_points()
        {
            var player = new Player
            {
                Tool1 = new Tool { Value = 4 },
                Tool2 = new Tool { Value = 4 },
                Tool3 = new Tool { Value = 3 },
            };
            player.CivilizationCards.Add(new CivilizationCard { CardTop = CardTop.ThreeFood, CardBottom = CardBottom.Tool2Score });

            var playerScore = _scoreCalculator.Score(player);

            Assert.That(playerScore, Is.EqualTo(22));
        }

        [Test]
        public void Player_with_3_tools_and_3_Tool1Score_4_Tool2Score_cards_has_33_points()
        {
            var player = new Player
            {
                Tool2 = new Tool { Value = 1 },
                Tool3 = new Tool { Value = 2 },
            };
            player.CivilizationCards.Add(new CivilizationCard { CardTop = CardTop.ThreeFood, CardBottom = CardBottom.Tool1Score });
            player.CivilizationCards.Add(new CivilizationCard { CardTop = CardTop.ThreeFood, CardBottom = CardBottom.Tool1Score });
            player.CivilizationCards.Add(new CivilizationCard { CardTop = CardTop.ThreeFood, CardBottom = CardBottom.Tool1Score });
            player.CivilizationCards.Add(new CivilizationCard { CardTop = CardTop.ThreeFood, CardBottom = CardBottom.Tool2Score });
            player.CivilizationCards.Add(new CivilizationCard { CardTop = CardTop.ThreeFood, CardBottom = CardBottom.Tool2Score });
            player.CivilizationCards.Add(new CivilizationCard { CardTop = CardTop.ThreeFood, CardBottom = CardBottom.Tool2Score });
            player.CivilizationCards.Add(new CivilizationCard { CardTop = CardTop.ThreeFood, CardBottom = CardBottom.Tool2Score });

            var playerScore = _scoreCalculator.Score(player);

            Assert.That(playerScore, Is.EqualTo(33));
        }

        [Test]
        public void Player_with_0_farms_and_1_Farm1Score_cards_has_0_points()
        {
            var player = new Player();
            player.CivilizationCards.Add(new CivilizationCard { CardTop = CardTop.ThreeFood, CardBottom = CardBottom.Farm1Score });

            var playerScore = _scoreCalculator.Score(player);

            Assert.That(playerScore, Is.EqualTo(0));
        }

        [Test]
        public void Player_with_9_farms_and_1_Farm1Score_cards_has_9_points()
        {
            var player = new Player
            {
                FarmLevel = 9,
            };
            player.CivilizationCards.Add(new CivilizationCard { CardTop = CardTop.ThreeFood, CardBottom = CardBottom.Farm1Score });

            var playerScore = _scoreCalculator.Score(player);

            Assert.That(playerScore, Is.EqualTo(9));
        }

        [Test]
        public void Player_with_3_farms_and_4_Farm1Score_cards_has_12_points()
        {
            var player = new Player
            {
                FarmLevel = 3,
            };
            player.CivilizationCards.Add(new CivilizationCard { CardTop = CardTop.ThreeFood, CardBottom = CardBottom.Farm1Score });
            player.CivilizationCards.Add(new CivilizationCard { CardTop = CardTop.ThreeFood, CardBottom = CardBottom.Farm1Score });
            player.CivilizationCards.Add(new CivilizationCard { CardTop = CardTop.ThreeFood, CardBottom = CardBottom.Farm1Score });
            player.CivilizationCards.Add(new CivilizationCard { CardTop = CardTop.ThreeFood, CardBottom = CardBottom.Farm1Score });

            var playerScore = _scoreCalculator.Score(player);

            Assert.That(playerScore, Is.EqualTo(12));
        }

        [Test]
        public void Player_with_10_farms_and_2_Farm1Score_3_Farm2Score_cards_has_80_points()
        {
            var player = new Player
            {
                FarmLevel = 10,
            };
            player.CivilizationCards.Add(new CivilizationCard { CardTop = CardTop.ThreeFood, CardBottom = CardBottom.Farm1Score });
            player.CivilizationCards.Add(new CivilizationCard { CardTop = CardTop.ThreeFood, CardBottom = CardBottom.Farm1Score });
            player.CivilizationCards.Add(new CivilizationCard { CardTop = CardTop.ThreeFood, CardBottom = CardBottom.Farm2Score });
            player.CivilizationCards.Add(new CivilizationCard { CardTop = CardTop.ThreeFood, CardBottom = CardBottom.Farm2Score });
            player.CivilizationCards.Add(new CivilizationCard { CardTop = CardTop.ThreeFood, CardBottom = CardBottom.Farm2Score });

            var playerScore = _scoreCalculator.Score(player);

            Assert.That(playerScore, Is.EqualTo(80));
        }

        [Test]
        public void Player_with_0_huts_and_1_Hut1Score_cards_has_0_points()
        {
            var player = new Player();
            player.CivilizationCards.Add(new CivilizationCard { CardTop = CardTop.ThreeFood, CardBottom = CardBottom.Hut1Score });

            var playerScore = _scoreCalculator.Score(player);

            Assert.That(playerScore, Is.EqualTo(0));
        }

        [Test]
        public void Player_with_2_huts_and_1_Hut1Score_cards_has_2_points()
        {
            var player = new Player();
            player.Huts.Add(new Hut());
            player.Huts.Add(new Hut());
            player.CivilizationCards.Add(new CivilizationCard { CardTop = CardTop.ThreeFood, CardBottom = CardBottom.Hut1Score });

            var playerScore = _scoreCalculator.Score(player);

            Assert.That(playerScore, Is.EqualTo(2));
        }

        [Test]
        public void Player_with_6_huts_and_3_Hut1Score_cards_has_18_points()
        {
            var player = new Player();
            player.Huts.Add(new Hut());
            player.Huts.Add(new Hut());
            player.Huts.Add(new Hut());
            player.Huts.Add(new Hut());
            player.Huts.Add(new Hut());
            player.Huts.Add(new Hut());
            player.CivilizationCards.Add(new CivilizationCard { CardTop = CardTop.ThreeFood, CardBottom = CardBottom.Hut1Score });
            player.CivilizationCards.Add(new CivilizationCard { CardTop = CardTop.ThreeFood, CardBottom = CardBottom.Hut1Score });
            player.CivilizationCards.Add(new CivilizationCard { CardTop = CardTop.ThreeFood, CardBottom = CardBottom.Hut1Score });

            var playerScore = _scoreCalculator.Score(player);

            Assert.That(playerScore, Is.EqualTo(18));
        }

        [Test]
        public void Player_with_3_huts_and_2_Hut2Score_cards_has_12_points()
        {
            var player = new Player();
            player.Huts.Add(new Hut());
            player.Huts.Add(new Hut());
            player.Huts.Add(new Hut());
            player.CivilizationCards.Add(new CivilizationCard { CardTop = CardTop.ThreeFood, CardBottom = CardBottom.Hut2Score });
            player.CivilizationCards.Add(new CivilizationCard { CardTop = CardTop.ThreeFood, CardBottom = CardBottom.Hut2Score });

            var playerScore = _scoreCalculator.Score(player);

            Assert.That(playerScore, Is.EqualTo(12));
        }

        [Test]
        public void Player_with_4_huts_and_2_Hut1Score_3_Hut2Score_cards_has_32_points()
        {
            var player = new Player();
            player.Huts.Add(new Hut());
            player.Huts.Add(new Hut());
            player.Huts.Add(new Hut());
            player.Huts.Add(new Hut());
            player.CivilizationCards.Add(new CivilizationCard { CardTop = CardTop.ThreeFood, CardBottom = CardBottom.Hut1Score });
            player.CivilizationCards.Add(new CivilizationCard { CardTop = CardTop.ThreeFood, CardBottom = CardBottom.Hut1Score });
            player.CivilizationCards.Add(new CivilizationCard { CardTop = CardTop.ThreeFood, CardBottom = CardBottom.Hut2Score });
            player.CivilizationCards.Add(new CivilizationCard { CardTop = CardTop.ThreeFood, CardBottom = CardBottom.Hut2Score });
            player.CivilizationCards.Add(new CivilizationCard { CardTop = CardTop.ThreeFood, CardBottom = CardBottom.Hut2Score });

            var playerScore = _scoreCalculator.Score(player);

            Assert.That(playerScore, Is.EqualTo(32));
        }

        [Test]
        public void Player_with_Score3Points_on_top_of_card_has_3_points()
        {
            var player = new Player();
            player.CivilizationCards.Add(new CivilizationCard { CardTop = CardTop.Score3Points, CardBottom = CardBottom.Hut3Score });

            var playerScore = _scoreCalculator.Score(player);

            Assert.That(playerScore, Is.EqualTo(3));
        }

        [Test]
        public void Player_with_2_Score3Points_on_top_of_card_has_6_points()
        {
            var player = new Player();
            player.CivilizationCards.Add(new CivilizationCard { CardTop = CardTop.Score3Points, CardBottom = CardBottom.Hut3Score });
            player.CivilizationCards.Add(new CivilizationCard { CardTop = CardTop.Score3Points, CardBottom = CardBottom.Farm2Score });

            var playerScore = _scoreCalculator.Score(player);

            Assert.That(playerScore, Is.EqualTo(6));
        }

        [Test]
        public void Player_with_hut_with_no_value_has_0_points()
        {
            var player = new Player();
            player.Huts.Add(new Hut());

            var playerScore = _scoreCalculator.Score(player);

            Assert.That(playerScore, Is.EqualTo(0));
        }

        [Test]
        public void Player_with_hut_bought_with_2_clay_1_gold_has_14_points()
        {
            var player = new Player();
            var hut = new Hut();
            hut.PayUsing(new Dictionary<Resource, int> { { Resource.Clay, 2 }, { Resource.Gold, 1 } });
            player.Huts.Add(hut);

            var playerScore = _scoreCalculator.Score(player);

            Assert.That(playerScore, Is.EqualTo(14));
        }
    }
}
