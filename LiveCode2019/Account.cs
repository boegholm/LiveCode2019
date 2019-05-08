namespace LiveCode2019
{
    class Account
    {
        public string Name { get; set; }
        public Account(int initialbalance, string name)
        {
            Name = name;
            Balance = initialbalance;
        }
        public event BalanceLow BalanceLowEvent;

        private int _balance = 0;
        public int Balance
        {
            get { return _balance; }
            set
            {
                if (value <= 50)
                {
                    if(BalanceLowEvent!=null)
                        BalanceLowEvent(this);
                }
                _balance = value;
            }
        }
    }
}