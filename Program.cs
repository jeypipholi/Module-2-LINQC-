using System;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace LINQActivity
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var manager = new EmployeeManager();

            while (true)
            {
                Console.WriteLine("\nEmployee Management System" +
                                  "\n1. Add Employee" +
                                  "\n2. List of all Employees" +
                                  "\n3. Find Employee by ID" +
                                  "\n4. Update Employee" +
                                  "\n5. Delete Employee" +
                                  "\n6. Exit");
                Console.Write("Enter your choice (1-6): ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter Employee Id: ");
                        int empid = int.Parse(Console.ReadLine());
                        Console.Write("Enter Name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter Position: ");
                        string position = Console.ReadLine();
                        Console.Write("Enter Salary: ");
                        decimal salary = decimal.Parse(Console.ReadLine());

                        manager.AddEmployee(new Employee(empid, name, position, salary));
                        break;
                    case 2:
                        manager.DisplayAll();
                        Console.WriteLine();
                        break;
                    case 3:
                        Console.Write("Enter employee id: ");
                        int searchId = int.Parse(Console.ReadLine());
                        manager.FindEmployee(searchId);
                        Console.WriteLine();
                        break;
                    case 4:
                        Console.Write("Enter employee ID: ");
                        int updateId = int.Parse(Console.ReadLine());
                        Console.Write("Enter Updated Name: ");
                        string updateName = Console.ReadLine();
                        Console.Write("Enter updated Position: ");
                        string updatePosition = Console.ReadLine();
                        Console.Write("Enter updated salary: ");
                        decimal updateSalary = decimal.Parse(Console.ReadLine());
                        manager.UpdateEmployee(updateId,updateName,updatePosition,updateSalary);
                        Console.WriteLine();
                        break;
                    case 5:
                        Console.Write("Enter employee Id to delete: ");
                        int deleteId = int.Parse(Console.ReadLine());
                        manager.DeleteEmployee(deleteId);
                        Console.WriteLine();
                        break;
                    case 6:
                        Console.WriteLine("Exitingggggg.");
                        return;
                    default:
                        Console.WriteLine("Invalid Input. Please try again.");
                        break;
                }
            }
        }
    }
}
