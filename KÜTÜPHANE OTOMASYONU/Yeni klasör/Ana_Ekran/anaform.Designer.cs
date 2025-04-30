namespace Ana_Ekran
{
    partial class anaform
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
            this.odunc_button = new System.Windows.Forms.Button();
            this.kitap_button = new System.Windows.Forms.Button();
            this.iade_button = new System.Windows.Forms.Button();
            this.uye_button = new System.Windows.Forms.Button();
            this.kullanıcı_button = new System.Windows.Forms.Button();
            this.cikis_button = new System.Windows.Forms.Button();
            this.kisim_label = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // odunc_button
            // 
            this.odunc_button.Location = new System.Drawing.Point(789, 150);
            this.odunc_button.Name = "odunc_button";
            this.odunc_button.Size = new System.Drawing.Size(154, 44);
            this.odunc_button.TabIndex = 0;
            this.odunc_button.Text = "Ödünç Alma İşlemi";
            this.odunc_button.UseVisualStyleBackColor = true;
            // 
            // kitap_button
            // 
            this.kitap_button.Location = new System.Drawing.Point(184, 397);
            this.kitap_button.Name = "kitap_button";
            this.kitap_button.Size = new System.Drawing.Size(154, 48);
            this.kitap_button.TabIndex = 1;
            this.kitap_button.Text = "Kitap İşlemleri";
            this.kitap_button.UseVisualStyleBackColor = true;
            // 
            // iade_button
            // 
            this.iade_button.Location = new System.Drawing.Point(792, 281);
            this.iade_button.Name = "iade_button";
            this.iade_button.Size = new System.Drawing.Size(157, 44);
            this.iade_button.TabIndex = 2;
            this.iade_button.Text = "İade İşlemleri";
            this.iade_button.UseVisualStyleBackColor = true;
            // 
            // uye_button
            // 
            this.uye_button.Location = new System.Drawing.Point(184, 150);
            this.uye_button.Name = "uye_button";
            this.uye_button.Size = new System.Drawing.Size(154, 44);
            this.uye_button.TabIndex = 3;
            this.uye_button.Text = "Üye İşlemleri";
            this.uye_button.UseVisualStyleBackColor = true;
            this.uye_button.Click += new System.EventHandler(this.uye_button_Click);
            // 
            // kullanıcı_button
            // 
            this.kullanıcı_button.Location = new System.Drawing.Point(184, 281);
            this.kullanıcı_button.Name = "kullanıcı_button";
            this.kullanıcı_button.Size = new System.Drawing.Size(154, 44);
            this.kullanıcı_button.TabIndex = 4;
            this.kullanıcı_button.Text = "Kullanıcı İşlemleri";
            this.kullanıcı_button.UseVisualStyleBackColor = true;
            // 
            // cikis_button
            // 
            this.cikis_button.Location = new System.Drawing.Point(795, 397);
            this.cikis_button.Name = "cikis_button";
            this.cikis_button.Size = new System.Drawing.Size(154, 48);
            this.cikis_button.TabIndex = 5;
            this.cikis_button.Text = "Çıkış Yap";
            this.cikis_button.UseVisualStyleBackColor = true;
            this.cikis_button.Click += new System.EventHandler(this.cikis_button_Click);
            // 
            // kisim_label
            // 
            this.kisim_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kisim_label.Location = new System.Drawing.Point(318, 43);
            this.kisim_label.Name = "kisim_label";
            this.kisim_label.Size = new System.Drawing.Size(498, 42);
            this.kisim_label.TabIndex = 6;
            this.kisim_label.Text = "KÜTÜPHANE TAKİP İŞLEMLERİ ";
            this.kisim_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(344, 150);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(439, 295);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // anaform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 558);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.kisim_label);
            this.Controls.Add(this.cikis_button);
            this.Controls.Add(this.kullanıcı_button);
            this.Controls.Add(this.uye_button);
            this.Controls.Add(this.iade_button);
            this.Controls.Add(this.kitap_button);
            this.Controls.Add(this.odunc_button);
            this.Name = "anaform";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.anaform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button odunc_button;
        private System.Windows.Forms.Button kitap_button;
        private System.Windows.Forms.Button iade_button;
        private System.Windows.Forms.Button uye_button;
        private System.Windows.Forms.Button kullanıcı_button;
        private System.Windows.Forms.Button cikis_button;
        private System.Windows.Forms.Label kisim_label;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

