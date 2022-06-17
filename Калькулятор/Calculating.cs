using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Калькулятор
{
    public interface ITwoArgumentsCalculator
    {
        double Calculate(double value_1, double value_2);
    }
    public class Multiplication : ITwoArgumentsCalculator
    {
        public double Calculate(double value_1, double value_2) => (value_1 * value_2);
    }
    public class Summation : ITwoArgumentsCalculator
    {
        public double Calculate(double value_1, double value_2) => (value_1 + value_2);
    }
    public class Subtraction : ITwoArgumentsCalculator
    {
        public double Calculate(double value_1, double value_2) => (value_1 - value_2);
    }
    public class Division : ITwoArgumentsCalculator
    {
        public double Calculate(double value_1, double value_2)
        {
            if (value_2 == 0)
                throw new Exception("Деление на 0 невозможно");
            return value_1 / value_2;
        }
    }
    public class Modulo_Division : ITwoArgumentsCalculator
    {
        public double Calculate(double value_1, double value_2) => (value_1 % value_2);
    }
    public class Elevate : ITwoArgumentsCalculator
    {
        public double Calculate(double value_1, double value_2) => (Math.Pow(value_1, value_2));
    }
    public class Root : ITwoArgumentsCalculator
    {
        public double Calculate(double value_1, double value_2) => (Math.Pow(value_1, 1.0 / value_2));
    }
    public class Log_Base : ITwoArgumentsCalculator
    {
        public double Calculate(double value_1, double value_2) => (Math.Log(value_1, value_2));
    }
    public class TwoArgumentsFactory
    {
        public ITwoArgumentsCalculator Create_Calculator(string type)
        {
            switch(type)
            {
                case "^":
                    return new Elevate();
                case "root":
                    return new Root();
                case "log base":
                    return new Log_Base();
                case "+":
                    return new Summation();
                case "-":
                    return new Subtraction();
                case "x":
                    return new Multiplication();
                case "/":
                    return new Division();
                case "mod":
                    return new Modulo_Division();
                default: return null;
            }
        }
    }
}
