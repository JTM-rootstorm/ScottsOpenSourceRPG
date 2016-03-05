using System.Collections.Generic;

namespace Engine.Entities
{
    public class Player : LivingCreature
    {
        public string Name { get; private set; }
        public Races Race { get; private set; }
        public PlayerClasses PlayerClass { get; private set; }
        public int Strength { get; private set; }
        public int Dexterity { get; private set; }
        public int Constitution { get; private set; }
        public int Intelligence { get; private set; }
        public int Wisdom { get; private set; }
        public int Charisma { get; private set; }

        public Player(string name, Races race, PlayerClasses playerClass,
            int strength, int dexterity, int constitution, int intelligence, int wisdom, int charisma)
        {
            Name = name;
            Race = race;
            PlayerClass = playerClass;
            Strength = strength;
            Dexterity = dexterity;
            Constitution = constitution;
            Intelligence = intelligence;
            Wisdom = wisdom;
            Charisma = charisma;
        }

        public static Player CreateRandomPlayer(string name)
        {
            var race = new List<Races>
            {
                Races.Dwarf,
                Races.Elf,
                Races.Gnome,
                Races.HalfElf,
                Races.HalfOrc,
                Races.Halfling,
                Races.Human
            }[RandomNumberGenerator.GetNumberBetween(0, 6)];

            var playerClass = new List<PlayerClasses>
            {
                PlayerClasses.Bard,
                PlayerClasses.Cleric,
                PlayerClasses.Druid,
                PlayerClasses.Fighter,
                PlayerClasses.Paladin,
                PlayerClasses.Ranger,
                PlayerClasses.Thief,
                PlayerClasses.Wizard
            }[RandomNumberGenerator.GetNumberBetween(0, 7)];

            return new Player(name,
                race,
                playerClass,
                RandomNumberGenerator.GetNumberBetween(3, 18),
                RandomNumberGenerator.GetNumberBetween(3, 18),
                RandomNumberGenerator.GetNumberBetween(3, 18),
                RandomNumberGenerator.GetNumberBetween(3, 18),
                RandomNumberGenerator.GetNumberBetween(3, 18),
                RandomNumberGenerator.GetNumberBetween(3, 18));
        }
    }
}