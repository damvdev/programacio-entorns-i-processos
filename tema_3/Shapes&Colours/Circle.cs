using System;

namespace exemples
{
    public class Circle : Shape2D
    {
        
        public Circle(double radius, Colour baseColour) : base(baseColour)
        {
            Radius = radius;
        }

        public double Radius
        {
            get => default;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Radius must be greater than 0");
                }
                this.Radius = value;
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
