using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_var24
{
    public partial class Form2 : Form
    {
        ITransport plane = null;

        public ITransport getPlane { get { return plane; } }

        public void DrawPlane()
        {
            if (plane != null)
            {
                Bitmap bmp = new Bitmap(pictureBoxPlane.Width, pictureBoxPlane.Height);
                Graphics gr = Graphics.FromImage(bmp);
                plane.setPosition(5, 0);
                plane.drawPlane(gr);
                pictureBoxPlane.Image = bmp;
            }
        }
        public delegate void myDel(ITransport e);

        private event myDel eventAddPlane;

        public void AddEvent(myDel ev)
        {
            if (eventAddPlane == null)
            {
                eventAddPlane = new myDel(ev);
            }
            else
            {
                eventAddPlane += ev;
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (eventAddPlane != null)
            {
                eventAddPlane(plane);
            }
            Close();
        }

        public Form2()
        {
            InitializeComponent();
            panelBlack.MouseDown += panelColor_MouseDown;
            panelYellow.MouseDown += panelColor_MouseDown;
            panelGray.MouseDown += panelColor_MouseDown;
            panelGreen.MouseDown += panelColor_MouseDown;
            panelRed.MouseDown += panelColor_MouseDown;
            panelWhite.MouseDown += panelColor_MouseDown;
            panelBlue.MouseDown += panelColor_MouseDown;
            panelOrange.MouseDown += panelColor_MouseDown;

            buttonCancel.Click += (object sender, EventArgs e) => { Close(); };
        }

        private void labelPlane_MouseDown(object sender, MouseEventArgs e)
        {
            labelPlane.DoDragDrop(labelPlane.Text,
                DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void labelLightPlane_MouseDown(object sender, MouseEventArgs e)
        {
            labelLightPlane.DoDragDrop(labelLightPlane.Text,
                DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void panelPlane_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "Plane":
                    plane = new Plane(7, 750, 1.50, 4100, Color.White, Color.Black);
                    break;
                case "LightPlane":
                    plane = new LightPlane(7, 750, 1.50, 4100, Color.White, true, true, Color.Black, Color.Red);
                    break;
            }
            DrawPlane();
        }

        private void panelPlane_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void labelBaseColor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void labelBaseColor_DragDrop(object sender, DragEventArgs e)
        {
            if (plane != null)
            {
                plane.setMainColor((Color)e.Data.GetData(typeof(Color)));
                DrawPlane();
            }
        }

        private void panelColor_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Control).DoDragDrop((sender as Control).BackColor,
                DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void labelDopColor_DragDrop(object sender, DragEventArgs e)
        {
            if (plane != null)
            {
                if (plane is LightPlane)
                {
                    (plane as LightPlane).setDopColor((Color)e.Data.GetData(typeof(Color)));
                    DrawPlane();
                }
            }
        }

        private void setDopColor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }


    }
}
