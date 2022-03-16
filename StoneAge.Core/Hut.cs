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
                var pointsPaidForResource = resourceAndQuantity.Key.Cost * resourceAndQuantity.Value;
                PointsPaid += pointsPaidForResource;
            }
        }
    }
}
