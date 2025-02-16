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
    /// Логика взаимодействия для AddPowerPlantsPage.xaml
    /// </summary>
    public partial class AddPowerPlantsPage : Page
    {
        private PowerPlantsViewModel _viewModel;
        public PowerPlants _powerplants;
        internal AddPowerPlantsPage(PowerPlantsViewModel viewModel, PowerPlants powerplants = null)
        {
            InitializeComponent();
            _viewModel = viewModel;
            _powerplants = powerplants ?? new PowerPlants();

            if (_powerplants != null)
            {
                NameTextBox.Text = _powerplants.plant_name;
                GeolocationTextBox.Text = _powerplants.plant_geolocation;
                IntoTextBox.Text = _powerplants.plant_into;
                ImageTextBox.Text = _powerplants.plant_image;
            }
        }
        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            _powerplants.plant_name = NameTextBox.Text;
            _powerplants.plant_geolocation = GeolocationTextBox.Text;
            _powerplants.plant_into = IntoTextBox.Text;
            _powerplants.plant_image = ImageTextBox.Text;

            if (_powerplants.plant_id == 0)
            {
                _viewModel.PowerPlants.Add(_powerplants);
                _viewModel._powerplantsService.AddPowerPlants(_powerplants);
            }
            else
            {
                _viewModel._powerplantsService.EditPowerPlants(_powerplants);
            }

            NavigationService.GoBack();
        }
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
