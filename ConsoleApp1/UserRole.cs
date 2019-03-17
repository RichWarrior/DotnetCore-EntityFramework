using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class UserRole
    {
        public int Id { get; set; }
        public int UsersId { get; set; }
        public int RolesId { get; set; }
        public Roles Role { get; set; }        
        //public ICollection<Users> Users { get; set; }
        //public UserRole()
        //{
        //    Users = new HashSet<Users>();
        //}
    }
}
