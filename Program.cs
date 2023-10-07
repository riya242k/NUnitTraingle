using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTraingle
{
    public static class Triangle
    {
        public static void Main()
        {

        }
        public static string ValidTriangle(int firstAngle, int secondAngle, int thirdAngle)
        {
            string result;
            //  The * in first and second angle. Ideally, it should be an addition.
            if ((firstAngle * secondAngle + thirdAngle) == 180)
            {
                result = "The triangle is valid.";
            }
            else
            {
                result = "The triangle is NOT valid.";
            }
            return result;
        }
    }
}
