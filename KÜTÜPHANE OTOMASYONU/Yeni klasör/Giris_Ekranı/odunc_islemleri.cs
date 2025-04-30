using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Giris_Ekranı
{
    public partial class odunc_islemleri : Form
    {

        SqlDataReader dr;
        SqlCommand com;

        public string kullaniciTipi { get; set; }  // Kullanıcı tipi (Admin veya Personel)
        public odunc_islemleri()
        {
            InitializeComponent();
        }

 

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa = (Anasayfa)Application.OpenForms["Anasayfa"];
            if (anasayfa != null)
            {
                anasayfa.Show();
            }
            this.Close(); // Kullanıcı işlemleri formunu kapat
        }

        private void uyeAdSoyadAra_Click_1(object sender, EventArgs e)
        {
            try
            {
                // TextBox'lardan üye adı ve soyadını al
                string uyeKullaniciAd = uyeAd.Text.Trim();  // uyeAdTextBox, TextBox adı
                string uyeKullaniciSoyad = uyeSoyad.Text.Trim();  // uyeSoyadTextBox, TextBox adı

                // Prosedürü çağır ve bağlantıyı helper üzerinden oluştur
                using (SqlConnection con = SqlHelper.GetConnection())
                {
                    com = new SqlCommand("dbo.UyeAdSoyadAra", con);
                    com.CommandType = CommandType.StoredProcedure;

                    // Parametreleri ekle
                    com.Parameters.AddWithValue("@uyeKullaniciAd", uyeKullaniciAd);
                    com.Parameters.AddWithValue("@uyeKullaniciSoyad", uyeKullaniciSoyad);

                    // Veriyi al ve DataGridView'e aktar
                    SqlDataAdapter da = new SqlDataAdapter(com);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    uyeAdSoyadListele.DataSource = dt;

                    // Eşleşen üye bulunamadıysa kullanıcıya uyarı göster
                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("Eşleşen üye bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("Üyeler başarıyla listelendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                // Hata durumunda mesaj göster
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void kitapAdAra_Click_1(object sender, EventArgs e)
        {
            try
            {
                // SqlHelper sınıfını kullanarak bağlantıyı al
                using (SqlConnection con = SqlHelper.GetConnection())
                {
                    string kitapAdi = kitapAd.Text.Trim();

                    // Prosedürü çağır
                    using (SqlCommand com = new SqlCommand("KitapAdAra", con))
                    {
                        com.CommandType = CommandType.StoredProcedure;
                        com.Parameters.AddWithValue("@kitapAd", kitapAdi);

                        // Veriyi al ve DataGridView'e aktar
                        using (SqlDataAdapter da = new SqlDataAdapter(com))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            kitapListele.DataSource = dt;
                        }
                    }

                    // raftaDurum sütununu ReadOnly yaparak tıklanmasını engelle
                    if (kitapListele.Columns.Contains("raftaDurum"))
                    {
                        kitapListele.Columns["raftaDurum"].ReadOnly = true; // ReadOnly'yi true yaparak tıklanmasını engelle
                    }

                    MessageBox.Show("Kitaplar başarıyla listelendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void islemkayitEkle_Click_1(object sender, EventArgs e)
        {

            // adminID ve personelID TextBox'larının kontrolü
            if (!string.IsNullOrEmpty(adminID.Text) && !string.IsNullOrEmpty(personelID.Text))
            {
                MessageBox.Show("Hem adminID hem personelID aynı anda dolu olamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(adminID.Text) && string.IsNullOrEmpty(personelID.Text))
            {
                MessageBox.Show("En az bir adminID ya da personelID girilmelidir.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // SqlHelper sınıfını kullanarak bağlantıyı al
                using (SqlConnection con = SqlHelper.GetConnection())
                {
                    // SQL komut nesnesini oluştur
                    using (SqlCommand com = new SqlCommand("InsertIslemKaydi", con))
                    {
                        com.CommandType = CommandType.StoredProcedure;

                        // adminID ve personelID'yi kontrol et
                        com.Parameters.AddWithValue("@adminID", string.IsNullOrEmpty(adminID.Text) ? (object)DBNull.Value : adminID.Text);
                        com.Parameters.AddWithValue("@personelID", string.IsNullOrEmpty(personelID.Text) ? (object)DBNull.Value : personelID.Text);
                        com.Parameters.AddWithValue("@demirbasID", demirbasID.Text); // demirbasID TextBox'tan alınır
                        com.Parameters.AddWithValue("@uyeID", uyeID.Text); // uyeID TextBox'tan alınır

                        // Prosedürü çalıştır
                        com.ExecuteNonQuery();

                        // Başarılı mesajı
                        MessageBox.Show("İşlem kaydı başarıyla oluşturuldu ve ilgili kitap rafDurumu güncellendi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                // Hata durumunda mesaj göster
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void oduncKitapListesi_Click_1(object sender, EventArgs e)
        {
            // Prosedür adı
            string query = "OduncVermeIslemKayitlari"; // Daha önce oluşturduğunuz prosedür ismi

            try
            {
                // SqlHelper sınıfını kullanarak bağlantıyı al
                using (SqlConnection con = SqlHelper.GetConnection())
                {
                    // SQL komut nesnesi
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Veri okuyucu
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            // Geçici DataTable oluştur
                            DataTable dataTable = new DataTable();
                            dataTable.Load(reader);

                            // DataGridView'e veri bağla
                            islemKaydiListele.DataSource = dataTable;
                        }
                    }


                    // Başarı mesajı
                    MessageBox.Show("Ödünç verilen kitaplar başarıyla listelendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // Hata mesajı
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Anasayfa anasayfa = (Anasayfa)Application.OpenForms["Anasayfa"];
            if (anasayfa != null)
            {
                anasayfa.Show();
            }
            this.Close(); // Üye işlemleri formunu kapat
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void uyeAdSoyadAraTeslim_Click_1(object sender, EventArgs e)
        {

            try
            {
                // TextBox'lardan üye adı ve soyadını al
                string uyeKullaniciAd = uyeAdTeslim.Text.Trim();  // uyeAdTextBox, TextBox adı
                string uyeKullaniciSoyad = uyeSoyadTeslim.Text.Trim();  // uyeSoyadTextBox, TextBox adı

                // SqlHelper sınıfını kullanarak bağlantıyı al
                using (SqlConnection con = SqlHelper.GetConnection())
                {
                    // Prosedürü çağır
                    using (SqlCommand com = new SqlCommand("dbo.UyeAdSoyadAra", con))
                    {
                        com.CommandType = CommandType.StoredProcedure;

                        // Parametreleri ekle
                        com.Parameters.AddWithValue("@uyeKullaniciAd", uyeKullaniciAd);
                        com.Parameters.AddWithValue("@uyeKullaniciSoyad", uyeKullaniciSoyad);

                        // Veriyi al ve DataGridView'e aktar
                        using (SqlDataAdapter da = new SqlDataAdapter(com))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            uyeAdSoyadListeleTeslim.DataSource = dt;

                            // Eşleşen üye bulunamadıysa kullanıcıya uyarı göster
                            if (dt.Rows.Count == 0)
                            {
                                MessageBox.Show("Eşleşen üye bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else
                            {
                                MessageBox.Show("Üyeler başarıyla listelendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Hata durumunda mesaj göster
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void kitapAdAraTeslim_Click_1(object sender, EventArgs e)
        {
            try
            {
                // TextBox'tan kitap adını al ve temizle
                string kitapAdi = kitapAdTeslim.Text.Trim();

                // SqlHelper sınıfını kullanarak bağlantıyı al
                using (SqlConnection con = SqlHelper.GetConnection())
                {
                    // Prosedürü çağır
                    using (SqlCommand com = new SqlCommand("KitapAdAra", con))
                    {
                        com.CommandType = CommandType.StoredProcedure;

                        // Parametre ekle
                        com.Parameters.AddWithValue("@kitapAd", kitapAdi);

                        // Veriyi al ve DataGridView'e aktar
                        using (SqlDataAdapter da = new SqlDataAdapter(com))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            kitapAdListeleTeslim.DataSource = dt;

                            // "raftaDurum" sütununu ReadOnly yap
                            if (kitapAdListeleTeslim.Columns.Contains("raftaDurum"))
                            {
                                kitapAdListeleTeslim.Columns["raftaDurum"].ReadOnly = true;
                            }
                        }
                    }
                }

                // Başarı mesajı
                MessageBox.Show("Kitaplar başarıyla listelendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Hata mesajı
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void iadeAlTeslim_Click_1(object sender, EventArgs e)
        {
            // adminID ve personelID TextBox'larının kontrolü
            if (!string.IsNullOrEmpty(adminIDTeslim.Text) && !string.IsNullOrEmpty(personelIDTeslim.Text))
            {
                MessageBox.Show("Hem adminID hem personelID aynı anda dolu olamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(adminIDTeslim.Text) && string.IsNullOrEmpty(personelIDTeslim.Text))
            {
                MessageBox.Show("En az bir adminID ya da personelID girilmelidir.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // SqlHelper sınıfını kullanarak bağlantıyı al
                using (SqlConnection con = SqlHelper.GetConnection())
                {
                    // SQL komut nesnesini oluştur
                    using (SqlCommand com = new SqlCommand("UpdateIslemKaydi", con))
                    {
                        com.CommandType = CommandType.StoredProcedure;

                        // adminID ve personelID'yi kontrol et
                        com.Parameters.AddWithValue("@adminID", string.IsNullOrEmpty(adminIDTeslim.Text) ? (object)DBNull.Value : adminIDTeslim.Text);
                        com.Parameters.AddWithValue("@personelID", string.IsNullOrEmpty(personelIDTeslim.Text) ? (object)DBNull.Value : personelIDTeslim.Text);
                        com.Parameters.AddWithValue("@demirbasID", demirbasIDTeslim.Text); // demirbasID TextBox'tan alınır
                        com.Parameters.AddWithValue("@uyeID", uyeIDTeslim.Text); // uyeID TextBox'tan alınır

                        // Prosedürü çalıştır
                        com.ExecuteNonQuery();
                    }

                    // Başarılı mesajı
                    MessageBox.Show("İade işlemi başarıyla tamamlandı ve ilgili demirbaş rafta olarak güncellendi.",
                                    "Başarılı",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // Hata durumunda mesaj göster
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void iadeKayitListele_Click_1(object sender, EventArgs e)
        {
            try
            {
                // SqlHelper kullanarak bağlantıyı al
                using (SqlConnection con = SqlHelper.GetConnection())
                {
                    // SQL komut nesnesini oluştur
                    using (SqlCommand com = new SqlCommand("İadeListeleIslemKayitlari", con))
                    {
                        com.CommandType = CommandType.StoredProcedure;

                        // Veri okuma ve DataGrid'e bağlama
                        using (SqlDataAdapter da = new SqlDataAdapter(com))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);

                            // DataGridView'e veri bağlama
                            islemKayitListeleTeslim.DataSource = dt;

                            // DataGrid sütun başlıklarını düzenleyebilirsiniz
                            if (islemKayitListeleTeslim.Columns.Contains("adminID"))
                                islemKayitListeleTeslim.Columns["adminID"].HeaderText = "Admin ID";

                            if (islemKayitListeleTeslim.Columns.Contains("personelID"))
                                islemKayitListeleTeslim.Columns["personelID"].HeaderText = "Personel ID";

                            if (islemKayitListeleTeslim.Columns.Contains("uyeID"))
                                islemKayitListeleTeslim.Columns["uyeID"].HeaderText = "Üye ID";

                            if (islemKayitListeleTeslim.Columns.Contains("uyeKullaniciAd"))
                                islemKayitListeleTeslim.Columns["uyeKullaniciAd"].HeaderText = "Üye Adı";

                            if (islemKayitListeleTeslim.Columns.Contains("uyeKullaniciSoyad"))
                                islemKayitListeleTeslim.Columns["uyeKullaniciSoyad"].HeaderText = "Üye Soyadı";

                            if (islemKayitListeleTeslim.Columns.Contains("demirbasID"))
                                islemKayitListeleTeslim.Columns["demirbasID"].HeaderText = "Demirbaş ID";

                            if (islemKayitListeleTeslim.Columns.Contains("kitapAd"))
                                islemKayitListeleTeslim.Columns["kitapAd"].HeaderText = "Kitap Adı";

                            if (islemKayitListeleTeslim.Columns.Contains("iadeTarih"))
                                islemKayitListeleTeslim.Columns["iadeTarih"].HeaderText = "İade Tarihi";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Hata durumunda mesaj göster
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      
    }
    }
    

