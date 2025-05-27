using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandoProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Commando Commando = new Commando("Israel", "a123");
            Commando.SayName("GENERAL");
            Commando.Walk();
            Commando.Hide();
            Commando.Attack();
            Weapon weapon = new Weapon("Muhammad", "Iran",100);
            weapon.Shoot();
            Console.WriteLine(weapon.NumbeOfBalls);

        }
    }
}
