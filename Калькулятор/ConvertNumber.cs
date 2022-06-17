using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Калькулятор
{
    public interface IConvertNumber
    {
        double Convertation(double number);
    }
    public class Logarithm : IConvertNumber
    {
        public double Convertation(double number) => (Math.Log10(number));
    }
    public class Natural_Logarithm : IConvertNumber
    {
        public double Convertation(double number) => (Math.Log(number));
    }
    public class Ten_To_The_Power : IConvertNumber
    {
        public double Convertation(double number) => (Math.Pow(10, number));
    }
    public class Square_Root : IConvertNumber
    {
        public double Convertation(double number) => (Math.Sqrt(number));
    }
    public class Cube_Root : IConvertNumber
    {
        public double Convertation(double number) => (Math.Pow(number, 1.0 / 3.0));
    }
    public class Square : IConvertNumber
    {
        public double Convertation(double number) => (Math.Pow(number, 2));
    }
    public class Cube : IConvertNumber
    {
        public double Convertation(double number) => (Math.Pow(number, 3));
    }
    public class Factorial : IConvertNumber
    {
        public double Convertation(double number)
        {
            if (number == 0)
                return 1;
            else
                return number * Convertation(number - 1);
        }
    }
    public class Scale_Up : IConvertNumber
    {
        public double Convertation(double number) => (1 / number);
    }
    public class Module : IConvertNumber
    {
        public double Convertation(double number) => (Math.Abs(number));
    }
    public class Two_In_Power : IConvertNumber
    {
        public double Convertation(double number) => (Math.Pow(2.0, number));
    }
    public class E_In_Power : IConvertNumber
    {
        public double Convertation(double number) => (Math.Pow(Math.E, number));
    }
    public class ConvertNumber
    {
        public IConvertNumber Create_Convert(string type)
        {
            switch(type)
            {
                case "log": return new Logarithm();
                case "ln": return new Natural_Logarithm();
                case "10^x": return new Ten_To_The_Power();
                case "sqrt(x)": return new Square_Root();
                case "cuberoot(x)": return new Cube_Root();
                case "x^2": return new Square();
                case "x^3": return new Cube();
                case "n!": return new Factorial();
                case "1/x": return new Scale_Up();
                case "|x|": return new Module();
                case "2^x": return new Two_In_Power();
                case "e^x": return new E_In_Power();
                default: return null;
            }
        }
    }
}
