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
    /// Логика взаимодействия для AdminEmployeesPage.xaml
    /// </summary>
    public partial class AdminEmployeesPage : Page
    {
        private EmployeesViewModel _viewModel;
        public AdminEmployeesPage()
        {
            InitializeComponent();
            _viewModel = new EmployeesViewModel();
            DataContext = _viewModel;
        }
        private void AddEmployeesButton_Click(object sender, RoutedEventArgs e)
        {
            // Создаем новый объект Employees
            var newEmployee = new Employees();

            // Передаем оба параметра в конструктор
            NavigationService.Navigate(new AddEmployeesPage(_viewModel, newEmployee));
        }

        private void EditEmployeesButton_Click(object sender, RoutedEventArgs e)
        {
            if (EmployeesListView.SelectedItem is Employees selectedEmployees)
            {
                NavigationService.Navigate(new AddEmployeesPage(_viewModel, selectedEmployees));
            }
        }
        private void DeleteEmployeesButton_Click(object sender, RoutedEventArgs e)
        {

            if (EmployeesListView.SelectedItem is Employees selectedEmployees)
            {
                _viewModel.Employees.Remove(selectedEmployees);
                _viewModel._employeesService.DeleteEmployees(selectedEmployees.employee_id);
            }
        }

        private void PowerPlantsButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AdminPowerPlantsPage());
        }

        private void RefreshButton_Click(object sender, RoutedEventArgs e)
        {
            _viewModel.LoadEmployees();
        }
    }
}
