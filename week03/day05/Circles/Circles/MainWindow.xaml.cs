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

namespace Circles
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            foxDraw.StrokeColor(Colors.Aqua);
            foxDraw.FillColor(Colors.Transparent);

            double radius = canvas.Width;
            double centerX = radius / 2;
            double centerY = radius / 2;

            DrawOfTheRings(foxDraw, centerX, centerY, radius);
        }

        public static void DrawOfTheRings(FoxDraw foxDraw, double origoX, double origoY, double offset)
        {
            foxDraw.DrawEllipse(origoX - offset / 2, origoY - offset / 2, offset, offset);

            if (offset <= 50)
            {
                return;
            }
            else
            {
                DrawOfTheRings(foxDraw, origoX, origoY - offset / 3, offset / 3);
                DrawOfTheRings(foxDraw, origoX - offset / 3, origoY + offset / 3, offset / 3);
                DrawOfTheRings(foxDraw, origoX + offset / 3, origoY + offset / 3, offset / 3);
            }
        }
    }
}
