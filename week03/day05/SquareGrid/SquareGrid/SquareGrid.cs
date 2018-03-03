/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GreenFox;
namespace SquareGrid
{
    class SquareGrid
    {
        private double offset;
        private double centerX;
        private double centerY;
        public SquareGrid(double offset, double centerX, double centerY)
        {
            this.offset = offset;
            this.centerX = centerX;
            this.centerY = centerY;
        }
        public void DrawSquaresOnSquaresOnSquares(FoxDraw foxDraw)
        {
            foxDraw.DrawRectangle(centerX - offset / 2, centerY - offset / 2, offset, offset);
            foxDraw.DrawRectangle(centerX - offset / 2, centerY - offset / 2, offset / 2, offset / 2);
            foxDraw.DrawRectangle(centerX + offset / 2, centerY - offset / 2, offset / 2, offset / 2);
            foxDraw.DrawRectangle(centerX + offset / 2, centerY + offset / 2, offset / 2, offset / 2);
            foxDraw.DrawRectangle(centerX - offset / 2, centerY + offset / 2, offset / 2, offset / 2);
            if (offset <= 50)
            {
                return;
            }
            else
            {
                DrawSquaresOnSquaresOnSquares(foxDraw);
            }
        }
    }
}
*/