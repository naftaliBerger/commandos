using System;
using System.Net.NetworkInformation;

public class Commando
{
    public string name;
    public int codeName;
    public string[] tools  = { "Petite" , "Chisel" ,"Rope" , "WaterBag" };
    public string status;

    public Commando(string nane , int codeName)
    {
        this.name = nane;
        this.codeName = codeName;
    }

    public void Walk()
    {
        status = "Going";
        Console.WriteLine("The Soldier is leaving.");
    }
    public void Hide() 
    {
        status = "Hiding";
        Console.WriteLine("The Soldier is Hiding");
    }
    public void Attack()
    {
        Console.WriteLine($"Commando with a code name: {codeName} Attack !!!");
    }


}