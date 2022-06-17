
namespace Калькулятор
{
    partial class Калькулятор
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.display = new System.Windows.Forms.PictureBox();
            this.number_one = new System.Windows.Forms.Button();
            this.number_two = new System.Windows.Forms.Button();
            this.number_three = new System.Windows.Forms.Button();
            this.number_four = new System.Windows.Forms.Button();
            this.number_five = new System.Windows.Forms.Button();
            this.number_six = new System.Windows.Forms.Button();
            this.number_seven = new System.Windows.Forms.Button();
            this.number_eight = new System.Windows.Forms.Button();
            this.number_nine = new System.Windows.Forms.Button();
            this.number_zero = new System.Windows.Forms.Button();
            this._decimal = new System.Windows.Forms.Button();
            this.positive_or_negative = new System.Windows.Forms.Button();
            this.equally = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.multiplication = new System.Windows.Forms.Button();
            this.division = new System.Windows.Forms.Button();
            this.total_value = new System.Windows.Forms.Label();
            this.string_value = new System.Windows.Forms.Label();
            this.modulo_division = new System.Windows.Forms.Button();
            this.backspace = new System.Windows.Forms.Button();
            this.natural_logarithm = new System.Windows.Forms.Button();
            this.decimal_logarithm = new System.Windows.Forms.Button();
            this.ten_to_the_power_of_x = new System.Windows.Forms.Button();
            this.power = new System.Windows.Forms.Button();
            this.square_root = new System.Windows.Forms.Button();
            this.square = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.cube = new System.Windows.Forms.Button();
            this.cuberoot = new System.Windows.Forms.Button();
            this.second = new System.Windows.Forms.Button();
            this.scale_up = new System.Windows.Forms.Button();
            this.module = new System.Windows.Forms.Button();
            this.Pi = new System.Windows.Forms.Button();
            this.E = new System.Windows.Forms.Button();
            this.rand = new System.Windows.Forms.Button();
            this.factorial = new System.Windows.Forms.Button();
            this.yroot = new System.Windows.Forms.Button();
            this.two_in_power = new System.Windows.Forms.Button();
            this.log_base = new System.Windows.Forms.Button();
            this.e_in_power = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.display)).BeginInit();
            this.SuspendLayout();
            // 
            // display
            // 
            this.display.BackColor = System.Drawing.SystemColors.Window;
            this.display.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.display.Location = new System.Drawing.Point(13, 13);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(294, 89);
            this.display.TabIndex = 0;
            this.display.TabStop = false;
            // 
            // number_one
            // 
            this.number_one.Location = new System.Drawing.Point(67, 276);
            this.number_one.Name = "number_one";
            this.number_one.Size = new System.Drawing.Size(60, 30);
            this.number_one.TabIndex = 1;
            this.number_one.Text = "1";
            this.number_one.UseVisualStyleBackColor = true;
            this.number_one.Click += new System.EventHandler(this.Enter_Value);
            this.number_one.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Keyboard_Active);
            // 
            // number_two
            // 
            this.number_two.Location = new System.Drawing.Point(129, 276);
            this.number_two.Name = "number_two";
            this.number_two.Size = new System.Drawing.Size(60, 30);
            this.number_two.TabIndex = 1;
            this.number_two.Text = "2";
            this.number_two.UseVisualStyleBackColor = true;
            this.number_two.Click += new System.EventHandler(this.Enter_Value);
            this.number_two.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Keyboard_Active);
            // 
            // number_three
            // 
            this.number_three.Location = new System.Drawing.Point(191, 276);
            this.number_three.Name = "number_three";
            this.number_three.Size = new System.Drawing.Size(60, 30);
            this.number_three.TabIndex = 1;
            this.number_three.Text = "3";
            this.number_three.UseVisualStyleBackColor = true;
            this.number_three.Click += new System.EventHandler(this.Enter_Value);
            this.number_three.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Keyboard_Active);
            // 
            // number_four
            // 
            this.number_four.Location = new System.Drawing.Point(67, 242);
            this.number_four.Name = "number_four";
            this.number_four.Size = new System.Drawing.Size(60, 30);
            this.number_four.TabIndex = 1;
            this.number_four.Text = "4";
            this.number_four.UseVisualStyleBackColor = true;
            this.number_four.Click += new System.EventHandler(this.Enter_Value);
            this.number_four.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Keyboard_Active);
            // 
            // number_five
            // 
            this.number_five.Location = new System.Drawing.Point(129, 242);
            this.number_five.Name = "number_five";
            this.number_five.Size = new System.Drawing.Size(60, 30);
            this.number_five.TabIndex = 1;
            this.number_five.Text = "5";
            this.number_five.UseVisualStyleBackColor = true;
            this.number_five.Click += new System.EventHandler(this.Enter_Value);
            this.number_five.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Keyboard_Active);
            // 
            // number_six
            // 
            this.number_six.Location = new System.Drawing.Point(191, 242);
            this.number_six.Name = "number_six";
            this.number_six.Size = new System.Drawing.Size(60, 30);
            this.number_six.TabIndex = 1;
            this.number_six.Text = "6";
            this.number_six.UseVisualStyleBackColor = true;
            this.number_six.Click += new System.EventHandler(this.Enter_Value);
            this.number_six.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Keyboard_Active);
            // 
            // number_seven
            // 
            this.number_seven.Location = new System.Drawing.Point(67, 208);
            this.number_seven.Name = "number_seven";
            this.number_seven.Size = new System.Drawing.Size(60, 30);
            this.number_seven.TabIndex = 1;
            this.number_seven.Text = "7";
            this.number_seven.UseVisualStyleBackColor = true;
            this.number_seven.Click += new System.EventHandler(this.Enter_Value);
            this.number_seven.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Keyboard_Active);
            // 
            // number_eight
            // 
            this.number_eight.Location = new System.Drawing.Point(129, 208);
            this.number_eight.Name = "number_eight";
            this.number_eight.Size = new System.Drawing.Size(60, 30);
            this.number_eight.TabIndex = 1;
            this.number_eight.Text = "8";
            this.number_eight.UseVisualStyleBackColor = true;
            this.number_eight.Click += new System.EventHandler(this.Enter_Value);
            this.number_eight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Keyboard_Active);
            // 
            // number_nine
            // 
            this.number_nine.Location = new System.Drawing.Point(191, 208);
            this.number_nine.Name = "number_nine";
            this.number_nine.Size = new System.Drawing.Size(60, 30);
            this.number_nine.TabIndex = 1;
            this.number_nine.Text = "9";
            this.number_nine.UseVisualStyleBackColor = true;
            this.number_nine.Click += new System.EventHandler(this.Enter_Value);
            this.number_nine.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Keyboard_Active);
            // 
            // number_zero
            // 
            this.number_zero.Location = new System.Drawing.Point(129, 310);
            this.number_zero.Name = "number_zero";
            this.number_zero.Size = new System.Drawing.Size(60, 30);
            this.number_zero.TabIndex = 1;
            this.number_zero.Text = "0";
            this.number_zero.UseVisualStyleBackColor = true;
            this.number_zero.Click += new System.EventHandler(this.Enter_Value);
            this.number_zero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Keyboard_Active);
            // 
            // _decimal
            // 
            this._decimal.Location = new System.Drawing.Point(191, 310);
            this._decimal.Name = "_decimal";
            this._decimal.Size = new System.Drawing.Size(60, 30);
            this._decimal.TabIndex = 1;
            this._decimal.Text = ",";
            this._decimal.UseVisualStyleBackColor = true;
            this._decimal.Click += new System.EventHandler(this.Enter_Value);
            this._decimal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Keyboard_Active);
            // 
            // positive_or_negative
            // 
            this.positive_or_negative.Location = new System.Drawing.Point(67, 310);
            this.positive_or_negative.Name = "positive_or_negative";
            this.positive_or_negative.Size = new System.Drawing.Size(60, 30);
            this.positive_or_negative.TabIndex = 1;
            this.positive_or_negative.Text = "+/-";
            this.positive_or_negative.UseVisualStyleBackColor = true;
            this.positive_or_negative.Click += new System.EventHandler(this.Enter_Value);
            this.positive_or_negative.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Keyboard_Active);
            // 
            // equally
            // 
            this.equally.Location = new System.Drawing.Point(253, 310);
            this.equally.Name = "equally";
            this.equally.Size = new System.Drawing.Size(60, 30);
            this.equally.TabIndex = 1;
            this.equally.Text = "=";
            this.equally.UseVisualStyleBackColor = true;
            this.equally.Click += new System.EventHandler(this.Start_Calculation);
            this.equally.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Keyboard_Active);
            // 
            // plus
            // 
            this.plus.Location = new System.Drawing.Point(253, 276);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(60, 30);
            this.plus.TabIndex = 1;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.Type_Of_Option);
            this.plus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Keyboard_Active);
            // 
            // minus
            // 
            this.minus.Location = new System.Drawing.Point(253, 242);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(60, 30);
            this.minus.TabIndex = 1;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.Type_Of_Option);
            this.minus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Keyboard_Active);
            // 
            // multiplication
            // 
            this.multiplication.Location = new System.Drawing.Point(253, 208);
            this.multiplication.Name = "multiplication";
            this.multiplication.Size = new System.Drawing.Size(60, 30);
            this.multiplication.TabIndex = 1;
            this.multiplication.Text = "x";
            this.multiplication.UseVisualStyleBackColor = true;
            this.multiplication.Click += new System.EventHandler(this.Type_Of_Option);
            this.multiplication.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Keyboard_Active);
            // 
            // division
            // 
            this.division.Location = new System.Drawing.Point(253, 174);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(60, 30);
            this.division.TabIndex = 1;
            this.division.Text = "/";
            this.division.UseVisualStyleBackColor = true;
            this.division.Click += new System.EventHandler(this.Type_Of_Option);
            this.division.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Keyboard_Active);
            // 
            // total_value
            // 
            this.total_value.AutoEllipsis = true;
            this.total_value.BackColor = System.Drawing.SystemColors.Window;
            this.total_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.total_value.Location = new System.Drawing.Point(21, 16);
            this.total_value.Name = "total_value";
            this.total_value.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.total_value.Size = new System.Drawing.Size(278, 45);
            this.total_value.TabIndex = 2;
            this.total_value.Text = "total";
            this.total_value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.total_value.Visible = false;
            // 
            // string_value
            // 
            this.string_value.BackColor = System.Drawing.SystemColors.Window;
            this.string_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.string_value.Location = new System.Drawing.Point(21, 58);
            this.string_value.Name = "string_value";
            this.string_value.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.string_value.Size = new System.Drawing.Size(278, 29);
            this.string_value.TabIndex = 3;
            this.string_value.Text = "0";
            this.string_value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // modulo_division
            // 
            this.modulo_division.Location = new System.Drawing.Point(253, 141);
            this.modulo_division.Name = "modulo_division";
            this.modulo_division.Size = new System.Drawing.Size(60, 30);
            this.modulo_division.TabIndex = 1;
            this.modulo_division.Text = "mod";
            this.modulo_division.UseVisualStyleBackColor = true;
            this.modulo_division.Click += new System.EventHandler(this.Type_Of_Option);
            this.modulo_division.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Keyboard_Active);
            // 
            // backspace
            // 
            this.backspace.Location = new System.Drawing.Point(253, 108);
            this.backspace.Name = "backspace";
            this.backspace.Size = new System.Drawing.Size(60, 30);
            this.backspace.TabIndex = 1;
            this.backspace.Text = "<-";
            this.backspace.UseVisualStyleBackColor = true;
            this.backspace.Click += new System.EventHandler(this.Enter_Value);
            this.backspace.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Keyboard_Active);
            // 
            // natural_logarithm
            // 
            this.natural_logarithm.Location = new System.Drawing.Point(5, 310);
            this.natural_logarithm.Name = "natural_logarithm";
            this.natural_logarithm.Size = new System.Drawing.Size(60, 30);
            this.natural_logarithm.TabIndex = 1;
            this.natural_logarithm.Text = "ln";
            this.natural_logarithm.UseVisualStyleBackColor = true;
            this.natural_logarithm.Click += new System.EventHandler(this.Convert_Number_By_Type);
            this.natural_logarithm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Keyboard_Active);
            // 
            // decimal_logarithm
            // 
            this.decimal_logarithm.Location = new System.Drawing.Point(5, 276);
            this.decimal_logarithm.Name = "decimal_logarithm";
            this.decimal_logarithm.Size = new System.Drawing.Size(60, 30);
            this.decimal_logarithm.TabIndex = 1;
            this.decimal_logarithm.Text = "log";
            this.decimal_logarithm.UseVisualStyleBackColor = true;
            this.decimal_logarithm.Click += new System.EventHandler(this.Convert_Number_By_Type);
            this.decimal_logarithm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Keyboard_Active);
            // 
            // ten_to_the_power_of_x
            // 
            this.ten_to_the_power_of_x.Location = new System.Drawing.Point(5, 242);
            this.ten_to_the_power_of_x.Name = "ten_to_the_power_of_x";
            this.ten_to_the_power_of_x.Size = new System.Drawing.Size(60, 30);
            this.ten_to_the_power_of_x.TabIndex = 1;
            this.ten_to_the_power_of_x.Text = "10^x";
            this.ten_to_the_power_of_x.UseVisualStyleBackColor = true;
            this.ten_to_the_power_of_x.Click += new System.EventHandler(this.Convert_Number_By_Type);
            this.ten_to_the_power_of_x.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Keyboard_Active);
            // 
            // power
            // 
            this.power.Location = new System.Drawing.Point(5, 208);
            this.power.Name = "power";
            this.power.Size = new System.Drawing.Size(60, 30);
            this.power.TabIndex = 1;
            this.power.Text = "x^y";
            this.power.UseVisualStyleBackColor = true;
            this.power.Click += new System.EventHandler(this.Enter_Value);
            this.power.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Keyboard_Active);
            // 
            // square_root
            // 
            this.square_root.Location = new System.Drawing.Point(5, 174);
            this.square_root.Name = "square_root";
            this.square_root.Size = new System.Drawing.Size(60, 30);
            this.square_root.TabIndex = 1;
            this.square_root.Text = "sqrt(x)";
            this.square_root.UseVisualStyleBackColor = true;
            this.square_root.Click += new System.EventHandler(this.Convert_Number_By_Type);
            this.square_root.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Keyboard_Active);
            // 
            // square
            // 
            this.square.Location = new System.Drawing.Point(5, 141);
            this.square.Name = "square";
            this.square.Size = new System.Drawing.Size(60, 30);
            this.square.TabIndex = 1;
            this.square.Text = "x^2";
            this.square.UseVisualStyleBackColor = true;
            this.square.Click += new System.EventHandler(this.Convert_Number_By_Type);
            this.square.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Keyboard_Active);
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(191, 108);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(60, 30);
            this.reset.TabIndex = 1;
            this.reset.Text = "CE";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.Enter_Value);
            this.reset.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Keyboard_Active);
            // 
            // cube
            // 
            this.cube.Location = new System.Drawing.Point(67, 141);
            this.cube.Name = "cube";
            this.cube.Size = new System.Drawing.Size(60, 30);
            this.cube.TabIndex = 1;
            this.cube.Text = "x^3";
            this.cube.UseVisualStyleBackColor = true;
            this.cube.Click += new System.EventHandler(this.Convert_Number_By_Type);
            this.cube.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Keyboard_Active);
            // 
            // cuberoot
            // 
            this.cuberoot.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cuberoot.Location = new System.Drawing.Point(67, 174);
            this.cuberoot.Name = "cuberoot";
            this.cuberoot.Size = new System.Drawing.Size(60, 30);
            this.cuberoot.TabIndex = 1;
            this.cuberoot.Text = "cuberoot(x)";
            this.cuberoot.UseVisualStyleBackColor = true;
            this.cuberoot.Click += new System.EventHandler(this.Convert_Number_By_Type);
            this.cuberoot.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Keyboard_Active);
            // 
            // second
            // 
            this.second.Location = new System.Drawing.Point(5, 108);
            this.second.Name = "second";
            this.second.Size = new System.Drawing.Size(60, 30);
            this.second.TabIndex = 1;
            this.second.Text = "second";
            this.second.UseVisualStyleBackColor = true;
            this.second.Click += new System.EventHandler(this.Switch_On_Second);
            this.second.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Keyboard_Active);
            // 
            // scale_up
            // 
            this.scale_up.Location = new System.Drawing.Point(129, 174);
            this.scale_up.Name = "scale_up";
            this.scale_up.Size = new System.Drawing.Size(60, 30);
            this.scale_up.TabIndex = 1;
            this.scale_up.Text = "1/x";
            this.scale_up.UseVisualStyleBackColor = true;
            this.scale_up.Click += new System.EventHandler(this.Convert_Number_By_Type);
            this.scale_up.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Keyboard_Active);
            // 
            // module
            // 
            this.module.Location = new System.Drawing.Point(191, 174);
            this.module.Name = "module";
            this.module.Size = new System.Drawing.Size(60, 30);
            this.module.TabIndex = 1;
            this.module.Text = "|x|";
            this.module.UseVisualStyleBackColor = true;
            this.module.Click += new System.EventHandler(this.Convert_Number_By_Type);
            this.module.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Keyboard_Active);
            // 
            // Pi
            // 
            this.Pi.Location = new System.Drawing.Point(67, 108);
            this.Pi.Name = "Pi";
            this.Pi.Size = new System.Drawing.Size(60, 30);
            this.Pi.TabIndex = 1;
            this.Pi.Text = "Pi";
            this.Pi.UseVisualStyleBackColor = true;
            this.Pi.Click += new System.EventHandler(this.Enter_Value);
            this.Pi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Keyboard_Active);
            // 
            // E
            // 
            this.E.Location = new System.Drawing.Point(129, 108);
            this.E.Name = "E";
            this.E.Size = new System.Drawing.Size(60, 30);
            this.E.TabIndex = 1;
            this.E.Text = "e";
            this.E.UseVisualStyleBackColor = true;
            this.E.Click += new System.EventHandler(this.Enter_Value);
            this.E.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Keyboard_Active);
            // 
            // rand
            // 
            this.rand.Location = new System.Drawing.Point(191, 141);
            this.rand.Name = "rand";
            this.rand.Size = new System.Drawing.Size(60, 30);
            this.rand.TabIndex = 1;
            this.rand.Text = "rand";
            this.rand.UseVisualStyleBackColor = true;
            this.rand.Click += new System.EventHandler(this.Enter_Value);
            this.rand.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Keyboard_Active);
            // 
            // factorial
            // 
            this.factorial.Location = new System.Drawing.Point(129, 141);
            this.factorial.Name = "factorial";
            this.factorial.Size = new System.Drawing.Size(60, 30);
            this.factorial.TabIndex = 1;
            this.factorial.Text = "n!";
            this.factorial.UseVisualStyleBackColor = true;
            this.factorial.Click += new System.EventHandler(this.Convert_Number_By_Type);
            this.factorial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Keyboard_Active);
            // 
            // yroot
            // 
            this.yroot.Location = new System.Drawing.Point(5, 208);
            this.yroot.Name = "yroot";
            this.yroot.Size = new System.Drawing.Size(60, 30);
            this.yroot.TabIndex = 4;
            this.yroot.Text = "root";
            this.yroot.UseVisualStyleBackColor = true;
            this.yroot.Visible = false;
            this.yroot.Click += new System.EventHandler(this.Type_Of_Option);
            this.yroot.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Keyboard_Active);
            // 
            // two_in_power
            // 
            this.two_in_power.Location = new System.Drawing.Point(5, 242);
            this.two_in_power.Name = "two_in_power";
            this.two_in_power.Size = new System.Drawing.Size(60, 30);
            this.two_in_power.TabIndex = 5;
            this.two_in_power.Text = "2^x";
            this.two_in_power.UseVisualStyleBackColor = true;
            this.two_in_power.Visible = false;
            this.two_in_power.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Keyboard_Active);
            // 
            // log_base
            // 
            this.log_base.Location = new System.Drawing.Point(5, 276);
            this.log_base.Name = "log_base";
            this.log_base.Size = new System.Drawing.Size(60, 30);
            this.log_base.TabIndex = 6;
            this.log_base.Text = "log base";
            this.log_base.UseVisualStyleBackColor = true;
            this.log_base.Visible = false;
            this.log_base.Click += new System.EventHandler(this.Type_Of_Option);
            this.log_base.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Keyboard_Active);
            // 
            // e_in_power
            // 
            this.e_in_power.Location = new System.Drawing.Point(5, 310);
            this.e_in_power.Name = "e_in_power";
            this.e_in_power.Size = new System.Drawing.Size(60, 30);
            this.e_in_power.TabIndex = 7;
            this.e_in_power.Text = "e^x";
            this.e_in_power.UseVisualStyleBackColor = true;
            this.e_in_power.Visible = false;
            this.e_in_power.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Keyboard_Active);
            // 
            // Калькулятор
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 349);
            this.Controls.Add(this.e_in_power);
            this.Controls.Add(this.log_base);
            this.Controls.Add(this.two_in_power);
            this.Controls.Add(this.yroot);
            this.Controls.Add(this.number_zero);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.module);
            this.Controls.Add(this.scale_up);
            this.Controls.Add(this.factorial);
            this.Controls.Add(this.rand);
            this.Controls.Add(this.E);
            this.Controls.Add(this.Pi);
            this.Controls.Add(this.cube);
            this.Controls.Add(this.second);
            this.Controls.Add(this.square);
            this.Controls.Add(this.cuberoot);
            this.Controls.Add(this.square_root);
            this.Controls.Add(this.power);
            this.Controls.Add(this.ten_to_the_power_of_x);
            this.Controls.Add(this.decimal_logarithm);
            this.Controls.Add(this.natural_logarithm);
            this.Controls.Add(this.backspace);
            this.Controls.Add(this.number_nine);
            this.Controls.Add(this.number_eight);
            this.Controls.Add(this.number_seven);
            this.Controls.Add(this.number_six);
            this.Controls.Add(this.number_five);
            this.Controls.Add(this.number_four);
            this.Controls.Add(this.positive_or_negative);
            this.Controls.Add(this.modulo_division);
            this.Controls.Add(this.division);
            this.Controls.Add(this.multiplication);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.equally);
            this.Controls.Add(this._decimal);
            this.Controls.Add(this.number_three);
            this.Controls.Add(this.number_two);
            this.Controls.Add(this.number_one);
            this.Controls.Add(this.string_value);
            this.Controls.Add(this.total_value);
            this.Controls.Add(this.display);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Калькулятор";
            this.RightToLeftLayout = true;
            this.Text = "Калькулятор";
            ((System.ComponentModel.ISupportInitialize)(this.display)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox display;
        private System.Windows.Forms.Button number_two;
        private System.Windows.Forms.Button number_three;
        private System.Windows.Forms.Button number_four;
        private System.Windows.Forms.Button number_five;
        private System.Windows.Forms.Button number_six;
        private System.Windows.Forms.Button number_seven;
        private System.Windows.Forms.Button number_eight;
        private System.Windows.Forms.Button number_nine;
        private System.Windows.Forms.Button number_zero;
        private System.Windows.Forms.Button _decimal;
        private System.Windows.Forms.Button positive_or_negative;
        private System.Windows.Forms.Button number_one;
        private System.Windows.Forms.Button equally;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button multiplication;
        private System.Windows.Forms.Button division;
        private System.Windows.Forms.Label string_value;
        private System.Windows.Forms.Label total_value;
        private System.Windows.Forms.Button modulo_division;
        private System.Windows.Forms.Button backspace;
        private System.Windows.Forms.Button natural_logarithm;
        private System.Windows.Forms.Button decimal_logarithm;
        private System.Windows.Forms.Button ten_to_the_power_of_x;
        private System.Windows.Forms.Button power;
        private System.Windows.Forms.Button square_root;
        private System.Windows.Forms.Button square;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button cube;
        private System.Windows.Forms.Button cuberoot;
        private System.Windows.Forms.Button second;
        private System.Windows.Forms.Button scale_up;
        private System.Windows.Forms.Button module;
        private System.Windows.Forms.Button Pi;
        private System.Windows.Forms.Button E;
        private System.Windows.Forms.Button rand;
        private System.Windows.Forms.Button factorial;
        private System.Windows.Forms.Button yroot;
        private System.Windows.Forms.Button two_in_power;
        private System.Windows.Forms.Button log_base;
        private System.Windows.Forms.Button e_in_power;
    }
}

