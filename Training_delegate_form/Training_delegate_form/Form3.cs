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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        Dictionary<string, string> MyDic = new Dictionary<string, string>();

        Form4 f4 = new Form4();
        private void button1_Click(object sender, EventArgs e)
        {
           
            f4 = new Form4();
            //MyDic.Add(f4.,"123");
            
            this.AddOwnedForm(f4);
            f4.Show();
            f4.getpos += F4_getpos;


            //foreach (Form f in this.OwnedForms)
            //{
            //    MessageBox.Show(f.Name);
            //}
        }

        private void F4_getpos(int top, int left)
        {
            label1.Text = string.Format("{0},{1}", left, top);
        }

        private void Form3_Move(object sender, EventArgs e)
        {
            int i = 1;
            double angle = 0;
            //f4.Location = new Point(this.Top + this.Width, this.Left +this.Height);
            //f4.Location = new Point(this.Top + this.Height, this.Left +this.Width);
            //f4.Location = new Point(this.Left + this.Width, this.Top );
             
            foreach (Form f in this.OwnedForms)
            {
                angle = 360 / this.OwnedForms.Count();
                double X = this.Left;
                double Y = this.Top;
                double Radius = 500;
                double NEW_X = 0;
                double NEW_Y = 0;
                angle *= i;
                NEW_X = X + Radius * Math.Cos(angle * 3.14 / 180);
                NEW_Y = Y + Radius * Math.Sin(angle * 3.14 / 180);
                
             
                f.Location = new Point((int)NEW_X, (int)NEW_Y);
               


                //switch (i)
                //{
                //    case 1:
                //        f.Location = new Point(this.Left + this.Width , this.Top);  //右
                //        break;
                //    case 2:
                //        f.Location = new Point(this.Left, this.Top + this.Height );  //下
                //        break;
                //    case 3:
                //        f.Location = new Point(this.Left + -1*(f.Width ), this.Top);  //左
                //        break;
                //    case 4:
                //        f.Location = new Point(this.Left , this.Top + f.Height *-1);  //上
                //        break;

                //}

                i++;
            }
        }
    }
}
