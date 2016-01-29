using System;

namespace Engine.Entities
{
    public abstract class LivingCreature : PropertyChangeNotifyingObject
    {
        public event EventHandler Killed;

        private int _currentHitPoints;

        protected int MaximumHitPoints { get; set; }

        public int CurrentHitPoints
        {
            get { return _currentHitPoints; }
            protected set
            {
                int originalCurrentHitPoints = _currentHitPoints;

                _currentHitPoints = value;

                if(_currentHitPoints != originalCurrentHitPoints)
                {
                    NotifyPropertyChanged("CurrentHitPoints");
                }

                if(_currentHitPoints <= 0)
                {
                    Killed.SafeInvoke();
                }
            }
        }

        public void CompletelyHeal()
        {
            CurrentHitPoints = MaximumHitPoints;
        }
    }
}
