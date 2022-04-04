using System.ComponentModel.DataAnnotations;

namespace PlantPedia.Model
{
    public class PlantModel
    {
        public Guid PlantId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public double Price { get; set; }

        [MaxLength(250)]
        public string Name { get; set; }
        public Guid PlantCategoryId { get; set; }
        public PlantCategoryModel PlantCategory { get; set; }
    }
}
