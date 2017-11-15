namespace lab1_var24_C
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxHaveOil = new System.Windows.Forms.CheckBox();
            this.numericUpDownSalt = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownPotatos = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonWash = new System.Windows.Forms.Button();
            this.radioButtonClose = new System.Windows.Forms.RadioButton();
            this.radioButtonOpen = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonSlicePotatos = new System.Windows.Forms.Button();
            this.buttonClearPotatos = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonCookPotatos = new System.Windows.Forms.Button();
            this.buttonCook = new System.Windows.Forms.Button();
            this.buttonAddPan = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.buttonGetPotatos = new System.Windows.Forms.Button();
            this.buttonAddPotatos = new System.Windows.Forms.Button();
            this.buttonAddOil = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.buttonAddSalt = new System.Windows.Forms.Button();
            this.buttonPutPotatos = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSalt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPotatos)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxHaveOil);
            this.groupBox1.Controls.Add(this.numericUpDownSalt);
            this.groupBox1.Controls.Add(this.numericUpDownPotatos);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(40, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 173);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ингредиенты";
            // 
            // checkBoxHaveOil
            // 
            this.checkBoxHaveOil.AutoSize = true;
            this.checkBoxHaveOil.Location = new System.Drawing.Point(82, 110);
            this.checkBoxHaveOil.Name = "checkBoxHaveOil";
            this.checkBoxHaveOil.Size = new System.Drawing.Size(50, 17);
            this.checkBoxHaveOil.TabIndex = 5;
            this.checkBoxHaveOil.Text = "Есть";
            this.checkBoxHaveOil.UseVisualStyleBackColor = true;
            this.checkBoxHaveOil.CheckedChanged += new System.EventHandler(this.checkBoxHaveOil_CheckedChanged);
            // 
            // numericUpDownSalt
            // 
            this.numericUpDownSalt.Location = new System.Drawing.Point(82, 59);
            this.numericUpDownSalt.Name = "numericUpDownSalt";
            this.numericUpDownSalt.Size = new System.Drawing.Size(99, 20);
            this.numericUpDownSalt.TabIndex = 4;
            // 
            // numericUpDownPotatos
            // 
            this.numericUpDownPotatos.Location = new System.Drawing.Point(82, 33);
            this.numericUpDownPotatos.Name = "numericUpDownPotatos";
            this.numericUpDownPotatos.Size = new System.Drawing.Size(99, 20);
            this.numericUpDownPotatos.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Масло";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Соль";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Картошка";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonWash);
            this.groupBox2.Controls.Add(this.radioButtonClose);
            this.groupBox2.Controls.Add(this.radioButtonOpen);
            this.groupBox2.Location = new System.Drawing.Point(313, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(240, 173);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Кран";
            // 
            // buttonWash
            // 
            this.buttonWash.Location = new System.Drawing.Point(127, 46);
            this.buttonWash.Name = "buttonWash";
            this.buttonWash.Size = new System.Drawing.Size(92, 53);
            this.buttonWash.TabIndex = 2;
            this.buttonWash.Text = "Помыть картошку";
            this.buttonWash.UseVisualStyleBackColor = true;
            this.buttonWash.Click += new System.EventHandler(this.buttonWash_Click);
            // 
            // radioButtonClose
            // 
            this.radioButtonClose.AutoSize = true;
            this.radioButtonClose.Checked = true;
            this.radioButtonClose.Location = new System.Drawing.Point(18, 83);
            this.radioButtonClose.Name = "radioButtonClose";
            this.radioButtonClose.Size = new System.Drawing.Size(69, 17);
            this.radioButtonClose.TabIndex = 1;
            this.radioButtonClose.TabStop = true;
            this.radioButtonClose.Text = "Закрыть";
            this.radioButtonClose.UseVisualStyleBackColor = true;
            this.radioButtonClose.CheckedChanged += new System.EventHandler(this.radioButtonClose_CheckedChanged);
            // 
            // radioButtonOpen
            // 
            this.radioButtonOpen.AutoSize = true;
            this.radioButtonOpen.Location = new System.Drawing.Point(18, 46);
            this.radioButtonOpen.Name = "radioButtonOpen";
            this.radioButtonOpen.Size = new System.Drawing.Size(69, 17);
            this.radioButtonOpen.TabIndex = 0;
            this.radioButtonOpen.TabStop = true;
            this.radioButtonOpen.Text = "Открыть";
            this.radioButtonOpen.UseVisualStyleBackColor = true;
            this.radioButtonOpen.CheckedChanged += new System.EventHandler(this.radioButtonOpen_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonSlicePotatos);
            this.groupBox3.Controls.Add(this.buttonClearPotatos);
            this.groupBox3.Location = new System.Drawing.Point(569, 22);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(240, 173);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Нож";
            // 
            // buttonSlicePotatos
            // 
            this.buttonSlicePotatos.Location = new System.Drawing.Point(37, 84);
            this.buttonSlicePotatos.Name = "buttonSlicePotatos";
            this.buttonSlicePotatos.Size = new System.Drawing.Size(157, 50);
            this.buttonSlicePotatos.TabIndex = 1;
            this.buttonSlicePotatos.Text = "Нарезать картошку";
            this.buttonSlicePotatos.UseVisualStyleBackColor = true;
            this.buttonSlicePotatos.Click += new System.EventHandler(this.buttonSlicePotatos_Click_1);
            // 
            // buttonClearPotatos
            // 
            this.buttonClearPotatos.Location = new System.Drawing.Point(37, 28);
            this.buttonClearPotatos.Name = "buttonClearPotatos";
            this.buttonClearPotatos.Size = new System.Drawing.Size(157, 50);
            this.buttonClearPotatos.TabIndex = 0;
            this.buttonClearPotatos.Text = "Почистить картошку";
            this.buttonClearPotatos.UseVisualStyleBackColor = true;
            this.buttonClearPotatos.Click += new System.EventHandler(this.buttonClearPotatos_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buttonCookPotatos);
            this.groupBox4.Controls.Add(this.buttonCook);
            this.groupBox4.Controls.Add(this.buttonAddPan);
            this.groupBox4.Controls.Add(this.checkBox1);
            this.groupBox4.Location = new System.Drawing.Point(40, 201);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(240, 247);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Плита";
            // 
            // buttonCookPotatos
            // 
            this.buttonCookPotatos.Enabled = false;
            this.buttonCookPotatos.Location = new System.Drawing.Point(38, 178);
            this.buttonCookPotatos.Name = "buttonCookPotatos";
            this.buttonCookPotatos.Size = new System.Drawing.Size(171, 48);
            this.buttonCookPotatos.TabIndex = 3;
            this.buttonCookPotatos.Text = "Готовить";
            this.buttonCookPotatos.UseVisualStyleBackColor = true;
            this.buttonCookPotatos.Click += new System.EventHandler(this.buttonCookPotatos_Click);
            // 
            // buttonCook
            // 
            this.buttonCook.Enabled = false;
            this.buttonCook.Location = new System.Drawing.Point(38, 105);
            this.buttonCook.Name = "buttonCook";
            this.buttonCook.Size = new System.Drawing.Size(171, 48);
            this.buttonCook.TabIndex = 2;
            this.buttonCook.Text = "Довести масло до кипения";
            this.buttonCook.UseVisualStyleBackColor = true;
            this.buttonCook.Click += new System.EventHandler(this.buttonCook_Click);
            // 
            // buttonAddPan
            // 
            this.buttonAddPan.Location = new System.Drawing.Point(38, 51);
            this.buttonAddPan.Name = "buttonAddPan";
            this.buttonAddPan.Size = new System.Drawing.Size(171, 48);
            this.buttonAddPan.TabIndex = 1;
            this.buttonAddPan.Text = "Поставить кастрюлю";
            this.buttonAddPan.UseVisualStyleBackColor = true;
            this.buttonAddPan.Click += new System.EventHandler(this.buttonAddPan_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(82, 28);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(45, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Вкл";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.buttonGetPotatos);
            this.groupBox5.Controls.Add(this.buttonAddPotatos);
            this.groupBox5.Controls.Add(this.buttonAddOil);
            this.groupBox5.Location = new System.Drawing.Point(313, 201);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(240, 247);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Кастрюля";
            // 
            // buttonGetPotatos
            // 
            this.buttonGetPotatos.Enabled = false;
            this.buttonGetPotatos.Location = new System.Drawing.Point(37, 178);
            this.buttonGetPotatos.Name = "buttonGetPotatos";
            this.buttonGetPotatos.Size = new System.Drawing.Size(169, 48);
            this.buttonGetPotatos.TabIndex = 2;
            this.buttonGetPotatos.Text = "Вынуть картошку";
            this.buttonGetPotatos.UseVisualStyleBackColor = true;
            this.buttonGetPotatos.Click += new System.EventHandler(this.buttonGetPotatos_Click);
            // 
            // buttonAddPotatos
            // 
            this.buttonAddPotatos.Enabled = false;
            this.buttonAddPotatos.Location = new System.Drawing.Point(37, 105);
            this.buttonAddPotatos.Name = "buttonAddPotatos";
            this.buttonAddPotatos.Size = new System.Drawing.Size(169, 48);
            this.buttonAddPotatos.TabIndex = 1;
            this.buttonAddPotatos.Text = "Добавить картошку";
            this.buttonAddPotatos.UseVisualStyleBackColor = true;
            this.buttonAddPotatos.Click += new System.EventHandler(this.buttonAddPotatos_Click);
            // 
            // buttonAddOil
            // 
            this.buttonAddOil.Enabled = false;
            this.buttonAddOil.Location = new System.Drawing.Point(37, 51);
            this.buttonAddOil.Name = "buttonAddOil";
            this.buttonAddOil.Size = new System.Drawing.Size(169, 48);
            this.buttonAddOil.TabIndex = 0;
            this.buttonAddOil.Text = "Налить масло";
            this.buttonAddOil.UseVisualStyleBackColor = true;
            this.buttonAddOil.Click += new System.EventHandler(this.buttonAddOil_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.buttonAddSalt);
            this.groupBox6.Controls.Add(this.buttonPutPotatos);
            this.groupBox6.Location = new System.Drawing.Point(569, 201);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(240, 247);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Тарелка";
            // 
            // buttonAddSalt
            // 
            this.buttonAddSalt.Enabled = false;
            this.buttonAddSalt.Location = new System.Drawing.Point(38, 105);
            this.buttonAddSalt.Name = "buttonAddSalt";
            this.buttonAddSalt.Size = new System.Drawing.Size(145, 48);
            this.buttonAddSalt.TabIndex = 1;
            this.buttonAddSalt.Text = "Добавить соль";
            this.buttonAddSalt.UseVisualStyleBackColor = true;
            this.buttonAddSalt.Click += new System.EventHandler(this.buttonAddSalt_Click);
            // 
            // buttonPutPotatos
            // 
            this.buttonPutPotatos.Enabled = false;
            this.buttonPutPotatos.Location = new System.Drawing.Point(38, 51);
            this.buttonPutPotatos.Name = "buttonPutPotatos";
            this.buttonPutPotatos.Size = new System.Drawing.Size(145, 48);
            this.buttonPutPotatos.TabIndex = 0;
            this.buttonPutPotatos.Text = "Выложить картошку";
            this.buttonPutPotatos.UseVisualStyleBackColor = true;
            this.buttonPutPotatos.Click += new System.EventHandler(this.buttonPutPotatos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 489);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSalt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPotatos)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxHaveOil;
        private System.Windows.Forms.NumericUpDown numericUpDownSalt;
        private System.Windows.Forms.NumericUpDown numericUpDownPotatos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonWash;
        private System.Windows.Forms.RadioButton radioButtonClose;
        private System.Windows.Forms.RadioButton radioButtonOpen;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonSlicePotatos;
        private System.Windows.Forms.Button buttonClearPotatos;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button buttonCookPotatos;
        private System.Windows.Forms.Button buttonCook;
        private System.Windows.Forms.Button buttonAddPan;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button buttonGetPotatos;
        private System.Windows.Forms.Button buttonAddPotatos;
        private System.Windows.Forms.Button buttonAddOil;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button buttonAddSalt;
        private System.Windows.Forms.Button buttonPutPotatos;
    }
}

