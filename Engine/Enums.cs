namespace Engine
{
    public enum PlayerActions
    {
        DoNothing,
        MoveNorth,
        MoveSouth,
        MoveEast,
        MoveWest,
        UseSelectedWeapon,
        UseSelectedConsumableItem,
        ViewInventory,
        ViewQuestLog,
        ViewSkills
    }

    public enum ArmorLocations
    {
        Head,
        Shoulder,
        Back,
        LeftArm,
        RightArm,
        Chest,
        Waist,
        Legs,
        Feet
    }

    public enum JeweleryLocations
    {
        LeftEar,
        RightEar,
        Neck,
        LeftWrist,
        LeftHand,
        RightWrist,
        RightHand
    }

    public enum ConsumableTypes
    {
        Potion,
        Beverage,
        Food
    }
}
