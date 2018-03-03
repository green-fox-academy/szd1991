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
using GreenFox;

namespace SierpinskyCarpet
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);

            double startX = canvas.Width / 3;
            double startY = canvas.Height / 3;
            double startSide = canvas.Width / 3;

            foxDraw.StrokeColor(Colors.White);
            foxDraw.FillColor(Colors.Crimson);

            DrawSierpinskyCarpet(foxDraw, startX, startY, startSide);
        }

        public static void DrawSierpinskyCarpet(FoxDraw foxDraw, double startX, double startY, double offset)
        {
            foxDraw.DrawRectangle(startX, startY, offset, offset);

            if (offset <= 5)
            {
                return;
            }
            else
            {
                DrawSierpinskyCarpet(foxDraw, startX - offset + offset / 3, startY - offset + offset / 3, offset / 3);
                DrawSierpinskyCarpet(foxDraw, startX + offset / 3, startY - offset + offset / 3, offset / 3);
                DrawSierpinskyCarpet(foxDraw, startX + offset + offset / 3, startY - offset + offset / 3, offset / 3);
                DrawSierpinskyCarpet(foxDraw, startX - offset + offset / 3, startY + offset / 3, offset / 3);
                DrawSierpinskyCarpet(foxDraw, startX + offset + offset / 3, startY + offset / 3, offset / 3);
                DrawSierpinskyCarpet(foxDraw, startX - offset + offset / 3, startY + offset + offset / 3, offset / 3);
                DrawSierpinskyCarpet(foxDraw, startX + offset / 3, startY + offset + offset / 3, offset / 3);
                DrawSierpinskyCarpet(foxDraw, startX + offset + offset / 3, startY + offset + offset / 3, offset / 3);
            }
        }
    }
}
