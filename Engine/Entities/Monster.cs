using System.Collections.Generic;
using System.Linq;

namespace Engine.Entities
{
    public class Monster : LivingCreature
    {
        private readonly List<LootItem> _lootItems = new List<LootItem>();

        public string Name { get; private set; }
        public string NamePlural { get; private set; }
        public int Level { get; private set; }
        public int MaximumDamage { get; private set; }

        public int RewardExperiencePoints { get; private set; }

        public List<ItemAndQuantity> LootItems
        {
            get
            {
                // Get random loot items from the monster
                List<ItemAndQuantity> lootedItems =
                    (from lootItem in _lootItems
                     where RandomNumberGenerator.GetNumberBetween(1, 100) <= lootItem.DropPercentage
                     select new ItemAndQuantity(lootItem.Item, 1)).ToList();

                // If no items were randomly selected, then add the default loot item(s).
                if(lootedItems.Count == 0)
                {
                    lootedItems.AddRange(from lootItem in _lootItems where lootItem.IsDefaultItem select new ItemAndQuantity(lootItem.Item, 1));
                }

                return lootedItems;
            }
        }

        internal Monster(string name, string namePlural, int level, int currentHitPoints, int maximumHitPoints, int maximumDamage, int rewardExperiencePoints)
        {
            Name = name;
            NamePlural = namePlural;

            Level = level;
            CurrentHitPoints = currentHitPoints;
            MaximumHitPoints = maximumHitPoints;
            MaximumDamage = maximumDamage;

            RewardExperiencePoints = rewardExperiencePoints;
        }

        internal void AddLootItem(BaseGameItem item, int dropPercentage, bool isDefaultItem)
        {
            _lootItems.Add(new LootItem(item, dropPercentage, isDefaultItem));
        }
    }
}
