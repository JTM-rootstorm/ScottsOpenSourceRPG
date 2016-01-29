using System;

namespace Engine.Entities
{
    public class Jewelry : BaseGameItem
    {
        public JeweleryLocations JewelryLocation { get; private set; }

        public Jewelry(Guid id, string name, string namePlural, int value, 
            JeweleryLocations location, int minimumLevelToUse = 0, int maximumStackSize = 0)
            : base(id, name, namePlural, value, minimumLevelToUse, maximumStackSize)
        {
            JewelryLocation = location;
        }
    }
}
