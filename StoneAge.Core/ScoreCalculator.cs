﻿using System.Collections.Generic;
using System.Linq;

namespace StoneAge.Core
{
    public class ScoreCalculator
    {
        private static readonly List<CardBottom> _greenBottoms = new List<CardBottom>
        {
            CardBottom.GreenHealing,
            CardBottom.GreenArt,
            CardBottom.GreenWriting,
            CardBottom.GreenPottery,
            CardBottom.GreenTime,
            CardBottom.GreenTransport,
            CardBottom.GreenMusic,
            CardBottom.GreenWeaving,
        };

        private static readonly Dictionary<CardBottom, int> _meepleBottoms = new Dictionary<CardBottom, int>
        {
            { CardBottom.Meeple1Score, 1 },
            { CardBottom.Meeple2Score, 2 },
        };

        private static readonly Dictionary<CardBottom, int> _toolBottoms = new Dictionary<CardBottom, int>
        {
            { CardBottom.Tool1Score, 1 },
            { CardBottom.Tool2Score, 2 },
        };

        private static readonly Dictionary<CardBottom, int> _farmBottoms = new Dictionary<CardBottom, int>
        {
            { CardBottom.Farm1Score, 1 },
            { CardBottom.Farm2Score, 2 },
        };

        private static readonly Dictionary<CardBottom, int> _hutBottoms = new Dictionary<CardBottom, int>
        {
            { CardBottom.Hut1Score, 1 },
            { CardBottom.Hut2Score, 2 },
            { CardBottom.Hut3Score, 3 },
        };

        public int Score(Player player)
        {
            var score = 0;
            score += CalculateGreenCardScore(player);
            score += CalculateImmediateCardPoints(player);

            score += ScoreCardBottomsBasedOn(_meepleBottoms, player.MeepleCount, player.CivilizationCards);
            score += ScoreCardBottomsBasedOn(_toolBottoms, player.CombinedToolValue, player.CivilizationCards);
            score += ScoreCardBottomsBasedOn(_farmBottoms, player.FarmLevel, player.CivilizationCards);
            score += ScoreCardBottomsBasedOn(_hutBottoms, player.Huts.Count, player.CivilizationCards);

            score += ScoreHuts(player.Huts);

            return score;
        }

        private static int CalculateGreenCardScore(Player player)
        {
            var groupedCards = player.CivilizationCards
                .Where(c => _greenBottoms.Contains(c.CardBottom))
                .GroupBy(c => c.CardBottom)
                .ToList();

            var uniqueCount = groupedCards.Count;
            var greenCardGroup1Score = uniqueCount * uniqueCount;

            var duplicateCount = groupedCards
                .Count(g => g.Count() > 1);
            var greenCardGroup2Score = duplicateCount * duplicateCount;

            var greenCardScore = greenCardGroup1Score + greenCardGroup2Score;
            return greenCardScore;
        }

        private static int CalculateImmediateCardPoints(Player player)
        {
            var immediate3PointCardCount = player.CivilizationCards.Count(c => c.CardTop == CardTop.Score3Points);

            return immediate3PointCardCount * 3;
        }

        private static int ScoreCardBottomsBasedOn(Dictionary<CardBottom, int> cardsToBaseScoreOn, int hutsCount, List<CivilizationCard> playerCivilizationCards)
        {
            var scoreToAdd = 0;
            foreach (var cardBottom in cardsToBaseScoreOn.Keys)
            {
                var matchingCardCount = playerCivilizationCards
                    .Count(c => c.CardBottom == cardBottom);
                scoreToAdd += hutsCount * matchingCardCount * cardsToBaseScoreOn[cardBottom];
            }

            return scoreToAdd;
        }

        private static int ScoreHuts(List<Hut> playerHuts)
        {
            var scoreToAdd = playerHuts.Sum(h => h.PointsPaid);

            return scoreToAdd;
        }
    }
}
