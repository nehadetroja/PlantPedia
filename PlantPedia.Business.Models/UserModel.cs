using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace PlantPedia.Business.Models
{
    public class User
    {
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public Guid UserId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public Guid UserRoleId { get; set; }
        public UserRole UserRole { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
