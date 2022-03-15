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
    }
}
