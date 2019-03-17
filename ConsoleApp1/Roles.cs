using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1
{
    public class Roles
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Users> Users { get; set; }
        public ICollection<UserRole> UserRoles { get; set; }

        public Roles()
        {
            Users = new HashSet<Users>();
            UserRoles = new HashSet<UserRole>();
        }
    }
}
