namespace nalanKaraca2018280068
{
    partial class Form1
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

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.Roma = new System.Windows.Forms.Button();
            this.sayi = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Roma
            // 
            this.Roma.Location = new System.Drawing.Point(411, 22);
            this.Roma.Name = "Roma";
            this.Roma.Size = new System.Drawing.Size(118, 23);
            this.Roma.TabIndex = 0;
            this.Roma.Text = "Roma rakamına çevir";
            this.Roma.UseVisualStyleBackColor = true;
            this.Roma.Click += new System.EventHandler(this.Roma_Click);
            // 
            // sayi
            // 
            this.sayi.Location = new System.Drawing.Point(411, 78);
            this.sayi.Name = "sayi";
            this.sayi.Size = new System.Drawing.Size(118, 23);
            this.sayi.TabIndex = 1;
            this.sayi.Text = "Sayıya Çevir";
            this.sayi.UseVisualStyleBackColor = true;
            this.sayi.Click += new System.EventHandler(this.sayi_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(286, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lütfen  [1,3999]  aralığında bir sayı giriniz";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(553, 21);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Lütfen [I,MMM CM XC IX] aralığında  roma rakamı giriniz";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(286, 75);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(553, 78);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 210);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.sayi);
            this.Controls.Add(this.Roma);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Roma;
        private System.Windows.Forms.Button sayi;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
    }
}

