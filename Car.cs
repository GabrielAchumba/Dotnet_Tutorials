public class Car
{
    private string color = string.Empty; // Field
    public string Color // Property
    {
        get { return color; }
        set { color = value; }
    }
    

    public void Drive() // Method
    {
        Console.WriteLine("Driving...");
    }
}