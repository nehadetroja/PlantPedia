namespace PlantPedia.Business.Models
{
    public class OrderItemModel
    {
        public Guid OrderItemId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }        
        public int Quantity { get; set; }
        public double UnitPrice { get; set; }
        public double TotalPrice { get; set; }
        public Guid PlantId { get; set; }
        public PlantModel Plant { get; set; }
        public Guid OrderId { get; set; }
        public OrderModel Order { get; set; }
    }
}
