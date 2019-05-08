namespace LiveCode2019
{
    public class Tank : Vehicle
    {
        private int _value = 100;
        public int Age { get; set; }

        public override int Cost
        {
            get { return (int)((100.0 / (Age + 1)) * _value); }
            protected set { _value = value; }
        }

        public override int Speed { get; protected set; } = 50;
    }
}