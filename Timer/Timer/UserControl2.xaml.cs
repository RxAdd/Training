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
    /// UserControl2.xaml 的互動邏輯
    /// </summary>
    public partial class UserControl2 : UserControl
    {
        public UserControl2()
        {
            InitializeComponent();
        }

        public void clean_something()
        {
            BrushConverter bc = new BrushConverter();
            Brush brush = (Brush)bc.ConvertFrom("White");
            Rec1.Fill = brush;
            Rec2.Fill = brush;
            Rec3.Fill = brush;
            Rec4.Fill = brush;
            Rec5.Fill = brush;
            Rec6.Fill = brush;
            Rec7.Fill = brush;
        }
        public void draw_something(string str)
        {
            BrushConverter bc = new BrushConverter();
            Brush brush = (Brush)bc.ConvertFrom("Black");

            clean_something();
            string[] Position = str.Split(',');

            for (int i = 0; i < Position.Count(); i++)
            {
                switch (Position[i])
                {

                    case "0":
                        Rec1.Fill = brush;
                        Rec2.Fill = brush;
                        Rec4.Fill = brush;
                        Rec5.Fill = brush;
                        Rec6.Fill = brush;
                        Rec7.Fill = brush;
                        break;
                    case "1":
                        Rec2.Fill = brush;
                        Rec4.Fill = brush;
                        break;

                    case "2":
                        Rec1.Fill = brush;
                        Rec2.Fill = brush;
                        Rec3.Fill = brush;
                        Rec6.Fill = brush;
                        Rec5.Fill = brush;
                        break;

                    case "3":
                        Rec1.Fill = brush;
                        Rec2.Fill = brush;
                        Rec3.Fill = brush;
                        Rec4.Fill = brush;
                        Rec5.Fill = brush;
                        break;

                    case "4":
                        Rec7.Fill = brush;
                        Rec3.Fill = brush;
                        Rec2.Fill = brush;
                        Rec4.Fill = brush;
                        break;

                    case "5":
                        Rec1.Fill = brush;
                        Rec7.Fill = brush;
                        Rec3.Fill = brush;
                        Rec4.Fill = brush;
                        Rec5.Fill = brush;
                        break;

                    case "6":
                        Rec1.Fill = brush;
                        Rec7.Fill = brush;
                        Rec6.Fill = brush;
                        Rec5.Fill = brush;
                        Rec4.Fill = brush;
                        Rec3.Fill = brush;
                        break;
                    case "7":
                        Rec7.Fill = brush;
                        Rec1.Fill = brush;
                        Rec2.Fill = brush;
                        Rec4.Fill = brush;
                        break;
                    case "8":
                        Rec1.Fill = brush;
                        Rec2.Fill = brush;
                        Rec3.Fill = brush;
                        Rec4.Fill = brush;
                        Rec5.Fill = brush;
                        Rec6.Fill = brush;
                        Rec7.Fill = brush;

                        break;
                    case "9":
                        Rec1.Fill = brush;
                        Rec2.Fill = brush;
                        Rec3.Fill = brush;
                        Rec4.Fill = brush;
                        Rec7.Fill = brush;
                        break;

                }




            }
        }
    }
}
