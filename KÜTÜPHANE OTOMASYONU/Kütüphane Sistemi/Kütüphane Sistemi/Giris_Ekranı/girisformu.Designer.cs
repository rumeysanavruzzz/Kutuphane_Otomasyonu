namespace Giris_Ekranı
{
    partial class girisformu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(girisformu));
            this.eposta_text = new System.Windows.Forms.TextBox();
            this.sifre_text = new System.Windows.Forms.TextBox();
            this.eposta_label = new System.Windows.Forms.Label();
            this.sifre_label = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.girisyap_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.personel_rbutton = new System.Windows.Forms.RadioButton();
            this.admin_rbutton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // eposta_text
            // 
            this.eposta_text.Location = new System.Drawing.Point(551, 124);
            this.eposta_text.Multiline = true;
            this.eposta_text.Name = "eposta_text";
            this.eposta_text.Size = new System.Drawing.Size(256, 42);
            this.eposta_text.TabIndex = 1;
            // 
            // sifre_text
            // 
            this.sifre_text.Location = new System.Drawing.Point(551, 230);
            this.sifre_text.Multiline = true;
            this.sifre_text.Name = "sifre_text";
            this.sifre_text.PasswordChar = '*';
            this.sifre_text.Size = new System.Drawing.Size(256, 35);
            this.sifre_text.TabIndex = 2;
            // 
            // eposta_label
            // 
            this.eposta_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.eposta_label.Location = new System.Drawing.Point(416, 129);
            this.eposta_label.Name = "eposta_label";
            this.eposta_label.Size = new System.Drawing.Size(116, 37);
            this.eposta_label.TabIndex = 3;
            this.eposta_label.Text = "E-Posta:";
            // 
            // sifre_label
            // 
            this.sifre_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifre_label.Location = new System.Drawing.Point(416, 230);
            this.sifre_label.Name = "sifre_label";
            this.sifre_label.Size = new System.Drawing.Size(82, 35);
            this.sifre_label.TabIndex = 4;
            this.sifre_label.Text = "Şifre:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(354, 230);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(56, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(353, 124);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(57, 55);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // girisyap_button
            // 
            this.girisyap_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.girisyap_button.Location = new System.Drawing.Point(474, 421);
            this.girisyap_button.Name = "girisyap_button";
            this.girisyap_button.Size = new System.Drawing.Size(248, 60);
            this.girisyap_button.TabIndex = 0;
            this.girisyap_button.Text = "GİRİŞ YAPINIZ";
            this.girisyap_button.UseVisualStyleBackColor = true;
            this.girisyap_button.Click += new System.EventHandler(this.girisyap_button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1163, 653);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // personel_rbutton
            // 
            this.personel_rbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.personel_rbutton.Location = new System.Drawing.Point(421, 334);
            this.personel_rbutton.Name = "personel_rbutton";
            this.personel_rbutton.Size = new System.Drawing.Size(156, 35);
            this.personel_rbutton.TabIndex = 8;
            this.personel_rbutton.TabStop = true;
            this.personel_rbutton.Text = "Personel";
            this.personel_rbutton.UseVisualStyleBackColor = true;
            // 
            // admin_rbutton
            // 
            this.admin_rbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.admin_rbutton.Location = new System.Drawing.Point(610, 334);
            this.admin_rbutton.Name = "admin_rbutton";
            this.admin_rbutton.Size = new System.Drawing.Size(147, 35);
            this.admin_rbutton.TabIndex = 9;
            this.admin_rbutton.TabStop = true;
            this.admin_rbutton.Text = "Admin";
            this.admin_rbutton.UseVisualStyleBackColor = true;
            // 
            // girisformu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 653);
            this.Controls.Add(this.admin_rbutton);
            this.Controls.Add(this.personel_rbutton);
            this.Controls.Add(this.sifre_label);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.eposta_label);
            this.Controls.Add(this.eposta_text);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.girisyap_button);
            this.Controls.Add(this.sifre_text);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "girisformu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.girisformu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox eposta_text;
        private System.Windows.Forms.TextBox sifre_text;
        private System.Windows.Forms.Label eposta_label;
        private System.Windows.Forms.Label sifre_label;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button girisyap_button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton personel_rbutton;
        private System.Windows.Forms.RadioButton admin_rbutton;
    }
}

