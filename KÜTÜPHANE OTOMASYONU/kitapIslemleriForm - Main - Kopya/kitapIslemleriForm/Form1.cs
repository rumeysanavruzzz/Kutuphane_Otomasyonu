using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;


// Excel işlemleri için

namespace kitapIslemleriForm
{
    public partial class Form1 : Form
    {
        private SqlConnection baglanti = new SqlConnection("Server=localhost;Database=VeritabaniAdi;Integrated Security=True;");

        // Veritabanı bağlantı dizesi
        private string connectionString = "Server=DESKTOP-K7MCDTS\\RUMEYSA;Database=kitapIslemleri;Trusted_Connection=True";

        public Form1()
        {
            InitializeComponent();
        }

        // Form yüklendiğinde DataGridView'e veri yükleme
        private void Form1_Load(object sender, EventArgs e)
        {
            ListeyiYenile();
        }

        // Veritabanından kitapları çekip DataGridView'e yükleme metodu
        private void ListeyiYenile()
        {
            try
            {
                // SQL sorgusu
                string query = "SELECT kitapAd, kategoriAd, baskiNo, ISBN, gelisFiyat, kutuphaneID, raftaDurum, yazarAd, yazarSoyad, basimYil, sayfaSayi, yayinEvi FROM Kitap";

                // DataTable oluştur
                DataTable dataTable = new DataTable();

                // Veritabanı bağlantısını aç
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // DataAdapter kullanarak veriyi çek
                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn))
                    {
                        dataAdapter.Fill(dataTable); // Veriyi DataTable'a doldur
                    }
                }

                // DataGridView'e veriyi bağla
                eklemeListesi.AutoGenerateColumns = true; // Sütunları otomatik oluştur
                eklemeListesi.DataSource = dataTable; // DataTable'ı bağla
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veriler yüklenirken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Kitap ekleme işlemi
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Kullanıcıdan alınan değerler
                string kitapAd = textBox1.Text;
                string kategoriAd = textBox2.Text;
                short baskiNo = Convert.ToInt16(textBox3.Text);
                string ISBN = textBox4.Text;
                decimal gelisFiyat = Convert.ToDecimal(textBox5.Text);
                byte kutuphaneID = Convert.ToByte(textBox7.Text);
                bool raftaDurum = textBox8.Text.ToLower() == "true";
                string yazarAd = textBox9.Text;
                string yazarSoyad = textBox10.Text;
                DateTime basimYil = Convert.ToDateTime(textBox11.Text);
                int sayfaSayi = Convert.ToInt32(textBox12.Text);
                string yayinEvi = textBox13.Text;

                // Stored Procedure çağrısı
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("KitapEkle", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@kitapAd", kitapAd);
                        cmd.Parameters.AddWithValue("@kategoriAd", kategoriAd);
                        cmd.Parameters.AddWithValue("@baskiNo", baskiNo);
                        cmd.Parameters.AddWithValue("@ISBN", ISBN);
                        cmd.Parameters.AddWithValue("@gelisFiyat", gelisFiyat);
                        cmd.Parameters.AddWithValue("@kutuphaneID", kutuphaneID);
                        cmd.Parameters.AddWithValue("@raftaDurum", raftaDurum);
                        cmd.Parameters.AddWithValue("@yazarAd", yazarAd);
                        cmd.Parameters.AddWithValue("@yazarSoyad", yazarSoyad);
                        cmd.Parameters.AddWithValue("@basimYil", basimYil);
                        cmd.Parameters.AddWithValue("@sayfaSayi", sayfaSayi);
                        cmd.Parameters.AddWithValue("@yayinEvi", yayinEvi);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Kitap başarıyla eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Listeyi güncelle
                ListeyiYenile();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Formdaki "Kapat" butonu
        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void eklemeListesi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                // Kullanıcıdan Demirbaş ID'sini alıyoruz
                int demirbasID;
                if (int.TryParse(textBox27.Text, out demirbasID)) // Demirbaş ID'nin geçerli bir sayı olup olmadığını kontrol ediyoruz
                {
                    // Veritabanı bağlantısı
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();

                        // KitapSil prosedürünü çağıran komut
                        using (SqlCommand cmd = new SqlCommand("KitapSil", conn))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;

                            // Demirbaş ID'sini parametre olarak ekliyoruz
                            cmd.Parameters.AddWithValue("@demirbasID", demirbasID);

                            // Stored procedure'ü çalıştırıyoruz
                            cmd.ExecuteNonQuery();
                        }
                    }

                    // İşlem başarılıysa kullanıcıya bilgi ver
                    MessageBox.Show("Kitap başarıyla silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Listeyi güncelle (silme sonrası verileri yenile)
                    ListeyiYenile();
                }
                else
                {
                    // Geçersiz ID için kullanıcıyı uyar
                    MessageBox.Show("Geçerli bir Demirbaş ID giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                // Hata durumunda kullanıcıya bilgi ver
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            // Get the book name from the TextBox (assuming it's named txtKitapAd)
            string kitapAd = textBox28.Text;

            // Call the stored procedure
            CallStoredProcedure(kitapAd);
        }

        private void CallStoredProcedure(string kitapAd)
        {
            // Define the connection string
            string connectionString = "Server=DESKTOP-K7MCDTS\\RUMEYSA;Database=kitapIslemleri;Trusted_Connection=True"; // Make sure to replace this with your actual connection string

            // Create a new connection to the database
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    // Open the connection
                    conn.Open();

                    // Create a command to call the stored procedure
                    SqlCommand cmd = new SqlCommand("KitapAdAra", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Add the @kitapAd parameter to the stored procedure
                    cmd.Parameters.AddWithValue("@kitapAd", kitapAd);

                    // Create a data adapter to fill the DataGridView with the results
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Bind the DataTable to the DataGridView to display the results
                    dataGridView1.DataSource = dt; // Change to your DataGridView name
                }
                catch (Exception ex)
                {
                    // If there is an error, show an error message
                    MessageBox.Show("Bir hata oluştu: " + ex.Message);
                }
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            // Satırda herhangi bir hücreye tıklandığında
            if (e.RowIndex >= 0) // Yalnızca geçerli bir satıra tıklanmışsa
            {
                // DataGridView'deki tıklanan satırdaki verileri al
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Tıklanan satırdaki hücre değerlerini TextBox'lara aktar
                textBox28.Text = row.Cells["kitapAd"].Value?.ToString();    // Kitap adı
                textBox2.Text = row.Cells["kategoriAd"].Value?.ToString();   // Kategori Adı
                textBox3.Text = row.Cells["baskiNo"].Value?.ToString();      // Baskı No
                textBox4.Text = row.Cells["ISBN"].Value?.ToString();         // ISBN
                textBox5.Text = row.Cells["gelisFiyat"].Value?.ToString();   // Geliş Fiyat
                textBox6.Text = row.Cells["kutuphaneID"].Value?.ToString();  // Kütüphane ID
                textBox7.Text = row.Cells["raftaDurum"].Value?.ToString();  // Rafta Durum
                textBox8.Text = row.Cells["yazarAd"].Value?.ToString();     // Yazar Adı
                textBox9.Text = row.Cells["yazarSoyad"].Value?.ToString();  // Yazar Soyadı
                textBox10.Text = row.Cells["basimYil"].Value?.ToString();   // Basım Yılı
                textBox11.Text = row.Cells["sayfaSayi"].Value?.ToString();  // Sayfa Sayısı
                textBox12.Text = row.Cells["yayinEvi"].Value?.ToString();   // Yayın Evi
            }
        }


        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                // Kullanıcıdan alınan veriler (TextBox'lar üzerinden)
                int demirbasID = Convert.ToInt32(textBox27.Text);  // Demirbaş ID
                string kitapAd = textBox26.Text;  // Kitap adı
                string kategoriAd = textBox25.Text;  // Kategori adı
                short baskiNo = Convert.ToInt16(textBox24.Text);  // Baskı No
                string ISBN = textBox23.Text;  // ISBN
                decimal gelisFiyat = Convert.ToDecimal(textBox22.Text);  // Geliş Fiyatı
                byte kutuphaneID = Convert.ToByte(textBox20.Text);  // Kütüphane ID
                string yazarAd = textBox18.Text;  // Yazar Adı
                string yazarSoyad = textBox17.Text;  // Yazar Soyadı
                DateTime basimYil = Convert.ToDateTime(textBox16.Text);  // Basım Yılı
                int sayfaSayi = Convert.ToInt32(textBox15.Text);  // Sayfa Sayısı
                string yayinEvi = textBox14.Text;  // Yayın Evi
                bool raftaDurum = Convert.ToBoolean(textBox19.Text);

                // KitapGuncelle prosedürünü çağırma
                KitapGuncelle(demirbasID, kitapAd, kategoriAd, baskiNo, ISBN, gelisFiyat, kutuphaneID, yazarAd, yazarSoyad, basimYil, sayfaSayi, yayinEvi, raftaDurum);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void KitapGuncelle(int demirbasID, string kitapAd, string kategoriAd, short baskiNo, string ISBN, decimal gelisFiyat, byte kutuphaneID, string yazarAd, string yazarSoyad, DateTime basimYil, int sayfaSayi, string yayinEvi, bool raftaDurum)
        {
            try
            {
                // Veritabanı bağlantısı
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // KitapGuncelle prosedürünü çağırma
                    using (SqlCommand cmd = new SqlCommand("KitapGuncelle", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Parametreleri ekliyoruz
                        cmd.Parameters.AddWithValue("@demirbasID", demirbasID);
                        cmd.Parameters.AddWithValue("@kitapAd", kitapAd);
                        cmd.Parameters.AddWithValue("@kategoriAd", kategoriAd);
                        cmd.Parameters.AddWithValue("@baskiNo", baskiNo);
                        cmd.Parameters.AddWithValue("@ISBN", ISBN);
                        cmd.Parameters.AddWithValue("@gelisFiyat", gelisFiyat);
                        cmd.Parameters.AddWithValue("@kutuphaneID", kutuphaneID);
                        cmd.Parameters.AddWithValue("@yazarAd", yazarAd);
                        cmd.Parameters.AddWithValue("@yazarSoyad", yazarSoyad);
                        cmd.Parameters.AddWithValue("@basimYil", basimYil);
                        cmd.Parameters.AddWithValue("@sayfaSayi", sayfaSayi);
                        cmd.Parameters.AddWithValue("@yayinEvi", yayinEvi);
                        cmd.Parameters.AddWithValue("@raftaDurum", raftaDurum); // Rafta Durum (1: işaretli, 0: işaretsiz)

                        // Prosedürü çalıştırıyoruz
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Kitap başarıyla güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load_(object sender, EventArgs e)
        {

        }

        private void textBox28_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void buttonListele_Click(object sender, EventArgs e)
        {
            ListeyiYenile();
        }




        private void buttonVeriCek_Click(object sender, EventArgs e)
        {
            try
            {
                // Veritabanından veri çekme
                string query = "SELECT kitapAd, kategoriAd, baskiNo, ISBN, gelisFiyat, kutuphaneID, raftaDurum, yazarAd, yazarSoyad, basimYil, sayfaSayi, yayinEvi FROM Kitap";
                DataTable dataTable = new DataTable();

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn))
                    {
                        dataAdapter.Fill(dataTable); // Veriyi DataTable'a doldur
                    }
                }

                // Excel uygulaması başlat
                Excel.Application excelApp = new Excel.Application();
                excelApp.Visible = true;

                // Yeni bir Excel çalışma kitabı oluştur
                Excel.Workbook workbook = excelApp.Workbooks.Add();
                Excel.Worksheet worksheet = workbook.Sheets[1];
                worksheet.Name = "Kitap Verileri";

                // Sütun başlıklarını ekle
                for (int i = 0; i < dataTable.Columns.Count; i++)
                {
                    worksheet.Cells[1, i + 1] = dataTable.Columns[i].ColumnName;
                }

                // Veriyi Excel hücrelerine aktar
                for (int row = 0; row < dataTable.Rows.Count; row++)
                {
                    for (int col = 0; col < dataTable.Columns.Count; col++)
                    {
                        worksheet.Cells[row + 2, col + 1] = dataTable.Rows[row][col].ToString();
                    }
                }

                // Kullanıcıya başarı mesajı
                MessageBox.Show("Veriler Excel'e başarıyla aktarıldı.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonVeriAl_Click(object sender, EventArgs e)
        {
            try
            {
                // Excel dosyasını açmak için dosya seçme penceresi
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
                openFileDialog.Title = "Excel Dosyasını Seçin";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;

                    // Excel uygulamasını başlat
                    Excel.Application excelApp = new Excel.Application();
                    Excel.Workbook workbook = excelApp.Workbooks.Open(filePath);
                    Excel.Worksheet worksheet = workbook.Sheets[1];
                    Excel.Range range = worksheet.UsedRange;

                    // Excel verilerini DataTable'a aktarma
                    DataTable dataTable = new DataTable();
                    for (int col = 1; col <= range.Columns.Count; col++)
                    {
                        dataTable.Columns.Add(range.Cells[1, col].Value2.ToString());
                    }

                    // Verileri satır satır ekle
                    for (int row = 2; row <= range.Rows.Count; row++)
                    {
                        DataRow newRow = dataTable.NewRow();
                        for (int col = 1; col <= range.Columns.Count; col++)
                        {
                            newRow[col - 1] = range.Cells[row, col].Value2?.ToString();
                        }
                        dataTable.Rows.Add(newRow);
                    }

                    // Veritabanına verileri ekleme
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        foreach (DataRow row in dataTable.Rows)
                        {
                            using (SqlCommand cmd = new SqlCommand("KitapEkle", conn))
                            {
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.AddWithValue("@kitapAd", row["kitapAd"]);
                                cmd.Parameters.AddWithValue("@kategoriAd", row["kategoriAd"]);
                                cmd.Parameters.AddWithValue("@baskiNo", Convert.ToInt16(row["baskiNo"]));
                                cmd.Parameters.AddWithValue("@ISBN", row["ISBN"]);
                                cmd.Parameters.AddWithValue("@gelisFiyat", Convert.ToDecimal(row["gelisFiyat"]));
                                cmd.Parameters.AddWithValue("@kutuphaneID", Convert.ToByte(row["kutuphaneID"]));
                                cmd.Parameters.AddWithValue("@raftaDurum", Convert.ToBoolean(row["raftaDurum"]));
                                cmd.Parameters.AddWithValue("@yazarAd", row["yazarAd"]);
                                cmd.Parameters.AddWithValue("@yazarSoyad", row["yazarSoyad"]);
                                cmd.Parameters.AddWithValue("@basimYil", Convert.ToDateTime(row["basimYil"]));
                                cmd.Parameters.AddWithValue("@sayfaSayi", Convert.ToInt32(row["sayfaSayi"]));
                                cmd.Parameters.AddWithValue("@yayinEvi", row["yayinEvi"]);

                                cmd.ExecuteNonQuery();
                            }
                        }
                    }

                    // Kullanıcıya başarı mesajı
                    MessageBox.Show("Veriler veritabanına başarıyla aktarıldı.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }




}
    

