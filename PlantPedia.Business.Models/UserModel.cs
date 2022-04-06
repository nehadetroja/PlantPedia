using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace PlantPedia.Business.Models
{
    public class UserModel
    {
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public Guid UserId { get; set; }
        [MaxLength(250)]
        public string UserName { get; set; }
        public string Email { get; set; }
        [MaxLength(250)]
        public string FirstName { get; set; }
        [MaxLength(250)]
        public string LastName { get; set; }
        public string Password { get; set; }
        public Guid UserRoleId { get; set; }
        public UserRoleModel UserRole { get; set; }
        public ICollection<OrderModel> Orders { get; set; }
    }
}
