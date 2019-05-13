using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApplication11
{

   

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string _strValue;
        public string StrValue
        {
        
            set
            {
                label1.Text = value;
                _strValue = value;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            f2.setstr += F2_setstr;


        }

        private void F2_setstr(string str)
        {
            label1.Text = str;
        }

        public void ssetstr(string a)
        {


        }


    }
        



}
