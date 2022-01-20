using System.Collections;

namespace DataCollection
{
    public class Data 
    {
        private List<string> _notes = new List<string>();
        // public static void DataMain(){

        

            

        //    Console.WriteLine("This is Data");
        //    Console.ReadLine();

        // }

        public void View(){
            Console.Clear();
            Console.WriteLine("Here is a list of your current notes:");
            
            int prefix = 1;
            foreach (string item in _notes)
            {
                Console.WriteLine($"{prefix}.{item}");
                prefix++;
            }
            Console.WriteLine("\r\n Press enter key to continue");
            Console.ReadLine();
        }

        public void Add(string str){
            _notes.Add(str);    
            Console.WriteLine("\r\n Note has been added! Press enter to continue");            
            Console.ReadLine();

        }

        public void Delete(){
            try{
            Console.Clear();
            Console.WriteLine("Which note would you like to delete? (If none, just hit enter)");
            int prefix = 1;
            foreach (string item in _notes)
            {
                Console.WriteLine($"{prefix}.{item}");
                prefix++;
            }
            int numInput = Convert.ToInt32(Console.ReadLine());
            while (numInput > _notes.Count || numInput < 1) {
                Console.WriteLine("Number is outside of range of the number of list items found. Please enter a new number.");
                numInput = Convert.ToInt32(Console.ReadLine());
            }
            int arrayConvert = numInput-1;
            _notes.RemoveAt(arrayConvert);
            Console.WriteLine("\r\n The note has been successfully deleted. Press enter to continue");
            Console.ReadLine();
            }
            catch(FormatException e) {
                Console.WriteLine("\r\n No valid entry was input, going back to main menu.");
                Console.ReadLine();
            }


        }

        public void Search(){
            try{
            Console.Clear();
            Console.WriteLine("What number note would you like to look up?");
            int numSearch = Convert.ToInt32(Console.ReadLine());
            while (numSearch > _notes.Count || numSearch < 1) {
                Console.WriteLine("\r\n Number is outside of range of the number of list items found. Please enter a new number.");
                numSearch = Convert.ToInt32(Console.ReadLine());
            }
            int arrayConvert = numSearch-1;
            Console.WriteLine("Your note has been found and is below -- press enter to continue");
            Console.WriteLine(_notes[arrayConvert]);
            Console.ReadLine();
            }
            catch(FormatException e) {
                Console.WriteLine("\r\n No valid entry was input, going back to main menu.");
                Console.ReadLine();
            }
        }
    }    
}