using Калькулятор;
using NUnit.Framework;
using System;

namespace Calculator.Tests
{
    [TestFixture]
    public class CalculateTest
    {
        [TestCase("^", typeof(Elevate))]
        [TestCase("root", typeof(Root))]
        [TestCase("log base", typeof(Log_Base))]
        [TestCase("+", typeof(Summation))]
        [TestCase("-", typeof(Subtraction))]
        [TestCase("/", typeof(Division))]
        [TestCase("x", typeof(Multiplication))]
        [TestCase("mod", typeof(Modulo_Division))]
        public void CreateCalculatorTest(string name, Type type)
        {
            var calculator = new TwoArgumentsFactory();
            var factory = calculator.Create_Calculator(name);
            Assert.IsInstanceOf(type, factory);
        }
    }
    [TestFixture]
    public class ConvertNumberTest
    {
        [TestCase("log", typeof(Logarithm))]
        [TestCase("ln", typeof(Natural_Logarithm))]
        [TestCase("10^x", typeof(Ten_To_The_Power))]
        [TestCase("sqrt(x)", typeof(Square_Root))]
        [TestCase("cuberoot(x)", typeof(Cube_Root))]
        [TestCase("x^2", typeof(Square))]
        [TestCase("x^3", typeof(Cube))]
        [TestCase("n!", typeof(Factorial))]
        [TestCase("1/x", typeof(Scale_Up))]
        [TestCase("|x|", typeof(Module))]
        [TestCase("2^x", typeof(Two_In_Power))]
        [TestCase("e^x", typeof(E_In_Power))]
        public void CreateConvertTest(string name, Type type)
        {
            var calculator = new ConvertNumber();
            var factory = calculator.Create_Convert(name);
            Assert.IsInstanceOf(type, factory);
        }
    }
}