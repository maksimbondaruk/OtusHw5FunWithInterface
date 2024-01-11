using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otus.HW_Interfaces
{
    class Quadcopter : IFlyingRobot, IChargeable
    {
        public List <string> GetComponents()
        {
            return _components;
        }
        public string GetInfo()
        {
            return "blablalba";
        }
        public void Charge()
        {
            Console.WriteLine("Charging...");
            Thread.Sleep(3000);
            Console.WriteLine("Charged!");
        }

        List<string> _components = new() { "rotor1", "rotor2", "rotor3", "rotor4" };   
    }
}
