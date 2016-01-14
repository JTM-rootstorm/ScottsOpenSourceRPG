using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Engine.Entities
{
    public class Quest : PropertyChangeNotifyingObject
    {
        private readonly List<Guid> _questsRequiredToCompleteFirst = new List<Guid>();
        private readonly List<ItemAndQuantity> _itemsNeededToComplete = new List<ItemAndQuantity>();
        private readonly List<ItemAndQuantity> _rewardItems = new List<ItemAndQuantity>();
        private readonly List<Skill> _rewardSkills = new List<Skill>(); 
        private readonly List<Recipe> _rewardRecipes = new List<Recipe>(); 

        public string Name { get; private set; }
        public string Description { get; private set; }
        public int MinimumLevel { get; private set; }
        public bool IsRepeatable { get; private set; }
        public int RewardExperiencePoints { get; private set; }
        public int RewardCurrency { get; private set; }

        public ReadOnlyCollection<Guid> QuestsRequiredToCompleteFirst
        {
            get { return _questsRequiredToCompleteFirst.AsReadOnly(); }
        }

        public ReadOnlyCollection<ItemAndQuantity> ItemsNeededToComplete
        {
            get { return _itemsNeededToComplete.AsReadOnly(); }
        }

        public ReadOnlyCollection<ItemAndQuantity> RewardItems
        {
            get { return _rewardItems.AsReadOnly(); }
        }

        public ReadOnlyCollection<Skill> RewardSkills
        {
            get { return _rewardSkills.AsReadOnly(); }
        }

        public ReadOnlyCollection<Recipe> RewardRecipes
        {
            get { return _rewardRecipes.AsReadOnly(); }
        }

        public Quest(string name, string description, int minimumLevel, bool isRepeatable, int rewardExperiencePoints, int rewardCurrency)
        {
            Name = name;
            Description = description;
            MinimumLevel = minimumLevel;
            IsRepeatable = isRepeatable;

            RewardExperiencePoints = rewardExperiencePoints;
            RewardCurrency = rewardCurrency;
        }
    }
}
