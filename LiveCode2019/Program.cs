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
        private static List<Action<string>> actions = new List<Action<string>>();





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

            Console.ReadKey();
            List<GameObject> objects = new List<GameObject>(){new Buggy(), new Tank()};
        }
    }
}
