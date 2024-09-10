using System;

class SomeProgram
{
    static void Main(string[] args)
    {
        bool _someBool = false;

        if (_someBool)
        {
            Console.WriteLine("True");
        }
        else if (!_someBool)
        {
            Console.WriteLine("False");
        }
        else
        {
            Console.WriteLine("Other");
        }
    }
}
