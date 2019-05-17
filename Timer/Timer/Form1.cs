using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class Form1 : Form
    {
        public delegate void GetTime(string time);
        public event GetTime strGetTime;
        public Form1()
        {
            InitializeComponent();
        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string h1 = "";
            string h2 = "";
            string m1 = "";
            string m2 = "";
            string s1 = "";
            string s2 = "";
            string sTime = "";
            label1.Text = DateTime.Now.ToString("hh:mm:ss");
            sTime = DateTime.Now.ToString("hhmmss");
            h1 = sTime.Substring(0,1);
            h2 = sTime.Substring(1,1);
            m1 = sTime.Substring(2,1);
            m2 = sTime.Substring(3,1);
            s1 = sTime.Substring(4,1);
            s2 = sTime.Substring(5,1);

            userControl31.draw_something(h1);
            userControl32.draw_something(h2);
            userControl33.draw_something(m1);
            userControl34.draw_something(m2);
            userControl35.draw_something(s1);
            userControl36.draw_something(s2);
            userControl41.draw_something((int.Parse(s2) % 2).ToString());
            userControl42.draw_something((int.Parse(s2) % 2).ToString());

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
