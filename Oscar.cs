namespace App;


public class Car
{
    public string Color;
    public string Brand;

    public Car(string color, string crand)
    {
        Color = color;
        Brand = crand;
    }


    public void Drive()
    {
        Console.WriteLine($"a {Brand} is driving around in {Color} color lmao");
    }
}