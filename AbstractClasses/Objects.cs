namespace Interface_sample.AbstractClasses
{
	public abstract class Objects
    {
        private string color;

        public Objects(string color)
        {
            this.Color = color;
        }

        public string Color
        {
            get => this.color;
            private set => this.color = value;
        }

        public override string ToString() => $"The object {this.GetType().Name}";
    }
}
