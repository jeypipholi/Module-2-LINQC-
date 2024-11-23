using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQActivity
{
    public class EmployeeManager
    {
        private List<Employee> employees = new List<Employee>();
        public EmployeeManager()
        {
            employees = new List<Employee>();
        }
        public void AddEmployee(Employee employee)
        {
            if (employees.Any(e => e.Id == employee.Id))
            {
                Console.WriteLine("Employee with the samee ID already exists.");
                return;

            }
            employees.Add(employee);
            Console.WriteLine("Employee Added Successfully.");
            Console.WriteLine();
        }
        public void DisplayAll()
        {
            if (!employees.Any())
            {
                Console.WriteLine("No employees Found.");
                return;
            }
            Console.WriteLine("Employee List: ");

            foreach (var employee in employees)
            {
                Console.WriteLine(employee);
            }
            
            Console.WriteLine();
        }
        public void FindEmployee(int id)
        {

            var employee = employees.FirstOrDefault(e =>e.Id == id);

            if (employee == null)
            {
                Console.WriteLine("Employee Not Found");
            }
            else
            {
                Console.WriteLine("Employee Details: ");
                Console.WriteLine(employee);
            }
            Console.WriteLine();
        }
        public void UpdateEmployee(int id, string name, string position, decimal salary)
        {
            var employee = employees.FirstOrDefault(e => e.Id == id);

            if (employee == null)
            {
                Console.WriteLine("Employee Not Found.");
                return;
            }

            employee.Name = name;
            employee.Position = position;
            employee.Salary = salary;
            Console.WriteLine("Employee details updated successfully");
            Console.WriteLine();
        }

        public void DeleteEmployee(int id)
        {
            var employee = employees.FirstOrDefault(e => e.Id == id);
            if (employee == null)
            {
                Console.WriteLine("Employee not Found.");
                return;
            }
            employees.Remove(employee);
            Console.WriteLine("Employee removed successfully.");
            Console.WriteLine();
        }
    }
}
