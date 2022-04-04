using System.ComponentModel.DataAnnotations;

namespace PlantPedia.Model
{
    public class UserRoleModel
    {
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public Guid UserRoleId { get; set; }

        [MaxLength(250)]
        public string Role { get; set; }

        public ICollection<UserModel> Users { get; set; }
    }
}
