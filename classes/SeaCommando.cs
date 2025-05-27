using System;
using System.Net.NetworkInformation;

public class SeaCommando : Commando
{
    public bool pit;
    public SeaCommando(string nane, string codeName) : base(nane, codeName)
    {
        
    }
    public void swimming()
    {
        pit = true;
        Console.WriteLine("Commando swims!!!");
    }
    public override void Attack()
    {
        Console.WriteLine("Sea commando attacks!!!");
    }
}