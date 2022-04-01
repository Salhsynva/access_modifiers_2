using System;
using ClassLibrary;

namespace AccessModifiers2
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee();
            employee1.Name = "nergiz";
            employee1.Surname = "Abbasov";
            employee1.Salary = 1000;

            Employee employee2 = new Employee();
            employee2.Name = "Saleh";
            employee2.Surname = "Eliyev";
            employee2.Salary = 900;

            Department department = new Department();
            department.EmployeeLimit = 3;
            department.AddEmployee(employee1);
            department.AddEmployee(employee2);

            foreach (var item in department.Employees)
            {
                Console.WriteLine($"iscinin adi: {item.Name} - soyadi: {item.Surname} - maasi {item.Salary}");
            }

        }
    }
}
