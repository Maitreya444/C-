using System;

namespace MyApp
{
    public class Datatype
    {
        public unsafe void PrintDatatypes()
        {
            // Integer Types
            byte b = 255;
            sbyte sb = -128;
            short s = -32768;
            ushort us = 65535;
            int i = 2147483647;
            uint ui = 4294967295;
            long l = 9223372036854775807;
            ulong ul = 18446744073709551615;

            // Floating Point Types
            float f = 3.14f;
            double d = 9.698848465;
            decimal dec = 79228162514264337593543950335m;

            // Other Value Types
            char c = 'A';
            bool boolean = true;

            // Reference Types
            string str = "NK S";
            object obj = "This is an object";

            // Pointer demonstration for value types
            int* ptr = &i; // Pointer to integer
            double* dPtr = &d; // Pointer to double
            char* cPtr = &c; // Pointer to char

            // Printing values
            Console.WriteLine("Integer Types:");
            Console.WriteLine($"byte: {b}");
            Console.WriteLine($"sbyte: {sb}");
            Console.WriteLine($"short: {s}");
            Console.WriteLine($"ushort: {us}");
            Console.WriteLine($"int: {i}");
            Console.WriteLine($"uint: {ui}");
            Console.WriteLine($"long: {l}");
            Console.WriteLine($"ulong: {ul}");

            Console.WriteLine("\nFloating Point Types:");
            Console.WriteLine($"float: {f}");
            Console.WriteLine($"double: {d}");
            Console.WriteLine($"decimal: {dec}");

            Console.WriteLine("\nOther Value Types:");
            Console.WriteLine($"char: {c}");
            Console.WriteLine($"bool: {boolean}");

            Console.WriteLine("\nReference Types:");
            Console.WriteLine($"string: {str}");
            Console.WriteLine($"object: {obj}");

            // Printing memory addresses and values using pointers
            Console.WriteLine("\nPointer Values:");
            Console.WriteLine($"Address of int variable: {(long)ptr:X}, Value: {*ptr}");
            Console.WriteLine($"Address of double variable: {(long)dPtr:X}, Value: {*dPtr}");
            Console.WriteLine($"Address of char variable: {(long)cPtr:X}, Value: {*cPtr}");
        }
    }
}
