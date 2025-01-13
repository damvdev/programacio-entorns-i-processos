using System;


namespace exemples
{
    public abstract class Shape
    {
        protected Colour BaseColour;
        public static double DefaultSize = 1.0D;

        public Shape(Colour baseColour)
        {
            BaseColour = baseColour;
        }

        public abstract double GetArea();
    }
}
