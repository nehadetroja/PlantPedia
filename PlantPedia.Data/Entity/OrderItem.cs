using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantPedia.Data.Entity
{
    internal class OrderItem
    {
        public Guid OrderItemId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public int Quantity { get; set; }
        public double UnitPrice { get; set; }
        public double TotalPrice { get; set; }
        public Guid PlantId { get; set; }
        public Plant Plant { get; set; }
        public Guid OrderId { get; set; }
        public Order Order { get; set; }
    }
}
