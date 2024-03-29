﻿using System.Collections.Generic;

namespace StoneAge.Core
{
    public class Player
    {
        public List<CivilizationCard> CivilizationCards { get; set; } = new List<CivilizationCard>();

        public int MeepleCount { get; set; }

        public Tool Tool1 { get; set; }
        public Tool Tool2 { get; set; }
        public Tool Tool3 { get; set; }

        public int CombinedToolValue => (Tool1?.Value ?? 0) + (Tool2?.Value ?? 0) + (Tool3?.Value ?? 0);

        public int FarmLevel { get; set; }

        public List<Hut> Huts { get; set; } = new List<Hut>();
    }
}
