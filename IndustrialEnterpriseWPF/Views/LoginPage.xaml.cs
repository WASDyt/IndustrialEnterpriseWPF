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
    /// Логика взаимодействия для LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        private LoginViewModel _viewModel = new LoginViewModel();
        
        public LoginPage()
        {
            InitializeComponent();
            DataContext = _viewModel;
        }
        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            _viewModel.email = UsernameTextBox.Text;
            _viewModel.password = PasswordBox.Password;

            if (_viewModel.Authenticate())
            {
                var mainWindow = (MainWindow)Application.Current.MainWindow;
                mainWindow.NavigateToHomePage(_viewModel.AuthenticatedUser);
            }
            else
            {
                MessageBox.Show("Не верный пароль или email");
            }
        }

        private void ScipButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new UserPowerPlantsPage());
        }

        private void AddUseButton_Click(object sender, RoutedEventArgs e)
        {
            var viewModel = new UserViewModel();  // Создайте экземпляр UserViewModel
            NavigationService.Navigate(new AddUser(viewModel));
        }
    }
}
