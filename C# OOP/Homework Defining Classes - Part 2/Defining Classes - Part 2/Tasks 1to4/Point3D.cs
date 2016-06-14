namespace Defining_Classes___Part_2
{
    public struct Point3D
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        private static readonly Point3D opoint = new Point3D(0, 0, 0);
        public static Point3D Opoint { get { return Point3D.opoint; } }

        public Point3D(double x, double y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }
        public override string ToString()
        {
            return $"{this.X},{this.Y},{this.Z}";
        }
    }
}
