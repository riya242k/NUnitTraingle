using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnitTraingle;
using NUnit.Framework;

namespace NUnitTriangleTest
{
    //Author: Riya Gupta
    public class NUnitTriangleTest
    {
        [TestFixture]
        public class NUnitTriangleTest1
        {
            [Test]

            public void RiyaGupta_ValidTriangle_Input60and60and60_OutputValidTriangle()
            {
                //Arrange
                int firstAngle = 60;
                int secondAngle = 60;
                int thirdAngle = 60;

                string expected = "The triangle is valid.";

                //Act
                String actual = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);
                Console.WriteLine(actual);
                //Assert
                Assert.AreEqual(expected, actual);
            }

            [Test]
            public void RiyaGupta_InvalidTriangle_InputNegative60and100and140_OutputValidTriangle()
            {
                //Arrange
                int firstAngle = -60;
                int secondAngle = 100;
                int thirdAngle = 140;

                string expected = "The triangle is valid.";

                //Act
                String actual = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);
                Console.WriteLine(actual);
                //Assert
                Assert.AreEqual(expected, actual);
            }

            [Test]
            public void RiyaGupta_InvalidTriangle_Input0and140and40_OutputValidTriangle()
            {
                //Arrange
                int firstAngle = 0;
                int secondAngle = 140;
                int thirdAngle = 40;

                string expected = "The triangle is valid.";

                //Act
                String actual = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);
                Console.WriteLine(actual);
                //Assert
                Assert.AreEqual(expected, actual);
            }

            public static void Main()
            {

            }


        }

    }
}
