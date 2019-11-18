using Abstract_Factory.src.Routes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory.src.Climbers
{
    public class AOndra : Climber
    {
        public override void Climb(Route route)
        {
            Console.WriteLine(GetType().Name +
              " On-sights " + route.GetType().Name);
        }
    }
}
