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
    public partial class uye : Form
    {
        public string kullaniciTipi { get; set; }  // Kullanıcı tipi (Admin veya Personel)

        public uye()
        {
            InitializeComponent();
        }



        private void uye_Load(object sender, EventArgs e)
        {
            if (kullaniciTipi == "Personel")
            {
                // Personel için yetkisiz işlemleri devre dışı bırak
                geri_button.Enabled = true;
                uyeekle_button.Enabled = true;
                üyelistele_button.Enabled = true;
                uyeara_button.Enabled = true;
                uyeguncelle_buton.Enabled = true;
                siluyeara_button.Enabled = false; // Örneğin, kullanıcı ekleme butonu
                uyesil_button.Enabled = false;  // Örneğin, kullanıcı silme butonu
                silinecekuyelistle_button.Enabled = false;
            }

            else if (kullaniciTipi == "Admin")
            {
                // Admin için yetki işlemlerini ekle
                geri_button.Enabled = true;
                uyeekle_button.Enabled = true;
                üyelistele_button.Enabled = true;
                uyeara_button.Enabled = true;
                uyeguncelle_buton.Enabled = true;
                siluyeara_button.Enabled = true; // Örneğin, kullanıcı ekleme butonu
                uyesil_button.Enabled = true;  // Örneğin, kullanıcı silme butonu
                silinecekuyelistle_button.Enabled = true;
            }

        }


        

        private void geri_button_Click_1(object sender, EventArgs e)
        {
            //this.Close(); // Bu formu kapatır
            //Anasayfa anasayfaFormu = new Anasayfa();
            //anasayfaFormu.Show(); // Anasayfa formunu gösterir

            Anasayfa anasayfa = (Anasayfa)Application.OpenForms["Anasayfa"];
            if (anasayfa != null)
            {
                anasayfa.Show();
            }
            this.Close(); // Kullanıcı işlemleri formunu kapat

        }

        private void uyeekle_button_Click_1(object sender, EventArgs e)
        {
            string uyeAd = uyead_text.Text.Trim();
            string uyeSoyad = uyesoyad_text.Text.Trim();
            string uyeEposta = uyeposta_text.Text.Trim();
            string uyeCepTelefon = uyeceptel_text.Text.Trim();
            string uyeTcNo = uyetc_text.Text.Trim();
            string uyeAdres = uyeadres_text.Text.Trim();

            // Boş alan kontrolü
            if (string.IsNullOrWhiteSpace(uyeAd) || string.IsNullOrWhiteSpace(uyeSoyad) ||
                string.IsNullOrWhiteSpace(uyeEposta) || string.IsNullOrWhiteSpace(uyeCepTelefon) ||
                string.IsNullOrWhiteSpace(uyeTcNo) || string.IsNullOrWhiteSpace(uyeAdres))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun!");
                return;
            }


            try
            {
                // SqlConnection'ı SqlHelper'dan alıyoruz.
                using (SqlConnection con = SqlHelper.GetConnection())
                {
                    // TC, Eposta ve CepTelefon numarasını kontrol et
                    string checkQuery = "SELECT COUNT(*) FROM Uye WHERE uyeTcNo = @uyeTcNo OR uyeEposta = @uyeEposta OR uyeCepTelefon = @uyeCepTelefon";
                    SqlCommand checkCmd = new SqlCommand(checkQuery, con);
                    checkCmd.Parameters.AddWithValue("@uyeTcNo", uyeTcNo);
                    checkCmd.Parameters.AddWithValue("@uyeEposta", uyeEposta);
                    checkCmd.Parameters.AddWithValue("@uyeCepTelefon", uyeCepTelefon);

                    // Aynı TC, E-posta veya Telefon varsa hata mesajı ver
                    int count = (int)checkCmd.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("Bu TC Kimlik Numarası, E-posta veya Cep Telefonu zaten kayıtlı. Lütfen başka bir bilgi giriniz.");
                        return;
                    }



                    SqlCommand com = new SqlCommand("UyeEkle", con);
                    com.CommandType = CommandType.StoredProcedure;

                    // Parametreleri ekle
                    com.Parameters.AddWithValue("@uyeKullaniciAd", uyeAd);
                    com.Parameters.AddWithValue("@uyeKullaniciSoyad", uyeSoyad);
                    com.Parameters.AddWithValue("@uyeEposta", uyeEposta);
                    com.Parameters.AddWithValue("@uyeCepTelefon", uyeCepTelefon);
                    com.Parameters.AddWithValue("@uyeTcNo", uyeTcNo);
                    com.Parameters.AddWithValue("@uyeAdres", uyeAdres);
                    com.Parameters.AddWithValue("@uyeCeza", 0);
                    // Komutu çalıştır
                    com.ExecuteNonQuery();

                    MessageBox.Show("Üye başarıyla kaydedildi!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void üyelistele_button_Click_1(object sender, EventArgs e)
        {
            try
            {
                // SqlConnection'ı SqlHelper'dan alıyoruz.
                using (SqlConnection conn = SqlHelper.GetConnection())
                {
                    SqlCommand com = new SqlCommand("SELECT * FROM Uye", conn);
                    SqlDataAdapter adapter = new SqlDataAdapter(com);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Grid'e verileri ata
                    dataGridView1.DataSource = dataTable;

                    foreach (DataRow row in dataTable.Rows)
                    {
                        row["uyeCeza"] = string.Format("{0:F2}", row["uyeCeza"]); // 2 ondalıklı format
                    }

                    //// "uyeceza" kolonunu gizle
                    //if (dataGridView1.Columns["uyeceza"] != null)
                    //{
                    //    dataGridView1.Columns["uyeceza"].Visible = true;
                    //}
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);

            }
        }

        private void uyeara_button_Click_1(object sender, EventArgs e)
        {

            try
            {
                // TextBox'lardan üye adı ve soyadını al
                string uyeKullaniciAd = textBox8.Text.Trim();  // uyeAdTextBox, TextBox adı
                string uyeKullaniciSoyad = textBox9.Text.Trim();  // uyeSoyadTextBox, TextBox adı

                // Prosedürü çağır ve bağlantıyı helper üzerinden oluştur
                using (SqlConnection con = SqlHelper.GetConnection())
                {
                    SqlCommand com = new SqlCommand("dbo.UyeAdSoyadAra", con);
                    com.CommandType = CommandType.StoredProcedure;

                    //con = new SqlCommand("dbo.UyeAdSoyadAra", con);
                    //con.CommandType = CommandType.StoredProcedure;

                    // Parametreleri ekle
                    com.Parameters.AddWithValue("@uyeKullaniciAd", uyeKullaniciAd);
                    com.Parameters.AddWithValue("@uyeKullaniciSoyad", uyeKullaniciSoyad);

                    // Veriyi al ve DataGridView'e aktar
                    SqlDataAdapter da = new SqlDataAdapter(com);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView2.DataSource = dt;

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

        private void dataGridView2_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // Geçersiz satır kontrolü

            // Seçili satırı al
            DataGridViewRow row = dataGridView2.Rows[e.RowIndex];

            //ID bilgisini sakla
            id_text.Text = Convert.ToInt32(row.Cells["uyeID"].Value).ToString();

            // Güncelleme işlemi için alanları doldur
            uyeadg_text.Text = row.Cells["uyeKullaniciAd"].Value.ToString();
            uyesoyadg_text.Text = row.Cells["uyeKullaniciSoyad"].Value.ToString();
            uyepostag_text.Text = row.Cells["uyeEposta"].Value.ToString();
            uyeceptelg_text.Text = row.Cells["uyeCepTelefon"].Value.ToString();
            uyetcnog_text.Text = row.Cells["uyeTcNo"].Value.ToString();
            uyeadresg_text.Text = row.Cells["uyeAdres"].Value.ToString();
            uyecezag_text.Text = row.Cells["uyeCeza"].Value.ToString();
        }

        private void uyeguncelle_buton_Click_1(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                int uyeID = int.Parse(id_text.Text.Trim());
                string uyeAd = uyeadg_text.Text.Trim();
                string uyeSoyad = uyesoyadg_text.Text.Trim();
                string uyeEposta = uyepostag_text.Text.Trim();
                string uyeCepTelefon = uyeceptelg_text.Text.Trim();
                string uyeTcNo = uyetcnog_text.Text.Trim();
                string uyeAdres = uyeadresg_text.Text.Trim();

                try
                {
                    // Cep telefonu numarası doğrulaması: 5 ile başlama ve 10 karakter olma
                    if (!uyeCepTelefon.StartsWith("5") || uyeCepTelefon.Length != 10 || !uyeCepTelefon.All(char.IsDigit))
                    {
                        MessageBox.Show("Cep telefon numarası 5 ile başlamalı ve 10 haneli olmalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }



                    using (SqlConnection conn = SqlHelper.GetConnection())
                    {
                        // Mevcut üye bilgilerini al
                        string existingUyeTcNo = "";
                        string existingUyeEposta = "";
                        string existingUyeCepTelefon = "";

                        string selectQuery = "SELECT uyeTcNo, uyeEposta, uyeCepTelefon FROM Uye WHERE UyeID = @UyeID";
                        using (SqlCommand selectCmd = new SqlCommand(selectQuery, conn))
                        {
                            selectCmd.Parameters.AddWithValue("@UyeID", uyeID);
                            using (SqlDataReader reader = selectCmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    existingUyeTcNo = reader["uyeTcNo"].ToString();
                                    existingUyeEposta = reader["uyeEposta"].ToString();
                                    existingUyeCepTelefon = reader["uyeCepTelefon"].ToString();
                                }
                            }
                        }

                        // TC Kimlik Numarası çakışma kontrolü
                        if (uyeTcNo != existingUyeTcNo)
                        {
                            string tcNoCheckQuery = "SELECT COUNT(*) FROM Uye WHERE uyeTcNo = @uyeTcNo AND UyeID != @UyeID";
                            using (SqlCommand checkCmd = new SqlCommand(tcNoCheckQuery, conn))
                            {
                                checkCmd.Parameters.AddWithValue("@uyeTcNo", uyeTcNo);
                                checkCmd.Parameters.AddWithValue("@UyeID", uyeID);
                                int count = (int)checkCmd.ExecuteScalar();

                                if (count > 0)
                                {
                                    MessageBox.Show("Bu TC kimlik numarası zaten kayıtlı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                            }
                        }

                        // Eposta çakışma kontrolü
                        if (uyeEposta != existingUyeEposta)
                        {
                            string epostaCheckQuery = "SELECT COUNT(*) FROM Uye WHERE uyeEposta = @uyeEposta AND UyeID != @UyeID";
                            using (SqlCommand checkCmd = new SqlCommand(epostaCheckQuery, conn))
                            {
                                checkCmd.Parameters.AddWithValue("@uyeEposta", uyeEposta);
                                checkCmd.Parameters.AddWithValue("@UyeID", uyeID);
                                int count = (int)checkCmd.ExecuteScalar();

                                if (count > 0)
                                {
                                    MessageBox.Show("Bu e-posta adresi zaten kayıtlı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                            }
                        }

                        // Cep telefonu çakışma kontrolü
                        if (!uyeCepTelefon.StartsWith("5") || uyeCepTelefon.Length != 10 || !uyeCepTelefon.All(char.IsDigit))

                        {
                            string telefonCheckQuery = "SELECT COUNT(*) FROM Uye WHERE uyeCepTelefon = @uyeCepTelefon AND UyeID != @UyeID";
                            using (SqlCommand checkCmd = new SqlCommand(telefonCheckQuery, conn))
                            {
                                checkCmd.Parameters.AddWithValue("@uyeCepTelefon", uyeCepTelefon);
                                checkCmd.Parameters.AddWithValue("@UyeID", uyeID);
                                int count = (int)checkCmd.ExecuteScalar();

                                if (count > 0)
                                {
                                    MessageBox.Show("Bu cep telefon numarası zaten kayıtlı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                            }
                        }

                        // Üye bilgilerini güncelle
                        string updateQuery = "UPDATE Uye SET uyeKullaniciAd = @uyeKullaniciAd, uyeKullaniciSoyad = @uyeKullaniciSoyad, uyeEposta = @uyeEposta, uyeCepTelefon = @uyeCepTelefon, uyeTcNo = @uyeTcNo, uyeAdres = @uyeAdres WHERE UyeID = @UyeID";
                        using (SqlCommand updateCmd = new SqlCommand(updateQuery, conn))
                        {
                            updateCmd.Parameters.AddWithValue("@uyeKullaniciAd", uyeAd);
                            updateCmd.Parameters.AddWithValue("@uyeKullaniciSoyad", uyeSoyad);
                            updateCmd.Parameters.AddWithValue("@uyeEposta", uyeEposta);
                            updateCmd.Parameters.AddWithValue("@uyeCepTelefon", uyeCepTelefon);
                            updateCmd.Parameters.AddWithValue("@uyeTcNo", uyeTcNo);
                            updateCmd.Parameters.AddWithValue("@uyeAdres", uyeAdres);
                            updateCmd.Parameters.AddWithValue("@UyeID", uyeID);

                            int result = updateCmd.ExecuteNonQuery();

                            if (result > 0)
                            {
                                // DataGridView'deki satırı güncelle
                                DataGridViewRow row = dataGridView2.SelectedRows[0];
                                row.Cells["UyeKullaniciAd"].Value = uyeAd;
                                row.Cells["UyeKullaniciSoyad"].Value = uyeSoyad;
                                row.Cells["UyeEposta"].Value = uyeEposta;
                                row.Cells["UyeCepTelefon"].Value = uyeCepTelefon;
                                row.Cells["UyeTcNo"].Value = uyeTcNo;
                                row.Cells["UyeAdres"].Value = uyeAdres;

                                MessageBox.Show("Üye başarıyla güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Üye güncellenirken bir sorun oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lütfen güncellemek için bir üye seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void silinecekuyelistle_button_Click_1(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = SqlHelper.GetConnection())
                {
                    SqlCommand com = new SqlCommand("SELECT * FROM SilinmisUyeKayitlari", con);
                    SqlDataAdapter da = new SqlDataAdapter(com);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Silinmiş üyeleri DataGridView'de göster
                    dataGridView4.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void uyesil_button_Click_1(object sender, EventArgs e)
        {

            // DataGridView'de herhangi bir satır seçili mi kontrol et
            if (dataGridView3.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen silmek istediğiniz üyeyi seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Seçilen satırdan uyeID değerini al
            int uyeID = Convert.ToInt32(dataGridView3.SelectedRows[0].Cells["uyeID"].Value);

            // Silme işlemi için onay al
            DialogResult dialogResult = MessageBox.Show("Seçilen üyeyi silmek istediğinizden emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.No)
            {
                return;
            }

            try
            {
                using (SqlConnection con = SqlHelper.GetConnection())
                {
                    SqlCommand com = new SqlCommand("sp_UyeSil", con);
                    com.CommandType = CommandType.StoredProcedure;

                    // Parametreyi ekle
                    com.Parameters.AddWithValue("@uyeID", uyeID);


                    com.ExecuteNonQuery();

                    // Silme işlemi başarılı olduğunda kullanıcıya bilgi ver ve DataGridView'i güncelle
                    MessageBox.Show("Üye başarıyla silindi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // DataGridView'i yenilemek için listeleme işlemini tekrar yap
                    siluyeara_button_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void siluyeara_button_Click(object sender, EventArgs e)
        {

            //string uyeAd = textBox2.Text.Trim();  // Kullanıcı adı
            //string uyeSoyad = textBox1.Text.Trim();  // Kullanıcı soyadı

            //// Boş alan kontrolü
            //if (string.IsNullOrWhiteSpace(uyeAd) || string.IsNullOrWhiteSpace(uyeSoyad))
            //{
            //    MessageBox.Show("Lütfen üye adı ve soyadını giriniz!");
            //    return;
            //}

            //try
            //{
            //    using (SqlConnection con = SqlHelper.GetConnection())
            //    {
            //        SqlCommand com = new SqlCommand("dbo.UyeAdSoyadAra", con);
            //        com.CommandType = CommandType.StoredProcedure;

            //        // Parametreleri ekle
            //        com.Parameters.AddWithValue("@uyeKullaniciAd", uyeAd);
            //        com.Parameters.AddWithValue("@uyeKullaniciSoyad", uyeSoyad);

            //        // Veriyi al ve DataGridView'e aktar
            //        SqlDataAdapter da = new SqlDataAdapter(com);
            //        DataTable dt = new DataTable();
            //        da.Fill(dt);

            //        // DataGridView'e veriyi aktar
            //        dataGridView3.DataSource = dt;

            //        // Eşleşen üye bulunamadıysa kullanıcıya uyarı göster
            //        if (dt.Rows.Count == 0)
            //        {
            //            MessageBox.Show("Eşleşen üye bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        }
            //        else
            //        {
            //            MessageBox.Show("Üyeler başarıyla listelendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

            try
            {
                // TextBox'lardan üye adı ve soyadını al
                string uyeKullaniciAd = textBox2.Text.Trim();  // uyeAdTextBox, TextBox adı
                string uyeKullaniciSoyad = textBox1.Text.Trim();  // uyeSoyadTextBox, TextBox adı

                // Prosedürü çağır ve bağlantıyı helper üzerinden oluştur
                using (SqlConnection con = SqlHelper.GetConnection())
                {
                    SqlCommand com = new SqlCommand("dbo.UyeAdSoyadAra", con);
                    com.CommandType = CommandType.StoredProcedure;

                    //con = new SqlCommand("dbo.UyeAdSoyadAra", con);
                    //con.CommandType = CommandType.StoredProcedure;

                    // Parametreleri ekle
                    com.Parameters.AddWithValue("@uyeKullaniciAd", uyeKullaniciAd);
                    com.Parameters.AddWithValue("@uyeKullaniciSoyad", uyeKullaniciSoyad);

                    // Veriyi al ve DataGridView'e aktar
                    SqlDataAdapter da = new SqlDataAdapter(com);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView3.DataSource = dt;

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

        
    }
}
