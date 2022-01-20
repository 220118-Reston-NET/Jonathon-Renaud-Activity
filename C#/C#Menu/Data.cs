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

        public void Add(string res){
            _notes.Add(res);
            
            foreach (string item in _notes)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();

        }

    }    
}