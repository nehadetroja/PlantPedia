namespace PlantPedia.Business.Models
{
    public class Order
    {
        public Guid OrderId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }        
        public double OrderAmount { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }

        public ICollection<OrderItem> OrderItems { get; set; }
    }
}
