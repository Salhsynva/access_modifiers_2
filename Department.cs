using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Department
    {
        public Department()
        {
            Employees = new Employee[0];
        }
        public string Name;
        public int EmployeeLimit;
        public double _salaryLimit;
        public Employee[] Employees;

        public double SalaryLimit 
        { get => _salaryLimit;
            set 
            {
                if (value >= 250)
                {
                    _salaryLimit = value;
                }
            }
        }
        public void AddEmployee(Employee employee)
        {
            if (Employees.Length < EmployeeLimit)
            {
                Array.Resize(ref Employees, Employees.Length + 1);
                Employees[Employees.Length - 1] = employee;
            }
            
        }
    }
}
