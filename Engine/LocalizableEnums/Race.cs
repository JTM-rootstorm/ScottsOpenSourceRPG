namespace Engine.LocalizableEnums
{
    public class Race : LocalizableEnumValue
    {
        protected internal Race(string databaseValue) : base(databaseValue)
        {
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Race);
        }

        public bool Equals(Race race)
        {
            if(race == null)
            {
                return false;
            }

            return (ValueForDB == race.ValueForDB);
        }

        public override int GetHashCode()
        {
            return _databaseValue?.GetHashCode() ?? 0;
        }

        public static bool operator ==(Race a, Race b)
        {
            // If both are null, or both are same instance, return true.
            if(ReferenceEquals(a, b))
            {
                return true;
            }

            // If one is null, but not both, return false.
            if(((object)a == null) || ((object)b == null))
            {
                return false;
            }

            // Return true if the fields match:
            return a.ValueForDB == b.ValueForDB;
        }

        public static bool operator !=(Race a, Race b)
        {
            return !(a == b);
        }
    }
}
