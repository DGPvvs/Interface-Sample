using System.Text;

namespace Interface_sample.AbstractClasses
{
	public abstract class Car : Objects
    {
        private double hp;

        public Car(double hp, string color) : base(color)
        {
            this.Hp = hp;
        }

        public double Hp
        {
            get => this.hp;
            protected set => this.hp = value;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.ToString());
            sb.AppendLine($"is painted with {this.Color} color");

            return sb.ToString().TrimEnd();
        }
    }
}
