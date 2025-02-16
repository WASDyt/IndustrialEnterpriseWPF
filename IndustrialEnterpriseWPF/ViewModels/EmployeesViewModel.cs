using IndustrialEnterpriseWPF.BD;
using IndustrialEnterpriseWPF.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace IndustrialEnterpriseWPF.ViewModels
{
    internal class EmployeesViewModel : BaseViewModel
    {
        public EmployeesService _employeesService;
        public ObservableCollection<Employees> Employees { get; set; }

        public EmployeesViewModel()
        {
            _employeesService = new EmployeesService();
            Employees = new ObservableCollection<Employees>();
            LoadEmployees();
        }

        public void LoadEmployees()
        {
            Employees.Clear();
            var products = _employeesService.GetEmployees();
            foreach (var product in products)
            {
                Employees.Add(product);
            }
        }
    }
}
