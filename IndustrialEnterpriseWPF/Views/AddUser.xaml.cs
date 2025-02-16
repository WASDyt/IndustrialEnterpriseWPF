using IndustrialEnterpriseWPF.BD;
using IndustrialEnterpriseWPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace IndustrialEnterpriseWPF.Views
{
    /// <summary>
    /// Логика взаимодействия для AddUser.xaml
    /// </summary>
    public partial class AddUser : Page
    {
        private UserViewModel _viewModel;
        public Users _users;

        internal AddUser(UserViewModel viewModel, Users user = null)
        {
            InitializeComponent();
            _viewModel = viewModel;
            _users = user ?? new Users();

            if (_users != null)
            {  
                NameTextBox.Text = _users.user_name;
                LastnameTextBox.Text = _users.user_lastname;
                EmailTextBox.Text = _users.email;
                PasswordTextBox.Text = _users.password;
                // Здесь роль фиксируется на 1, и поле для редактирования роли удаляется.
                _users.role_id = 1;  // Устанавливаем роль на 1
            }
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            _users.user_name = NameTextBox.Text;
            _users.user_lastname = LastnameTextBox.Text;
            _users.email = EmailTextBox.Text;
            _users.password = PasswordTextBox.Text;
            // Роль не изменяется, она всегда остается равной 1
            _users.role_id = 1;

            if (_users.user_id == 0)
            {
                _viewModel.Users.Add(_users);
                _viewModel._userService.AddUser(_users);
            }
            else
            {
                // Логика для обновления существующего пользователя (если нужна)
            }

            NavigationService.GoBack();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
