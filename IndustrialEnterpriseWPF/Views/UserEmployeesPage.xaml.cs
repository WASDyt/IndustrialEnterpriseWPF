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
    /// Логика взаимодействия для UserEmployeesPage.xaml
    /// </summary>
    public partial class UserEmployeesPage : Page
    {
        private EmployeesViewModel _viewModel;
        public UserEmployeesPage()
        {
            InitializeComponent();
            _viewModel = new EmployeesViewModel();
            DataContext = _viewModel;
        }
        private void PowerPlantsButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new UserPowerPlantsPage());
        }
    }
}
