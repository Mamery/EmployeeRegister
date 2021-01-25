using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeRegister
{
    class ConsoleUI
    {
        public string GetInput()

        {

            return Console.ReadLine();

        }



        public void Print(string message)

        {

            Console.WriteLine(message); //write to the console

        }



        public void Print(Employee employee)

        {

            Console.WriteLine(employee);

        }
    }
}
