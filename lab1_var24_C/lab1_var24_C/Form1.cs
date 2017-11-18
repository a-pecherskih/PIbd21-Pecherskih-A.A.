using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1_var24_C
{
    public partial class Form1 : Form
    {
        private Potato[] potatos;

        private Salt salt;

        private WaterTap waterTap;

        private Knife knife;

        private Pan pan;

        private Stove stove;

        private Dish dish;

        private Oil oil;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            waterTap = new WaterTap();
            knife = new Knife();
            pan = new Pan();
            stove = new Stove();
            dish = new Dish();
            oil = new Oil();
        }    

        private void radioButtonOpen_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonOpen.Checked)
            {
                waterTap.State = true;
            }
        }

        private void radioButtonClose_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonClose.Checked)
            {
                waterTap.State = false;
            }
        }

        private void checkBoxHaveOil_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxHaveOil.Checked)
            {
                oil.State = checkBoxHaveOil.Checked;
            }
        }

        private void buttonWash_Click(object sender, EventArgs e)
        {
            if (numericUpDownPotatos.Value > 0)
            {
                if (!waterTap.State)
                {
                    MessageBox.Show("Кран закрыт, как мыть?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                potatos = new Potato[Convert.ToInt32(numericUpDownPotatos.Value)];
                pan.Init(Convert.ToInt32(numericUpDownPotatos.Value));
                for (int i = 0; i < potatos.Length; ++i)
                {
                    potatos[i] = new Potato();
                }
                for (int i = 0; i < potatos.Length; ++i)
                {
                    waterTap.Wash(potatos[i]);
                    //potatos[i].Dirty = 0;
                }
                numericUpDownPotatos.Enabled = false;
                radioButtonClose.Checked = true;
                buttonClearPotatos.Enabled = true;
                buttonSlicePotatos.Enabled = true;
                MessageBox.Show("Картошку помыли, нужно теперь почистить", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Картошки то нет, что мыть?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonClearPotatos_Click(object sender, EventArgs e)
        {
            if (numericUpDownPotatos.Value == 0)
            {
                if (potatos == null)
                {
                    MessageBox.Show("Картошки нет, что чистить?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            if (potatos == null)
            {
                MessageBox.Show("Картошку нужно помыть", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            for (int i = 0; i < potatos.Length; ++i)
            {
                knife.Clean(potatos[i]);
            }
            MessageBox.Show("Картошку почистили", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void buttonSlicePotatos_Click_1(object sender, EventArgs e)
        {
            if (numericUpDownPotatos.Value == 0)
            {
                if (potatos == null)
                {
                    MessageBox.Show("Картошки нет, что чистить?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
               if (potatos == null)
            {
                MessageBox.Show("Картошку нужно помыть", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            for (int i = 0; i < potatos.Length; ++i)
            {
                if (potatos[i].Have_skin)
                {
                    {
                        MessageBox.Show("Картошку бы почистить сначала", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

            }

            for (int i = 0; i < potatos.Length; ++i)
            {
                {
                    knife.Slice(potatos[i]);
                }
            }
            MessageBox.Show("Картошка готова к приготовлению!", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonAddPan_Click(object sender, EventArgs e)
        {          
            stove.Pan = pan;
            buttonAddOil.Enabled = true;
            MessageBox.Show("Кастрюлька на плите", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonAddOil_Click(object sender, EventArgs e)
        {
            if (!oil.State)
            {
                MessageBox.Show("Масла та нет, что добавлять?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            pan.InitOil();
            for (int i = 0; i < 3; ++i)
            {
                pan.AddOil(oil.GetOil());
            }
            buttonCook.Enabled = true;
            radioButtonClose.Checked = true;
            checkBoxHaveOil.Enabled = false;
            MessageBox.Show("Масло залили", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            stove.State = checkBox1.Checked;
        }

        private void buttonCook_Click(object sender, EventArgs e)
        {
            if (!stove.State)
            {
                MessageBox.Show("Может стоит плиту включить?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (oil.State)
            {
                stove.Cook();
                MessageBox.Show("Масло накалилось, можно добавлять картошку", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Information);
                buttonAddPotatos.Enabled = true;
                return;
            }

            else
            {
                MessageBox.Show("Что-то пошло не так, картошка не сварилась", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void buttonAddPotatos_Click(object sender, EventArgs e)
        {
            if (numericUpDownPotatos.Value == 0)
            {
                if (potatos == null)
                {
                    MessageBox.Show("Картошки то нет, что варить собрались?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else if (potatos == null)
            {
                MessageBox.Show("Картошку нужно помыть", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (potatos[0].Have_skin)
            {
                MessageBox.Show("Картошку нужно почистить ", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (potatos[0].Have_parts < 10)
            {
                MessageBox.Show("Картошку нужно нарезать", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            for (int i = 0; i < potatos.Length; ++i)
            {
                pan.AddPotato(potatos[i]);
            }
            buttonCookPotatos.Enabled = true;
            MessageBox.Show("Картошку добавили, можно готовить (Не забудьте, что готовится картошка очень быстро!)", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonCookPotatos_Click(object sender, EventArgs e)
        {
            if (!pan.ReadyToGo)
            {
                MessageBox.Show("У нас не все готово к варке!", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            stove.Cook();
            if (stove.Pan.IsReady())
            {
                checkBox1.Checked = false;
                buttonGetPotatos.Enabled = true;
                MessageBox.Show("Пожарилась", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Что-то пошло не так, картошка не пожарилась", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void buttonGetPotatos_Click(object sender, EventArgs e)
        {
            potatos = pan.GetPotatos();
            dish.Init(potatos.Length);
            buttonPutPotatos.Enabled = true;
            MessageBox.Show("Выкладываем вкусные чипсы на тарелку", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonPutPotatos_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < potatos.Length; ++i)
            {
                dish.AddPotato(potatos[i]);
            }
            buttonAddSalt.Enabled = true;
            MessageBox.Show("Домашние чипсы готовы! Соль добавить по вкусу", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonAddSalt_Click(object sender, EventArgs e)
        {
            salt = new Salt();
            salt.Count = Convert.ToInt32(numericUpDownSalt.Value);
            if (salt.Count > 0)
            {
                dish.AddSalt(salt);
                MessageBox.Show("Соль добавлена", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Соли же нет, что добавлять?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
