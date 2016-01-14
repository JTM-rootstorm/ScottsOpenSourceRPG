using System;

namespace Engine.Entities
{
    public abstract class ConsumableItem : BaseGameItem
    {
        public ConsumableTypes ConsumableType { get; private set; }

        public ConsumableItem(Guid id, ConsumableTypes consumableType, string name, string namePlural,
            int minimumLevelToUse = 0, int maximumStackSize = 0)
            : base(id, name, namePlural, minimumLevelToUse, maximumStackSize)
        {
        }
    }
}