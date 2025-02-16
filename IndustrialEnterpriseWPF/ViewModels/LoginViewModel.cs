using IndustrialEnterpriseWPF.BD;
using IndustrialEnterpriseWPF.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndustrialEnterpriseWPF.ViewModels
{
    internal class LoginViewModel : BaseViewModel
    {
        public UserService _userService;
        public string email { get; set; }
        public string password { get; set; }
        public Users AuthenticatedUser { get; private set; }

        public LoginViewModel()
        {
            _userService = new UserService();
        }

        public bool Authenticate()
        {
            AuthenticatedUser = _userService.Authenticate(email, password);
            return AuthenticatedUser != null;
        }
    }
}
