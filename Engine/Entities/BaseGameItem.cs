using System;

namespace Engine.Entities
{
    public abstract class BaseGameItem : PropertyChangeNotifyingObject
    {
        public Guid ID { get; private set; }
        public string Name { get; private set; }
        public string NamePlural { get; private set; }
        public int MinimumLevelToUse { get; private set; }
        public int MaximumStackSize { get; private set; }
        public int Value { get; private set; }

        public BaseGameItem(Guid id, string name, string namePlural, int value, int minimumLevelToUse, int maximumStackSize)
        {
            ID = id;
            Name = name;
            NamePlural = namePlural;
            Value = value;
            MinimumLevelToUse = minimumLevelToUse;
            MaximumStackSize = maximumStackSize;
        }
    }
}
