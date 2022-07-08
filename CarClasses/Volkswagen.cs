using Interface_sample.AbstractClasses;
using Interface_sample.Contract;
using System.Text;

namespace Interface_sample.CarClasses
{
	public class Volkswagen : Car, IPerformance
    {
        public Volkswagen(double hp, string color) : base(hp, color)
        {

        }

        public string Description()
        {
            double power = 1.35962173 * this.Hp;
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.ToString());

            sb.AppendLine($"with power {power:F2} kW");

            return sb.ToString().TrimEnd();
        }
    }
}
