using System;
using System.Net.NetworkInformation;

public class Commando
{
    private string name;
    public string codeName{get; set;}
    public string[] tools  = { "Petite" , "Chisel" ,"Rope" , "WaterBag" };
    public string status;

    public Commando(string nane , string codeName)
    {
        this.name = nane;
        this.codeName = codeName;
    }

    public void SayName(string commanderRank)
    {
        if (commanderRank == "GENERAL")
        {
            Console.WriteLine(name);
        }
        else if (commanderRank == "COLONEL")
        {
            Console.WriteLine(codeName);

        }
        else 
        {
            Console.WriteLine("This information is classified!!!!");
        }
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
    public virtual void Attack()
    {
        Console.WriteLine($"Commando with a code name: {codeName} Attack !!!");
    }


}