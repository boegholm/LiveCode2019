using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

// https://github.com/boegholm/LiveCode2019

namespace LiveCode2019
{

    class FileSender
    {
        public void SendFile(string filename, string receiver)
        {
            string data = Readfile(filename);
            SendData(data, receiver);
        }


        private void SendData(string data, string r)
        {
            // complex
        }
        private string Readfile(string filename )
        {
            /// complex implementation
            return "";
        }
    }







    class Program
    {

        static List<GameObject> gameobjects = new List<GameObject>();

        void PrintGO(GameObject g)
        {
            Console.WriteLine(g.Position);

        }

        public static void PrintVehicle(Vehicle veh)
        {
            if (veh is Buggy)
            {
                Buggy b = (Buggy) veh;
                Console.WriteLine("veh is buggy" + b );
            }
            Console.WriteLine(veh.Cost);
        }

        private static SDel foo;

        static void Main(string[] args)
        {
            new Person().SetAlder(1);


            Console.ReadKey();


            PrintVehicle(new Buggy());
            PrintVehicle(new Tank());            


            List<Person> plist = new List<Person>();
            plist.Add(new Person(){Navn = "Thomas", Efternavn = "B", Alder = 10});
            plist.Add(new Person(){Navn= "hans" , Efternavn = "H", Alder = 20});
            plist.Add(new Person(){Navn = "Henrik", Efternavn = "B", Alder=2});
            
            Person p = new Person().SetAlder(10).SetNavn("Thomas");
            Console.WriteLine(p);
            Console.ReadKey();


            


            plist.ForEach(Console.WriteLine);

            Console.WriteLine();
            var vs = plist.GroupBy(v => v.Efternavn);


            foreach (IGrouping<string, Person> grouping in vs)
            {
                Console.WriteLine(grouping.Key);
                foreach (Person person in grouping)
                {
                    Console.WriteLine(person);
                }
            }
            Console.WriteLine(vs);


            Console.ReadKey();
            return;



            Account aa  = new Account(10, "Min account");
            aa.BalanceLowEvent += AaOnBalanceLowEvent;

            aa.BalanceLowEvent += account => Console.WriteLine(account.Name + "  via lambda");
            aa.Balance = 10;

            Enumerable.Range(0, 10)
                .Select(v => Enumerable.Range(v, 10).ToArray())
                .Aggregate(new List<int>(), (ints, ints1) =>
            {
                ints.AddRange(ints1);
                return ints;
            }).ToArray();
            

            Console.ReadKey();
        }

        private static void AaOnBalanceLowEvent(Account a)
        {
            Console.WriteLine($"Account : {a.Name} has low balance: {a.Balance}");
        }
    }
}
