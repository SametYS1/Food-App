namespace Yemek
{
    partial class Kontrol3
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Font = new Font("Segoe UI Variable Small", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.Coral;
            label1.Location = new Point(128, 131);
            label1.Name = "label1";
            label1.Size = new Size(100, 36);
            label1.TabIndex = 0;
            label1.Text = "Adres :";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(246, 144);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(417, 23);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(246, 256);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(417, 23);
            textBox2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Black;
            label3.Font = new Font("Segoe UI Variable Small", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.Coral;
            label3.Location = new Point(110, 243);
            label3.Name = "label3";
            label3.Size = new Size(118, 36);
            label3.TabIndex = 3;
            label3.Text = "Telefon :";
            label3.Click += label3_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.FlatAppearance.BorderSize = 0;
            button1.Font = new Font("Segoe UI Variable Small", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button1.ForeColor = Color.Coral;
            button1.Location = new Point(174, 374);
            button1.Name = "button1";
            button1.Size = new Size(149, 91);
            button1.TabIndex = 5;
            button1.Text = "Adresi Kaydet";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.FlatAppearance.BorderSize = 0;
            button2.Font = new Font("Segoe UI Variable Small", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button2.ForeColor = Color.Coral;
            button2.Location = new Point(471, 374);
            button2.Name = "button2";
            button2.Size = new Size(149, 91);
            button2.TabIndex = 6;
            button2.Text = "Siparişi Tamamla";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Kontrol3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Kontrol3";
            Size = new Size(858, 604);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
        private Button button1;
        private Button button2;
    }
}
