﻿using System;
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
 
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public delegate void setstring(string str);
        public event setstring setstr;
        private void button1_Click(object sender, EventArgs e)
        {
            setstr(textBox1.Text);   //== setstr?.Invoke(textBox1.Text);
           
        }
    }
}
