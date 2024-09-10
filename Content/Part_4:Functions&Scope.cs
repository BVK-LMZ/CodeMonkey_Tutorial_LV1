using System;

class SomeProgram
{
    // Class-level fields
    private int _someNumber = 3;
    private int _someOtherNumber = 4;
    private int _someOtherNumber2 = 3;

    static void Main(string[] args)
    {
        // Create an instance of SomeProgram to access non-static members
        SomeProgram program = new SomeProgram();

        // Call methods using the instance
        program.AddStuff(program._someNumber, program._someOtherNumber);
        program.AddStuff(program._someNumber, program._someOtherNumber, program._someOtherNumber2);
    }

    private void AddStuff(int _arg1, int _arg2)
    {
        // Example implementation
        Console.WriteLine($"AddStuff with 2 arguments: {_arg1 + _arg2}");
    }

    private void AddStuff(int _arg1, int _arg2, int _arg3)
    {
        // Example implementation
        Console.WriteLine($"AddStuff with 3 arguments: {_arg1 + _arg2 + _arg3}");
    }
}
