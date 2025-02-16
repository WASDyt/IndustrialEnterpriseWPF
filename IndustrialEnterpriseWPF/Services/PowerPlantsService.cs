using IndustrialEnterpriseWPF.BD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace IndustrialEnterpriseWPF.Services
{
    internal class PowerPlantsService
    {
        public List<PowerPlants> GetPowerPlants()
        {
            using (var context = new IndustrialEnterpriseEntities())
            {
                return context.PowerPlants.ToList();
            }
        }

        public void AddPowerPlants(PowerPlants powerplants)
        {
            using (var context = new IndustrialEnterpriseEntities())
            {
                context.PowerPlants.Add(powerplants);
                context.SaveChanges();
            }
        }

        public void EditPowerPlants(PowerPlants powerplants)
        {
            using (var context = new IndustrialEnterpriseEntities())
            {
                var existingPowerPlants = context.PowerPlants.Find(powerplants.plant_id);
                if (existingPowerPlants != null)
                {
                    existingPowerPlants.plant_id = powerplants.plant_id;
                    existingPowerPlants.plant_name = powerplants.plant_name;
                    existingPowerPlants.plant_geolocation = powerplants.plant_geolocation;
                    existingPowerPlants.plant_into = powerplants.plant_into;
                    existingPowerPlants.plant_image = powerplants.plant_image;


                    context.SaveChanges();
                }
            }
        }

        public void DeletePowerPlants(int powerplantsID)
        {
            using (var context = new IndustrialEnterpriseEntities())
            {
                var powerplants = context.PowerPlants.Find(powerplantsID);
                if (powerplants != null)
                {
                    context.PowerPlants.Remove(powerplants);
                    context.SaveChanges();
                }
            }
        }
    }
}
