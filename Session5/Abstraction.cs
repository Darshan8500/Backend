using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session5
{
    abstract class Appliance
    {
        public abstract void TurnOn();
        public void Info() => Console.WriteLine("This is a general appliance.");
    }

    class WashingMachine : Appliance
    {
        public override void TurnOn() => Console.WriteLine("Washing Machine is ON.");
    }

    public class Abstraction
    {
        public static void Run()
        {
            Console.WriteLine("4. Abstraction:");
            Appliance wm = new WashingMachine();
            wm.TurnOn();
            wm.Info();
            Console.WriteLine();
        }
    }
}
