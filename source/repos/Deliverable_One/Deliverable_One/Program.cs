using System;

namespace Deliverable_One
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! What kind of trip would you like to go on?" + " Please choose one: musical, tropical, or adventurous");

            //Declare and initialize variables
            string vacationType = Console.ReadLine();
            string statement = "";
            string result;

            Console.WriteLine("How many are in your group?");

            int groupSize = Convert.ToInt32(Console.ReadLine());
            string suggest = "";

            //Conditional Statements
            if (vacationType == "musical") statement = "New Orleans.";
            else if (vacationType == "tropical") statement = "A Beach vacation in Mexico.";
            else if (vacationType == "adventurous") statement = "go whitewater rafting in the Grand Canyon.";

            if (groupSize <= 2) suggest = "take a First Class Flight";
            else if (groupSize > 2 && groupSize <= 5) suggest = "go by Helicopter ride";
            else if (groupSize >= 6) suggest = "Charter a Flight";

            //Concatenation

            result = "Since you are a group of " + groupSize + " going on a " + vacationType + " vacation, you should " + suggest + " to " + statement;
            Console.WriteLine(result);
        }
    }
}
