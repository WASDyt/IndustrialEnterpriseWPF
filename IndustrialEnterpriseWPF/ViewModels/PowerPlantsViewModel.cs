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
    internal class PowerPlantsViewModel : BaseViewModel
    {
        public PowerPlantsService _powerplantsService;
        public ObservableCollection<PowerPlants> PowerPlants { get; set; }

        public PowerPlantsViewModel()
        {
            _powerplantsService = new PowerPlantsService();
            PowerPlants = new ObservableCollection<PowerPlants>();
            LoadPowerPlants();
        }

        public void LoadPowerPlants()
        {
            PowerPlants.Clear();
            var powerplants = _powerplantsService.GetPowerPlants();
            foreach (var powerplant in powerplants)
            {
                PowerPlants.Add(powerplant);
            }
        }
    }
}
