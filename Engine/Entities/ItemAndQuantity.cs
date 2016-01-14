namespace Engine.Entities
{
    public class ItemAndQuantity
    {
        public BaseGameItem Item { get; set; }
        public int Quantity { get; set; }

        public string Name
        {
            get { return Quantity == 1 ? Item.Name : Item.NamePlural; }
        }

        public ItemAndQuantity(BaseGameItem item, int quantity)
        {
            Item = item;
            Quantity = quantity;
        }
    }
}
