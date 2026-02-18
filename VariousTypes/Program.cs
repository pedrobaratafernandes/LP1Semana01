using System;

namespace VariousTypes
{
    public class Program
    {

        private static void Main(string[] args)
        {

            // Create integer variables
            int a = 10;        // standard integer (32 bits)
            uint b = 20U;      // unsigned integer (32 bits)
            long c = 30L;      // long integer (64 bits)
            ulong d = 40UL;    // unsigned long integer (64 bits)
            short e = 5;       // short integer (16 bits)
            byte f = 255;      // very short integer (8 bits)

            // Print the values of the various integer variables to the console
            Console.WriteLine($"int: {a}");
            Console.WriteLine($"uint: {b}");
            Console.WriteLine($"long: {c}");
            Console.WriteLine($"ulong: {d}");
            Console.WriteLine($"short: {e}");
            Console.WriteLine($"byte: {f}");

            // emoji in char (16 bits)
            char love = '\u2764';
            char rain = '\u2602';
            char smile = '\u263A';


            // Print the emojis
            Console.WriteLine($"{love} {rain} {smile}");

            // Create real (floating-point) variables
            double x = 3.1415;    // double precision (64 bits)
            float y = 3.1415f;    // single precision (32 bits)
            decimal z = 3.1415m;  // decimal precision (128 bits)

            // Print the values of the various real variables to the console
            Console.WriteLine($"double: {x}");
            Console.WriteLine($"float: {y}");
            Console.WriteLine($"decimal: {z}");
        }
    }
}
