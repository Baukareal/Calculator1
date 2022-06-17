using Калькулятор;
using NUnit.Framework;
using System;

namespace Calculator.Tests
{
    [TestFixture]
    public class Check_Division_Exception
    {
        [Test]
        [TestCase(2, 0)]
        public void Check_On_Zero(double value_1, double value_2)
        {
            var exc = new Division();
            Assert.Throws<Exception> (() => exc.Calculate(value_1, value_2));
        }
    }
}