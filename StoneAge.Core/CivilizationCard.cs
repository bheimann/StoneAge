namespace StoneAge.Core
{
    public class CivilizationCard
    {
        public CardTop CardTop { get; set; }
        public CardBottom CardBottom { get; set; }
    }

    public enum CardTop
    {
        ThreeFood,
        FiveFood,
        TwoStone,
        ToolIncrease,
        FarmIncrease,
        RollForGold,
        Lottery,
        Score3Points,
    }

    public enum CardBottom
    {
        GreenHealing,
        GreenArt,
        GreenWriting,
        GreenPottery,
        GreenTime,
        GreenTransport,
        GreenMusic,
        GreenWeaving,
        Tool1Score,
        Tool2Score,
        Hut1Score,
        Hut2Score,
        Hut3Score,
        Meeple1Score,
        Meeple2Score,
        Farm1Score,
        Farm2Score,
    }
}
