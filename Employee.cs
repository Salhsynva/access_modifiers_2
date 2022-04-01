using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Employee
    {
        public string _name;
        public string _surname;
        public double _salary;

        public string Name
        {
            get => _name;
            set
            {
                int count = 1;
                if (!string.IsNullOrWhiteSpace(value) && char.IsLetter(value[0]) && char.IsUpper(value[0]))
                {
                    for (int i = 1; i < value.Length; i++)
                    {
                        if (char.IsLetter(value[i]))
                            count++;
                    }
                }
                if (count > 1)
                    _name = value;
            }
        }
        public string Surname
        {
            get => _surname;
            set
            {
                int count = 1;
                if (!string.IsNullOrWhiteSpace(value) && char.IsLetter(value[0]) && char.IsUpper(value[0]))
                {
                    for (int i = 1; i < value.Length; i++)
                    {
                        if (char.IsLetter(value[i]))
                            count++;
                    }
                }
                if (count > 1)
                    _surname = value;
            }
        }
        public double Salary {
            get => _salary;
            set 
            {
                if (value >= 250)
                    _salary = value;
            } 
        }

    }
}
