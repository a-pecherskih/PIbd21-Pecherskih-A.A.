namespace Lab2_var24
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
            this.pictureBoxDraw = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonSelectColor = new System.Windows.Forms.Button();
            this.buttonSelectDopColor = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBoxWings = new System.Windows.Forms.CheckBox();
            this.checkBoxScrew = new System.Windows.Forms.CheckBox();
            this.buttonSetPlane = new System.Windows.Forms.Button();
            this.buttonSetLightPlane = new System.Windows.Forms.Button();
            this.textBoxMaxSpeed = new System.Windows.Forms.TextBox();
            this.textBoxMaxAltitude = new System.Windows.Forms.TextBox();
            this.textBoxMaxCountPassenget = new System.Windows.Forms.TextBox();
            this.textBoxWeight = new System.Windows.Forms.TextBox();
            this.buttonMove = new System.Windows.Forms.Button();
            this.buttonSelectDopColor2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDraw)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxDraw
            // 
            this.pictureBoxDraw.Location = new System.Drawing.Point(22, 18);
            this.pictureBoxDraw.Name = "pictureBoxDraw";
            this.pictureBoxDraw.Size = new System.Drawing.Size(627, 372);
            this.pictureBoxDraw.TabIndex = 0;
            this.pictureBoxDraw.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 427);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Max speed";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 455);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Max Altitude";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(200, 427);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Max cout passenger";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(262, 450);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Weight";
            // 
            // buttonSelectColor
            // 
            this.buttonSelectColor.BackColor = System.Drawing.Color.DarkRed;
            this.buttonSelectColor.Location = new System.Drawing.Point(473, 420);
            this.buttonSelectColor.Name = "buttonSelectColor";
            this.buttonSelectColor.Size = new System.Drawing.Size(90, 27);
            this.buttonSelectColor.TabIndex = 5;
            this.buttonSelectColor.Text = "Color";
            this.buttonSelectColor.UseVisualStyleBackColor = false;
            this.buttonSelectColor.Click += new System.EventHandler(this.buttonSelectColor_Click);
            // 
            // buttonSelectDopColor
            // 
            this.buttonSelectDopColor.BackColor = System.Drawing.Color.Lime;
            this.buttonSelectDopColor.Location = new System.Drawing.Point(473, 453);
            this.buttonSelectDopColor.Name = "buttonSelectDopColor";
            this.buttonSelectDopColor.Size = new System.Drawing.Size(90, 27);
            this.buttonSelectDopColor.TabIndex = 6;
            this.buttonSelectDopColor.Text = "Color";
            this.buttonSelectDopColor.UseVisualStyleBackColor = false;
            this.buttonSelectDopColor.Click += new System.EventHandler(this.buttonSelectDopColor_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(411, 427);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Main color";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(436, 456);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Color";
            // 
            // checkBoxWings
            // 
            this.checkBoxWings.AutoSize = true;
            this.checkBoxWings.Location = new System.Drawing.Point(580, 423);
            this.checkBoxWings.Name = "checkBoxWings";
            this.checkBoxWings.Size = new System.Drawing.Size(56, 17);
            this.checkBoxWings.TabIndex = 9;
            this.checkBoxWings.Text = "Wings";
            this.checkBoxWings.UseVisualStyleBackColor = true;
            // 
            // checkBoxScrew
            // 
            this.checkBoxScrew.AutoSize = true;
            this.checkBoxScrew.Location = new System.Drawing.Point(580, 454);
            this.checkBoxScrew.Name = "checkBoxScrew";
            this.checkBoxScrew.Size = new System.Drawing.Size(56, 17);
            this.checkBoxScrew.TabIndex = 10;
            this.checkBoxScrew.Text = "Screw";
            this.checkBoxScrew.UseVisualStyleBackColor = true;
            this.checkBoxScrew.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // buttonSetPlane
            // 
            this.buttonSetPlane.Location = new System.Drawing.Point(151, 498);
            this.buttonSetPlane.Name = "buttonSetPlane";
            this.buttonSetPlane.Size = new System.Drawing.Size(117, 36);
            this.buttonSetPlane.TabIndex = 11;
            this.buttonSetPlane.Text = "Set plane";
            this.buttonSetPlane.UseVisualStyleBackColor = true;
            this.buttonSetPlane.Click += new System.EventHandler(this.buttonSetPlane_Click);
            // 
            // buttonSetLightPlane
            // 
            this.buttonSetLightPlane.Location = new System.Drawing.Point(298, 498);
            this.buttonSetLightPlane.Name = "buttonSetLightPlane";
            this.buttonSetLightPlane.Size = new System.Drawing.Size(108, 36);
            this.buttonSetLightPlane.TabIndex = 12;
            this.buttonSetLightPlane.Text = "Set light plane";
            this.buttonSetLightPlane.UseVisualStyleBackColor = true;
            this.buttonSetLightPlane.Click += new System.EventHandler(this.buttonSetLightPlane_Click);
            // 
            // textBoxMaxSpeed
            // 
            this.textBoxMaxSpeed.Location = new System.Drawing.Point(107, 424);
            this.textBoxMaxSpeed.Name = "textBoxMaxSpeed";
            this.textBoxMaxSpeed.Size = new System.Drawing.Size(65, 20);
            this.textBoxMaxSpeed.TabIndex = 13;
            // 
            // textBoxMaxAltitude
            // 
            this.textBoxMaxAltitude.Location = new System.Drawing.Point(107, 454);
            this.textBoxMaxAltitude.Name = "textBoxMaxAltitude";
            this.textBoxMaxAltitude.Size = new System.Drawing.Size(65, 20);
            this.textBoxMaxAltitude.TabIndex = 14;
            // 
            // textBoxMaxCountPassenget
            // 
            this.textBoxMaxCountPassenget.Location = new System.Drawing.Point(309, 423);
            this.textBoxMaxCountPassenget.Name = "textBoxMaxCountPassenget";
            this.textBoxMaxCountPassenget.Size = new System.Drawing.Size(65, 20);
            this.textBoxMaxCountPassenget.TabIndex = 15;
            // 
            // textBoxWeight
            // 
            this.textBoxWeight.Location = new System.Drawing.Point(309, 450);
            this.textBoxWeight.Name = "textBoxWeight";
            this.textBoxWeight.Size = new System.Drawing.Size(65, 20);
            this.textBoxWeight.TabIndex = 16;
            // 
            // buttonMove
            // 
            this.buttonMove.Location = new System.Drawing.Point(526, 499);
            this.buttonMove.Name = "buttonMove";
            this.buttonMove.Size = new System.Drawing.Size(123, 34);
            this.buttonMove.TabIndex = 17;
            this.buttonMove.Text = "Move";
            this.buttonMove.UseVisualStyleBackColor = true;
            this.buttonMove.Click += new System.EventHandler(this.buttonMove_Click_1);
            // 
            // buttonSelectDopColor2
            // 
            this.buttonSelectDopColor2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonSelectDopColor2.Location = new System.Drawing.Point(642, 426);
            this.buttonSelectDopColor2.Name = "buttonSelectDopColor2";
            this.buttonSelectDopColor2.Size = new System.Drawing.Size(79, 42);
            this.buttonSelectDopColor2.TabIndex = 18;
            this.buttonSelectDopColor2.Text = "Color";
            this.buttonSelectDopColor2.UseVisualStyleBackColor = false;
            this.buttonSelectDopColor2.Click += new System.EventHandler(this.buttonSelectDopColor2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 546);
            this.Controls.Add(this.buttonSelectDopColor2);
            this.Controls.Add(this.buttonMove);
            this.Controls.Add(this.textBoxWeight);
            this.Controls.Add(this.textBoxMaxCountPassenget);
            this.Controls.Add(this.textBoxMaxAltitude);
            this.Controls.Add(this.textBoxMaxSpeed);
            this.Controls.Add(this.buttonSetLightPlane);
            this.Controls.Add(this.buttonSetPlane);
            this.Controls.Add(this.checkBoxScrew);
            this.Controls.Add(this.checkBoxWings);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonSelectDopColor);
            this.Controls.Add(this.buttonSelectColor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxDraw);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDraw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxDraw;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonSelectColor;
        private System.Windows.Forms.Button buttonSelectDopColor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBoxWings;
        private System.Windows.Forms.CheckBox checkBoxScrew;
        private System.Windows.Forms.Button buttonSetPlane;
        private System.Windows.Forms.Button buttonSetLightPlane;
        private System.Windows.Forms.TextBox textBoxMaxSpeed;
        private System.Windows.Forms.TextBox textBoxMaxAltitude;
        private System.Windows.Forms.TextBox textBoxMaxCountPassenget;
        private System.Windows.Forms.TextBox textBoxWeight;
        private System.Windows.Forms.Button buttonMove;
        private System.Windows.Forms.Button buttonSelectDopColor2;
    }
}

