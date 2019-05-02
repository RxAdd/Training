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
            if (operatored == true)
            {
                txb_result.Text = "";
                operatored = false;
            }
            txb_result.Text += "0";
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            if (operatored == true)
            {
                txb_result.Text = "";
                operatored = false;
            }
            txb_result.Text += "1";
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            if (operatored == true)
            {
                txb_result.Text = "";
                operatored = false;
            }
            txb_result.Text += "2";
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            if (operatored == true)
            {
                txb_result.Text = "";
                operatored = false;
            }
            txb_result.Text += "3";
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            if (operatored == true)
            {
                txb_result.Text = "";
                operatored = false;
            }
            txb_result.Text += "4";
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            if (operatored == true)
            {
                txb_result.Text = "";
                operatored = false;
            }
            txb_result.Text += "5";
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            if (operatored == true)
            {
                txb_result.Text = "";
                operatored = false;
            }
            txb_result.Text += "6";
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            if (operatored == true)
            {
                txb_result.Text = "";
                operatored = false;
            }
            txb_result.Text += "7";
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            if (operatored == true)
            {
                txb_result.Text = "";
                operatored = false;
            }
            txb_result.Text += "8";
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            if (operatored == true)
            {
                txb_result.Text = "";
                operatored = false;
            }
            txb_result.Text += "9";
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

            txb_result.Text += ".";
        }
    }
}
