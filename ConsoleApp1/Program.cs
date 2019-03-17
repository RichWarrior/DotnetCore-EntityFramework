using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var dbContext = new ApplicationDbContext())
            {
                //One To One EfCore
                dbContext.Database.EnsureDeleted();
                dbContext.Database.EnsureCreated();
                var role = new Roles();
                role.Name = "Admin";
                dbContext.Roles.Add(role);
                var usr = new Users();
                usr.Name = "Faruk";
                usr.Surname = "Şahin";
                usr.Profile = new UserProfile
                {
                    NickName = "RichWarrior",
                    ProfilePicture = "avatar.png"
                };
                usr.Address.Add(new Address
                {
                    State = "Kağıthane",
                    City = "İstanbul",
                    City_Address = "Talatpaşa Mah"
                });
                dbContext.Users.Add(usr);
                dbContext.SaveChanges();
                dbContext.UserRoles.Add(new UserRole
                {
                 UsersId = 1,
                 RolesId=1
                });
                dbContext.SaveChanges();

                //Create Users
                //dbContext.Database.EnsureDeleted();
                //dbContext.Database.EnsureCreated();
                //dbContext.Users.Add(new Users
                //{
                //    Name = "Faruk",
                //    Surname = "Şahin"
                //});                
                //dbContext.SaveChanges();
                //dbContext.Users.ToList().ForEach(x =>
                //{
                //    Console.WriteLine(x.Name);
                //});

                //Get User

                var getuser = dbContext.Users.Include(t => t.Profile).Include(t=>t.Roles).FirstOrDefault(x => x.Id == 1);
            }
            //Console.WriteLine("Kullanıcı Oluşturuldu!");
            Console.ReadKey();
        }
    }
}
