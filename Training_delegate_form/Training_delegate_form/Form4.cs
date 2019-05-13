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


    public partial class Form4 : Form
    {
        public  Form4()
        {

            InitializeComponent();
        }
        public delegate void GetPosition(int top ,int left);
        public event GetPosition getpos;

        private void Form4_Move(object sender, EventArgs e)
        {
            getpos(this.Left, this.Top);
        }

        private void Form4_Load(object sender, EventArgs e)
        {


        }

        private void F3_follow_position(int top, int left)
        {
            this.Location = new Point(left, top);
        }
    }



   
}
