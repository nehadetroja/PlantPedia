using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantPedia.Data.Entity
{
    internal class PlantCategory
    {
        public Guid PlantCategoryId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }

        [MaxLength(250)]
        public string CategoryName { get; set; }

        public ICollection<Plant> Plants { get; set; }
    }
}
