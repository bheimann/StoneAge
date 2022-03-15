using System.Linq;

namespace StoneAge.Core
{
    public class ScoreCalculator
    {
        public int Score(Player player)
        {
            var score = 0;
            var groupedCards = player.CivilizationCards
                .GroupBy(c => c.CardBottom)
                .ToList();

            var uniqueCount = groupedCards.Count;
            score += uniqueCount * uniqueCount;

            var duplicateCount = groupedCards
                .Count(g => g.Count() > 1);
            score += duplicateCount * duplicateCount;

            return score;
        }
    }
}
