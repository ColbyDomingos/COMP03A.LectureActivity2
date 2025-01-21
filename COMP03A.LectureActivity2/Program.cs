//Author: Colby D.
//Course COMP-003A
//Faculty: Jonathan Cruz
// Purpose: A program demonstrating statements, variables, and operators.

namespace COMP03A.LectureActivity2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Step 3.1 
            string userName; //name variable, name and stuff
            int userAge; //age variable, only simple ints
            double productPrice; //product price variable with decimals allowed
            bool isStudent; //stores if being a student is t or f

            //Adds a prompt asking for name of user
            Console.Write("Enter your name pleaseeeee: ");
            userName = Console.ReadLine(); //sets what they type as the name var

            //prompts for their age
            Console.Write(userName + " how old are you: ");
            userAge = int.Parse(Console.ReadLine()); //parses the string into an int and stores it as age

            //prompts for a product price, maybe they are selling something?
            Console.Write("Enter the price of a product: ");
            productPrice = double.Parse(Console.ReadLine()); //parses the string into a double and stores it into price var

            //asks if the student is in fact a student
            Console.Write("Are you a student? (true/false): ");
            isStudent = bool.Parse(Console.ReadLine()); //parses the string into a bool and stores it in the bool isStudent

            //Step 3.2: Perform calcualtions
            int futureAge = userAge + 5; // userAge +5, thus future
            bool isAdult = userAge >= 18; // States if user is 18 or older
            bool isAdultStudent = isStudent && isAdult; // Determine if the user is an adult student

            //Step 3.3: Display outputs using string interpolation 
            Console.WriteLine($"\nHola, {userName}.");// Greetings me and or you
            Console.WriteLine($"You are currently {userAge} years young. In 5 years you gonna be {futureAge}."); // Tells them about their future age
            Console.WriteLine($"Are you 18 or older???? {isAdult}"); // States if the user is 18 or nay
            Console.WriteLine($"Are you both a student and 18 or older????? {isAdultStudent}"); // Displays if the user is both an adult and is a student
        }
    }
}
