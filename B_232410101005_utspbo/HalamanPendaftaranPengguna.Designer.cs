﻿namespace B_232410101005_utspbo
{
    partial class HalamanPendaftaranPengguna
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Algerian", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(110, 45);
            label1.Name = "label1";
            label1.Size = new Size(566, 49);
            label1.TabIndex = 0;
            label1.Text = "Pendaftaran Pengguna";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(124, 165);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 1;
            label2.Text = "Nama";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(124, 219);
            label3.Name = "label3";
            label3.Size = new Size(162, 25);
            label3.TabIndex = 2;
            label3.Text = "Jenjang Pendidikan";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(340, 159);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(311, 31);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(340, 225);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(311, 31);
            textBox2.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(601, 310);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 5;
            button1.Text = "Daftar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // HalamanPendaftaranPengguna
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "HalamanPendaftaranPengguna";
            Text = "HalamanPendaftaranPengguna";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
    }
}