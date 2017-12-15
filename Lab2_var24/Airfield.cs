using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_var24
{
    class Airfield
    {
        List<ClassArray<ITransport>> airfield;

        int countPlaces = 20;

        int placeSizeWidth = 210;

        int placeSizeHeight = 80;

        int currentLevel;

        public int getCurrentLevel { get { return currentLevel; } }

        public Airfield(int countStages)
        {

            airfield = new List<ClassArray<ITransport>>();
            ClassArray<ITransport> pln;

            for (int i = 0; i < countStages; i++)
            {
                pln = new ClassArray<ITransport>(20, null);
                airfield.Add(pln);
            }
        }

        public void LevelUp()
        {
            if (currentLevel + 1 < airfield.Count)
            {
                currentLevel++;
            }
        }

        public void LevelDown()
        {
            if (currentLevel > 0)
            {
                currentLevel--;
            }
        }

        public int PutPlaneInAirfield(ITransport plane)
        {
            return airfield[currentLevel] + plane;
        }

        public ITransport GetPlaneFromAirfield(int ticket)
        {
            return airfield[currentLevel] - ticket;
        }

        public void Draw(Graphics g)
        {
            DrawMarking(g);
            for (int i = 0; i < countPlaces; i++)
            {
                var plane = airfield[currentLevel][i];
                if (plane != null)
                {
                    plane.setPosition(5 + i / 5 * placeSizeWidth + 5 + 5, i % 5 * placeSizeHeight + 15 - 30);
                    plane.drawPlane(g);
                }
            }
        }

        private void DrawMarking(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 3);

            //границы парковки
            g.DrawString("L" + (currentLevel + 1), new Font("Arial", 30), new SolidBrush(Color.Blue),
                (countPlaces / 5) * placeSizeWidth - 70, 420);
            g.DrawRectangle(pen, 0, 0, (countPlaces / 5) * placeSizeWidth, 480);

            for (int i = 0; i < countPlaces / 5; i++)
            { //отрисовка по 5 мест на линии
                for (int j = 0; j < 6; ++j)
                {//линия разметки места
                    g.DrawLine(pen, i * placeSizeWidth, j * placeSizeHeight, i * placeSizeWidth + 100, j * placeSizeHeight);
                    if (j < 5)
                    {
                        g.DrawString((i * 5 + j + 1).ToString(), new Font("Arial", 30),
                            new SolidBrush(Color.Blue), i * placeSizeWidth + 30, j * placeSizeHeight + 20);
                    }
                }
                g.DrawLine(pen, i * placeSizeWidth, 0, i * placeSizeWidth, 400);
            }
        }
    }
}
