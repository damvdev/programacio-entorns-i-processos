using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemples
{
    public abstract class Shape2D : Shape
    {
        protected Shape2D(Colour baseColour) : base(baseColour){}
        public abstract double GetPerimeter();
    }
}
