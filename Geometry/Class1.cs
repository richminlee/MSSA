using System;
using System.Threading.Channels;

namespace Geometry
{
    public class Class1
    {
        public static double CalcAreaTriangle(double triangleBase, double triangleHeight)
        {
            double areaOfTriangle = (triangleBase * triangleHeight) / 2;
            return areaOfTriangle;
        }
    }
}
