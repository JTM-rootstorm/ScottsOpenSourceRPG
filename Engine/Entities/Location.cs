using System.Collections.Generic;
using System.Collections.ObjectModel;

using Engine.Collections;

namespace Engine.Entities
{
    public class Location
    {
        private readonly List<Quest> _questsAvailableHere = new List<Quest>();
        private readonly RandomDistributionList<Monster> _monstersPotentiallySpawningHere = 
            new RandomDistributionList<Monster>();
        private readonly List<BaseGameItem> _itemsRequiredToEnter = new List<BaseGameItem>();

        private Monster _currentMonster; 

        public Coordinate Coordinates { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public int MinimumLevel { get; private set; }
        
        public List<BaseGameItem> ItemsRequiredToEnter
        {
            get { return _itemsRequiredToEnter; }
        }

        public Monster CurrentMonster
        {
            get
            {
                // If there is no monster here, or the current monster is dead, get a new monster
                if(_currentMonster == null || _currentMonster.CurrentHitPoints <= 0)
                {
                    // Only get a new monster if this location has monsters assigned to it
                    if(_monstersPotentiallySpawningHere.IsNotEmpty())
                    {
                        _currentMonster = _monstersPotentiallySpawningHere.GetRandomItem();
                    }
                }

                return _currentMonster;
            }
        }


        public Location(Coordinate coordinate, string name, string description)
        {
            Coordinates = coordinate;
            Name = name;
            Description = description;
        }

        public Location(int x, int y, string name, string description, int minimumLevel) : 
            this(new Coordinate(x,y), name, description)
        {
            MinimumLevel = minimumLevel;
        }

        public ReadOnlyCollection<Quest> AvailableQuests
        {
            get { return _questsAvailableHere.AsReadOnly(); }
        }

        public void AddPotentialMonster(Monster monster, int likelihoodOfAppearing)
        {
            _monstersPotentiallySpawningHere.AddItem(monster, likelihoodOfAppearing);
        }

        public void AddAvailableQuest(Quest quest)
        {
            _questsAvailableHere.Add(quest);
        }
    }
}
