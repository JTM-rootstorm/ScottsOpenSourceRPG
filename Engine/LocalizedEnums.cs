using System.Collections.Generic;
using System.Linq;
using Engine.LocalizableEnums;

namespace Engine
{
    public static class LocalizedEnums
    {
        private static readonly List<PlayerClass> _playerClasses = new List<PlayerClass>();
        private static readonly List<Race> _races = new List<Race>(); 

        private const string PLAYER_CLASS_BARD = "Bard";
        private const string PLAYER_CLASS_CLERIC = "Cleric";
        private const string PLAYER_CLASS_DRUID = "Druid";
        private const string PLAYER_CLASS_FIGHTER = "Fighter";
        private const string PLAYER_CLASS_PALADIN = "Paladin";
        private const string PLAYER_CLASS_RANGER = "Ranger";
        private const string PLAYER_CLASS_THIEF = "Thief";
        private const string PLAYER_CLASS_WIZARD = "Wizard";

        private const string RACE_DWARF = "Dwarf";
        private const string RACE_ELF = "Elf";
        private const string RACE_GNOME = "Gnome";
        private const string RACE_HALFLING = "Halfling";
        private const string RACE_HALF_ELF = "Half-elf";
        private const string RACE_HALF_ORC = "Half-orc";
        private const string RACE_HUMAN = "Human";

        static LocalizedEnums()
        {
            _playerClasses.Add(new PlayerClass(PLAYER_CLASS_BARD));
            _playerClasses.Add(new PlayerClass(PLAYER_CLASS_CLERIC));
            _playerClasses.Add(new PlayerClass(PLAYER_CLASS_DRUID));
            _playerClasses.Add(new PlayerClass(PLAYER_CLASS_FIGHTER));
            _playerClasses.Add(new PlayerClass(PLAYER_CLASS_PALADIN));
            _playerClasses.Add(new PlayerClass(PLAYER_CLASS_RANGER));
            _playerClasses.Add(new PlayerClass(PLAYER_CLASS_THIEF));
            _playerClasses.Add(new PlayerClass(PLAYER_CLASS_WIZARD));

            _races.Add(new Race(RACE_DWARF));
            _races.Add(new Race(RACE_ELF));
            _races.Add(new Race(RACE_GNOME));
            _races.Add(new Race(RACE_HALFLING));
            _races.Add(new Race(RACE_HALF_ELF));
            _races.Add(new Race(RACE_HALF_ORC));
            _races.Add(new Race(RACE_HUMAN));
        }

        public static class PlayerClasses
        {
            public static PlayerClass Bard { get { return _playerClasses.Single(x => x.ValueForDB == PLAYER_CLASS_BARD); } }
            public static PlayerClass Cleric { get { return _playerClasses.Single(x => x.ValueForDB == PLAYER_CLASS_CLERIC); } }
            public static PlayerClass Druid { get { return _playerClasses.Single(x => x.ValueForDB == PLAYER_CLASS_DRUID); } }
            public static PlayerClass Fighter { get { return _playerClasses.Single(x => x.ValueForDB == PLAYER_CLASS_FIGHTER); } }
            public static PlayerClass Paladin { get { return _playerClasses.Single(x => x.ValueForDB == PLAYER_CLASS_PALADIN); } }
            public static PlayerClass Ranger { get { return _playerClasses.Single(x => x.ValueForDB == PLAYER_CLASS_RANGER); } }
            public static PlayerClass Thief { get { return _playerClasses.Single(x => x.ValueForDB == PLAYER_CLASS_THIEF); } }
            public static PlayerClass Wizard { get { return _playerClasses.Single(x => x.ValueForDB == PLAYER_CLASS_WIZARD); } }

            public static List<PlayerClass> ToList()
            {
                return _playerClasses;
            }

            public static PlayerClass ForDBValue(string valueFromDB)
            {
                return _playerClasses.Single(x => x.ValueForDB == valueFromDB);
            }
        }

        public static class Races
        {
            public static Race Dwarf { get { return _races.Single(x => x.ValueForDB == RACE_DWARF); } }
            public static Race Elf { get { return _races.Single(x => x.ValueForDB == RACE_ELF); } }
            public static Race Gnome { get { return _races.Single(x => x.ValueForDB == RACE_GNOME); } }
            public static Race HalfElf { get { return _races.Single(x => x.ValueForDB == RACE_HALF_ELF); } }
            public static Race HalfOrc { get { return _races.Single(x => x.ValueForDB == RACE_HALF_ORC); } }
            public static Race Halfling { get { return _races.Single(x => x.ValueForDB == RACE_HALFLING); } }
            public static Race Human { get { return _races.Single(x => x.ValueForDB == RACE_HUMAN); } }

            public static List<Race> ToList()
            {
                return _races;
            }

            public static Race ForDBValue(string valueFromDB)
            {
                return _races.Single(x => x.ValueForDB == valueFromDB);
            }
        }
    }
}
