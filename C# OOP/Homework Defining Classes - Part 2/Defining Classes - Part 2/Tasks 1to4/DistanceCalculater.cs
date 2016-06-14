﻿namespace Defining_Classes___Part_2
{
    using System;
    static class DistanceCalculater
    { 
       public static double CalculateDistance(Point3D p1, Point3D p2)
        {
            double distance  = Math.Sqrt(Math.Pow(p1.X - p2.X, 2) + 
                               Math.Pow(p1.Y - p2.Y, 2) + 
                               Math.Pow(p1.Z - p2.Z, 2));
            return distance;
        }
    }
}
