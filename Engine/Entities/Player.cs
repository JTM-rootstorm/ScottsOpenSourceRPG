namespace Engine.Entities
{
    public class Player : LivingCreature
    {
        public string Name { get; private set; }
        public int Strength { get; private set; }
        public int Dexterity { get; private set; }
        public int Constitution { get; private set; }
        public int Intelligence { get; private set; }
        public int Wisdom { get; private set; }
        public int Charisma { get; private set; }

        public Player(string name, int strength, int dexterity, int constitution, int intelligence, int wisdom, int charisma)
        {
            Name = name;
            Strength = strength;
            Dexterity = dexterity;
            Constitution = constitution;
            Intelligence = intelligence;
            Wisdom = wisdom;
            Charisma = charisma;
        }

        public static Player CreateRandomPlayer(string name)
        {
            return new Player(name, 
                RandomNumberGenerator.GetNumberBetween(3, 18),
                RandomNumberGenerator.GetNumberBetween(3, 18),
                RandomNumberGenerator.GetNumberBetween(3, 18),
                RandomNumberGenerator.GetNumberBetween(3, 18),
                RandomNumberGenerator.GetNumberBetween(3, 18),
                RandomNumberGenerator.GetNumberBetween(3, 18));
        }
    }
}
