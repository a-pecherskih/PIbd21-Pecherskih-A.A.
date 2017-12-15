using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_var24
{
    class Plane : Vehicle
    {
        public override int MaxCountPassengers
        {
            get
            {
                return base.MaxCountPassengers;
            }
            protected set
            {
                if (value > 0 && value < 7)
                {
                    base.MaxCountPassengers = value;
                }
                else
                {
                    base.MaxCountPassengers = 5;
                }
            }
        }

        public override int MaxSpeed
        {
            get
            {
                return base.MaxSpeed;
            }
            protected set
            {
                if (value > 0 && value < 750)
                {
                    base.MaxSpeed = value;
                }
                else
                {
                    base.MaxSpeed = 630;
                }
            }
        }

        public override double MaxAltitude
        {
            get
            {
                return base.MaxAltitude;
            }
            protected set
            {
                if (value > 0 && value < 1.50)
                {
                    base.MaxAltitude = value;
                }
                else
                {
                    base.MaxAltitude = 1.20;
                }
            }
        }

        public Color DopColor { get; }

        public override double Weight
        {
            get
            {
                return base.Weight;
            }
            protected set
            {
                if (value > 1650 && value < 4100)
                {
                    base.Weight = value;
                }
                else
                {
                    base.Weight = 2500;
                }
            }
        }

        public Plane( int maxCountPassengers, int maxSpeed, double maxAltitude, double weight, Color color, Color dopcolor)
        {
            this.MaxCountPassengers = maxCountPassengers;
            this.MaxSpeed = maxSpeed;
            this.MaxAltitude = maxAltitude;
            this.ColorBody = color;
            this.DopColor = dopcolor;
            this.Weight = weight;
            this.countPassengers = 0;
            Random rand = new Random();
            startPosX = rand.Next(10, 200);
            startPosY = rand.Next(10, 200);
        }

        public override void drawPlane(Graphics g)
        {
            drawLightPlane(g);
        }

        public override void movePlane(Graphics g)
        {
            startPosX += 10;
            drawPlane(g);
        }

        protected virtual void drawLightPlane(Graphics g)
        {
            //границы машины
            Brush brDopColor = new SolidBrush(DopColor); // кисть красная
            Brush brColor = new SolidBrush(ColorBody); //переданный цвет
            Pen pen = new Pen(Color.Black);
            g.DrawEllipse(pen, startPosX + 69, startPosY + 44, 21, 16); // обводка переда
            g.FillEllipse(brColor, startPosX + 70, startPosY + 45, 20, 15); //перед
            g.DrawRectangle(pen, startPosX + 54, startPosY + 19, 16, 66); // обводка крыльев
            g.FillRectangle(brDopColor, startPosX + 55, startPosY + 20, 15, 65); //крылья 
            g.DrawRectangle(pen, startPosX-1, startPosY + 44, 81, 16); // обводка основы
            g.FillRectangle(brColor, startPosX, startPosY + 45, 80, 15); //основная линия  

            g.DrawRectangle(pen, startPosX - 1, startPosY + 34, 11, 36); // обводка зада
            g.FillRectangle(brDopColor, startPosX, startPosY + 35, 10, 35); //зад
        }
    }
}
