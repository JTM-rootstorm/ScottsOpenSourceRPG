using System;

namespace Engine.Entities
{
    public class Jewelry : BaseGameItem
    {
        public JeweleryLocations JewelryLocation { get; private set; }

        public Jewelry(Guid id, string name, string namePlural, JeweleryLocations location, int minimumLevelToUse = 0, int maximumStackSize = 0)
            : base(id, name, namePlural, minimumLevelToUse, maximumStackSize)
        {
            JewelryLocation = location;
        }
    }
}
