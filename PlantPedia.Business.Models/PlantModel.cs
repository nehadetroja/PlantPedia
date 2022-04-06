using System.ComponentModel.DataAnnotations;

namespace PlantPedia.Business.Models
{
    public class Plant
    {
        public Guid PlantId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public double Price { get; set; }
        public string Name { get; set; }
        public Guid PlantCategoryId { get; set; }
        public PlantCategory PlantCategory { get; set; }
    }
}
