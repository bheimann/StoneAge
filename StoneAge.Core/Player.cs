using System.Collections.Generic;

namespace StoneAge.Core
{
    public class Player
    {
        public List<CivilizationCard> CivilizationCards { get; set; } = new List<CivilizationCard>();
        public int MeepleCount { get; set; }
    }
}
