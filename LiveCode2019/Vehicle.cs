namespace LiveCode2019
{

    interface IPositionable
    {
        Vector3 Position { get; set; }
    }

    class Helikopter : IPositionable
    {
        public Vector3 Position { get; set; }
    }


    public abstract class Vehicle : GameObject
    {
        public abstract int Cost { get; protected set; }
        public abstract int Speed { get; protected set; }
    }



}