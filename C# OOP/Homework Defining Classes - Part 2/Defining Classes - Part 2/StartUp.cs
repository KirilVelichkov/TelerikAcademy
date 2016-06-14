namespace Defining_Classes___Part_2
{
    using System;
    using Task_8to10;
    using Tasks_5to7;
    [Version(1, 0)]
    class StartUp
    {
        static void Main()
        {
            //Testing Tasks 1,2,3
            Console.WriteLine("---- Testing Tasks 1,2,3 ----");
            var point = new Point3D(1, 1, 1);

            Console.WriteLine($"My point = {point}");
            Console.WriteLine($"Zero point = {Point3D.Opoint}");

            var distance = DistanceCalculater.CalculateDistance(point, Point3D.Opoint);
            Console.WriteLine($"Distance between {point} and {Point3D.Opoint} = {distance}");

            //Testing Task 4
            Console.WriteLine("---- Testing Task 4 ----");
            var path = PathStorage.LoadPath(@"..\..\Points.txt");
            Console.Write(path);
            PathStorage.SavePath(path, @"..\..\EditedPoints.txt");

            //Testing task 5,6,7
            GenericListTest.TestGenericList();

            //Testing Task 8,9,10
            MatrixTest.TestMatrix();


            Type type = typeof(StartUp);
            object[] allAttributes = type.GetCustomAttributes(false);
            Console.WriteLine(allAttributes[0].ToString().PadLeft(Console.BufferWidth));
        }
    }
}
