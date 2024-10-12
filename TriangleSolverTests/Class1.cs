using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriangleSolverTests;
using NUnit.Framework;
namespace TriangleSolverTests
{
    public class Triangle
    {
        private int side1;
        private int side2;
        private int side3;

        public Triangle(int s1, int s2, int s3)
        {
            side1 = s1;
            side2 = s2;
            side3 = s3;
        }

        public string GetTriangleType()
        {
            if (side1 == 0 || side2 == 0 || side3 == 0)
            {
                return "Error: Sides cannot be zero";
            }

            if (side1 + side2 <= side3 || side1 + side3 <= side2 || side2 + side3 <= side1)
            {
                return "Error: Invalid triangle";
            }

            if (side1 == side2 && side2 == side3)
            {
                return "Equilateral";
            }

            if (side1 == side2 || side1 == side3 || side2 == side3)
            {
                return "Isosceles";
            }

            return "Scalene";
        }
    }

    [TestFixture]
    public class TriangleTests
    {
        // Equilateral triangle test
        [Test]
        public void Test_EquilateralTriangle_ValidSides_ReturnsTrue()
        {
            Triangle triangle = new Triangle(3, 3, 3);
            string result = triangle.GetTriangleType();
            Assert.That(result, Is.EqualTo("Equilateral"));
        }
        // Isosceles triangle tests
        [Test]
        public void Test_IsoscelesTriangle_ValidSides1_ReturnsTrue()
        {
            Triangle triangle = new Triangle(5, 5, 3);
            string result = triangle.GetTriangleType();
            Assert.That(result, Is.EqualTo("Isosceles"));
        }

        [Test]
        public void Test_IsoscelesTriangle_ValidSides2_ReturnsTrue()
        {
            Triangle triangle = new Triangle(6, 6, 8);
            string result = triangle.GetTriangleType();
            Assert.That(result, Is.EqualTo("Isosceles"));
        }

        [Test]
        public void Test_IsoscelesTriangle_ValidSides3_ReturnsTrue()
        {
            Triangle triangle = new Triangle(10, 8, 10);
            string result = triangle.GetTriangleType();
            Assert.That(result, Is.EqualTo("Isosceles"));
        }
        [Test]
        public void Test_ScaleneTriangle_ValidSides2_ReturnsTrue()
        {
            Triangle triangle = new Triangle(6, 8, 10);
            string result = triangle.GetTriangleType();
            Assert.That(result, Is.EqualTo("Scalene"));
        }

        [Test]
        public void Test_ScaleneTriangle_ValidSides3_ReturnsTrue()
        {
            Triangle triangle = new Triangle(7, 8, 9);
            string result = triangle.GetTriangleType();
            Assert.That(result, Is.EqualTo("Scalene"));
        }

        [Test]
        public void Test_ScaleneTriangle_ValidSides4_ReturnsTrue()
        {
            Triangle triangle = new Triangle(9, 10, 11);
            string result = triangle.GetTriangleType();
            Assert.That(result, Is.EqualTo("Scalene"));
        }

        [Test]
        public void Test_ScaleneTriangle_ValidSides5_ReturnsTrue()
        {
            Triangle triangle = new Triangle(13, 14, 15);
            string result = triangle.GetTriangleType();
            Assert.That(result, Is.EqualTo("Scalene"));
        }
        // Zero-length side tests
        [Test]
        public void Test_TriangleWithZeroSide1_ReturnsError()
        {
            Triangle triangle = new Triangle(0, 3, 3);
            string result = triangle.GetTriangleType();
            Assert.That(result, Is.EqualTo("Error: Sides cannot be zero"));
        }

        [Test]
        public void Test_TriangleWithZeroSide2_ReturnsError()
        {
            Triangle triangle = new Triangle(3, 0, 3);
            string result = triangle.GetTriangleType();
            Assert.That(result, Is.EqualTo("Error: Sides cannot be zero"));
        }

        [Test]
        public void Test_TriangleWithZeroSide3_ReturnsError()
        {
            Triangle triangle = new Triangle(3, 3, 0);
            string result = triangle.GetTriangleType();
            Assert.That(result, Is.EqualTo("Error: Sides cannot be zero"));
        }


    }
}

