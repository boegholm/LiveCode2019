using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveCode2019
{
    class Vector3
    {
        public Vector3()
        {
            X = Y = Z = 0;
        }
        public Vector3(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
    }
    class GameObject
    {
        public GameObject()
        {
            Position = new Vector3();
        }
        public Vector3 Position { get; set; }
    }

    abstract class Vehicle : GameObject
    {
        public abstract int Cost { get; protected set; }
        public abstract int Speed { get; protected set; }
    }

    class Buggy : Vehicle
    {
        public override int Cost { get; protected set; } = 60;
        public override int Speed { get; protected set; } = 100;
    }

    class Tank : Vehicle
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

    

    class Program
    {
        public static void PrintGameObject(GameObject go)
        {

        }

        public static void PrintVehicle(Vehicle veh)
        {

        }


        static void Main(string[] args)
        {
            List<GameObject> objects = new List<GameObject>(){new Buggy(), new Tank()};
        }
    }
}
