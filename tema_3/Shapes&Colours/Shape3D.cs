
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemples
{
    public abstract class Shape3D : Shape
    {
        protected Shape3D(Colour baseColour) : base(baseColour) { }
        public abstract double GetVolume();
    }
}
