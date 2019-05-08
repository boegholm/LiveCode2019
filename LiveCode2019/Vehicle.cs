namespace LiveCode2019
{

    interface IGameObject
    {
        Vector3 Position { get; set; }
    }

    class Helikopter : IGameObject
    {
        public Vector3 Position { get; set; }
    }


    public abstract class Vehicle : GameObject
    {
        public abstract int Cost { get; protected set; }
        public abstract int Speed { get; protected set; }
    }



}