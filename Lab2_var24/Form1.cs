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
        Color color;
        Color dopColor;
        Color dopColor2;
        int maxSpeed;
        double maxAltitude;
        int maxCountPass;
        int weight;

        private ITransport inter;
        public Form1()
        {
            InitializeComponent();
            color = Color.White;
            dopColor = Color.Yellow;
            maxSpeed = 750; 
            maxAltitude = 1.50;
            maxCountPass = 7;
            weight = 4100;
            buttonSelectColor.BackColor = color;
            buttonSelectDopColor.BackColor = dopColor;
            buttonSelectDopColor2.BackColor = dopColor2;

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonSelectColor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                color = cd.Color;
                buttonSelectColor.BackColor = color;
            }
        }

        private void buttonSelectDopColor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                dopColor = cd.Color;
                buttonSelectDopColor.BackColor = dopColor;
            }
        }

        private void buttonSelectDopColor2_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                dopColor2 = cd.Color;
                buttonSelectDopColor2.BackColor = dopColor2;
            }
        }

        private bool checkFields()
        {
            if (!int.TryParse(textBoxMaxSpeed.Text, out maxSpeed))
            {
                return false;
            }
            if(!double.TryParse(textBoxMaxAltitude.Text, out maxAltitude))
            {
                return false;
            }
            if (!int.TryParse(textBoxMaxCountPassenget.Text, out maxCountPass))
            {
                return false;
            }
            if (!int.TryParse(textBoxWeight.Text, out weight))
            {
                return false;
            }
            return true;
        }

        private void buttonSetPlane_Click(object sender, EventArgs e)
        {
            if (checkFields())
            {
                inter = new Plane(maxCountPass, maxSpeed, maxAltitude, weight, color, dopColor);
                Bitmap bmp = new Bitmap(pictureBoxDraw.Width, pictureBoxDraw.Height);
                Graphics gr = Graphics.FromImage(bmp);
                inter.drawPlane(gr);
                pictureBoxDraw.Image = bmp;
            }
        }

        private void buttonSetLightPlane_Click(object sender, EventArgs e)
        {
            if (checkFields())
            {
                inter = new LightPlane(maxCountPass, maxSpeed, maxAltitude, weight, color, checkBoxWings.Checked, checkBoxScrew.Checked, dopColor, dopColor2);
                Bitmap bmp = new Bitmap(pictureBoxDraw.Width, pictureBoxDraw.Height);
                Graphics gr = Graphics.FromImage(bmp);
                inter.drawPlane(gr);
                pictureBoxDraw.Image = bmp;
            }

        }

        private void buttonMove_Click_1(object sender, EventArgs e)
        {
            if (inter != null)
            {
                Bitmap bmp = new Bitmap(pictureBoxDraw.Width, pictureBoxDraw.Height);
                Graphics gr = Graphics.FromImage(bmp);
                inter.movePlane(gr);
                pictureBoxDraw.Image = bmp;
            }
        }

        
    }
}
