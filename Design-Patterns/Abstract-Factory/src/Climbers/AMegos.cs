using System;
using System.Collections.Generic;
using System.Text;
using Abstract_Factory.src.Routes;

namespace Abstract_Factory.src.Climbers
{
    public class AMegos : Climber
    {
        public override void Climb(Route route)
        {
            Console.WriteLine(GetType().Name +
              " flashes " + route.GetType().Name);
        }
    }
}
