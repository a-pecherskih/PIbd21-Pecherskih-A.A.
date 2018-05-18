using NLog;
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
        Form2 form;
        private Logger log;
        public Form1()
        {
            InitializeComponent();
            log = LogManager.GetCurrentClassLogger();
            airfield = new Airfield(5);

            for (int i = 1; i < 6; i++)
            {
                listBoxLevels.Items.Add("Уровень " + i);
            }
            listBoxLevels.SelectedIndex = airfield.getCurrentLevel;
            Draw();
        }

        private void Draw()
        {
            if (listBoxLevels.SelectedIndex >= 0)
            {
                Bitmap bmp = new Bitmap(pictureBoxAirfield.Width, pictureBoxAirfield.Height);
                Graphics gr = Graphics.FromImage(bmp);
                airfield.Draw(gr);
                pictureBoxAirfield.Image = bmp;
            }
        }

        private void buttonDowm_Click(object sender, EventArgs e)
        {
            airfield.LevelDown();
            listBoxLevels.SelectedIndex = airfield.getCurrentLevel;
            log.Info("Переходим на уровень ниже. Текущий уровень: " + airfield.getCurrentLevel);
            Draw();
        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            airfield.LevelUp();
            listBoxLevels.SelectedIndex = airfield.getCurrentLevel;
            log.Info("Переходим на уровень выше. Текущий уровень: " + airfield.getCurrentLevel);
            Draw();
        }

        private void buttonSetPlane_Click(object sender, EventArgs e)
        {
            form = new Form2();
            form.AddEvent(AddPlane);
            form.Show();
        }

        private void AddPlane(ITransport plane)
        {
            if (plane != null)
            {
                try
                {
                    int place = airfield.PutPlaneInAirfield(plane);
                    Draw();
                    MessageBox.Show("Ваше место: " + place);
                    log.Info("Отрисовываем самолет на месте: " + place);
                }
                catch (AirfieldOverflowException ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка переполнения",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Общая ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (listBoxLevels.SelectedIndex > -1)
            {//Прежде чем забрать машину, надо выбрать с какого уровня будем забирать
                string level = listBoxLevels.Items[listBoxLevels.SelectedIndex].ToString();
                if (maskedTextBox1.Text != "")
                {
                    ITransport plane = airfield.GetPlaneFromAirfield(Convert.ToInt32(maskedTextBox1.Text));

                    Bitmap bmp = new Bitmap(pictureBoxTakePlane.Width, pictureBoxTakePlane.Height);
                    Graphics gr = Graphics.FromImage(bmp);
                    plane.setPosition(5, -10);
                    plane.drawPlane(gr);
                    pictureBoxTakePlane.Image = bmp;
                    Draw();
                }
                else
                {
                    MessageBox.Show("Извините, на этом месте нет машины");
                }
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (airfield.SaveData(saveFileDialog1.FileName))
                {
                    MessageBox.Show("Сохранение прошло успешно", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Не сохранилось", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (airfield.LoadData(openFileDialog1.FileName))
                {
                    MessageBox.Show("Загрузили", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Не загрузили", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Draw();

            }
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            airfield.Sort();
        }
    }
}
