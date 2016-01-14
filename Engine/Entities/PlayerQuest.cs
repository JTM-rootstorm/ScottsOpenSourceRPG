namespace Engine.Entities
{
    public class PlayerQuest : PropertyChangeNotifyingObject
    {
        public Quest Quest { get; private set; }
        public bool IsCompleted { get; private set; }

        public string Name { get { return Quest.Name; } }

        public PlayerQuest(Quest quest)
        {
            Quest = quest;
            IsCompleted = false;
        }

        public void MarkAsCompleted()
        {
            IsCompleted = true;
        }
    }
}
