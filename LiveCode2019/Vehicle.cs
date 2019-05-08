namespace LiveCode2019
{
    public abstract class Vehicle : GameObject
    {
        public abstract int Cost { get; protected set; }
        public abstract int Speed { get; protected set; }
    }
}