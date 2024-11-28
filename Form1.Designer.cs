namespace Yemek
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            kontrol11 = new Kontrol1();
            kontrol21 = new Kontrol2();
            kontrol31 = new Kontrol3();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Coral;
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(12, 160);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 345);
            panel1.TabIndex = 0;
            // 
            // button3
            // 
            button3.BackColor = Color.Black;
            button3.FlatAppearance.BorderSize = 0;
            button3.Font = new Font("Segoe UI Variable Display Semib", 12F, FontStyle.Bold);
            button3.ForeColor = Color.Coral;
            button3.Location = new Point(20, 227);
            button3.Name = "button3";
            button3.Size = new Size(159, 98);
            button3.TabIndex = 4;
            button3.Text = "Adres";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.FlatAppearance.BorderSize = 0;
            button2.Font = new Font("Segoe UI Variable Display Semib", 12F, FontStyle.Bold);
            button2.ForeColor = Color.Coral;
            button2.Location = new Point(21, 123);
            button2.Name = "button2";
            button2.Size = new Size(159, 98);
            button2.TabIndex = 3;
            button2.Text = "Menüler";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.FlatAppearance.BorderSize = 0;
            button1.Font = new Font("Segoe UI Variable Display Semib", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.ForeColor = Color.Coral;
            button1.Location = new Point(20, 16);
            button1.Name = "button1";
            button1.Size = new Size(159, 98);
            button1.TabIndex = 2;
            button1.Text = "Ana Sayfa";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Coral;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(12, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(1375, 75);
            panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(99, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(101, 75);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Montserrat Black", 27.7499962F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(404, 11);
            label2.Name = "label2";
            label2.Size = new Size(719, 51);
            label2.TabIndex = 1;
            label2.Text = "Acıktığınızda siparişiniz kapınızda";
            // 
            // kontrol11
            // 
            kontrol11.Location = new Point(218, 93);
            kontrol11.Name = "kontrol11";
            kontrol11.Size = new Size(1169, 613);
            kontrol11.TabIndex = 2;
            // 
            // kontrol21
            // 
            kontrol21.Location = new Point(253, 109);
            kontrol21.Name = "kontrol21";
            kontrol21.Size = new Size(1111, 568);
            kontrol21.TabIndex = 3;
            // 
            // kontrol31
            // 
            kontrol31.Location = new Point(253, 109);
            kontrol31.Name = "kontrol31";
            kontrol31.Size = new Size(882, 604);
            kontrol31.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1408, 749);
            Controls.Add(kontrol31);
            Controls.Add(kontrol21);
            Controls.Add(kontrol11);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label2;
        private PictureBox pictureBox1;
        private Kontrol1 kontrol11;
        private Kontrol2 kontrol21;
        private Kontrol3 kontrol31;
    }
}
