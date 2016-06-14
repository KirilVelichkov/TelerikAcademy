namespace Defining_Classes___Part_2
{
    using System.IO;
    using System.Linq;
    static class PathStorage
    {
        public static Path LoadPath(string filePath)
        {
            StreamReader streamReader = new StreamReader(filePath);
            Path path = new Path();
            while (!streamReader.EndOfStream)
            {
                path.AddPointFromList(streamReader.ReadLine().Split(',').Select(double.Parse).ToList());
            }
            return path;
        }

        public static void SavePath(Path path, string filePath)
        {
            StreamWriter streamWriter = new StreamWriter(filePath);
            streamWriter.WriteLine(path.ToString());
            streamWriter.Close();
        }
     
    }
}
