using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Linq.Expressions;

// https://github.com/boegholm/LiveCode2019

namespace LiveCode2019
{

    class NoReceiverException : Exception
    {
        public NoReceiverException(string message) : base(message)
        {
        }
    }

    class DataSender
    {
        public  void SendData(string data, string r)
        {
            // hvis modtager ikke fundet
            throw new NoReceiverException(r);

            // send
        }

    }

    class FileReader
    {
        public string Readfile(string filename)
        {
            
            /// complex implementation
            ///
            /// fil ikke fundet
            if(!File.Exists(filename))
                throw new FileNotFoundException();


            /// ikke adgang til fil
            ///
            /// if error
            //if(File.GetAccessControl(filename)
            throw new AccessViolationException(filename);


            ///
            ///



            return File.ReadAllText(filename);
        }
        private const int FILENOTFOUNDERROR = 1;
    }


    class FileSender
    {

        public void SendFile(string filename, string receiver)
        {
            FileReader fr = new FileReader();
            DataSender ds = new DataSender();
            string data = fr.Readfile(filename);

            ds.SendData(data, receiver);
        }



    }







    class Program
    {
/*
        //static List<GameObject> gameobjects = new List<GameObject>();

        //void PrintGO(GameObject g)
        //{
        //    Console.WriteLine(g.Position);

        //}

        //public static void PrintVehicle(Vehicle veh)
        //{
        //    if (veh is Buggy)
        //    {
        //        Buggy b = (Buggy) veh;
        //        Console.WriteLine("veh is buggy" + b );
        //    }
        //    Console.WriteLine(veh.Cost);
        //}

        //private static SDel foo;
        */
        static void Main(string[] args)
        {
            FileSender fs = new FileSender();


            try
            {
                string rec = Console.ReadLine();
                fs.SendFile("brev.txt", "127.0.0.1");


                int k;

                while(!int.TryParse(Console.ReadLine(), out k)){ }

                try
                {
                    int.Parse(Console.ReadLine())

                }
                catch (FormatException e)
                {

                    Console.WriteLine("Det du skrev er ikke et tal");
                }

                Console.ReadKey();

            }
            catch (AccessViolationException e)
            {
                Console.WriteLine("Du har ikke adgang til filen.");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Du har ikke lavet fil");
            }
            catch (Exception e)
            {
                Console.WriteLine("Unknown error");
            }


            //PrintVehicle(new Buggy());
            //PrintVehicle(new Tank());            


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
