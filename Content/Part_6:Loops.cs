using System;

class Program
{
    static void Main(string[] args)
    {
        // Count to 3 using different types of loops
        Console.WriteLine("Using while loop:");
        CountWithWhileLoop();

        Console.WriteLine("\nUsing do-while loop:");
        CountWithDoWhileLoop();

        Console.WriteLine("\nUsing for loop:");
        CountWithForLoop();

        Console.WriteLine("\nUsing foreach loop:");
        CountWithForEachLoop();

        Console.WriteLine("\nUsing ternary operator:");
        CountWithTernary();
    }

    // Function to count to 3 using a while loop
    static void CountWithWhileLoop()
    {
        int counter = 1; // Start counting from 1
        while (counter <= 3) // Loop while counter is less than or equal to 3
        {
            Console.WriteLine(counter); // Print current count
            counter++; // Increment the counter
        }
    }

    // Function to count to 3 using a do-while loop
    static void CountWithDoWhileLoop()
    {
        int counter = 1; // Start counting from 1
        do
        {
            Console.WriteLine(counter); // Print current count
            counter++; // Increment the counter
        } while (counter <= 3); // Check the condition at the end of the loop
    }

    // Function to count to 3 using a for loop
    static void CountWithForLoop()
    {
        // Initialize counter, set condition, and increment counter in the for loop
        for (int counter = 1; counter <= 3; counter++)
        {
            Console.WriteLine(counter); // Print current count
        }
    }

    // Function to count to 3 using a foreach loop
    static void CountWithForEachLoop()
    {
        // Create an array with the numbers 1, 2, and 3
        int[] numbers = { 1, 2, 3 };

        // Use foreach to iterate through each element in the array
        foreach (int number in numbers)
        {
            Console.WriteLine(number); // Print each number
        }
    }

    // Function to count to 3 using ternary operator
    static void CountWithTernary()
    {
        // A simple approach to use the ternary operator to count to 3
        // This prints each number 1, 2, or 3 based on the value of i
        for (int i = 1; i <= 3; i++)
        {
            // Ternary operator to print either the current number or nothing (always prints)
            string result = (i <= 3) ? i.ToString() : "No more";
            Console.WriteLine(result); // Print the result (always prints 1, 2, or 3 in this case)
        }
    }
}

