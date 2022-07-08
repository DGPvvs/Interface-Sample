using Interface_sample.AbstractClasses;
using Interface_sample.Contract;
using System.Text;

namespace Interface_sample.CarClasses
{
	public class Opel : Car, IPerformance
    {
        private double torque;

        public Opel(double hp, double rpm, string color) : base(hp, color)
        {
            double power = 1.35962173 * this.Hp;
            this.torque = 9549 * power / rpm;
        }

        public string Description()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.ToString());

            sb.AppendLine($"with torque {this.torque:F2} kN");

            return sb.ToString().TrimEnd();
        }
    }
}
