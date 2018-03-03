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

namespace SquareGrid
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            foxDraw.StrokeColor(Colors.DarkSeaGreen);
            foxDraw.FillColor(Colors.Transparent);

            double side = canvas.Width / 2;
            double centerX = canvas.Width / 2;
            double centerY = canvas.Height / 2;

            DrawSquaresOnSquaresOnSquares(foxDraw, centerX, centerY, side);
        }

        public static void DrawSquaresOnSquaresOnSquares(FoxDraw foxDraw, double centerX, double centerY, double offset)
        {
            foxDraw.DrawRectangle(centerX - offset / 2, centerY - offset / 2, offset, offset);

            if (offset <= 50)
            {
                return;
            }
            else
            {
                DrawSquaresOnSquaresOnSquares(foxDraw, centerX - offset / 2, centerY - offset / 2, offset / 2);
                DrawSquaresOnSquaresOnSquares(foxDraw, centerX + offset / 2, centerY - offset / 2, offset / 2);
                DrawSquaresOnSquaresOnSquares(foxDraw, centerX + offset / 2, centerY + offset / 2, offset / 2);
                DrawSquaresOnSquaresOnSquares(foxDraw, centerX - offset / 2, centerY + offset / 2, offset / 2);
            }
        }
    }
}