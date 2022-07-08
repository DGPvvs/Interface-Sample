using Interface_sample.AbstractClasses;

namespace Interface_sample.ShapeClasses
{
	public class Rectangle : Shape
    {
        public Rectangle(double length, double width, string color) : base(color)
        {
            this.Area = length * width;
        }
    }
}
