using System;
using System.Windows.Forms;

/// <summary>
/// Ниже идет код моего калькулятора, который я напИсал в несколько дней в течение двух месяцев, ну так сказать: "Могу себе позволить".
/// Немного отдохнул летом так сказатб--
/// </summary>
namespace Калькулятор
{
    public partial class Калькулятор : Form
    {
        #region external_values;
        public const int max_value = 14;
        public string[] value = new string[max_value];
        public string[] sign = new string[max_value - 1];
        public string last_option;
        public int current;
        bool option = false;
        bool finish_calculate = false;
        bool write_number = true;
        bool second_mod = false;
        #endregion
        public Калькулятор()
        {
            InitializeComponent();
            Reset_ALL();
        }
        private void Check_Finish(object sender)
        {
            if (finish_calculate)
            {
                Reset_ALL();
                finish_calculate = false;
            }
        }
        private void Reset_ALL()
        {
            option = false;
            write_number = true;
            string_value.Text = "0";
            total_value.Visible = false;
            current = 0;
            if(total_value.Text.Length != 0)
                total_value.Text = total_value.Text.Remove(0);
            for (int i = 0; i < max_value; i++)
                value[i] = "0";
        }
        private void Next_Counter(object sender)
        {
            if(write_number)
                Write_Value();
            sign[current] = ((Button)sender).Text;
            if (sign[current] == "x^y")
                sign[current] = "^";
            total_value.Text += " " + sign[current] + " ";
            string_value.Text = "0";
            current++;
            value[current] = "0";
            last_option = null;
            write_number = true;
            option = false;
        }
        private void Type_Of_Option(object sender, EventArgs e)
        {
            Check_Finish(sender);
            if (current < max_value - 1)
                Next_Counter(sender);
            else
                MessageBox.Show("Максимально количество операций было превышено");
        }
        public void Word_Processing()
        {
            if (value[current].Length == 0 || value[current] == "-")
                value[current] = "0";
            if (value[current].IndexOf(',') != -1)
                string_value.Text = value[current];
            else
                string_value.Text = Convert.ToString((Convert.ToDouble(value[current])));
            value[current] = string_value.Text;
        }
        public void Enter_Value(object sender, EventArgs e)
        {
            Check_Finish(sender);
            switch (((Button)sender).Name)
            {
                case "reset":
                    Reset_ALL();
                    break;
                case "backspace":
                    if(!option) 
                        value[current] = value[current].Remove(value[current].Length - 1);
                    break;
                case "positive_or_negative":
                    value[current] = Convert.ToString(Convert.ToDouble(value[current]) * (-1));
                    break;
                case "Pi":
                    option = true;
                    value[current] = Convert.ToString(Math.PI);
                    break;
                case "E":
                    option = true;
                    value[current] = Convert.ToString(Math.E);
                    break;
                case "rand":
                    option = true;
                    Random rnd = new Random();
                    value[current] = Convert.ToString(rnd.NextDouble());
                    break;
                default:
                    if (option)
                    {
                        write_number = true;
                        value[current] = "0";
                        string_value.Text = "0";
                        option = false;
                    }
                    if (value[current].Length < max_value)
                    {
                        if (!(((Button)sender).Name == "_decimal" && value[current].IndexOf(',') > 0))
                            value[current] += ((Button)sender).Text;
                    } else MessageBox.Show("Превышено максимальное значение");
                    break;
            }
            Word_Processing();
        }
        private void Keyboard_Active(object sender, KeyPressEventArgs e)
        {
            switch(e.KeyChar.ToString()[0])
            {
                case '1': Enter_Value(number_one, e); break;
                case '2': Enter_Value(number_two, e); break;
                case '3': Enter_Value(number_three, e); break;
                case '4': Enter_Value(number_four, e); break;
                case '5': Enter_Value(number_five, e); break;
                case '6': Enter_Value(number_six, e); break;
                case '7': Enter_Value(number_seven, e); break;
                case '8': Enter_Value(number_eight, e); break;
                case '9': Enter_Value(number_nine, e); break;
                case '0': Enter_Value(number_zero, e); break;
                case 'a': Enter_Value(positive_or_negative, e); break;
                case 'R': Enter_Value(rand, e); break;
                case 'e': Enter_Value(E, e); break;
                case 'p': Enter_Value(Pi, e); break;
                case '+': Type_Of_Option(plus, e); break;
                case '-': Type_Of_Option(minus, e); break;
                case '*': Type_Of_Option(multiplication, e); break;
                case '/': Type_Of_Option(division, e); break;
                case 'm': Type_Of_Option(modulo_division, e); break;
                case '^': Type_Of_Option(power, e); break;
                case 'w': Type_Of_Option(yroot, e); break;
                case 'L': Type_Of_Option(log_base, e); break;
                case '=': Start_Calculation(equally, e); break;
                case 'l': Convert_Number_By_Type(decimal_logarithm, e); break;
                case 'n': Convert_Number_By_Type(natural_logarithm, e); break;
                case 'h': Convert_Number_By_Type(ten_to_the_power_of_x, e); break;
                case 's': Convert_Number_By_Type(square_root, e); break;
                case 'g': Convert_Number_By_Type(square, e); break;
                case 'c': Convert_Number_By_Type(cube, e); break;
                case '!': Convert_Number_By_Type(factorial, e); break;
                case 'r': Convert_Number_By_Type(scale_up, e); break;
                case '|': Convert_Number_By_Type(module, e); break;
                case 'q': Convert_Number_By_Type(cuberoot, e); break;
                case '`': Switch_On_Second(second, e); break;
                case (char)8: Enter_Value(backspace, e); break;
                case (char)27: Enter_Value(reset, e); break;
                case ',': Enter_Value(_decimal, e); break;
                default: break;
            }
        }
        public int Find_Priority()
        {
            if (sign[0] == "=")
                return -1;
            for (int count = 0; count < current; count++)
                if (sign[count] == "^" || sign[count] == "root" || sign[count] == "log base")
                    return count;
            for (int count = 0; count < current; count++)
                if (sign[count] == "/" || sign[count] == "x" || sign[count] == "mod")
                    return count;
            return 0;
        }
        public string[] Shift(string[] array, int start)
        {
            for(int count = start; count < current - 1; count++)
                array[count] = array[count + 1];
            return array;
        }
        private void Start_Calculation(object sender, EventArgs e)
        {
            Next_Counter(sender);
            TwoArgumentsFactory create = new TwoArgumentsFactory();
            try
            {
                while (Find_Priority() != (-1))
                {
                    ITwoArgumentsCalculator calculator = create.Create_Calculator(sign[Find_Priority()]);
                    double results = calculator.Calculate(Convert.ToDouble(value[Find_Priority()]),
                                                                            Convert.ToDouble(value[Find_Priority() + 1]));
                    value[Find_Priority() + 1] = Convert.ToString(results);
                    Shift(value, Find_Priority());
                    Shift(sign, Find_Priority());
                    current--;
                }
                string_value.Text = Convert.ToString(Convert.ToDouble(value[0]));
            }
            catch (Exception exc)
            {
                string_value.Text = exc.Message;
            }
            finish_calculate = true;
        }
        public void Write_Value()
        {
            if(last_option != null)
                total_value.Text = total_value.Text.Remove(total_value.Text.Length - last_option.Length);
            if (value[current][0] == '-')
                total_value.Text += "(" + Convert.ToString((Convert.ToDouble(value[current]))) + ")";
            else total_value.Text += Convert.ToString((Convert.ToDouble(value[current])));
            total_value.Visible = true;
        }
        public void Write_Option(object sender, string current_value)
        {
            write_number = false;
            total_value.Visible = true;
            switch(((Button)sender).Text)
            {
                case "log":
                    last_option = "log(" + current_value + ")"; break;
                case "ln":
                    last_option = "ln(" + current_value + ")"; break;
                case "10^x":
                    last_option = "10^(" + current_value + ")"; break;
                case "sqrt(x)":
                    last_option = "sqrt(" + current_value + ")"; break;
                case "cuberoot(x)":
                    last_option = "cuberoot(" + current_value + ")"; break;
                case "x^2":
                    last_option = current_value + " ^ 2"; break;
                case "x^3":
                    last_option = current_value + " ^ 3"; break;
                case "n!":
                    last_option = current_value + "!"; break;
                case "1/x":
                    last_option = "1 / " + current_value; break;
                case "|x|":
                    last_option = "|" + current_value + "|"; break;
                case "2^x":
                    last_option = "2 ^ " + current_value; break;
                case "e^x":
                    last_option = "e ^ " + current_value; break;
                default: break;
            }
            total_value.Text += last_option;
        }
        private void Convert_Number_By_Type(object sender, EventArgs e)
        {
            ConvertNumber Create = new ConvertNumber();
            IConvertNumber convertNumber = Create.Create_Convert(((Button)sender).Text);
            Write_Option(sender, value[current]);
            double current_number = convertNumber.Convertation(Convert.ToDouble(value[current]));
            value[current] = Convert.ToString(current_number);
            string_value.Text = value[current];
            option = true;
        }

        private void Switch_On_Second(object sender, EventArgs e)
        {
            second_mod = !second_mod;
            power.Visible = !second_mod;
            ten_to_the_power_of_x.Visible = !second_mod;
            decimal_logarithm.Visible = !second_mod;
            natural_logarithm.Visible = !second_mod;
            yroot.Visible = second_mod;
            log_base.Visible = second_mod;
            two_in_power.Visible = second_mod;
            e_in_power.Visible = second_mod;
        }
    }
}