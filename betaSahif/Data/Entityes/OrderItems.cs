namespace betaSahif.Data.Entityes
{
    public class OrderItems : BaseEntity
    {
        public int Amount { get; set; }
        public double TotalPrice { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; } = new Product();

        public int OrderId { get; set; }
        public Order Order { get; set; } = new Order();

    }
}
