using Abstract_Factory.src.Routes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory.src.Climbers
{
    public class AHonnold : Climber
    {
        public override void Climb(Route route)
        {
            Console.WriteLine(GetType().Name +
              " speed climbs " + route.GetType().Name);
        }
    }
}
