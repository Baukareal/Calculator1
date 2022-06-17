using NUnit.Framework;
using Калькулятор;

namespace Calculator.Tests
{
    [TestFixture]
    public class MultiplicationTests
    {
        [Test]
        [TestCase(0, 0, 0)]
        [TestCase(3, 4, 12)]
        [TestCase(-7, -2, 14)]
        public void CalculateTest(double value_1, double value_2, double expected)
        {
            var calculator = new Multiplication();
            var actual_result = calculator.Calculate(value_1, value_2);
            Assert.AreEqual(expected, actual_result);
        }
    }
    [TestFixture]
    public class SummationTests
    {
        [Test]
        [TestCase(0, 0, 0)]
        [TestCase(3, 4, 7)]
        [TestCase(-7, -2, -9)]
        public void CalculateTest(double value_1, double value_2, double expected)
        {
            var calculator = new Summation();
            var actual_result = calculator.Calculate(value_1, value_2);
            Assert.AreEqual(expected, actual_result);
        }
    }
    [TestFixture]
    public class SubtractionTests
    {
        [Test]
        [TestCase(0, 0, 0)]
        [TestCase(7, 4, 3)]
        [TestCase(-9, -2, -7)]
        public void CalculateTest(double value_1, double value_2, double expected)
        {
            var calculator = new Subtraction();
            var actual_result = calculator.Calculate(value_1, value_2);
            Assert.AreEqual(expected, actual_result);
        }
    }
    public class DivisionTests
    {
        [Test]
        [TestCase(1, 1, 1)]
        [TestCase(3, 1, 3)]
        [TestCase(9.0, 2.0, 4.5)]
        public void CalculateTest(double value_1, double value_2, double expected)
        {
            var calculator = new Division();
            var actual_results = calculator.Calculate(value_1, value_2);
            Assert.AreEqual(expected, actual_results);
        }
    }
    public class Modulo_DivisionTests
    {
        [Test]
        [TestCase(1, 1, 0)]
        [TestCase(3, 1, 0)]
        [TestCase(9, 2, 1)]
        public void CalculateTest(double value_1, double value_2, double expected)
        {
            var calculator = new Modulo_Division();
            var actual_results = calculator.Calculate(value_1, value_2);
            Assert.AreEqual(expected, actual_results);
        }
    }
    [TestFixture]
    public class ElevateTests
    {
        [Test]
        [TestCase(1, 0, 1)]
        [TestCase(3, 2, 9)]
        [TestCase(-3, 3, -27)]
        public void CalculateTest(double value_1, double value_2, double expected)
        {
            var calculator = new Elevate();
            var actual_result = calculator.Calculate(value_1, value_2);
            Assert.AreEqual(expected, actual_result);
        }
    }
    [TestFixture]
    public class RootTests
    {
        [Test]
        [TestCase(1, 6, 1)]
        [TestCase(32, 5, 2)]
        [TestCase(9, 2, 3)]
        public void CalculateTest(double value_1, double value_2, double expected)
        {
            var calculator = new Root();
            var actual_result = calculator.Calculate(value_1, value_2);
            Assert.AreEqual(expected, actual_result);
        }
    }
    [TestFixture]
    public class Log_BaseTests
    {
        [Test]
        [TestCase(2, 2, 1)]
        [TestCase(4, 2, 2)]
        [TestCase(27, 3, 3)]
        public void CalculateTest(double value_1, double value_2, double expected)
        {
            var calculator = new Log_Base();
            var actual_result = calculator.Calculate(value_1, value_2);
            Assert.AreEqual(expected, actual_result);
        }
    }
}