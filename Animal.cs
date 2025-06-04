
// Base class
public class Animal
{
    public void Eat()
    {
        Console.WriteLine("Eating...");
    }

    public virtual void Speak()
    {
        Console.WriteLine("Animal sound");
    }
}

// Derived class
public class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("Barking...");
    }

    public override void Speak() // overriding is polymorphism
    {
        Console.WriteLine("Bark");
    }
}