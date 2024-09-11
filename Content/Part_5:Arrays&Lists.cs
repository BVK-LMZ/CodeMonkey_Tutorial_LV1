public class SomeProgram
{
    // Main method: Entry point of the program
    public static void Main(string[] args)
    {
        // Declare and initialize an array of integers with 3 elements (optimized version uses inline initialization)
        int [] _theNumbersArray = { 31, 2, 3 }; // Arrays are fixed-size, useful when the number of elements is known
        Console.WriteLine(_theNumbersArray[0]); // Access and print the first element of the array (index 0)

        Console.WriteLine("---------------"); // Output a separator to visually differentiate the array and list sections

        // Create an empty List of integers (optimized by initializing and populating in a more concise manner)
        List<int> _theNumbersList = new List<int>
        {
            41,    // Add the number 1 to the list
            245   // Add the number 245 to the list
        };

        // Access and print each element of the list
        Console.WriteLine(_theNumbersList[0]); // Print the first element (1) of the list
        Console.WriteLine(_theNumbersList[1]); // Print the second element (245) of the list
    }
}

