namespace Ordering_system.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Produto Produto { get; set; }

        public OrderItem()
        {

        }
        public OrderItem(int quantity, double price, Produto produto)
        {
            Quantity = quantity;
            Price = price;
            Produto = produto;
        }
        public double SubTotal()
        {
            return Quantity * Price;
        }
    }
}
