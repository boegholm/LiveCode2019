namespace LiveCode2019
{
    public class Vector3
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
}