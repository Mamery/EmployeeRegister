using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeRegister
{
    class Employee
    {
        public int Salary { get; set; }
        public string Name { get; set; }

        public Employee(string name, int salary)
        {
            Salary = salary;
            Name = name;
        }


        //  public int MyProperty { get; set; } //auto-implemented property
        // public string Name { get => name; set => name = value; } //standard C# code
        /**
         * We need to write this peace of code so many times in our code and that is too much work to do.
         * it would b better to compress those codes in very few lines.
         */
    }
}
