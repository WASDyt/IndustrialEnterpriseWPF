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
    /// Логика взаимодействия для AddEmployeesPage.xaml
    /// </summary>
    public partial class AddEmployeesPage : Page
    {
        private EmployeesViewModel _viewModel;
        public Employees _employees;
        internal AddEmployeesPage(EmployeesViewModel viewModel, Employees employees = null)
        {
            InitializeComponent();
            _viewModel = viewModel;
            _employees = employees ?? new Employees();
            if (_employees != null)
            {
                NameTextBox.Text = _employees.employee_name;
                LastNameTextBox.Text = _employees.employee_lastname;
                PositionTextBox.Text = _employees.employee_position;
                EmailTextBox.Text = _employees.employee_email;
                QualificationsTextBox.Text = _employees.employee_qualifications;
                idPowerPlantsTextBox.Text = _employees.plant_id.ToString();
            }
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            _employees.employee_name = NameTextBox.Text;
            _employees.employee_lastname = LastNameTextBox.Text;
            _employees.employee_position = PositionTextBox.Text;
            _employees.employee_email = EmailTextBox.Text;
            _employees.employee_qualifications = QualificationsTextBox.Text;
            _employees.plant_id = int.Parse(idPowerPlantsTextBox.Text);

            if (_employees.employee_id == 0)
            {
                _viewModel.Employees.Add(_employees);
                _viewModel._employeesService.AddEmployees(_employees);
            }
            else
            {
                _viewModel._employeesService.EditEmployees(_employees);
            }

            NavigationService.GoBack();
        }
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
