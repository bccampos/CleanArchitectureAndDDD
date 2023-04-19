namespace bruno.CleanArchDDD.Domain.Entities
{
    public class OrderItem
    {
        public string ItemId { get; private set; }
        public decimal Price { get; private set; }
        public int Quantity { get; private set; }

        public OrderItem(string itemId, decimal price, int quantity)
        {
            ItemId = itemId;
            Price = price;
            Quantity = quantity;
        }

        public decimal GetTotal()
        {
            return Price * Quantity;
        }
    }
}