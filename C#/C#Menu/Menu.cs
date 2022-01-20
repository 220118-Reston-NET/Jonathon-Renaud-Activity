using DataCollection;

namespace MenuFunction
{
    
        public class Menu
    {

            public static void MenuMain(){
            bool repeat = true;
            Data data = new Data();


            while(repeat){

            Console.Clear();
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("~~~~~~~~~~~~~ Basic Calculator ~~~~~~~~~~~~");
            Console.WriteLine("~~~~~~~~~~~~~ & Short Notes!!! ~~~~~~~~~~~~");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("1. Add two numbers!");
            Console.WriteLine("2. Subtract two numbers!");
            Console.WriteLine("3. Multiply two numbers!");
            Console.WriteLine("4. Divide two numbers!");
            Console.WriteLine("5. View/Edit Notes");
            Console.WriteLine("6. Exit Application");
            string? userInput = Console.ReadLine();

            if (userInput == "1")
            {
                Console.WriteLine("Please give me two numbers to add");
                int num1 = Convert.ToInt32(Console.ReadLine());
                int num2 = Convert.ToInt32(Console.ReadLine());

                string answer = $"The sum of {num1} and {num2} is {num1+num2}";
                Console.WriteLine(answer);
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
            //    Data.DataMain();
            bool repeat2 = true;

            while(repeat2) {
            Console.Clear();
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("~~~~~~~~~~~~~    Notes Menu    ~~~~~~~~~~~~");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("1. View Current Notes");
            Console.WriteLine("2. Add a New Note");
            Console.WriteLine("3. Delete a Note");
            Console.WriteLine("4. Search for a Specific Note");
            Console.WriteLine("5. Exit This Menu");
            string? userInput2 = Console.ReadLine();

            switch (userInput2)
            {
                case "1":
                    break;
                case "2":
                    Console.WriteLine("What note would you like to add to your notes?");
                    string res = Console.ReadLine();
                    data.Add(res);
                    break;
                case "3":
                    break;
                case "4":
                    break;
                case "5":
                    repeat2 = false;
                    break;
                default:
                    Console.WriteLine("Invalid input, please try again!");
                    break;

            }

               
            }
            }

            else if (userInput == "6")
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