using System.Runtime.InteropServices;

public class Enemy
{
    public string Name;
    public int life = 100;
    public bool status  = true ;
    public string shout = "I am an enemy";

    public Enemy(string name)
    {
        Name = name;
        
    }
}