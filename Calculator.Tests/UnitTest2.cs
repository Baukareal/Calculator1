using Калькулятор;
using NUnit.Framework;
using System;

namespace Calculator.Tests
{
    [TestFixture]
    public class LogarithmTest
    {
        [Test]
        [TestCase(10, 1)]
        [TestCase(100, 2)]
        [TestCase(1000, 3)]
        public void ConvertTest(double number, double expected)
        {
            var Convert = new Logarithm();
            var obtained = Convert.Convertation(number);
            Assert.AreEqual(expected, obtained);
        }
    }
    [TestFixture]
    public class Natural_LogarithmTest
    {
        [Test]
        [TestCase(Math.E, 1)]
        [TestCase(Math.E * Math.E, 2)]
        [TestCase(Math.E * Math.E * Math.E, 3)]
        public void ConvertTest(double number, double expected)
        {
            var Convert = new Natural_Logarithm();
            var obtained = Convert.Convertation(number);
            Assert.AreEqual(expected, obtained);
        }
    }
    [TestFixture]
    public class Ten_To_The_PowerTest
    {
        [Test]
        [TestCase(2, 100)]
        [TestCase(1, 10)]
        [TestCase(0, 1)]
        public void ConvertTest(double number, double expected)
        {
            var Convert = new Ten_To_The_Power();
            var obtained = Convert.Convertation(number);
            Assert.AreEqual(expected, obtained);
        }
    }
    [TestFixture]
    public class Square_RootTest
    {
        [Test]
        [TestCase(4, 2)]
        [TestCase(9, 3)]
        [TestCase(1, 1)]
        public void ConvertTest(double number, double expected)
        {
            var Convert = new Square_Root();
            var obtained = Convert.Convertation(number);
            Assert.AreEqual(expected, obtained);
        }
    }
    public class Cube_RootTest
    {
        [Test]
        [TestCase(8, 2)]
        [TestCase(1, 1)]
        [TestCase(27, 3)]
        public void ConvertTest(double number, double expected)
        {
            var Convert = new Cube_Root();
            var obtained = Convert.Convertation(number);
            Assert.AreEqual(expected, obtained);
        }
    }
    public class SquareTest
    {
        [Test]
        [TestCase(1, 1)]
        [TestCase(2, 4)]
        [TestCase(4, 16)]
        public void ConvertTest(double number, double expected)
        {
            var Convert = new Square();
            var obtained = Convert.Convertation(number);
            Assert.AreEqual(expected, obtained);
        }
    }
    public class CubeTest
    {
        [Test]
        [TestCase(1, 1)]
        [TestCase(-5, -125)]
        [TestCase(3, 27)]
        public void ConvertTest(double number, double expected)
        {
            var Convert = new Cube();
            var obtained = Convert.Convertation(number);
            Assert.AreEqual(expected, obtained);
        }
    }
    public class FactorialTest
    {
        [Test]
        [TestCase(1, 1)]
        [TestCase(0, 1)]
        [TestCase(3, 6)]
        public void ConvertTest(double number, double expected)
        {
            var Convert = new Factorial();
            var obtained = Convert.Convertation(number);
            Assert.AreEqual(expected, obtained);
        }
    }
    public class Scale_UpTest
    {
        [Test]
        [TestCase(1, 1)]
        [TestCase(4, 0.25)]
        [TestCase(8, 0.125)]
        public void ConvertTest(double number, double expected)
        {
            var Convert = new Scale_Up();
            var obtained = Convert.Convertation(number);
            Assert.AreEqual(expected, obtained);
        }
    }
    public class ModuleTest
    {
        [Test]
        [TestCase(0, 0)]
        [TestCase(-5, 5)]
        [TestCase(4, 4)]
        public void ConvertTest(double number, double expected)
        {
            var Convert = new Module();
            var obtained = Convert.Convertation(number);
            Assert.AreEqual(expected, obtained);
        }
    }
    public class Two_In_PowerTest
    {
        [Test]
        [TestCase(0, 1)]
        [TestCase(4, 16)]
        [TestCase(5, 32)]
        public void ConvertTest(double number, double expected)
        {
            var Convert = new Two_In_Power();
            var obtained = Convert.Convertation(number);
            Assert.AreEqual(expected, obtained);
        }
    }
    public class E_In_PowerTest
    {
        [Test]
        [TestCase(1, Math.E)]
        [TestCase(0, 1)]
        [TestCase(-1, 1 / Math.E)]
        public void ConvertTest(double number, double expected)
        {
            var Convert = new E_In_Power();
            var obtained = Convert.Convertation(number);
            Assert.AreEqual(expected, obtained);
        }
    }
}