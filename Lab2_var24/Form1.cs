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
    public partial class Form1 : Form
    {
        Airfield airfield;
        public Form1()
        {
            InitializeComponent();
            airfield = new Airfield();
            Draw();
        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxAirfield.Width, pictureBoxAirfield.Height);
            Graphics gr = Graphics.FromImage(bmp);
            airfield.Draw(gr, pictureBoxAirfield.Width, pictureBoxAirfield.Height);
            pictureBoxAirfield.Image = bmp;
        }

        private void buttonSetPlane_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    var plane = new Plane(7, 750, 1.50, 4100, dialog.Color, dialogDop.Color);
                    int place = airfield.PutPlaneInAirfield(plane);
                    Draw();
                    MessageBox.Show("Ваше место: " + place);
                }
            }
        }

        private void buttonSetLightPlane_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    ColorDialog dialogDop2 = new ColorDialog();
                    if (dialogDop.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        var plane = new LightPlane(7, 750, 1.50, 4100, dialog.Color, true, true, dialogDop.Color, dialogDop2.Color);
                        int place = airfield.PutPlaneInAirfield(plane);
                        Draw();
                        MessageBox.Show("Ваше место: " + place);
                    }
                }
            }
        }

        private void buttonTakePlane_Click(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text != "")
            {
                var plane = airfield.GetPlaneFromAirfield(Convert.ToInt32(maskedTextBox1.Text));

                Bitmap bmp = new Bitmap(pictureBoxTakePlane.Width, pictureBoxTakePlane.Height);
                Graphics gr = Graphics.FromImage(bmp);
                plane.setPosition(5, 5);
                plane.drawPlane(gr);
                pictureBoxTakePlane.Image = bmp;
                Draw();
            }
        }
    }
}
