using System.Collections.Generic;

namespace StoneAge.Core
{
    public class Hut
    {
        public int PointsPaid { get; private set; }

        public void PayUsing(Dictionary<Resource, int> resourcesUsed)
        {
            foreach (var resourceAndQuantity in resourcesUsed)
            {
                var resourceValue = (int)resourceAndQuantity.Key;
                var quantityUsed = resourceAndQuantity.Value;
                PointsPaid += resourceValue * quantityUsed;
            }
        }
    }
}
