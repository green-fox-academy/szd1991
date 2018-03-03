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

namespace RecursiveSquares
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);

            double side = canvas.Width / 3;

            foxDraw.StrokeColor(Colors.Navy);
            foxDraw.FillColor(Colors.Gold);

            // foxDraw.DrawRectangle(0, 0, canvas.Width, canvas.Height);

            DrawFourBoxes(foxDraw, 0, 0, side);

        }

        public static void DrawFourBoxes(FoxDraw foxDraw, double startX, double startY, double offset)
        {
            foxDraw.DrawRectangle(startX + offset, startY, offset, offset);
            foxDraw.DrawRectangle(startX + 2 * offset, startY + offset, offset, offset);
            foxDraw.DrawRectangle(startX + offset, startY + 2 * offset, offset, offset);
            foxDraw.DrawRectangle(startX, startY + offset, offset, offset);
            
            if (offset <= 5)
            {
                return;
            }
            else
            {
                DrawFourBoxes(foxDraw, startX + offset, startY, offset / 3);
                DrawFourBoxes(foxDraw, startX + 2 * offset, startY + offset, offset / 3);
                DrawFourBoxes(foxDraw, startX + offset, startY + 2 * offset, offset / 3);
                DrawFourBoxes(foxDraw, startX, startY + offset, offset / 3);
            }
        }
    }
}
