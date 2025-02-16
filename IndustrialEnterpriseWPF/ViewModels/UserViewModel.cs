using IndustrialEnterpriseWPF.BD;
using IndustrialEnterpriseWPF.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndustrialEnterpriseWPF.ViewModels
{
    internal class UserViewModel : BaseViewModel
    {
        public UserService _userService;
        public ObservableCollection<Users> Users { get; set; }

        public UserViewModel()
        {
            _userService = new UserService();
            Users = new ObservableCollection<Users>();
            LoadUsers();
        }

        public void LoadUsers()
        {
            Users.Clear();
            var products = _userService.GetUsers();
            foreach (var product in products)
            {
                Users.Add(product);
            }
        }
    }
}
