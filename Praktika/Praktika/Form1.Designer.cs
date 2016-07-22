namespace Praktika
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
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox_battery = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox_CPU = new System.Windows.Forms.RichTextBox();
            this.richTextBox_os = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.richTextBox_RAM = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.richTextBox2_video = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.richTextBox_disc = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(290, 435);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Получить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox_battery
            // 
            this.richTextBox_battery.Location = new System.Drawing.Point(22, 64);
            this.richTextBox_battery.Name = "richTextBox_battery";
            this.richTextBox_battery.Size = new System.Drawing.Size(305, 100);
            this.richTextBox_battery.TabIndex = 1;
            this.richTextBox_battery.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Информация о батареи";
            // 
            // richTextBox_CPU
            // 
            this.richTextBox_CPU.Location = new System.Drawing.Point(22, 183);
            this.richTextBox_CPU.Name = "richTextBox_CPU";
            this.richTextBox_CPU.Size = new System.Drawing.Size(305, 100);
            this.richTextBox_CPU.TabIndex = 4;
            this.richTextBox_CPU.Text = "";
            // 
            // richTextBox_os
            // 
            this.richTextBox_os.Location = new System.Drawing.Point(333, 183);
            this.richTextBox_os.Name = "richTextBox_os";
            this.richTextBox_os.Size = new System.Drawing.Size(309, 100);
            this.richTextBox_os.TabIndex = 6;
            this.richTextBox_os.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Информация о процесоре";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(330, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Информация о OS";
            // 
            // richTextBox_RAM
            // 
            this.richTextBox_RAM.Location = new System.Drawing.Point(22, 306);
            this.richTextBox_RAM.Name = "richTextBox_RAM";
            this.richTextBox_RAM.Size = new System.Drawing.Size(305, 96);
            this.richTextBox_RAM.TabIndex = 9;
            this.richTextBox_RAM.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Информация о ОЗУ";
            // 
            // richTextBox2_video
            // 
            this.richTextBox2_video.Location = new System.Drawing.Point(333, 306);
            this.richTextBox2_video.Name = "richTextBox2_video";
            this.richTextBox2_video.Size = new System.Drawing.Size(309, 96);
            this.richTextBox2_video.TabIndex = 11;
            this.richTextBox2_video.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(333, 287);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Информация о видеокарте";
            // 
            // richTextBox_disc
            // 
            this.richTextBox_disc.Location = new System.Drawing.Point(336, 64);
            this.richTextBox_disc.Name = "richTextBox_disc";
            this.richTextBox_disc.Size = new System.Drawing.Size(306, 100);
            this.richTextBox_disc.TabIndex = 13;
            this.richTextBox_disc.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(333, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(165, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Информация о жестких дисках";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 467);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.richTextBox_disc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.richTextBox2_video);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.richTextBox_RAM);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.richTextBox_os);
            this.Controls.Add(this.richTextBox_CPU);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox_battery);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox_battery;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox_CPU;
        private System.Windows.Forms.RichTextBox richTextBox_os;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox richTextBox_RAM;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox richTextBox2_video;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox richTextBox_disc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
    }
}

