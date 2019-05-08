using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

// https://github.com/boegholm/LiveCode2019

namespace LiveCode2019
{
    delegate void BalanceLow(Account a);
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

    




    class Program
    {

        public static void Foo(SDel p)
        {
            
        }


        private static SDel foo;

        static void Main(string[] args)
        {
            Account aa  = new Account(10, "Min account");
            aa.BalanceLowEvent += AaOnBalanceLowEvent;

            aa.BalanceLowEvent += account => Console.WriteLine(account.Name + "  via lambda");
            aa.Balance = 10;

            Enumerable.Range(0, 10).Select(v => Enumerable.Range(v, 10).ToArray()).Aggregate(new List<int>(), (ints, ints1) =>
            {
                ints.AddRange(ints1);
                return ints;
            });
            

            Console.ReadKey();
        }

        private static void AaOnBalanceLowEvent(Account a)
        {
            Console.WriteLine($"Account : {a.Name} has low balance: {a.Balance}");
        }
    }


    class Person
    {

    }

    delegate void SDel(string s);
}
