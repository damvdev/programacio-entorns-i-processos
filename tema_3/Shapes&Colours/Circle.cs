using System;

namespace exemples
{
    public class Circle : Shape2D
    {

        private double _radius;
        public Circle(double radius, Colour baseColour) : base(baseColour)
        {
            Radius = radius;
        }

        public double Radius
        {
            get => _radius;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Radius must be greater than 0");
                }
                _radius = value;
            }
        }

        public override double GetArea()
        {
            throw new NotImplementedException();
        }

        public override double GetPerimeter()
        {
            throw new NotImplementedException();
        }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}
