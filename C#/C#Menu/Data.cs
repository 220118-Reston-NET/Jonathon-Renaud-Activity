using System.Collections;

namespace DataCollection
{
    public class Data 
    {
        private List<string> _notes = new List<string>();
        public static void DataMain(){

        

            

           Console.WriteLine("This is Data");
           Console.ReadLine();

        }

        public void View(){
            Console.WriteLine("Here is a list of your current notes:");
            
            int prefix = 1;
            foreach (string item in _notes)
            {
                Console.WriteLine($"{prefix}.{item}");
                prefix++;
            }
            Console.WriteLine("Press enter key to continue");
            Console.ReadLine();
        }

        public void Add(string hinasd){
            
            _notes.Add(hinasd);    
            Console.WriteLine("Note has been added! Press enter to continue");            
            Console.ReadLine();

        }

        public void Delete(){
            Console.WriteLine("Which note would you like to delete?");
            int prefix = 1;
            foreach (string item in _notes)
            {
                Console.WriteLine($"{prefix}.{item}");
                prefix++;
            }
            int numInput = Convert.ToInt32(Console.ReadLine());
            int arrayConvert = numInput-1;
            _notes.RemoveAt(arrayConvert);
            Console.WriteLine("The note has been successfully deleted. Press enter to continue");
            Console.ReadLine();


        }

        public void Search(){
            // Console.WriteLine("What number note would you like to look up?");
            // int numSearch = Convert.ToInt32(Console.ReadLine());
            // while (numSearch > _notes.Length || numSearch < 0) {
            //     Console.WriteLine("Number is outside of range of the number of list items found. Please enter a new number.");
            //     numSearch = Convert.ToInt32(Console.ReadLine());
            // }
        }
    }    
}