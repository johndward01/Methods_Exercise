using System;

namespace Methods_Exercise_01_Answers
{
    class Program
    {
        static void Main(string[] args)
        {
            var userInput = String.Empty;
            // TODO: Call the PrintGreeting() method 
            PrintGreeting();

            // TODO: For each method call call the AddSpaces() method to separate the answers
            AddSpaces();

            // TODO: Call the SayHello() method
            SayHello("John", "Doe");

            AddSpaces();

            // TODO: Call the GreetUser() method
            GreetUser();

            AddSpaces();

            // TODO: Call the Exponentiate() method and store the returned value in a variable called result
            var result = Exponentiate();

            // TODO: Write result out to the console (display the result creatively)
            Console.WriteLine($"The result is: {result}");

            AddSpaces();

            // TODO: Call the IsPrime() method and write out the result to the console
            // TODO: Creatively display the information to the console window
            while (userInput.ToLower() != "no")
            {
                if (IsPrime())
                {
                    Console.WriteLine("The number is a prime number.");
                }
                else
                {
                    Console.WriteLine("The number is not a prime number");
                }

                AddSpaces();

                Console.WriteLine("Would you like to continue? (Type 'yes' and press enter to continue or 'no' and press enter to exit!)");
                userInput = Console.ReadLine();
            }
        }

        // TODO: Create a public static method called AddSpaces() which creates 2 blank lines when called
        public static void AddSpaces()
        {
            Console.WriteLine();
            Console.WriteLine();
        }

        // TODO: Create a public static method called PrintGreeting() with a return type of void that takes no parameters,
        // and writes to the console "Hello World!"
        public static void PrintGreeting()
        {
            Console.WriteLine("Hello World!");
        }

        // TODO: Create a public static method called SayHello() with a return type of void which takes 2 parameters firstName & lastName,
        // and concatenates them into a sentence Ex: "Hello, John Smith!" then writes them to the console
        public static void SayHello(string firstName, string lastName)
        {
            Console.WriteLine("Hello, " + firstName + " " + lastName + "!");
        }

        // TODO: Create a method called GreetUser() that asks the user for their name
        // then greets them with that name to the console (don't forget to prompt the user to enter their name!)
        public static void GreetUser()
        {
            Console.Write("Please enter your name: ");
            var userName = Console.ReadLine();
            Console.WriteLine($"Hello {userName}.. welcome!");
        }

        // TODO: Create a method called Exponentiate() that asks the user for a number and a powerOF
        // and then calculates the result of raising the first to the second (don't forget to prompt the user to enter the 2 numbers!)
        public static double Exponentiate()
        {
            Console.Write("Please enter the first number: ");
            var isANumber = double.TryParse(Console.ReadLine(), out double num);

            Console.Write("Please enter the second number: ");
            var isAPower = double.TryParse(Console.ReadLine(), out double powerOf);
            return Math.Pow(num, powerOf);
        }

        // TODO: Create a method called IsPrime() that asks the user for a number then returns true if the number is prime or false otherwise
        // (don't forget to prompt the user to enter the number!) 
        public static bool IsPrime()
        {
            Console.Write("Input the number and i'll check to see if it's prime: ");
            var input = double.Parse(Console.ReadLine());

            int counter = 2;
            while (counter < input)
            {
                if (input % counter == 0)
                {
                    return false;
                }
                counter++;
            }
            return true;
        }



    }
}
