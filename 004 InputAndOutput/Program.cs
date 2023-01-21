using System;

namespace _004_InputAndOutput
{
    class Program
    {
        static void Main(string[] args)
        {
            // Simple Output

            string hello = "Hello world";
            Console.WriteLine(hello);  //WriteLine-new line in the end
            Console.WriteLine("Welcome to the C#");
            Console.WriteLine(18.5);

            Console.Write("Hello "); //Write-without new line
            Console.Write("Barsik =P");
            Console.Write("\n\n\n"); // \n - three new lines


            //Trick called interpolation
            string name = "Constantin";
            int age = 35;
            double height = 1.85;
            Console.WriteLine($"Name:{name} Age:{age} Height:{height}m Cash:{238 + 125} bucks"); // Often there is a need to print to the console in one line the values ​​of several variables at once.
                                                                                                 // In this case, we can use a trick called interpolation

            Console.WriteLine("Name:{0} Age:{2} Height:{1}m", name, height, age);// {0}, {1}, {2}. These are placeholders, instead of which some values ​​will be substituted when the string is output to the console.
                                                                                 // Substituted values ​​are specified after the string separated by commas
            Console.Write("\n\n\n");

            //Simple input

            Console.WriteLine("Enter your name:");
            string? name2 = Console.ReadLine();
            Console.WriteLine($"Hi {name2}");
            /*A feature of the Console.ReadLine() method is that it can only read information from the console as a string. 
             * In addition, there is a possible situation when the Console.ReadLine method does not have lines available for reading, that is, when it has nothing to read, it returns null, that is, roughly speaking, in fact, the absence of a value.
             * And to reflect this situation, we define the variable name, into which we receive input from the console, as a variable of type string?. 
             * Here string indicates that the variable can store values ​​of type string, i.e. strings. 
             * And the question mark? indicates that the variable can also store the value null, that is, in fact, have no value*/
            Console.Write("\n\n\n");

            // If you need to read other types of data 

            // Convert.ToInt32()(conver to int type)

            //Convert.ToDouble()(convert to double type)

            //Convert.ToDecimal()(conver to decimal type)

            Console.Write("Enter your name:");
            string? name3 = Console.ReadLine();

            Console.Write("Enter your age: ");
            int age2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your height: ");
            double height2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter your salary: ");
            decimal salary = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine($"Name: {name3} Age: {age2} Height:{height2}m Salary:{salary}$");

            /*
             In C#, there are two types of casting:

             Implicit Casting (automatically) - converting a smaller type to a larger type size
            char -> int -> long -> float -> double

            Explicit Casting (manually) - converting a larger type to a smaller size type
            double -> float -> long -> int -> char
             */

            //Implicit Casting
            int myInt = 9;
            double myDouble = myInt;       // Automatic casting: int to double

            Console.WriteLine(myInt);      // Outputs 9
            Console.WriteLine(myDouble);   // Outputs 9

            //Explicit Casting
            double myDouble2 = 9.78;
            int myInt2 = (int)myDouble2;    // Manual casting: double to int

            Console.WriteLine(myDouble2);   // Outputs 9.78
            Console.WriteLine(myInt2);      // Outputs 9

            //Type Conversion Methods

            int myInt3 = 10;
            double myDouble3 = 5.25;
            bool myBool2 = true;

            Console.WriteLine(Convert.ToString(myInt3));    // convert int to string
            Console.WriteLine(Convert.ToDouble(myInt3));    // convert int to double
            Console.WriteLine(Convert.ToInt32(myDouble3));  // convert double to int
            Console.WriteLine(Convert.ToString(myBool2));   // convert bool to string




        }
    }
}
