using Engine.Utilities;

namespace Engine.LocalizableEnums
{
    public abstract class LocalizableEnumValue
    {
        protected readonly string _databaseValue;

        protected LocalizableEnumValue(string databaseValue)
        {
            _databaseValue = databaseValue;
        }

        public override string ToString()
        {
            return _databaseValue.InCurrentLanguage();
        }

        public string ValueForDB
        {
            get { return _databaseValue; }
        }

        public string ValueForUI
        {
            get { return ToString(); }
        }
    }
}
