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
        public Account(int initialbalance)
        {
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
            p("foo");
        }


        private static SDel foo;

        static void Main(string[] args)
        {
            Account aa  = new Account(10);

            

            Console.ReadKey();
        }
    }


    class Person
    {

    }

    delegate void SDel(string s);
}
