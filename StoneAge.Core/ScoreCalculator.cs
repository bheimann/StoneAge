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
            {CardBottom.Meeple1Score, 1},
            {CardBottom.Meeple2Score, 2},
        };

        private static readonly Dictionary<CardBottom, int> _toolBottoms = new Dictionary<CardBottom, int>
        {
            {CardBottom.Tool1Score, 1},
            {CardBottom.Tool2Score, 2},
        };

        public int Score(Player player)
        {
            var score = 0;
            var groupedCards = player.CivilizationCards
                .Where(c => _greenBottoms.Contains(c.CardBottom))
                .GroupBy(c => c.CardBottom)
                .ToList();

            var uniqueCount = groupedCards.Count;
            score += uniqueCount * uniqueCount;

            var duplicateCount = groupedCards
                .Count(g => g.Count() > 1);
            score += duplicateCount * duplicateCount;

            foreach (var cardBottom in _meepleBottoms.Keys)
            {
                var meepleCardCount = player.CivilizationCards.Count(c => c.CardBottom == cardBottom);
                score += player.MeepleCount * meepleCardCount * _meepleBottoms[cardBottom];
            }

            var toolTotalCount = (player.Tool1?.Value ?? 0) + (player.Tool2?.Value ?? 0) + (player.Tool3?.Value ?? 0);
            foreach (var cardBottom in _toolBottoms.Keys)
            {
                var toolCardCount = player.CivilizationCards.Count(c => c.CardBottom == cardBottom);
                score += toolTotalCount * toolCardCount * _toolBottoms[cardBottom];
            }

            return score;
        }
    }
}
