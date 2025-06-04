public class Car
{
    private string color = string.Empty; // Field

    public Car(string _color)
    {
        color = _color;
        Console.WriteLine($"{color} car created");
    }
    public string Color // Property
    {
        get { return color; }
        set { color = value; }
    }


    public void Drive() // Method
    {
        Console.WriteLine("Driving...");
    }
    
    ~Car()
    {
        Console.WriteLine("Car object destroyed"); // this will collected by garbage collector
    }
}