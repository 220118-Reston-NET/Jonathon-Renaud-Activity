using System.Collections;

namespace CollectionFunction

{
    public class Collection
    {
        //Array
        //Used to store a datatype and have a fixed size
        //Syntax: (datatype[] (name of variable) = new (datatype)[(size of the array)])

        private int[] _nums = new int[5];

        // Generic collection
        // They store a specific datatype and have a variable size
        // Syntax: <(dataype)>

        // List Collection
        // zero-based index
        // used to store a datatype and has variable size
        private List<string> _strings = new List<string>();

        //Hashset Collection
        // There is no particular order to the elements, so not zero-based index
        // no duplicate elements
        private HashSet<int> _numsCollection = new HashSet<int>();

        // Dictionary Collection
        // Stores information through key-value pairs
        // There is no particular order
        private Dictionary<string,int> _directory = new Dictionary<string,int>();

        // Non-Generic Collection
        // They store any datatype and have a variable size
        private ArrayList _nonGeneric = new ArrayList();

        public void CollectionMain()
        {
            Console.WriteLine("==Collection Demo==");

            _nums[0] = 3;
            _nums[1] = 10;
            _nums[2] = 4;
        

            foreach (int num in _nums)
            {
            Console.WriteLine(num);
            }

            for (int i = 0; i < _nums.Length; i++)
            {
                
            }

            Console.WriteLine("==List Collection==");
            Console.WriteLine("List demo");
            _strings.Add("First element");
            _strings.Add("Second Element");
            _strings.Add("Third Element");

            foreach (string item in _strings)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(_strings[1]);

            Console.WriteLine("Hashset Demo");
            _numsCollection.Add(1);
            _numsCollection.Add(3);

            foreach (int item in _numsCollection)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("++++++++++Dictionary Demo");
            _directory.Add("Jonathon", -10000);
            _directory.Add("Vijhan", -100000);
            _directory.Add("Terrence", 50000);

            Console.WriteLine(_directory["Jonathon"]);

            Console.WriteLine("Non generic demo");

            _nonGeneric.Add("JN");
            _nonGeneric.Add(15);
            _nonGeneric.Add(false);

            foreach (var item in _nonGeneric)
            {
                Console.WriteLine(item);
            }

        }
    }    

}