namespace _002_VariablesAndConstants
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;  // Declare variable without assign value
            name = "Tom"; // assign the value later
            int age = 15; // Declare variable and assign value in one statement
            //const char gender; // You cannot declare a constant variable without assigning the value. If you do, an error will occur: A const field requires a value to be provided.
            const char gender = 'M'; // can't change value of constant variable (read-only)
            double balance_in_bank = 150.54;
            bool hostel_pass = true;

            Console.WriteLine($"Student name is:{name}"); // output name is  Tom
            Console.WriteLine($"Age is:{age}");           // output age is 15
            Console.WriteLine($"Gender is:{gender}");     // output gender is M (male)
            Console.WriteLine($"Balance in banks is{balance_in_bank} bucks");
            Console.WriteLine($"The student has a pass to the hostel?:{hostel_pass }");

            name = "Bob";             // We can change variable value
            age = 21;                 // We can change variable value
            // gender = 'F'; Will throw an error because we can't change the value of the constant variable (read-only)
            balance_in_bank = 125.34; // We can change variable value
            hostel_pass = false;      // We can change variable value

            Console.WriteLine("\nAfter change variable name,age,balance_bank,hostel_pass");

            Console.WriteLine($"\nStudent name is:{name}"); // now output is name is Bob
            Console.WriteLine($"Age is:{age}");             // now output age is 21
            Console.WriteLine($"Gender is:{gender}");       //output gender is male without any changes
            Console.WriteLine($"Balance in banks is {balance_in_bank} bucks");
            Console.WriteLine($"The student has a pass to the hostel?:{hostel_pass}");

            Console.WriteLine(); // Works like \n
            Console.WriteLine(age + balance_in_bank); // we can do mathematical operations with variables. Output 146.34
            Console.WriteLine("Hello " + name); //Combine text and a variable. Output Hello Bob

            int x = 5, y = 6, z = 50; //Declare more than one variable of the same type , use  a comma-separated list
            Console.WriteLine(x + y + z); //61

            int a, b, c;
            a = b = c = 50; //You can assign the same value to multiple variables in one line
            Console.WriteLine(a+b+c); //150




        }
    }
}