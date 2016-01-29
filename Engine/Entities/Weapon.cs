using System;

namespace Engine.Entities
{
    public class Weapon : BaseGameItem
    {
        public int MinimumDamage { get; private set; }
        public int MaximumDamage { get; private set; }

        public Weapon(Guid id, string name, string namePlural, int value, int minimumDamage, int maximumDamage, 
            int minimumLevelToUse = 0, int maximumStackSize = 0)
            : base(id, name, namePlural, value, minimumLevelToUse, maximumStackSize)
        {
            MinimumDamage = minimumDamage;
            MaximumDamage = maximumDamage;
        }
    }
}
