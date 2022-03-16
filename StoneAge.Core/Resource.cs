namespace StoneAge.Core
{
    public class Resource
    {
        private Resource(int cost)
        {
            Cost = cost;
        }

        public int Cost { get; }

        public static Resource Wood { get; } = new Resource(3);
        public static Resource Clay { get; } = new Resource(4);
        public static Resource Stone { get; } = new Resource(5);
        public static Resource Gold { get; } = new Resource(6);
    }
}
