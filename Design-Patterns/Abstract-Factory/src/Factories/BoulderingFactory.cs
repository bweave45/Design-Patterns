using Abstract_Factory.src.Climbers;
using Abstract_Factory.src.Routes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory.src.Factories
{
    public class BoulderingFactory: ClimbingFactory
    {
        public override Climber CreateClimber()
        {
            return new AMegos();
        }

        public override Route CreateRoute()
        {
            return new LucidDreaming();
        }
    }
}
