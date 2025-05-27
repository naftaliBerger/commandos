using System;
using System.Net.NetworkInformation;

public class AirCommando : Commando
{
    public bool Falling;
    public AirCommando(string nane, string codeName) :base(nane, codeName)
    {    
        
    }
    public void parachuting()
    {
        Falling = true;
        Console.WriteLine("Commando drops!!!");
    }
    public override void Attack()
    {
        Console.WriteLine("Air commando attacks!!!");
    }
}