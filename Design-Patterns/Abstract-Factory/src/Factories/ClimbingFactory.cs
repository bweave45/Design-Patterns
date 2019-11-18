using Abstract_Factory.src.Climbers;
using Abstract_Factory.src.Routes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory.src.Factories
{
    public abstract class ClimbingFactory
    {
        public abstract Climber CreateClimber();
        public abstract Route CreateRoute();
    }
}
