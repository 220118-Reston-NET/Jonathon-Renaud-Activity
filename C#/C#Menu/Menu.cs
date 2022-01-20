namespace MenuFunction
{
    public class Menu
    {
        public static void MenuMain(){
            bool repeat = true;

            while(repeat){

            Console.Clear();
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("~~~~~~~~~~~~~ Basic Calculator ~~~~~~~~~~~~");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("1. Add two numbers!");
            Console.WriteLine("2. Subtract two numbers!");
            Console.WriteLine("3. Multiply two numbers!");
            Console.WriteLine("4. Divide two numbers!");
            Console.WriteLine("5. Exit Calculator");
            string? userInput = Console.ReadLine();

            if (userInput == "1")
            {
                Console.WriteLine("Please give me two numbers to add");
                int num1 = Convert.ToInt32(Console.ReadLine());
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"The sum of {num1} and {num2} is {num1+num2}");
                Console.WriteLine("Press enter key to continue");
                Console.ReadLine();
            }

            else if (userInput == "2")
            {
                Console.WriteLine("Please give me a starting number");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please give a number to subtract from the first number");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"When you subtract {num2} from {num1} the result is {num1-num2}");
                Console.WriteLine("Press enter key to continue");
                Console.ReadLine();
            }

            else if (userInput == "3")
            {
                Console.WriteLine("Please give me two numbers to mulitple together");
                int num1 = Convert.ToInt32(Console.ReadLine());
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"{num1} * {num2} is {num1*num2}");
                Console.WriteLine("Press enter key to continue");
                Console.ReadLine();


            }

            else if (userInput == "4")
            {
                Console.WriteLine("Please give me a starting number");
                double num1 = (double)Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please give a number to divide the first number by");
                double num2 = (double)Convert.ToInt32(Console.ReadLine());
                while (num2 == 0 )
                {
                    Console.WriteLine("Please enter a non-zero number, cannot divide by zero!");
                    num2 = (double)Convert.ToInt32(Console.ReadLine());
                }
                    

                Console.WriteLine($" {num1} / {num2}  is {num1/num2}");
                Console.WriteLine("Press enter key to continue");
                Console.ReadLine();
                
            }

            else if (userInput == "5")
            {
                repeat = false;
                Console.WriteLine("Thanks for using me! <3  Goodbye!");
            }

            else {
                Console.WriteLine("Invalid input, try again");
                Console.WriteLine("Press enter key to go back and try again");
                Console.ReadLine();
            };

            };

        }
    }
}