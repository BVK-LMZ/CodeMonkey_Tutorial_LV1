using System;

class SomeProgram
{
    static void Main(string[] args)
    {
        bool _someBool = false;

        // Call the functions
        IfElseLogic(_someBool);
        TernaryLogic(_someBool);
        SwitchLogic(_someBool);
    }

    // Function with if-else logic
    static void IfElseLogic(bool _someBool)
    {
        if (_someBool)
        {
            Console.WriteLine("If-Else: True");
        }
        else if (!_someBool)
        {
            Console.WriteLine("If-Else: False");
        }
        else
        {
            Console.WriteLine("If-Else: Other");
        }
    }

    // Function with ternary logic
    static void TernaryLogic(bool _someBool)
    {
        string result = _someBool ? "Ternary: True" : "Ternary: False";
        Console.WriteLine(result);
    }

    // Function with switch statement logic
    static void SwitchLogic(bool _someBool)
    {
        switch (_someBool)
        {
            case true:
                Console.WriteLine("Switch: True");
                break;
            case false:
                Console.WriteLine("Switch: False");
                break;
            default:
                Console.WriteLine("Switch: Other");
                break;
        }
    }
}

