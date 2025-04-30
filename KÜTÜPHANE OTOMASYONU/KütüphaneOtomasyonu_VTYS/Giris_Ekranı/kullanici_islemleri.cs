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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Giris_Ekranı
{
    public partial class kullanici_islemleri : Form
    {

        SqlDataReader dr;
        SqlCommand com;

        public string kullaniciTipi { get; set; }  // Kullanıcı tipi (Admin veya Personel)
        public kullanici_islemleri()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetAdminData();
        }

        private void GetAdminData()
        {
            // SQL sorgusu için Command nesnesi oluşturuyoruz
            string storedProcedure = "AdminleriListele"; // Prosedür ismini yazıyoruz
            using (SqlConnection connection = SqlHelper.GetConnection()) // SqlHelper sınıfını kullanarak bağlantıyı alıyoruz
            {
                try
                {
                    // SqlCommand nesnesi ile prosedür çağrısı
                    using (SqlCommand cmd = new SqlCommand(storedProcedure, connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // DataAdapter kullanarak veriyi çekiyoruz
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();

                        // Veriyi DataTable'a dolduruyoruz
                        dataAdapter.Fill(dataTable);

                        // DataGridView'e veriyi bağlıyoruz
                        dataGridView1.DataSource = dataTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veri alınırken bir hata oluştu: " + ex.Message);
                }
            }




        }

        private void btnAdminEkle_Click(object sender, EventArgs e)
        {
            string adminAd = txtAdminAd.Text;
            string adminSoyad = txtAdminSoyad.Text;
            string adminSifre = txtAdminSifre.Text;
            string adminTcNo = txtAdminTcNo.Text;
            string adminEposta = txtAdminEposta.Text;
            string adminCepTelefon = txtAdminCepTelefon.Text;
            string adminAdres = txtAdminAdres.Text;

            try
            {
                // Cep telefonu numarası doğrulaması: 5 ile başlama ve 10 karakter olma
                if (!adminCepTelefon.StartsWith("5") || adminCepTelefon.Length != 10 || !adminCepTelefon.All(char.IsDigit))
                {
                    MessageBox.Show("Cep telefon numarası 5 ile başlamalı ve 10 haneli olmalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Şifre doğrulaması: Minimum 8 karakter, büyük harf, küçük harf ve rakam içermeli
                if (adminSifre.Length < 8 || !adminSifre.Any(char.IsDigit) || !adminSifre.Any(char.IsUpper) || !adminSifre.Any(char.IsLower))
                {
                    MessageBox.Show("Şifre en az 8 karakter olmalı, bir büyük harf, bir küçük harf ve bir rakam içermelidir.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // TC Kimlik Numarası doğrulaması: 11 haneli olmalı
                if (adminTcNo.Length != 11 || !adminTcNo.All(char.IsDigit))
                {
                    MessageBox.Show("TC Kimlik Numarası 11 haneli olmalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Eposta doğrulaması: Eposta @gmail.com ile bitmeli
                if (!adminEposta.EndsWith("@gmail.com"))
                {
                    MessageBox.Show("Eposta adresi @gmail.com ile bitmelidir.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Veritabanı kontrolü için bağlantı aç
                using (SqlConnection connection = SqlHelper.GetConnection()) // SqlHelper sınıfını kullanarak bağlantıyı alıyoruz
                {
                    // Mevcut kayıtları kontrol et
                    using (SqlCommand kontrolKomut = new SqlCommand(@"
                SELECT COUNT(*) 
                FROM Admin 
                WHERE adminTcNo = @adminTcNo OR adminEposta = @adminEposta OR adminCepTelefon = @adminCepTelefon", connection))
                    {
                        kontrolKomut.Parameters.AddWithValue("@adminTcNo", adminTcNo);
                        kontrolKomut.Parameters.AddWithValue("@adminEposta", adminEposta);
                        kontrolKomut.Parameters.AddWithValue("@adminCepTelefon", adminCepTelefon);

                        int kayitSayisi = (int)kontrolKomut.ExecuteScalar();

                        if (kayitSayisi > 0)
                        {
                            // Çakışma detayını kontrol et
                            using (SqlCommand detayKomut = new SqlCommand(@"
                        SELECT 
                            CASE 
                                WHEN adminTcNo = @adminTcNo THEN 'TC kimlik numarası'
                                WHEN adminEposta = @adminEposta THEN 'E-posta adresi'
                                WHEN adminCepTelefon = @adminCepTelefon THEN 'Cep telefon numarası'
                            END AS HataNedeni
                        FROM Admin
                        WHERE adminTcNo = @adminTcNo OR adminEposta = @adminEposta OR adminCepTelefon = @adminCepTelefon", connection))
                            {
                                detayKomut.Parameters.AddWithValue("@adminTcNo", adminTcNo);
                                detayKomut.Parameters.AddWithValue("@adminEposta", adminEposta);
                                detayKomut.Parameters.AddWithValue("@adminCepTelefon", adminCepTelefon);

                                string hataNedeni = (string)detayKomut.ExecuteScalar();

                                MessageBox.Show($"{hataNedeni} zaten kayıtlı. Güncelleme yapabilirsiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                    }

                    // Eğer çakışma yoksa AdminEkle prosedürünü çağır
                    using (SqlCommand cmd = new SqlCommand("AdminEkle", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Parametreleri ekle
                        cmd.Parameters.AddWithValue("@adminAd", adminAd);
                        cmd.Parameters.AddWithValue("@adminSoyad", adminSoyad);
                        cmd.Parameters.AddWithValue("@adminSifre", adminSifre);
                        cmd.Parameters.AddWithValue("@adminTcNo", adminTcNo);
                        cmd.Parameters.AddWithValue("@adminEposta", adminEposta);
                        cmd.Parameters.AddWithValue("@adminCepTelefon", adminCepTelefon);
                        cmd.Parameters.AddWithValue("@adminAdres", adminAdres);

                        // Prosedürü çalıştır
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Admin başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btniptal_Click(object sender, EventArgs e)
        {
            {
                var result = MessageBox.Show(
            "Admin Ekle işlemini iptal etmek istediğinizden emin misiniz?",
            "İptal Onayı",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

                // Eğer kullanıcı "Evet" derse
                if (result == DialogResult.Yes)
                {
                    // Ana sayfa formunu aç
                     Anasayfa anaSayfa = new Anasayfa(); 
                     anaSayfa.Show(); 

                    // Güncelleme formunu kapat
                    this.Close();
                }
            }
        }

        private void butonara_Click(object sender, EventArgs e)
        {
            try
            {
                // TextBox'lardan admin adı ve soyadını al
                string adminAd = txtAd.Text.Trim();  // adminAdTextBox: Admin adını almak için kullanılan TextBox
                string adminSoyad = txtSoyad.Text.Trim();  // adminSoyadTextBox: Admin soyadını almak için kullanılan TextBox

                // SQL komutunu oluştur ve saklı prosedürü çağır
                using (SqlConnection baglanti = SqlHelper.GetConnection()) // SqlHelper sınıfını kullanarak bağlantıyı alıyoruz
                {
                  

                    SqlCommand com = new SqlCommand("dbo.AdminAdSoyadAra", baglanti);
                    com.CommandType = CommandType.StoredProcedure;

                    // Parametreler boşsa, bunları null olarak gönder
                    if (string.IsNullOrEmpty(adminAd))
                    {
                        com.Parameters.AddWithValue("@adminAd", DBNull.Value);
                    }
                    else
                    {
                        com.Parameters.AddWithValue("@adminAd", adminAd);
                    }

                    if (string.IsNullOrEmpty(adminSoyad))
                    {
                        com.Parameters.AddWithValue("@adminSoyad", DBNull.Value);
                    }
                    else
                    {
                        com.Parameters.AddWithValue("@adminSoyad", adminSoyad);
                    }

                    // Veriyi al ve DataGridView'e aktar
                    SqlDataAdapter da = new SqlDataAdapter(com);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dtvAra.DataSource = dt;  // DataGridView'e veriyi bağla

                    // Eşleşen admin bulunamadıysa kullanıcıya uyarı göster
                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("Eşleşen admin bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("Adminler başarıyla listelendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                // Hata durumunda mesaj göster
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdminGuncelle_Click(object sender, EventArgs e)
        {
            // Formdaki verileri al
            int adminID = int.Parse(txtAdminID.Text.Trim());
            string adminad = adminAd.Text.Trim();
            string adminsoyad = adminSoyad.Text.Trim();
            string adminsifre = adminSifre.Text.Trim();
            string admintcno = adminTcNo.Text.Trim();
            string admineposta = adminEposta.Text.Trim();
            string adminceptelefon = adminCepTelefon.Text.Trim();
            string adminadres = adminAdres.Text.Trim();

            try
            {
                // Cep telefonu numarası doğrulaması: 5 ile başlama ve 10 karakter olma
                if (!adminceptelefon.StartsWith("5") || adminceptelefon.Length != 10 || !adminceptelefon.All(char.IsDigit))
                {
                    MessageBox.Show("Cep telefon numarası 5 ile başlamalı ve 10 haneli olmalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Şifre doğrulaması: Minimum 8 karakter, büyük harf, küçük harf ve rakam içermeli
                if (adminsifre.Length < 8 || !adminsifre.Any(char.IsDigit) || !adminsifre.Any(char.IsUpper) || !adminsifre.Any(char.IsLower))
                {
                    MessageBox.Show("Şifre en az 8 karakter olmalı, bir büyük harf, bir küçük harf ve bir rakam içermelidir.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // TC Kimlik Numarası doğrulaması: 11 haneli olmalı
                if (admintcno.Length != 11 || !admintcno.All(char.IsDigit))
                {
                    MessageBox.Show("TC Kimlik Numarası 11 haneli olmalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Eposta doğrulaması: Eposta @gmail.com ile bitmeli
                if (!admineposta.EndsWith("@gmail.com"))
                {
                    MessageBox.Show("Eposta adresi @gmail.com ile bitmelidir.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // SQL bağlantı dizesi ve veritabanı kontrolü
                using (SqlConnection baglanti = SqlHelper.GetConnection()) // SqlHelper sınıfını kullanarak bağlantıyı alıyoruz
                {
                    

                    // Mevcut adminin bilgilerini al
                    string existingAdminTcNo = "";
                    string existingAdminEposta = "";
                    string existingAdminCepTelefon = "";

                    using (SqlCommand command = new SqlCommand("SELECT adminTcNo, adminEposta, adminCepTelefon FROM Admin WHERE adminID = @adminID", baglanti))
                    {
                        command.Parameters.AddWithValue("@adminID", adminID);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                existingAdminTcNo = reader["adminTcNo"].ToString();
                                existingAdminEposta = reader["adminEposta"].ToString();
                                existingAdminCepTelefon = reader["adminCepTelefon"].ToString();
                            }
                        }
                    }

                    // TC Kimlik Numarası, Eposta ve Cep Telefonu üzerinde çakışma kontrolü
                    if (admintcno != existingAdminTcNo)
                    {
                        using (SqlCommand kontrolKomut = new SqlCommand("SELECT COUNT(*) FROM Admin WHERE adminTcNo = @adminTcNo AND adminID != @adminID", baglanti))
                        {
                            kontrolKomut.Parameters.AddWithValue("@adminTcNo", admintcno);
                            kontrolKomut.Parameters.AddWithValue("@adminID", adminID);
                            int kayitSayisi = (int)kontrolKomut.ExecuteScalar();

                            if (kayitSayisi > 0)
                            {
                                MessageBox.Show("Bu TC kimlik numarası zaten kayıtlı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                    }

                    if (admineposta != existingAdminEposta)
                    {
                        using (SqlCommand kontrolKomut = new SqlCommand("SELECT COUNT(*) FROM Admin WHERE adminEposta = @adminEposta AND adminID != @adminID", baglanti))
                        {
                            kontrolKomut.Parameters.AddWithValue("@adminEposta", admineposta);
                            kontrolKomut.Parameters.AddWithValue("@adminID", adminID);
                            int kayitSayisi = (int)kontrolKomut.ExecuteScalar();

                            if (kayitSayisi > 0)
                            {
                                MessageBox.Show("Bu e-posta adresi zaten kayıtlı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                    }

                    if (adminceptelefon != existingAdminCepTelefon)
                    {
                        using (SqlCommand kontrolKomut = new SqlCommand("SELECT COUNT(*) FROM Admin WHERE adminCepTelefon = @adminCepTelefon AND adminID != @adminID", baglanti))
                        {
                            kontrolKomut.Parameters.AddWithValue("@adminCepTelefon", adminceptelefon);
                            kontrolKomut.Parameters.AddWithValue("@adminID", adminID);
                            int kayitSayisi = (int)kontrolKomut.ExecuteScalar();

                            if (kayitSayisi > 0)
                            {
                                MessageBox.Show("Bu cep telefon numarası zaten kayıtlı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                    }

                    // Çakışma yoksa Admin bilgilerini güncelle
                    using (SqlCommand cmd = new SqlCommand("AdminGuncelle", baglanti))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Parametreleri ekle
                        cmd.Parameters.AddWithValue("@adminID", adminID);
                        cmd.Parameters.AddWithValue("@adminAd", adminad);
                        cmd.Parameters.AddWithValue("@adminSoyad", adminsoyad);
                        cmd.Parameters.AddWithValue("@adminSifre", adminsifre);
                        cmd.Parameters.AddWithValue("@adminTcNo", admintcno);
                        cmd.Parameters.AddWithValue("@adminEposta", admineposta);
                        cmd.Parameters.AddWithValue("@adminCepTelefon", adminceptelefon);
                        cmd.Parameters.AddWithValue("@adminAdres", adminadres);

                        // Prosedürü çalıştır ve işlem sonucunu kontrol et
                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Admin başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Admin güncellenirken bir sorun oluştu.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Ekstra bir işlem yapılması gerekirse burada yapılabilir
            }

            butonara_Click(sender, e);
        }

       

        private void btnSil_Click(object sender, EventArgs e)
        {
            // Kullanıcıdan adminID'yi al
            if (int.TryParse(txtAdminID.Text, out int adminID))
            {
                // Admin silme işlemini başlat
                SilAdmin(adminID);
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir admin ID giriniz.", "Geçersiz ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SilAdmin(int adminID)
        {
            try
            {
                // SQL prosedür adı
                string storedProcedure = "AdminSil";

                // SqlConnection'ı SqlHelper'dan alıyoruz
                using (var connection = SqlHelper.GetConnection())
                using (var command = new SqlCommand(storedProcedure, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Prosedür parametresini ekliyoruz
                    command.Parameters.AddWithValue("@adminID", adminID);

                    // Komutu çalıştır ve etkilenen satır sayısını al
                    int rowsAffected = command.ExecuteNonQuery();

                    // İşlem sonucunu kontrol et
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Admin başarıyla silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Admin silinemedi. Belirtilen ID bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                // Hata mesajı
                MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        //personel listele
        private void button2_Click(object sender, EventArgs e)
        {
            GetPersonelData();
        }

        private void GetPersonelData()
        {
            try
            {
                // Stored procedure adını belirtiyoruz
                string storedProcedure = "PersonelListele";

                // SqlConnection'ı SqlHelper'dan alıyoruz
                using (var connection = SqlHelper.GetConnection())
                using (var command = new SqlCommand(storedProcedure, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // DataAdapter kullanarak veriyi çekiyoruz
                    using (var dataAdapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();

                        // Veriyi DataTable'a dolduruyoruz
                        dataAdapter.Fill(dataTable);

                        // DataGridView'e veriyi bağlıyoruz
                        dataGridView2.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri alınırken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtvAra_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Yalnızca veri satırlarına tıklanmasını kontrol et
                if (e.RowIndex >= 0)
                {
                    // Satırdaki veriyle ilgili işlemleri burada yap
                    DataGridViewRow row = dtvAra.Rows[e.RowIndex];

                    // TextBox'lara verileri aktar
                    txtAdminID.Text = row.Cells["adminID"].Value.ToString();
                    adminAd.Text = row.Cells["adminAd"].Value.ToString();
                    adminSoyad.Text = row.Cells["adminSoyad"].Value.ToString();
                    adminSifre.Text = row.Cells["adminSifre"].Value.ToString();
                    adminTcNo.Text = row.Cells["adminTcNo"].Value.ToString();
                    adminEposta.Text = row.Cells["adminEposta"].Value.ToString();
                    adminCepTelefon.Text = row.Cells["adminCepTelefon"].Value.ToString();
                    adminAdres.Text = row.Cells["adminAdres"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                // Hata durumunda mesaj göster
                MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string personelAd = ad.Text.Trim();       // Personel Adı
            string personelSoyad = soyad.Text.Trim(); // Personel Soyadı
            string personelSifre = sifre.Text.Trim(); // Personel Şifresi
            string personelTcNo = tcno.Text.Trim();   // Personel TC Kimlik No
            string personelEposta = eposta.Text.Trim(); // Personel E-posta
            string personelCepTelefon = ceptelefon.Text.Trim(); // Personel Cep Telefonu
            string personelAdres = adres.Text.Trim();  // Personel Adresi

            try
            {
                // Cep telefonu numarası doğrulaması
                if (!personelCepTelefon.StartsWith("5") || personelCepTelefon.Length != 10 || !personelCepTelefon.All(char.IsDigit))
                {
                    MessageBox.Show("Cep telefon numarası 5 ile başlamalı ve 10 haneli olmalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Şifre doğrulaması
                if (personelSifre.Length < 8 || !personelSifre.Any(char.IsDigit) || !personelSifre.Any(char.IsUpper) || !personelSifre.Any(char.IsLower))
                {
                    MessageBox.Show("Şifre en az 8 karakter olmalı, bir büyük harf, bir küçük harf ve bir rakam içermelidir.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // TC Kimlik Numarası doğrulaması
                if (personelTcNo.Length != 11 || !personelTcNo.All(char.IsDigit))
                {
                    MessageBox.Show("TC Kimlik Numarası 11 haneli olmalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Eposta doğrulaması
                if (!personelEposta.EndsWith("@gmail.com"))
                {
                    MessageBox.Show("Eposta adresi @gmail.com ile bitmelidir.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (var baglanti = SqlHelper.GetConnection())
                {
                    // Mevcut kayıtları kontrol et
                    using (SqlCommand kontrolKomut = new SqlCommand(@"
SELECT COUNT(*) 
FROM Personel 
WHERE personelTcNo = @personelTcNo OR personelEposta = @personelEposta OR personelCepTelefon = @personelCepTelefon", baglanti))
                    {
                        kontrolKomut.Parameters.AddWithValue("@personelTcNo", personelTcNo);
                        kontrolKomut.Parameters.AddWithValue("@personelEposta", personelEposta);
                        kontrolKomut.Parameters.AddWithValue("@personelCepTelefon", personelCepTelefon);

                        int kayitSayisi = (int)kontrolKomut.ExecuteScalar();

                        if (kayitSayisi > 0)
                        {
                            MessageBox.Show("Bu bilgilerle kayıtlı bir personel zaten mevcut.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    // Çakışma yoksa PersonelEkle prosedürünü çağır
                    using (SqlCommand cmd = new SqlCommand("PersonelEkle", baglanti))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@personelAd", personelAd);
                        cmd.Parameters.AddWithValue("@personelSoyad", personelSoyad);
                        cmd.Parameters.AddWithValue("@personelSifre", personelSifre);
                        cmd.Parameters.AddWithValue("@personelTcNo", personelTcNo);
                        cmd.Parameters.AddWithValue("@personelEposta", personelEposta);
                        cmd.Parameters.AddWithValue("@personelCepTelefon", personelCepTelefon);
                        cmd.Parameters.AddWithValue("@personelAdres", personelAdres);

                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Personel başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Personel eklenirken bir sorun oluştu.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
        "Personel Ekleme işlemini iptal etmek istediğinizden emin misiniz?",
        "İptal Onayı",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question);

            // Eğer kullanıcı "Evet" derse
            if (result == DialogResult.Yes)
            {
                // Ana sayfa formunu aç
                Anasayfa anaSayfa = new Anasayfa();
                anaSayfa.Show();

                // Güncelleme formunu kapat
                this.Close();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                // SqlHelper sınıfı ile bağlantıyı al
                using (var baglanti = SqlHelper.GetConnection())
                {
                    // TextBox'lardan personel adı ve soyadını al
                    string personelAd = adara.Text.Trim();  // txtAd: Personel adını almak için kullanılan TextBox
                    string personelSoyad = soyadara.Text.Trim();  // txtSoyad: Personel soyadını almak için kullanılan TextBox

                    // SQL komutunu oluştur ve saklı prosedürü çağır
                    SqlCommand com = new SqlCommand("dbo.PersonelAdSoyadAra", baglanti);
                    com.CommandType = CommandType.StoredProcedure;

                    // Parametreler boşsa, bunları null olarak gönder
                    if (string.IsNullOrEmpty(personelAd))
                    {
                        com.Parameters.AddWithValue("@personelAd", DBNull.Value);
                    }
                    else
                    {
                        com.Parameters.AddWithValue("@personelAd", personelAd);
                    }

                    if (string.IsNullOrEmpty(personelSoyad))
                    {
                        com.Parameters.AddWithValue("@personelSoyad", DBNull.Value);
                    }
                    else
                    {
                        com.Parameters.AddWithValue("@personelSoyad", personelSoyad);
                    }

                    // Veriyi al ve DataGridView'e aktar
                    SqlDataAdapter da = new SqlDataAdapter(com);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView3.DataSource = dt;  // DataGridView'e veriyi bağla (dtvAra: DataGridView bileşeni)

                    // Eşleşen personel bulunamadıysa kullanıcıya uyarı göster
                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("Eşleşen personel bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("Personeller başarıyla listelendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                // Hata durumunda mesaj göster
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // Formdaki verileri al ve doğrula
            if (!int.TryParse(txtPersonelID.Text.Trim(), out int personelID))
            {
                MessageBox.Show("Personel ID geçerli bir sayı olmalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string personelAd = personelad.Text.Trim();
            string personelSoyad = personelsoyad.Text.Trim();
            string personelSifre = personelsifre.Text.Trim();
            string personelTcNo = personeltcno.Text.Trim();
            string personelEposta = personeleposta.Text.Trim();
            string personelCepTelefon = personelceptelefon.Text.Trim();
            string personelAdres = personeladres.Text.Trim();

            // Validasyon

            // TC Kimlik Numarası Validasyonu
            if (personelTcNo.Length != 11 || !personelTcNo.All(char.IsDigit))
            {
                MessageBox.Show("TC Kimlik Numarası 11 haneli ve sadece rakamlardan oluşmalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Cep Telefonu Validasyonu
            if (!personelCepTelefon.StartsWith("5") || personelCepTelefon.Length != 10 || !personelCepTelefon.All(char.IsDigit))
            {
                MessageBox.Show("Cep telefonu 5 ile başlamalı, 10 haneli olmalı ve sadece rakam içermelidir.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // E-posta Validasyonu
            if (!personelEposta.EndsWith("@gmail.com"))
            {
                MessageBox.Show("E-posta adresi @gmail.com ile bitmelidir.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Şifre Validasyonu
            if (personelSifre.Length < 8 ||
                !personelSifre.Any(char.IsUpper) ||
                !personelSifre.Any(char.IsLower) ||
                !personelSifre.Any(char.IsDigit))
            {
                MessageBox.Show("Şifre en az 8 karakter uzunluğunda, bir büyük harf, bir küçük harf ve bir rakam içermelidir.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // SQL bağlantısı ve prosedür çağırma
            using (var connection = SqlHelper.GetConnection())
            {
                try
                {
                    // Mevcut personel bilgilerini al
                    string existingPersonelTcNo = "";
                    string existingPersonelEposta = "";
                    string existingPersonelCepTelefon = "";

                    using (SqlCommand command = new SqlCommand("SELECT personelTcNo, personelEposta, personelCepTelefon FROM Personel WHERE personelID = @personelID", connection))
                    {
                        command.Parameters.AddWithValue("@personelID", personelID);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                existingPersonelTcNo = reader["personelTcNo"].ToString();
                                existingPersonelEposta = reader["personelEposta"].ToString();
                                existingPersonelCepTelefon = reader["personelCepTelefon"].ToString();
                            }
                        }
                    }

                    // TC Kimlik Numarası, Eposta ve Cep Telefonu üzerinde çakışma kontrolü
                    if (personelTcNo != existingPersonelTcNo)
                    {
                        using (SqlCommand kontrolKomut = new SqlCommand("SELECT COUNT(*) FROM Personel WHERE personelTcNo = @personelTcNo AND personelID != @personelID", connection))
                        {
                            kontrolKomut.Parameters.AddWithValue("@personelTcNo", personelTcNo);
                            kontrolKomut.Parameters.AddWithValue("@personelID", personelID);
                            int kayitSayisi = (int)kontrolKomut.ExecuteScalar();

                            if (kayitSayisi > 0)
                            {
                                MessageBox.Show("Bu TC kimlik numarası zaten kayıtlı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                    }

                    if (personelEposta != existingPersonelEposta)
                    {
                        using (SqlCommand kontrolKomut = new SqlCommand("SELECT COUNT(*) FROM Personel WHERE personelEposta = @personelEposta AND personelID != @personelID", connection))
                        {
                            kontrolKomut.Parameters.AddWithValue("@personelEposta", personelEposta);
                            kontrolKomut.Parameters.AddWithValue("@personelID", personelID);
                            int kayitSayisi = (int)kontrolKomut.ExecuteScalar();

                            if (kayitSayisi > 0)
                            {
                                MessageBox.Show("Bu e-posta adresi zaten kayıtlı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                    }

                    if (personelCepTelefon != existingPersonelCepTelefon)
                    {
                        using (SqlCommand kontrolKomut = new SqlCommand("SELECT COUNT(*) FROM Personel WHERE personelCepTelefon = @personelCepTelefon AND personelID != @personelID", connection))
                        {
                            kontrolKomut.Parameters.AddWithValue("@personelCepTelefon", personelCepTelefon);
                            kontrolKomut.Parameters.AddWithValue("@personelID", personelID);
                            int kayitSayisi = (int)kontrolKomut.ExecuteScalar();

                            if (kayitSayisi > 0)
                            {
                                MessageBox.Show("Bu cep telefon numarası zaten kayıtlı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                    }

                    // Çakışma yoksa Personel bilgilerini güncelle
                    using (SqlCommand cmd = new SqlCommand("PersonelGuncelle", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Parametreleri ekle
                        cmd.Parameters.AddWithValue("@personelID", personelID);
                        cmd.Parameters.AddWithValue("@personelAd", personelAd);
                        cmd.Parameters.AddWithValue("@personelSoyad", personelSoyad);
                        cmd.Parameters.AddWithValue("@personelSifre", personelSifre);
                        cmd.Parameters.AddWithValue("@personelTcNo", personelTcNo);
                        cmd.Parameters.AddWithValue("@personelEposta", personelEposta);
                        cmd.Parameters.AddWithValue("@personelCepTelefon", personelCepTelefon);
                        cmd.Parameters.AddWithValue("@personelAdres", personelAdres);

                        // Prosedürü çalıştır
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Personel bilgileri başarıyla güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (SqlException sqlEx)
                {
                    // SQL Server hatalarını yakala ve göster
                    MessageBox.Show("Bir SQL hatası oluştu: " + sqlEx.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    // Diğer hataları yakala ve göster
                    MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Yeniden listele
            button5_Click(sender, e);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Kullanıcıdan personelID'yi al
            if (int.TryParse(txtPersonelID.Text, out int personelID))
            {
                // Personel silme işlemini başlat
                SilPersonel(personelID);
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir personel ID giriniz.", "Geçersiz ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void SilPersonel(int personelID)
        {
            using (SqlConnection connection = SqlHelper.GetConnection()) // SqlHelper üzerinden bağlantı alıyoruz
            {
                try
                {
                    using (SqlCommand command = new SqlCommand("PersonelSil", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@personelID", personelID);

                        // Prosedürü çalıştır
                        command.ExecuteNonQuery();

                        MessageBox.Show("Personel başarıyla silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (SqlException ex)
                {
                    // Eğer bir hata varsa, kullanıcıya göster
                    if (ex.Message.Contains("Silme işlemi başarısız"))
                    {
                        MessageBox.Show("Belirtilen personelID ile bir kayıt bulunamadı veya silme işlemi gerçekleştirilemedi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                // Yalnızca veri satırlarına tıklanmasını kontrol et
                if (e.RowIndex >= 0)
                {
                    // Satırdaki veriyle ilgili işlemleri burada yap
                    DataGridViewRow row = dataGridView3.Rows[e.RowIndex];

                    // TextBox'lara verileri aktar
                    txtPersonelID.Text = row.Cells["personelID"].Value.ToString();
                    personelad.Text = row.Cells["personelad"].Value.ToString();
                    personelsoyad.Text = row.Cells["personelsoyad"].Value.ToString();
                    personelsifre.Text = row.Cells["personelsifre"].Value.ToString();
                    personeltcno.Text = row.Cells["personeltcno"].Value.ToString();
                    personeleposta.Text = row.Cells["personeleposta"].Value.ToString();
                    personelceptelefon.Text = row.Cells["personelceptelefon"].Value.ToString();
                    personeladres.Text = row.Cells["personeladres"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                // Hata durumunda mesaj göster
                MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        
        }

        private void kullanici_islemleri_Load(object sender, EventArgs e)
        {
            // Kullanıcı tipi kontrolü ve yetkilendirme
            if (kullaniciTipi == "Admin")
            {
                // Admin için tüm butonlar aktif
                button1.Enabled = true;
                btnAdminEkle.Enabled = true;
                btniptal.Enabled = true;
                butonara.Enabled = true;
                btnAdminGuncelle.Enabled = true;
                btnSil.Enabled = true;
                button2.Enabled = true;
                button4.Enabled = true;
                button3.Enabled = true;
                button5.Enabled = true;
                button7.Enabled = true;
                button6.Enabled = true;
            }
            else if (kullaniciTipi == "Personel")
            {
                // Personel için bazı butonlar devre dışı
                button1.Enabled = false;
                btnAdminEkle.Enabled = false;
                btniptal.Enabled = false;
                butonara.Enabled = false;
                btnAdminGuncelle.Enabled = false;
                btnSil.Enabled = false;
                //button1.Enabled = true;
                //btnAdminEkle.Enabled = true;
                //btniptal.Enabled = true;
                //butonara.Enabled = true;
                //btnAdminGuncelle.Enabled = true;
                //btnSil.Enabled = true;
                //button2.Enabled = true;
                //button4.Enabled = true;
                //button3.Enabled = true;
                //button5.Enabled = true;
                //button7.Enabled = true;
                //button6.Enabled = true;
                


            }
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label35_Click(object sender, EventArgs e)
        {

        }
    }
    }


