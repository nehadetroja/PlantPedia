namespace PlantPedia.Business.Models
{
    public class OrderModel
    {
        public Guid OrderId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }        
        public double OrderAmount { get; set; }
        public Guid UserId { get; set; }
        public UserModel User { get; set; }

        public ICollection<OrderItemModel> OrderItems { get; set; }
    }
}
