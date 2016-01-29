using System;

namespace Engine.Entities
{
    public class Armor : BaseGameItem
    {
        public ArmorLocations ArmorLocation { get; private set; }

        public Armor(Guid id, string name, string namePlural, int value, ArmorLocations location, int minimumLevelToUse = 0, int maximumStackSize = 0)
            : base(id, name, namePlural, value, minimumLevelToUse, maximumStackSize)
        {
            ArmorLocation = location;
        }
    }
}
