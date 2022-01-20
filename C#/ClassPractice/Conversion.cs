namespace ConversionFunction
{
    public class Conversion
    {
            // Static fields are shared between all objects from this class
            // In this way if you need a universal info that needs to be stored and shared to every object from this
            // Use a static field
        public static int _num;
            // static methods will make using that method without creating an object
        public static void ConversionMain()
        {
                // implicit - just means something is done automatically (most likely the compiler is doing it)
                // explicit - just means you have to write something to do it

                Console.WriteLine("=== Conversion Demo ===");
                int x = 10;
                double y = 85.29;
                char c = 'u';
                string str = "Hiya Barbie";

                // Implicit conversion

                double anotherDouble = x;
                Console.WriteLine(anotherDouble);

                // Explicit conversion
                int anotherInt = (int)y;
                // You now have lost the decimal in the process
        }

        public int GiveMeNumber()
        {
            return _num;
        }
    }
}