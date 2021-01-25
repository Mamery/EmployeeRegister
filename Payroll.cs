using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeRegister
{
    class Payroll
    {
        private List<Employee> payroll;


        public Payroll()
        {

            payroll = new List<Employee>();

        }

        public void AddEmployees(string name, int salary)

        {
            Employee emp = new Employee(name, salary);
            payroll.Add(emp);

        }

        public Employee[] GetEmployee()
        {

            Employee[] list = payroll.ToArray();

            return list;

        }


    }
}
