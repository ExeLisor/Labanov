namespace USSR
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TBspeed = new System.Windows.Forms.TextBox();
            this.TBangle = new System.Windows.Forms.TextBox();
            this.TBresistance = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.BtStart = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtStop = new System.Windows.Forms.Button();
            this.BtReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1267, 317);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // TBspeed
            // 
            this.TBspeed.Location = new System.Drawing.Point(11, 419);
            this.TBspeed.Name = "TBspeed";
            this.TBspeed.Size = new System.Drawing.Size(100, 22);
            this.TBspeed.TabIndex = 1;
            // 
            // TBangle
            // 
            this.TBangle.Location = new System.Drawing.Point(117, 420);
            this.TBangle.Name = "TBangle";
            this.TBangle.Size = new System.Drawing.Size(100, 22);
            this.TBangle.TabIndex = 2;
            // 
            // TBresistance
            // 
            this.TBresistance.Location = new System.Drawing.Point(223, 420);
            this.TBresistance.Name = "TBresistance";
            this.TBresistance.Size = new System.Drawing.Size(100, 22);
            this.TBresistance.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // BtStart
            // 
            this.BtStart.Location = new System.Drawing.Point(834, 387);
            this.BtStart.Name = "BtStart";
            this.BtStart.Size = new System.Drawing.Size(136, 57);
            this.BtStart.TabIndex = 4;
            this.BtStart.Text = "Старт";
            this.BtStart.UseVisualStyleBackColor = true;
            this.BtStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 400);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Угол";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(220, 400);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Масса";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 399);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Скорость";
            // 
            // BtStop
            // 
            this.BtStop.Location = new System.Drawing.Point(976, 387);
            this.BtStop.Name = "BtStop";
            this.BtStop.Size = new System.Drawing.Size(136, 57);
            this.BtStop.TabIndex = 9;
            this.BtStop.Text = "Стоп";
            this.BtStop.UseVisualStyleBackColor = true;
            this.BtStop.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtReset
            // 
            this.BtReset.Location = new System.Drawing.Point(1118, 387);
            this.BtReset.Name = "BtReset";
            this.BtReset.Size = new System.Drawing.Size(136, 57);
            this.BtReset.TabIndex = 12;
            this.BtReset.Text = "Перезапуск";
            this.BtReset.UseVisualStyleBackColor = true;
            this.BtReset.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 450);
            this.Controls.Add(this.BtReset);
            this.Controls.Add(this.BtStop);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtStart);
            this.Controls.Add(this.TBresistance);
            this.Controls.Add(this.TBangle);
            this.Controls.Add(this.TBspeed);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TBspeed;
        private System.Windows.Forms.TextBox TBangle;
        private System.Windows.Forms.TextBox TBresistance;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button BtStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtStop;
        private System.Windows.Forms.Button BtReset;
    }
}

