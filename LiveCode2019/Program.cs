using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

// https://github.com/boegholm/LiveCode2019

namespace LiveCode2019
{
    class Program
    {
        





        public static void PrintObject(object o)
        {

        }

        public static void PrintGameObject(GameObject go)
        {

        }

        public static void PrintVehicle(Vehicle veh)
        {

        }


        static void Main(string[] args)
        {
            SDel print = Console.WriteLine;


            print("hej");

            Console.ReadKey()
        }
    }


    class Person
    {

    }

    delegate void SDel(string s);
}
