using Interface_sample.Contract;
using System.Text;

namespace Interface_sample.AbstractClasses
{
	public abstract class Shape : Objects, IPerformance
    {
        private double area;

        public Shape(string color) : base(color)
        {

        }

        public double Area
        {
            get => this.area;
            protected set => this.area = value;
        }

        public string Description() => this.ToString();

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.ToString());
            sb.AppendLine($"is painted with {this.Color} color");
            sb.AppendLine($"and its area is {this.Area:F2}");

            return sb.ToString().TrimEnd();
        }
    }
}
