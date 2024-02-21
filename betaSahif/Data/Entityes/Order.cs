namespace betaSahif.Data.Entityes
{
    public class Order : BaseEntity
    {
        public DateTime Time { get; set; }
        public double TotalPrice { get; set; }
        public int UserId { get; set; }
        public User User { get; set; } = new User();

        public List<OrderItems> orderItems { get; set; } = new List<OrderItems>();

    }
}
