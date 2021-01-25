using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeRegister
{
    class Util
    {
        public static string AskForString(string prompt, ConsoleUI ui)

        {

            bool finished = false; //We just started and we have not finished yet

            string answer;



            do

            {

                Console.WriteLine(prompt);

                answer = ui.GetInput();


                if (String.IsNullOrWhiteSpace(answer))

                {

                    ui.Print("You must enter something, we have not finished yet and we are still in the loop");

                }

                else

                {

                    finished = true; 

                }


            } while (!finished);


            return answer;

        }



        public static int AskForInt(string prompt, ConsoleUI ui)

        {

            bool success = false;

            int answer;



            do

            {

                string input = AskForString(prompt, ui);

                success = int.TryParse(input, out answer);

                if (!success)

                    ui.Print("Only numbers");





            } while (!success);



            return answer;



        }
    }
}
