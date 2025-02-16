using IndustrialEnterpriseWPF.BD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace IndustrialEnterpriseWPF.Services
{
    internal class UserService
    {
        public Users Authenticate(string emails, string passwords)
        {
            using (var context = new IndustrialEnterpriseEntities())
            {
                return context.Users.FirstOrDefault(u => u.email == emails && u.password == passwords);
            }
        }

        public List<Users> GetUsers()
        {
            using (var context = new IndustrialEnterpriseEntities())
            {
                return context.Users.ToList();
            }
        }
        public void AddUser(Users user)
        {
            using (var context = new IndustrialEnterpriseEntities())
            {
                context.Users.Add(user);
                context.SaveChanges();
            }
        }
    }
}
