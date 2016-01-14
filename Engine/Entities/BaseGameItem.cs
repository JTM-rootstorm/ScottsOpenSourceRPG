using System;

namespace Engine.Entities
{
    public class BaseGameItem : PropertyChangeNotifyingObject
    {
        public Guid ID { get; private set; }
        public string Name { get; private set; }
        public string NamePlural { get; private set; }
        public int MinimumLevelToUse { get; private set; }
        public int MaximumStackSize { get; private set; } // Use 0 for unlimited stacking

        public BaseGameItem(Guid id, string name, string namePlural, int minimumLevelToUse = 0, int maximumStackSize = 0)
        {
            ID = id;
            Name = name;
            NamePlural = namePlural;
            MinimumLevelToUse = minimumLevelToUse;
            MaximumStackSize = maximumStackSize;
        }
    }
}
