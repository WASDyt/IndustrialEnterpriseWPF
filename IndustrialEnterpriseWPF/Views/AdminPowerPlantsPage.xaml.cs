using IndustrialEnterpriseWPF.ViewModels;
using IndustrialEnterpriseWPF.BD;
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
    /// Логика взаимодействия для AdminPowerPlantsPage.xaml
    /// </summary>
    public partial class AdminPowerPlantsPage : Page
    {
        private PowerPlantsViewModel _viewModel;
        public AdminPowerPlantsPage()
        {
            InitializeComponent();

            _viewModel = new PowerPlantsViewModel();
            DataContext = _viewModel;
        }

        public class PowerPlants
        {
            public int plant_id { get; set; }
            public string plant_name { get; set; }
            public string plant_geolocation { get; set; }
            public string plant_into { get; set; }
            public string plant_image { get; set; }  // Путь к изображению
        }

        private void AddPowerPlantstButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddPowerPlantsPage(_viewModel));
        }

        private void EditPowerPlantsButton_Click(object sender, RoutedEventArgs e)
        {
            if (PowerPlantsListView.SelectedItem is IndustrialEnterpriseWPF.BD.PowerPlants selectedPowerPlants)
            {
                NavigationService.Navigate(new AddPowerPlantsPage(_viewModel, selectedPowerPlants));
            }
        }

        private void DeletePowerPlantsButton_Click(object sender, RoutedEventArgs e)
        {
            if (PowerPlantsListView.SelectedItem is IndustrialEnterpriseWPF.BD.PowerPlants selectedPowerPlants)
            {
                _viewModel.PowerPlants.Remove(selectedPowerPlants);
                _viewModel._powerplantsService.DeletePowerPlants(selectedPowerPlants.plant_id);
            }
        }

        private void EmpoloyeesButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AdminEmployeesPage());
        }

        private void RefreshButton_Click(object sender, RoutedEventArgs e)
        {
            _viewModel.LoadPowerPlants();
        }

    }
}
