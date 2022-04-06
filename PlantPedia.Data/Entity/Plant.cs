using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantPedia.Data.Entity
{
    internal class Plant
    {
        public Guid PlantId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public double Price { get; set; }

        [MaxLength(250)]
        public string Name { get; set; }
        public Guid PlantCategoryId { get; set; }
        public PlantCategory PlantCategory { get; set; }
    }
}
