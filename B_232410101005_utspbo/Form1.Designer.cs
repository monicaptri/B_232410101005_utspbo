namespace B_232410101005_utspbo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Algerian", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(245, 66);
            label1.Name = "label1";
            label1.Size = new Size(265, 58);
            label1.TabIndex = 0;
            label1.Text = "Welcome";
            label1.SizeChanged += label1_SizeChanged;
            // 
            // button1
            // 
            button1.Location = new Point(256, 164);
            button1.Name = "button1";
            button1.Size = new Size(293, 48);
            button1.TabIndex = 1;
            button1.Text = "Halaman Tugas";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(256, 234);
            button2.Name = "button2";
            button2.Size = new Size(293, 54);
            button2.TabIndex = 2;
            button2.Text = "Halaman Pendaftaran Pengguna";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(256, 305);
            button3.Name = "button3";
            button3.Size = new Size(293, 50);
            button3.TabIndex = 3;
            button3.Text = "Halaman Login";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}
