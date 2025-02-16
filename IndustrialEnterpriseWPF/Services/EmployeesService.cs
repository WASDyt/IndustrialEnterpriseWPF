using IndustrialEnterpriseWPF.BD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndustrialEnterpriseWPF.Services
{
    internal class EmployeesService
    {
        public List<Employees> GetEmployees()
        {
            using (var context = new IndustrialEnterpriseEntities())
            {
                return context.Employees.ToList();
            }
        }

        public void AddEmployees(Employees employees)
        {
            using (var context = new IndustrialEnterpriseEntities())
            {
                context.Employees.Add(employees);
                context.SaveChanges();
            }
        }

        public void EditEmployees(Employees employees)
        {
            using (var context = new IndustrialEnterpriseEntities())
            {
                var existingEmployees = context.Employees.Find(employees.employee_id);
                if (existingEmployees != null)
                {
                    existingEmployees.employee_name = employees.employee_name;
                    existingEmployees.employee_lastname = employees.employee_lastname;
                    existingEmployees.employee_position = employees.employee_position;
                    existingEmployees.employee_email = employees.employee_email;
                    existingEmployees.employee_qualifications = employees.employee_qualifications;
                    existingEmployees.plant_id = employees.plant_id;
                    context.SaveChanges();
                }
            }
        }

        public void DeleteEmployees(int employeesId)
        {
            using (var context = new IndustrialEnterpriseEntities())
            {
                var employees = context.Employees.Find(employeesId);
                if (employees != null)
                {
                    context.Employees.Remove(employees);
                    context.SaveChanges();
                }
            }
        }
    }
}
