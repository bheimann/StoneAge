using System.Collections.Generic;
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

            var meeple1CardCount = player.CivilizationCards.Count(c => c.CardBottom == CardBottom.Meeple1Score);
            score += player.MeepleCount * meeple1CardCount;

            var meeple2CardCount = player.CivilizationCards.Count(c => c.CardBottom == CardBottom.Meeple2Score);
            score += player.MeepleCount * meeple2CardCount * 2;

            return score;
        }
    }
}
