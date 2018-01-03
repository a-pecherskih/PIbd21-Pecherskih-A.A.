using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
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
            int i = 0;
            foreach (var plane in airfield[currentLevel])
            {
                plane.setPosition(5 + i / 5 * placeSizeWidth + 5, i % 5 * placeSizeHeight + 15 - 30);
                plane.drawPlane(g);
                i++;
            }
        }

        public void Sort()
        {
            airfield.Sort();
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

        public bool SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            using (FileStream fs = new FileStream(filename, FileMode.Create))
            {
                using (BufferedStream bs = new BufferedStream(fs))
                {
                    //Запись кол-ва уровней
                    byte[] info = new UTF8Encoding(true).GetBytes("CountLeveles:" +
                        airfield.Count + Environment.NewLine);
                    fs.Write(info, 0, info.Length);
                    foreach (var level in airfield)
                    {
                        //Начинаем уровень
                        info = new UTF8Encoding(true).GetBytes("Level" + Environment.NewLine);
                        fs.Write(info, 0, info.Length);
                        for (int i = 0; i < countPlaces; i++)
                        {
                            var plane = level[i];
                            if (plane != null)
                            {//Если место не пустое, записываем тип самолета
                                if (plane.GetType().Name == "Plane")
                                {
                                    info = new UTF8Encoding(true).GetBytes("Plane:");
                                    fs.Write(info, 0, info.Length);
                                }
                                if (plane.GetType().Name == "LightPlane")
                                {
                                    info = new UTF8Encoding(true).GetBytes("LightPlane:");
                                    fs.Write(info, 0, info.Length);
                                }
                                //Запись параметров
                                info = new UTF8Encoding(true).GetBytes(plane.getInfo() + Environment.NewLine);
                                fs.Write(info, 0, info.Length);
                            }
                        }
                    }
                }
            }
            return true;
        }

        public bool LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                return false;
            }
            using (FileStream fs = new FileStream(filename, FileMode.Open))
            {
                string s = "";
                using (BufferedStream bs = new BufferedStream(fs))
                {
                    byte[] b = new byte[fs.Length];
                    UTF8Encoding temp = new UTF8Encoding(true);
                    while (bs.Read(b, 0, b.Length) > 0)
                    {
                        s += temp.GetString(b);
                    }
                }
                s = s.Replace("\r", "");
                var strs = s.Split('\n');
                if (strs[0].Contains("CountLeveles"))
                {//Считываем количество уровней
                    int count = Convert.ToInt32(strs[0].Split(':')[1]);
                    if (airfield != null)
                    {
                        airfield.Clear();
                    }
                    airfield = new List<ClassArray<ITransport>>(count);
                }
                else
                {
                    return false;
                }
                int counter = -1;
                for (int i = 1; i < strs.Length; ++i)
                {//шагаем по считанным записям
                    if (strs[i] == "Level")
                    {//начинаем новый уровень
                        counter++;
                        airfield.Add(new ClassArray<ITransport>(countPlaces, null));
                    }
                    else if (strs[i].Split(':')[0] == "Plane")
                    {
                        ITransport plane = new Plane(strs[i].Split(':')[1]);
                        int number = airfield[counter] + plane;
                        if (number == -1)
                        {
                            return false;
                        }
                    }
                    else if (strs[i].Split(':')[0] == "LightPlane")
                    {
                        ITransport plane = new LightPlane(strs[i].Split(':')[1]);
                        int number = airfield[counter] + plane;
                        if (number == -1)
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }
    }
}
