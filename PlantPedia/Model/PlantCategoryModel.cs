using System.ComponentModel.DataAnnotations;

namespace PlantPedia.Model
{
    public class PlantCategoryModel
    {
        public Guid PlantCategoryId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }

        [MaxLength(250)]
        public string CategoryName { get; set; }

        public ICollection<PlantModel> Plants { get; set; }
    }
}
