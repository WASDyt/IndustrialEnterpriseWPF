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
    /// Логика взаимодействия для UserPowerPlantsPage.xaml
    /// </summary>
    public partial class UserPowerPlantsPage : Page
    {
        private PowerPlantsViewModel _viewModel;
        public UserPowerPlantsPage()
        {
            InitializeComponent();
            _viewModel = new PowerPlantsViewModel();
            DataContext = _viewModel;
        }

        private void EmpoloyeesButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new UserEmployeesPage());
        }
    }
}
