using System;

namespace HelloWorld
{
    public class DataTypes
    {
        // Instance variables
        byte age = 31;
        int num = 200;
        float years = 3.5f;
        double price = 35.66;
        decimal turnOver = 345678.987m;
        char initial = 'A';
        string name = "Sanjeev";

        // Main method where the program execution starts
        public static void Main(string[] args)
        {
            // Create an instance of the DataTypes class to access its non-static fields
            DataTypes data = new DataTypes();

            // Print all the data types
            Console.WriteLine("Age (byte): " + data.age);
            Console.WriteLine("Number (int): " + data.num);
            Console.WriteLine("Years (float): " + data.years);
            Console.WriteLine("Price (double): " + data.price);
            Console.WriteLine("Turnover (decimal): " + data.turnOver);
            Console.WriteLine("Initial (char): " + data.initial);
            Console.WriteLine("Name (string): " + data.name);
        }
    }
}
