using Interface_sample.AbstractClasses;

namespace Interface_sample.ShapeClasses
{
	public class Triangle : Shape
    {
        public Triangle(double basis, double height, string color) : base(color)
        {
            this.Area = .5 * basis * height;
        }
    }
}
