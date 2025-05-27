using System;

public class Weapon
{
    public string Name;
    public string manufacturer;
    public int NumbeOfBalls;


    public Weapon(string Name, string manufacturer, int NumbeOfBalls)
    {
        this.Name = Name;
        this.manufacturer = manufacturer;
        this.NumbeOfBalls = NumbeOfBalls;
    }

    public void Shoot()
    {
        Console.WriteLine("bom!!");
        NumbeOfBalls -= 1;
    }
}