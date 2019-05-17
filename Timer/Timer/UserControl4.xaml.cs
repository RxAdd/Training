using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Timer
{
    /// <summary>
    /// UserControl4.xaml 的互動邏輯
    /// </summary>
    public partial class UserControl4 : UserControl
    {
        public UserControl4()
        {
            InitializeComponent();
        }

        public void clean_something()
        {


        }
        public void draw_something(string str)
        {
            BrushConverter bc = new BrushConverter();
            Brush brush = (Brush)bc.ConvertFrom("Black");
            Brush brushw = (Brush)bc.ConvertFrom("White");
            if (str.Equals("0"))
            {
                comma1.Fill = brush;
                comma2.Fill = brush;
            }
            else
            {
                comma1.Fill = brushw;
                comma2.Fill = brushw;
            }

        }
    }
}
