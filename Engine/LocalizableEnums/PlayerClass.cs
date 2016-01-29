namespace Engine.LocalizableEnums
{
    public class PlayerClass : LocalizableEnumValue
    {
        protected internal PlayerClass(string databaseValue) : base(databaseValue)
        {
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as PlayerClass);
        }

        public bool Equals(PlayerClass playerClass)
        {
            if(playerClass == null)
            {
                return false;
            }

            return (ValueForDB == playerClass.ValueForDB);
        }

        public override int GetHashCode()
        {
            return _databaseValue?.GetHashCode() ?? 0;
        }

        public static bool operator ==(PlayerClass a, PlayerClass b)
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

        public static bool operator !=(PlayerClass a, PlayerClass b)
        {
            return !(a == b);
        }
    }
}
