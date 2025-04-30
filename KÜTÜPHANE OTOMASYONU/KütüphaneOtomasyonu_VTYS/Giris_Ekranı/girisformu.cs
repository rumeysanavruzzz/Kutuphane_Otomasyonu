
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Security.Policy;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;




namespace Giris_Ekranı
{
    public partial class girisformu : Form
    {
        public object KullaniciBilgileri { get; set; }

        public girisformu()
        {
            InitializeComponent();
        }
        //public string kullaniciadi;
        private void girisyap_button_Click(object sender, EventArgs e)
        {
            string kullaniciAd = eposta_text.Text; // Kullanıcı Adı / E-posta TextBox
            string sifre = sifre_text.Text; // Şifre TextBox
            string rol = ""; // Kullanıcının rolü (Admin, Personel, Uye)

            // Kullanıcının rolünü belirlemek için, butonlarla veya başka bir UI ile bu değer alınabilir
            // Örneğin:
            if (admin_rbutton.Checked)
            {
                rol = "Admin";
            }
            else if (personel_rbutton.Checked)
            {
                rol = "Personel";
            }

            else
            {
                MessageBox.Show("Lütfen bir rol seçin!");
                return;
            }

            try
            {
                // Kullanıcı girişini doğrulama işlemi
                SqlConnection con = SqlHelper.GetConnection();
                SqlCommand com = new SqlCommand("sp_KullaniciGiris", con);
                com.CommandType = CommandType.StoredProcedure;

                // Parametreleri ekle
                com.Parameters.AddWithValue("@KullaniciAd", kullaniciAd);
                com.Parameters.AddWithValue("@Sifre", sifre);
                com.Parameters.AddWithValue("@Rol", rol);

                // Sonuçları oku
                SqlDataReader dr = com.ExecuteReader();

                if (dr.Read())
                {
                    if (rol == "Admin")
                    {
                        string adminAd = dr["adminAd"].ToString();
                        string adminSoyad = dr["adminSoyad"].ToString();
                        MessageBox.Show($"Admin Girişi Başarılı! Hoş geldiniz {adminAd} {adminSoyad}.");

                        Anasayfa anasayfa = new Anasayfa();
                        anasayfa.kullaniciTipi = "Admin"; // Admin olarak yetkilendirme
                        //anasayfa.kullaniciadi =
                        anasayfa.Show();
                        this.Hide();
                    }
                    else if (rol == "Personel")
                    {
                        string personelAd = dr["personelAd"].ToString();
                        string personelSoyad = dr["personelSoyad"].ToString();
                        MessageBox.Show($"Personel Girişi Başarılı! Hoş geldiniz {personelAd} {personelSoyad}.");

                        Anasayfa anasayfa = new Anasayfa();
                        anasayfa.kullaniciTipi = "Personel"; // Personel olarak yetkilendirme
                        anasayfa.Show();
                        this.Hide();

                        //uye_sil_menu.Enabled = false; // Menü öğesini devre dışı bırak
                    }

                }
                else
                {
                    MessageBox.Show("Giriş bilgileri hatalı! Lütfen tekrar deneyin.");
                }

                dr.Close();
                con.Close();


            }

            catch (SqlException sqlEx) // SQL hatalarını yakalar
            {
                MessageBox.Show("Veritabanı hatası: " + sqlEx.Message);
            }
            catch (Exception ex) // Diğer genel hatalar
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                // Veritabanı bağlantısını güvenli şekilde kapatma
                SqlConnection con = SqlHelper.GetConnection();  // Burada, bağlantıyı tekrar alıyoruz, çünkü con'a her zaman ulaşılabilir olmalı
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        private void girisformu_Load(object sender, EventArgs e)
        {

        }
    }  

}
