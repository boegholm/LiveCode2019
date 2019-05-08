namespace LiveCode2019
{
    public abstract class GameObject : IPositionable
    {
        public GameObject()
        {
            Position = new Vector3();
        }
        public Vector3 Position { get; set; }
    }
}