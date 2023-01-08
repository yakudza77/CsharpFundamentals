namespace _003_DataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool alive = true;   //Store true or false (1 or 0)
            bool isDead = false; // Size 1 bit

            // Type store  Whole numbers

            byte bit1 = 1;    //Store whole number from 0 to 255 by default unsigned
            byte bit2 = 102;  // Size 1 byte = 8bit

            sbyte bit3 = - -101; // signed byte type store whole number from -128 to 127
            sbyte bit4 = 104; // Size 1 byte = 8 bit

            short n1 = 1;     // store whole number from -32768 to 32767 by default is signed
            short n2 = -102;  // Size 2 bytes = 16 bit

            ushort n3 = 128;  //unsigned short type store whole number from 0 to 65535
            ushort n4 = 256;  // Size 2 bytes = 16 bit

            int a = 10;       //store whole number from -2147483648 to 2147483647 by default is signed
            int b = 356475865;//size 4 bytes = 32 bit 
            int c = 0b101;    //binary notation starting with 0b      b = 5
            int d = 0xFF;     // hexadecimal notation starts with 0x  d =255

            uint a1 = 10500;  //store whole number from 0 to 4294967295 Size is 4 bytes = 32 bit

            long l1 = -23432353253543L; // Store whole number from –9 223 372 036 854 775 808 to 9 223 372 036 854 775 807
            long l2 = 2343256546576765L;// By default is signed Size 8 bytes = 64 bit
            // We add L to the number because by default number will be readed like integer literal

            ulong l3 = 567346873685734687L;// unsigned long type store whole number from 0 to 18 446 744 073 709 551 615
                                           // Size is  8 bytes = 64 bit

            // Type store Fractional numbers

            //When assigning values, keep in mind the following subtlety: all real literals (fractional numbers) are treated as double values.
            //And to indicate that a fractional number represents a float type or a decimal type, you need to add a suffix to the literal: F / f - for float and M / m - for decimal.  

            float f1 = 45.345345F; //Note that you should end the value with an "F" for floats
                                   //Stores fractional numbers. Sufficient for storing 6 to 9 decimal digits
                                   // Size 4 bytes = 32but
            double d1 = 46.123213; //Note that you should end the value with an "D" for doubles
                                    // Stores fractional numbers. Sufficient for storing 15-17 decimal digits
                                    // Size 8 bytes
            decimal d2 = 46.34543643M; //Note that you should end the value with an "M" for decimal  (M money)
                                       //Stores fractional numbers. Sufficient for storing 28 to 29 decimal digits
           //The Decimal value type is appropriate for financial calculations that require large numbers of significant integral and fractional digits and no round-off errors


            //Type store character/letter/characters

            char q1 = 'A';  // Stores a single character/letter, surrounded by single quotes. Size 2 bytes
            char q2 = '\x5A'; //code ASCII     q2 = Z  www.asciitable.com
            char q3 = '\u0411'; // code Cyrillic Unicode q3 = Б

            string hello = "Hello"; // Stores a sequence of characters, surrounded by double quotes.
                                    // Size  2 bytes per character

            // Other types

            System.Int32 number = 56; //System type, is the full name of the type int

            // Implicit typing

            //For implicit typing, the var keyword is used instead of the data type name.
            //Then, during compilation, the compiler itself infers the data type based on the assigned value

            var word = "Hello world"; //the variable word is assigned a string, so this variable will be of type string
            var c2 = 256; //Since by default all integer values ​​are considered as values ​​of type int, therefore, in the end, the variable c will have type int

            // var c = null; //This code don't work with type var. You can't assign null to an implicitly-typed variable

            // This code don't work

            //var c3; //Implicity typed variables must be initialized

            














        }
    }
}