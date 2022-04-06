using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantPedia.Data.Entity
{
    internal class UserRole
    {
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public Guid UserRoleId { get; set; }

        [MaxLength(250)]
        public string Role { get; set; }

        public ICollection<User> Users { get; set; }
    }
}
