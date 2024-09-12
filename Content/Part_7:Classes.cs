using System;

class Program
{
    static void Main(string[] args)
    {
        // Creating an instance of the Animal class
        Animal myDog = new Animal("Dog", 4);

        // Accessing public method and fields
        myDog.DisplayInfo();

        // Accessing private field through a public method
        Console.WriteLine("Animal Name (via getter): " + myDog.GetAnimalName());

        // Trying to call a static method
        Console.WriteLine("\nCalling the static method:");
        Animal.StaticInfo();

        // Accessing and modifying public fields
        myDog.legs = 3; // Changing the number of legs
        myDog.DisplayInfo(); // Displaying updated info

        // Can't access private/protected members from here directly (outside the class)
        // myDog.name = "Cat"; // This would give an error because 'name' is private
    }
}

// Defining the Animal class
class Animal
{
    // Private field - only accessible within the class
    private string name;

    // Public field - accessible from anywhere
    public int legs;

    // Protected field - accessible within the class and derived classes
    protected bool isMammal;

    // Constructor - called when creating an instance of the class
    public Animal(string animalName, int numberOfLegs)
    {
        name = animalName; // Assigning value to the private field
        legs = numberOfLegs; // Assigning value to the public field
        isMammal = true; // Default to true (could be set differently later)
    }

    // Public method - accessible from outside the class
    public void DisplayInfo()
    {
        Console.WriteLine("Animal: " + name);
        Console.WriteLine("Number of Legs: " + legs);
        Console.WriteLine("Is Mammal: " + (isMammal ? "Yes" : "No"));
    }

    // Private method - can only be called within this class
    private void SecretAnimalInfo()
    {
        Console.WriteLine("This is a secret animal method.");
    }

    // Public method to get the private name field
    public string GetAnimalName()
    {
        return name;
    }

    // Static method - belongs to the class itself, not an instance
    public static void StaticInfo()
    {
        Console.WriteLine("Animals are part of nature!");
    }
}
