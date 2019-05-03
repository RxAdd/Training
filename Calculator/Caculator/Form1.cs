using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //List<string> tmp = new List<string>(); //存放單次數字
        Stack<string> my_operator = new Stack<string>(); // +-*/ 運算子
        Stack<string> my_operand = new Stack<string>(); // 1,2,3,4,5 運算元
        bool operatored = false;





        private void btn_0_Click(object sender, EventArgs e)
        {
            Button bt;
            bt = (Button)(sender);
            if (operatored == true)
            {
                txb_result.Text = "";
                operatored = false;
            }
            txb_result.Text += bt.Text;
        }


        private void btn_divide_Click(object sender, EventArgs e)
        {

            my_operand.Push(txb_result.Text);
            Caculate();
            my_operator.Push("/");
            operatored = true;
            //txb_result.Text = "/";

        }

        private void btn_multiply_Click(object sender, EventArgs e)
        {
            my_operand.Push(txb_result.Text);
            Caculate();
            my_operator.Push("*");
            operatored = true;
            //txb_result.Text = "*";


        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            my_operand.Push(txb_result.Text);
            Caculate();
            my_operator.Push("+");
            operatored = true;
            //txb_result.Text = "+";

        }

        private void btn_minus_Click(object sender, EventArgs e)
        {
            my_operand.Push(txb_result.Text);
            Caculate();
            my_operator.Push("-");
            operatored = true;
            //txb_result.Text = "-";


        }
        public void Caculate()
        {
            if (my_operator.Count > 0) //有運算符號
            {
                if (my_operand.Count > 1) //有數字
                {
                    double a = double.Parse(my_operand.Pop());
                    if (a == 0 && my_operator.Last() == "/") MessageBox.Show("Error除數不為0");
                    double b = double.Parse(my_operand.Pop());
                    double result = 0;
                    switch (my_operator.Pop())
                    {
                        case "+":
                            result = b + a;
                            break;
                        case "-":
                            result = b - a;
                            break;
                        case "*":
                            result = b * a;
                            break;
                        case "/":
                            result = b / a;
                            break;

                    }
                    my_operand.Push(result.ToString());
                    txb_result.Text = result.ToString();
                    operatored = false;
                }
            }

        }
        private void equal_Click(object sender, EventArgs e)
        {

            my_operand.Push(txb_result.Text);
            Caculate();
            txb_result.Text = my_operand.Pop();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            my_operand.Clear();
            my_operator.Clear();
            txb_result.Text = "";
            operatored = false;



        }

        private void btn_point_Click(object sender, EventArgs e)
        {
            if (!txb_result.Text.Contains("."))
            txb_result.Text += ".";
        }
    }
}
