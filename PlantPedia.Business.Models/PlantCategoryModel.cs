using System.ComponentModel.DataAnnotations;

namespace PlantPedia.Business.Models
{
    public class PlantCategory
    {
        public Guid PlantCategoryId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public string CategoryName { get; set; }

        public ICollection<Plant> Plants { get; set; }
    }
}
