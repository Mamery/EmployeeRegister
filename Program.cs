using System;

namespace EmployeeRegister
{
    class Program
    {
        static Payroll info = new Payroll();
        static ConsoleUI ui = new ConsoleUI();
        static void Main(string[] args)
        {

            SeeData();

            do
            {
                ShowMenu();
                UserAction();
            } while (true);


        }

        private static void UserAction()
        {
           

            {

                switch (Console.ReadLine())

                {

                    case "1":

                        AddEmployee();

                        break;

                    case "2":

                        PrintEmployee();

                        break;

                    case "3":

                        Environment.Exit(0);

                        break;

                    default:

                        ui.Print("Wrong input");

                        break;

                }

            }


        }

        private static void ShowMenu()
        {
            Console.WriteLine("1: Show menu");
            Console.WriteLine("2: PrintEmployee");
            Console.WriteLine("3: Quit");
        }

        private static void AddEmployee()

        {

            do

            {

                ui.Print("Add a new Employee, Q for exit");

                string name = Util.AskForString("Name: ", ui);

                if (name.Equals("Q")) break;

                int salary = Util.AskForInt("Salary: ", ui);

                info.AddEmployees(name, salary);



            } while (true);

        }

        private static void PrintEmployee()
        {
            Employee[] employees = info.GetEmployee();

            foreach (Employee em in employees)
            {
                Console.WriteLine($"Name: {em.Name} Salary: {em.Salary}");
            }
        }

        private static void SeeData()
        {
            info.AddEmployees("Dmitris", 150000);
            info.AddEmployees("Mike", 20000);
            info.AddEmployees("Stephan", 450000);

        }
    }
}
