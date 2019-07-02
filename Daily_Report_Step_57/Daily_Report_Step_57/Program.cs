using System;

namespace Daily_Report_Step_57
{
    class Program
    {
        static void Main()
        {
            string userInput;
            byte byteValue;

            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");

            Console.Write("What course are you on?");
            string courseCurrent = Console.ReadLine();


            Console.Write("What page number are you on?");
            userInput= Console.ReadLine();
            byte coursePageNumber = Convert.ToByte(userInput);

            Console.Write("Do you need help with anything? Please answer 'true' or 'false'.");
            userInput = Console.ReadLine();
            bool courseHelp = Convert.ToBoolean(userInput);

            Console.Write("Were there any positive experiences you’d like to share? Please give specifics.");
            string courseExperience = Console.ReadLine();

            Console.Write("Is there any other feedback you’d like to provide? Please be specific.");
            string courseFeedback = Console.ReadLine();

            Console.Write("How many hours did you study today?");
            userInput = Console.ReadLine();
            byte courseHours = Convert.ToByte(userInput);
        }
    }
}
