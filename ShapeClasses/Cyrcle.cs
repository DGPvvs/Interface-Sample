using Interface_sample.AbstractClasses;
using System;

namespace Interface_sample.ShapeClasses
{
	public class Cyrcle : Shape
    {
        public Cyrcle(double radius, string color) : base(color)
        {
            this.Area = Math.PI * radius * radius;
        }
    }
}
