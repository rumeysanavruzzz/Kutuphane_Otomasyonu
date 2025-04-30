using System;
using System.Windows.Forms;

namespace kitapIslemleriForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.kitapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kitapIslemleriDataSet = new kitapIslemleriForm.kitapIslemleriDataSet();
            this.kitapTableAdapter = new kitapIslemleriForm.kitapIslemleriDataSetTableAdapters.KitapTableAdapter();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox28 = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button7 = new System.Windows.Forms.Button();
            this.textBox27 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.textBox23 = new System.Windows.Forms.TextBox();
            this.textBox24 = new System.Windows.Forms.TextBox();
            this.textBox25 = new System.Windows.Forms.TextBox();
            this.textBox26 = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonListele = new System.Windows.Forms.Button();
            this.buttonVeriAl = new System.Windows.Forms.Button();
            this.buttonVeriCek = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.eklemeListesi = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.kitapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapIslemleriDataSet)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eklemeListesi)).BeginInit();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // kitapBindingSource
            // 
            this.kitapBindingSource.DataMember = "Kitap";
            this.kitapBindingSource.DataSource = this.kitapIslemleriDataSet;
            // 
            // kitapIslemleriDataSet
            // 
            this.kitapIslemleriDataSet.DataSetName = "kitapIslemleriDataSet";
            this.kitapIslemleriDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kitapTableAdapter
            // 
            this.kitapTableAdapter.ClearBeforeFill = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.textBox28);
            this.tabPage2.Controls.Add(this.label29);
            this.tabPage2.Controls.Add(this.label28);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.button7);
            this.tabPage2.Controls.Add(this.textBox27);
            this.tabPage2.Controls.Add(this.textBox14);
            this.tabPage2.Controls.Add(this.textBox15);
            this.tabPage2.Controls.Add(this.textBox16);
            this.tabPage2.Controls.Add(this.textBox17);
            this.tabPage2.Controls.Add(this.textBox18);
            this.tabPage2.Controls.Add(this.textBox19);
            this.tabPage2.Controls.Add(this.textBox20);
            this.tabPage2.Controls.Add(this.textBox21);
            this.tabPage2.Controls.Add(this.textBox22);
            this.tabPage2.Controls.Add(this.textBox23);
            this.tabPage2.Controls.Add(this.textBox24);
            this.tabPage2.Controls.Add(this.textBox25);
            this.tabPage2.Controls.Add(this.textBox26);
            this.tabPage2.Controls.Add(this.label27);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.label19);
            this.tabPage2.Controls.Add(this.label20);
            this.tabPage2.Controls.Add(this.label21);
            this.tabPage2.Controls.Add(this.label22);
            this.tabPage2.Controls.Add(this.label23);
            this.tabPage2.Controls.Add(this.label24);
            this.tabPage2.Controls.Add(this.label25);
            this.tabPage2.Controls.Add(this.label26);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1029, 575);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Kitap Güncelle/Sil";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(809, 82);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(187, 29);
            this.button5.TabIndex = 65;
            this.button5.Text = "Ara";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // textBox28
            // 
            this.textBox28.Location = new System.Drawing.Point(567, 79);
            this.textBox28.Name = "textBox28";
            this.textBox28.Size = new System.Drawing.Size(181, 22);
            this.textBox28.TabIndex = 64;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(476, 82);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(60, 16);
            this.label29.TabIndex = 63;
            this.label29.Text = "Kitap Ad:";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(476, 38);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(88, 16);
            this.label28.TabIndex = 62;
            this.label28.Text = "Arama İşlemi:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(479, 131);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(550, 448);
            this.panel1.TabIndex = 61;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(550, 448);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(221, 521);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(187, 23);
            this.button7.TabIndex = 60;
            this.button7.Text = "Sil";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // textBox27
            // 
            this.textBox27.Location = new System.Drawing.Point(157, 484);
            this.textBox27.Name = "textBox27";
            this.textBox27.Size = new System.Drawing.Size(181, 22);
            this.textBox27.TabIndex = 59;
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(157, 446);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(181, 22);
            this.textBox14.TabIndex = 54;
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(157, 408);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(181, 22);
            this.textBox15.TabIndex = 53;
            // 
            // textBox16
            // 
            this.textBox16.Location = new System.Drawing.Point(157, 371);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(181, 22);
            this.textBox16.TabIndex = 52;
            // 
            // textBox17
            // 
            this.textBox17.Location = new System.Drawing.Point(157, 334);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(181, 22);
            this.textBox17.TabIndex = 51;
            // 
            // textBox18
            // 
            this.textBox18.Location = new System.Drawing.Point(157, 295);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(181, 22);
            this.textBox18.TabIndex = 50;
            // 
            // textBox19
            // 
            this.textBox19.Location = new System.Drawing.Point(157, 264);
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new System.Drawing.Size(181, 22);
            this.textBox19.TabIndex = 49;
            // 
            // textBox20
            // 
            this.textBox20.Location = new System.Drawing.Point(157, 225);
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new System.Drawing.Size(181, 22);
            this.textBox20.TabIndex = 48;
            // 
            // textBox21
            // 
            this.textBox21.Location = new System.Drawing.Point(157, 182);
            this.textBox21.Name = "textBox21";
            this.textBox21.Size = new System.Drawing.Size(181, 22);
            this.textBox21.TabIndex = 47;
            // 
            // textBox22
            // 
            this.textBox22.Location = new System.Drawing.Point(157, 142);
            this.textBox22.Name = "textBox22";
            this.textBox22.Size = new System.Drawing.Size(181, 22);
            this.textBox22.TabIndex = 46;
            // 
            // textBox23
            // 
            this.textBox23.Location = new System.Drawing.Point(157, 113);
            this.textBox23.Name = "textBox23";
            this.textBox23.Size = new System.Drawing.Size(181, 22);
            this.textBox23.TabIndex = 45;
            // 
            // textBox24
            // 
            this.textBox24.Location = new System.Drawing.Point(157, 76);
            this.textBox24.Name = "textBox24";
            this.textBox24.Size = new System.Drawing.Size(181, 22);
            this.textBox24.TabIndex = 44;
            // 
            // textBox25
            // 
            this.textBox25.Location = new System.Drawing.Point(157, 38);
            this.textBox25.Name = "textBox25";
            this.textBox25.Size = new System.Drawing.Size(181, 22);
            this.textBox25.TabIndex = 43;
            // 
            // textBox26
            // 
            this.textBox26.Location = new System.Drawing.Point(157, 10);
            this.textBox26.Name = "textBox26";
            this.textBox26.Size = new System.Drawing.Size(181, 22);
            this.textBox26.TabIndex = 42;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label27.Location = new System.Drawing.Point(29, 484);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(109, 20);
            this.label27.TabIndex = 57;
            this.label27.Text = "Demirbaş ID:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(117, 546);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(187, 23);
            this.button3.TabIndex = 56;
            this.button3.Text = "İptal";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(8, 521);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(187, 23);
            this.button4.TabIndex = 55;
            this.button4.Text = "Güncelle";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(30, 448);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(82, 20);
            this.label14.TabIndex = 41;
            this.label14.Text = "Yayın Evi:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(30, 410);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(101, 20);
            this.label15.TabIndex = 40;
            this.label15.Text = "Sayfa Sayısı";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.Location = new System.Drawing.Point(30, 373);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(89, 20);
            this.label16.TabIndex = 39;
            this.label16.Text = "Basım Yılı:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.Location = new System.Drawing.Point(30, 334);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(108, 20);
            this.label17.TabIndex = 38;
            this.label17.Text = "Yazar Soyad:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.Location = new System.Drawing.Point(30, 297);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(82, 20);
            this.label18.TabIndex = 37;
            this.label18.Text = "Yazar Ad:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label19.Location = new System.Drawing.Point(30, 266);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(96, 20);
            this.label19.TabIndex = 36;
            this.label19.Text = "Raf Durum:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label20.Location = new System.Drawing.Point(30, 227);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(115, 20);
            this.label20.TabIndex = 35;
            this.label20.Text = "Kütüphane ID:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label21.Location = new System.Drawing.Point(30, 184);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(93, 20);
            this.label21.TabIndex = 34;
            this.label21.Text = "Giriş Tarih:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label22.Location = new System.Drawing.Point(30, 144);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(50, 20);
            this.label22.TabIndex = 33;
            this.label22.Text = "Fiyat:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label23.Location = new System.Drawing.Point(30, 115);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(53, 20);
            this.label23.TabIndex = 32;
            this.label23.Text = "ISBN:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label24.Location = new System.Drawing.Point(30, 78);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(82, 20);
            this.label24.TabIndex = 31;
            this.label24.Text = "Baskı No:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label25.Location = new System.Drawing.Point(30, 40);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(101, 20);
            this.label25.TabIndex = 30;
            this.label25.Text = "Kategori Ad:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label26.Location = new System.Drawing.Point(30, 10);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(77, 20);
            this.label26.TabIndex = 29;
            this.label26.Text = "Kitap Ad:";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonListele);
            this.tabPage1.Controls.Add(this.buttonVeriAl);
            this.tabPage1.Controls.Add(this.buttonVeriCek);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.textBox13);
            this.tabPage1.Controls.Add(this.textBox12);
            this.tabPage1.Controls.Add(this.textBox11);
            this.tabPage1.Controls.Add(this.textBox10);
            this.tabPage1.Controls.Add(this.textBox9);
            this.tabPage1.Controls.Add(this.textBox8);
            this.tabPage1.Controls.Add(this.textBox7);
            this.tabPage1.Controls.Add(this.textBox6);
            this.tabPage1.Controls.Add(this.textBox5);
            this.tabPage1.Controls.Add(this.textBox4);
            this.tabPage1.Controls.Add(this.textBox3);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.eklemeListesi);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1029, 575);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Kitap Ekle";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // buttonListele
            // 
            this.buttonListele.Location = new System.Drawing.Point(96, 544);
            this.buttonListele.Name = "buttonListele";
            this.buttonListele.Size = new System.Drawing.Size(174, 23);
            this.buttonListele.TabIndex = 31;
            this.buttonListele.Text = "Listele";
            this.buttonListele.UseVisualStyleBackColor = true;
            this.buttonListele.Click += new System.EventHandler(this.buttonListele_Click);
            // 
            // buttonVeriAl
            // 
            this.buttonVeriAl.Location = new System.Drawing.Point(180, 500);
            this.buttonVeriAl.Name = "buttonVeriAl";
            this.buttonVeriAl.Size = new System.Drawing.Size(174, 23);
            this.buttonVeriAl.TabIndex = 30;
            this.buttonVeriAl.Text = "Veri Al";
            this.buttonVeriAl.UseVisualStyleBackColor = true;
            this.buttonVeriAl.Click += new System.EventHandler(this.buttonVeriAl_Click);
            // 
            // buttonVeriCek
            // 
            this.buttonVeriCek.Location = new System.Drawing.Point(0, 500);
            this.buttonVeriCek.Name = "buttonVeriCek";
            this.buttonVeriCek.Size = new System.Drawing.Size(173, 23);
            this.buttonVeriCek.TabIndex = 29;
            this.buttonVeriCek.Text = "Veri Çek";
            this.buttonVeriCek.UseVisualStyleBackColor = true;
            this.buttonVeriCek.Click += new System.EventHandler(this.buttonVeriCek_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(180, 460);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(174, 23);
            this.button2.TabIndex = 28;
            this.button2.Text = "İptal";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 460);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 23);
            this.button1.TabIndex = 27;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(170, 398);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(184, 22);
            this.textBox13.TabIndex = 26;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(170, 370);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(184, 22);
            this.textBox12.TabIndex = 25;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(170, 331);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(184, 22);
            this.textBox11.TabIndex = 24;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(170, 289);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(184, 22);
            this.textBox10.TabIndex = 23;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(170, 250);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(184, 22);
            this.textBox9.TabIndex = 22;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(170, 212);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(184, 22);
            this.textBox8.TabIndex = 21;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(170, 177);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(184, 22);
            this.textBox7.TabIndex = 20;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(170, 150);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(184, 22);
            this.textBox6.TabIndex = 19;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(170, 121);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(184, 22);
            this.textBox5.TabIndex = 18;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(170, 93);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(184, 22);
            this.textBox4.TabIndex = 17;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(170, 65);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(184, 22);
            this.textBox3.TabIndex = 16;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(170, 36);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(184, 22);
            this.textBox2.TabIndex = 15;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(170, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(184, 22);
            this.textBox1.TabIndex = 14;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(26, 406);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 20);
            this.label13.TabIndex = 13;
            this.label13.Text = "Yayın Evi:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(26, 372);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 20);
            this.label12.TabIndex = 12;
            this.label12.Text = "Sayfa Sayısı";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(26, 331);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 20);
            this.label11.TabIndex = 11;
            this.label11.Text = "Basım Yılı:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(26, 291);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 20);
            this.label10.TabIndex = 10;
            this.label10.Text = "Yazar Soyad:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(26, 252);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 20);
            this.label9.TabIndex = 9;
            this.label9.Text = "Yazar Ad:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(26, 214);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Raf Durum:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(26, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Kütüphane ID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(26, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Giriş Tarih:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(26, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Fiyat:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(26, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "ISBN:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(26, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Baskı No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(26, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kategori Ad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(26, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kitap Ad:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // eklemeListesi
            // 
            this.eklemeListesi.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.eklemeListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eklemeListesi.Dock = System.Windows.Forms.DockStyle.Right;
            this.eklemeListesi.Location = new System.Drawing.Point(389, 3);
            this.eklemeListesi.Name = "eklemeListesi";
            this.eklemeListesi.RowHeadersWidth = 51;
            this.eklemeListesi.RowTemplate.Height = 24;
            this.eklemeListesi.Size = new System.Drawing.Size(637, 569);
            this.eklemeListesi.TabIndex = 0;
            this.eklemeListesi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.eklemeListesi_CellContentClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1037, 604);
            this.tabControl1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(414, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 66;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 604);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.kitapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapIslemleriDataSet)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eklemeListesi)).EndInit();
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void guncelleListelemeGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private kitapIslemleriDataSet kitapIslemleriDataSet;
        private BindingSource kitapBindingSource;
        private kitapIslemleriDataSetTableAdapters.KitapTableAdapter kitapTableAdapter;
        private TabPage tabPage2;
        private Button button7;
        private TextBox textBox27;
        private TextBox textBox14;
        private TextBox textBox15;
        private TextBox textBox16;
        private TextBox textBox17;
        private TextBox textBox18;
        private TextBox textBox19;
        private TextBox textBox20;
        private TextBox textBox21;
        private TextBox textBox22;
        private TextBox textBox23;
        private TextBox textBox24;
        private TextBox textBox25;
        private TextBox textBox26;
        private Label label27;
        private Button button3;
        private Button button4;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label20;
        private Label label21;
        private Label label22;
        private Label label23;
        private Label label24;
        private Label label25;
        private Label label26;
        private TabPage tabPage1;
        private Button button2;
        private Button button1;
        private TextBox textBox13;
        private TextBox textBox12;
        private TextBox textBox11;
        private TextBox textBox10;
        private TextBox textBox9;
        private TextBox textBox8;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView eklemeListesi;
        private TabControl tabControl1;
        private Panel panel1;
        private Label label29;
        private Label label28;
        private TextBox textBox28;
        private Button button5;
        private DataGridView dataGridView1;
        private Button buttonListele;
        private Button buttonVeriAl;
        private Button buttonVeriCek;
        private PictureBox pictureBox1;
    }
}

