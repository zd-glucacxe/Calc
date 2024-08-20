using System;
using System.Linq;
using System.Windows.Forms;

namespace Calc {
    /// <summary>
    /// 计算器窗口
    /// </summary>
    public partial class CalcForm : Form {


        public CalcForm() {
            InitializeComponent();

            Init();
        }

        /// <summary>
        /// 初始化相关属性
        /// </summary>
        private void Init() {
            AutoSizeMode = AutoSizeMode.GrowAndShrink;  //设置控件的大小可以根据其内容自动增大或减小。
            AutoSize = false;  // 窗体必须手动调整大小

            // 设置数字输入从右向左
            tb_num1.TextAlign = HorizontalAlignment.Right;
            tb_num2.TextAlign = HorizontalAlignment.Right;

            RegEvents();
            this.SetDisplayArea(true);
            SetDefaultValue("0"); //  初始化，默认第二行开始为0

            // 禁用窗口最大化，最小化
            MaximizeBox = false;
            MinimizeBox = false;


        }
        /// <summary>
        /// 设置textBox默认值
        /// </summary>
        private void SetDefaultValue(string value) {
            this.tb_num2.Text = value;
        }

        /// <summary>
        /// 设置Textbox，当第一位有输入时，将初始化的0给去除
        /// </summary>
        private void TextBox2Input() {
            if (tb_num2.Text == "0")
            {
                tb_num2.Text = "";
            }
        }

        /// <summary>
        /// 判断字符串是否包含运算符
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        private bool IsContainOperator(string str) {
            if (str.Contains("＋") || str.Contains("-") || str.Contains("＋") || str.Contains("÷"))
            {
                return true;
            }
            return false;
        }

        // 注册相关事件
        private void RegEvents() {

            // 设置＝ 键按钮功能
            this.btn_equal.Click += Btn_equal_Click;

            // 设置运算符按钮功能
            this.btn_add.Click += Btn_add_Click;
            this.btn_sub.Click += Btn_sub_Click;
            this.btn_mul.Click += Btn_mul_Click;
            this.btn_div.Click += Btn_div_Click;


            // 设置Del、CE 键 按钮功能
            this.btn_del.Click += Btn_del_Click;
            this.btn_cleanup.Click += Btn_cleanup_Click;

            // 设置数字 小数点按钮功能
            this.btn_point.Click += Btn_point_Click;
            this.btn_zero.Click += Btn_zero_Click;
            this.btn_1.Click += Btn_1_Click;
            this.btn_2.Click += Btn_2_Click;
            this.btn_3.Click += Btn_3_Click;
            this.btn_4.Click += Btn_4_Click;
            this.btn_5.Click += Btn_5_Click;
            this.btn_6.Click += Btn_6_Click;
            this.btn_7.Click += Btn_7_Click;
            this.btn_8.Click += Btn_8_Click;
            this.btn_9.Click += Btn_9_Click;
        }

        /// <summary>
        /// 等于 按键
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="NotImplementedException"></exception>
        private void Btn_equal_Click(object sender, EventArgs e) {
            string num1Str = tb_num1.Text.Substring(0, tb_num1.Text.Length - 1);
            double num1 = 0;
            bool temp = double.TryParse(num1Str, out num1); //把num1Str 转为双精度浮点数，成功则输出为num1. 失败则false
            if (!temp) // 转换失败
            {
                return; // 说明num1不是一个double类型的，可能是空串，无法运算操作
            }


            double num2 = 0;
            bool temp2 = double.TryParse(tb_num2.Text, out num2); //把num2Text 转为双精度浮点数，成功则输出为num2. 失败则false
            if (!temp2) // 转换失败
            {
                return; // 说明num2不是一个double类型的，可能是空串，无法运算操作
            }

            char operatorStr = tb_num1.Text.LastOrDefault(); // 获取运算符

            double res = Operations(num1, num2, operatorStr); // 运算操作

            tb_num1.Text += num2 + "=";
            tb_num2.Text = res.ToString();   // 显示结果到textBox2
        }

        /// <summary>
        /// 运算操作
        /// </summary>
        /// <param name="num1"></param> 第一个数 textBox1
        /// <param name="num2"></param> 第二个数 textBox2
        /// <param name="operatorStr"></param> 运算符
        private double Operations(double num1, double num2, char operatorStr) {
            switch (operatorStr)
            {
                case '+':
                    return num1 + num2;

                case '-':
                    return num1 - num2;

                case '×':
                    return num1 * num2;

                case '÷':
                    return num1 / num2;

                default:
                    return 0;
            }
        }


        /// <summary>
        /// 除法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="NotImplementedException"></exception>
        private void Btn_div_Click(object sender, EventArgs e) {
            // 如果字符串不包含运算符那么就 加上 预算符号， 如果字符串包含运算符，那么就改变最后一位运算符
            string tb1Str = tb_num1.Text;
            bool flag = IsContainOperator(tb1Str);
            if (!flag)
            {
                tb_num1.Text = tb_num2.Text + "÷";
            }
            else
            {
                IsRepeatOperatorControl();
                tb1Str = tb_num1.Text;
                tb_num1.Text = tb1Str.Substring(0, tb1Str.Length - 1) + "÷";
            }
        }

        /// <summary>
        /// 乘法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="NotImplementedException"></exception>
        private void Btn_mul_Click(object sender, EventArgs e) {
            // 如果字符串不包含运算符那么就 加上 预算符号， 如果字符串包含运算符，那么就改变最后一位运算符
            string tb1Str = tb_num1.Text;
            bool flag = IsContainOperator(tb1Str);
            if (!flag)
            {
                tb_num1.Text = tb_num2.Text + "×";
            }
            else
            {
                IsRepeatOperatorControl();
                tb1Str = tb_num1.Text;
                tb_num1.Text = tb1Str.Substring(0, tb1Str.Length - 1) + "×";
            }
        }

        /// <summary>
        /// 减法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="NotImplementedException"></exception>
        private void Btn_sub_Click(object sender, EventArgs e) {
            // 如果字符串不包含运算符那么就 加上 预算符号， 如果字符串包含运算符，那么就改变最后一位运算符
            string tb1Str = tb_num1.Text;
            bool flag = IsContainOperator(tb1Str);
            if (!flag)
            {
                tb_num1.Text = tb_num2.Text + "-";
            }
            else
            {
                IsRepeatOperatorControl();
                tb1Str = tb_num1.Text;
                tb_num1.Text = tb1Str.Substring(0, tb1Str.Length - 1) + "-";  //此方法没有考虑连续输入运算符的场景

            }
        }

        /// <summary>
        /// 加法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="NotImplementedException"></exception>
        private void Btn_add_Click(object sender, EventArgs e) {
            // 如果字符串不包含运算符那么就 加上 运算符号， 如果字符串包含运算符，那么就改变最后一位运算符
            string tb1Str = tb_num1.Text;
            bool flag = IsContainOperator(tb1Str);
            if (!flag)
            {
                tb_num1.Text = tb_num2.Text + "+";
            }
            else
            {
                IsRepeatOperatorControl();
                tb1Str = tb_num1.Text;
                tb_num1.Text = tb1Str.Substring(0, tb1Str.Length - 1) + "+";

            }
        }

        /// <summary>
        /// 检查处理 连续运算符 的特殊情况，避免在 tb_num1.Text 中重复添加运算符
        /// </summary>
        /// <returns></returns>
        private void IsRepeatOperatorControl() {
            var addIndex = tb_num1.Text.IndexOf("+");
            var subIndex = tb_num1.Text.IndexOf("-");
            var mulIndex = tb_num1.Text.IndexOf("×");
            var divIndex = tb_num1.Text.IndexOf("÷");
            if (addIndex == -1 && subIndex == -1 && mulIndex == -1 && divIndex == -1)
            {
                return;
            }
            if (addIndex != -1)
            {
                tb_num1.Text = tb_num2.Text + "+";
            }
            if (subIndex != -1)
            {
                tb_num1.Text = tb_num2.Text + "-" ;
            }
            if (mulIndex != -1)
            {
                tb_num1.Text = tb_num2.Text + "×";
            }
            if (divIndex != -1)
            {
                tb_num1.Text = tb_num2.Text + "÷";
            }

        }
        private void Btn_del_Click(object sender, EventArgs e) {
            // 如果界面初始化的0的话，就不需要删除了
            string str = tb_num2.Text;
            if (str == "0")
            {
                return;
            }
            // 如果删除到最后只剩一位了，那么就初始化为0
            if (str.Length == 1)
            {
                str = "0";
                tb_num2.Text = str;  // 更新文本框
            }
            else
            {
                // 设置Del功能，每次点击删除最后一位
                str = str.Substring(0, str.Length - 1);
                tb_num2.Text = str;  // 更新文本框
            }

        }



        private void Btn_cleanup_Click(object sender, EventArgs e) {
            this.tb_num1.Text = "";
            this.tb_num2.Text = "";
            tb_num2.Text = "0";
        }

        private void Btn_point_Click(object sender, EventArgs e) {
            if (tb_num2.Text == "")
            {
                return ;
            }
            if (tb_num1.Text.Contains("="))
            {
                tb_num2.Text += "";
                tb_num1.Text += "";
                return;
            }
            if (tb_num2.Text.Contains("."))
            {
                //当已经输入了一个 “.” 时， 就不能继续输入了（该按钮失效）
                return;
            }
            tb_num2.Text += ".";
        }


        /// <summary>
        /// num1TextBox 最后一个字符是运算符
        /// </summary>
        /// <param name="num"></param> 当前字符
        /// <returns></returns>
        private bool IsOperatorControl(int num) {
            var str1LastChar = tb_num1.Text.LastOrDefault();  //返回TextBox1最后一位
            if (tb_num1.Text.Length < 2) //小于2 没有意义
            {
                return false;
            }
            var numValue = tb_num1.Text.Substring(0, tb_num1.Text.Length - 1);// 除去最后一位字符的字符串
                                                                              // 当TextBox1最后一位是符号时，此时在TextBox2设置新数字时，需要将TextBox2清空，然后重新添加数字
            if (str1LastChar == '+' || str1LastChar == '-' || str1LastChar == '×' || str1LastChar == '÷')
            {
                if (numValue == tb_num2.Text) //在这个逻辑块中，进一步检查 numValue（tb_num1 除去最后一位字符后的内容）是否与 tb_num2 的文本相同。
                                              //如果相同，意味着用户刚刚输入了运算符，并且 tb_num2 可能显示了之前的结果或中间结果。在这种情况下，程序将：   
                {
                    //tb_num2.Text = "";  //清空 tb_num2 的内容。
                    tb_num2.Text = num.ToString();  //将 tb_num2 的内容设置为 num（即用户刚点击的数字）。
                }
                else
                    tb_num2.Text += num.ToString(); //如果 numValue 与 tb_num2.Text 不相同，说明用户可能已经输入了一些其他数字，此时程序会在 tb_num2 的末尾追加 num（用户点击的数字）。
                return true; // 最后，方法返回 true，表示操作成功处理。
            }
            return false;
        }
        private void Btn_9_Click(object sender, EventArgs e) {
            if (tb_num1.Text.Contains("="))
            {
                tb_num2.Text = "9";
                tb_num1.Text = "";
                return;
            }
            TextBox2Input();

            if (IsOperatorControl(9))
            {
                return;
            }
            tb_num2.Text += 9;
        }

        private void Btn_8_Click(object sender, EventArgs e) {
            if (tb_num1.Text.Contains("="))
            {
                tb_num2.Text = "8";
                tb_num1.Text = "";
                return;
            }
            TextBox2Input();
            if (IsOperatorControl(8))
            {
                return;
            }
            tb_num2.Text += 8;
        }
        private void Btn_7_Click(object sender, EventArgs e) {
            if (tb_num1.Text.Contains("="))
            {
                tb_num2.Text = "7";
                tb_num1.Text = "";
                return;
            }
            TextBox2Input();
            if (IsOperatorControl(7))
            {
                return;
            }
            tb_num2.Text += 7;
        }
        private void Btn_6_Click(object sender, EventArgs e) {
            if (tb_num1.Text.Contains("="))
            {
                tb_num2.Text = "6";
                tb_num1.Text = "";
                return;
            }
            TextBox2Input();
            if (IsOperatorControl(6))
            {
                return;
            }
            tb_num2.Text += 6;
        }
        private void Btn_5_Click(object sender, EventArgs e) {
            if (tb_num1.Text.Contains("="))
            {
                tb_num2.Text = "5";
                tb_num1.Text = "";
                return;
            }
            TextBox2Input();
            if (IsOperatorControl(5))
            {
                return;
            }
            tb_num2.Text += 5;
        }
        private void Btn_4_Click(object sender, EventArgs e) {
            if (tb_num1.Text.Contains("="))
            {
                tb_num2.Text = "4";
                tb_num1.Text = "";
                return;
            }
            TextBox2Input();
            if (IsOperatorControl(4))
            {
                return;
            }
            tb_num2.Text += 4;
        }
        private void Btn_3_Click(object sender, EventArgs e) {
            if (tb_num1.Text.Contains("="))
            {
                tb_num2.Text = "3";
                tb_num1.Text = "";
                return;
            }
            TextBox2Input();
            if (IsOperatorControl(3))
            {
                return;
            }
            tb_num2.Text += 3;
        }
        private void Btn_2_Click(object sender, EventArgs e) {
            if (tb_num1.Text.Contains("="))
            {
                tb_num2.Text = "2";
                tb_num1.Text = "";
                return;
            }
            TextBox2Input();
            if (IsOperatorControl(2))
            {
                return;
            }
            tb_num2.Text += 2;
        }
        private void Btn_1_Click(object sender, EventArgs e) {
            if (tb_num1.Text.Contains("="))
            {
                tb_num2.Text = "1";
                tb_num1.Text = "";
                return;  
            }  
            TextBox2Input();
            if (IsOperatorControl(1))
            {
                return;
            }
            tb_num2.Text += 1;
        }
        private void Btn_zero_Click(object sender, EventArgs e) {
            if (tb_num1.Text.Contains("=")) {
                tb_num2.Text = "0";
                tb_num1.Text = "";
                return;
            }
            TextBox2Input();
            if (IsOperatorControl(0))
            {
                return;
            }
            tb_num2.Text += 0;
        }


        /// <summary>
        /// 设置上方数字区域，是否可以修改
        /// </summary>
        /// <param name="ReadOnly">true: 不可以修改； false：可以修改</param>
        private void SetDisplayArea(bool ReadOnly) {
            this.tb_num1.ReadOnly = ReadOnly;  //不允许用户编辑，只能按钮输入
            this.tb_num2.ReadOnly = ReadOnly;
        }
    }
}
