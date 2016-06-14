namespace Defining_Classes___Part_2
{
    using System.Text;
    using System.Collections.Generic;
    class Path
    {
        List<Point3D> points;
        public Path()
        {
            points = new List<Point3D>();
        }

        public Path(List<Point3D> points)
        {
            this.points = points;
        }

        public void AddPointFromList(List<double> list)
        {
            points.Add(new Point3D(list[0], list[1], list[2]));
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in points)
            {
                sb.Append(item.ToString()).Append("\r\n");
            }
            return sb.ToString();
        }
    }
}
