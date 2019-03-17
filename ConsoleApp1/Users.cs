using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1
{
    public class Users
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public UserProfile Profile { get; set; }
        public ICollection<Address> Address { get; set; }
        public ICollection<UserRole> Roles { get; set; }
        public Users()
        {
            Address = new HashSet<Address>();
            Roles = new HashSet<UserRole>();
        }
    }
}
