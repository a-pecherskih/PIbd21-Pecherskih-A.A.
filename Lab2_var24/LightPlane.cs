using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_var24
{
    class LightPlane : Plane
    {
        private bool wings;

        private bool screw;

        private Color dopColor2;

        public LightPlane(int MaxCountPassengers, int MaxSpeed, double MaxAltitude, double weight, Color color,
            bool wings, bool screw, Color dopColor, Color dopColor2) :
            base(MaxCountPassengers, MaxSpeed, MaxAltitude, weight, color, dopColor)
        {
            this.wings = wings;
            this.screw = screw;
            this.dopColor2 = dopColor2;
        }

        protected override void drawLightPlane(Graphics g)
        {
            if (wings)
            {
                Pen pen = new Pen(Color.Black);
                Brush wings = new SolidBrush(dopColor2);
                g.DrawRectangle(pen, startPosX + 89, startPosY + 42, 4, 19); // обводка винта
                g.FillRectangle(wings, startPosX + 90, startPosY + 43, 3, 18); //винт
            }
            if (screw)
            {
                Pen pen = new Pen(Color.Black);
                Brush screw = new SolidBrush(dopColor2);
                g.DrawRectangle(pen, startPosX + 44, startPosY + 21, 11, 62); // обводка крыльев
                g.FillRectangle(screw, startPosX + 45, startPosY + 22, 10, 61); //крылья 
            }
            base.drawLightPlane(g);
            Brush br = new SolidBrush(dopColor2);
            Pen pen2 = new Pen(Color.Black);
            g.FillRectangle(br, startPosX + 60, startPosY + 50, 10, 5);           
            g.DrawRectangle(pen2, startPosX + 59, startPosY + 49, 11, 6);
        }
    }
}
