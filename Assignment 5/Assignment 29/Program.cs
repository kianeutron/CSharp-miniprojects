using System;

namespace Assignment29
{
    class Program
    {
        // Method to demonstrate passing by value
        static void ModifyByValue(int value)
        {
            value += 10; // Modifies the copy of the value
            Console.WriteLine($"Inside ModifyByValue, value is now: {value}");
        }

        // Method to demonstrate passing by reference
        static void ModifyByReference(ref int value)
        {
            value += 10; // Modifies the original value passed by reference
            Console.WriteLine($"Inside ModifyByReference, value is now: {value}");
        }

        // Start method to demonstrate passing by value and reference
        static void Start()
        {
            // Declare and initialize a value
            int number = 5;

            Console.WriteLine($"Original number before methods: {number}");

            // Passing by value - original value is unaffected
            ModifyByValue(number);
            Console.WriteLine($"After ModifyByValue, original number is still: {number}");

            // Passing by reference - original value is modified
            ModifyByReference(ref number);
            Console.WriteLine($"After ModifyByReference, original number is now: {number}");
        }

        // Main method to run the program
        static void Main(string[] args)
        {
            Start();
        }
    }
}
