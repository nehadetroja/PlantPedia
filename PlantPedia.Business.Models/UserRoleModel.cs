using System.ComponentModel.DataAnnotations;

namespace PlantPedia.Business.Models
{
    public class UserRole
    {
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public Guid UserRoleId { get; set; }
        public string Role { get; set; }
        public ICollection<User> Users { get; set; }
    }
}
