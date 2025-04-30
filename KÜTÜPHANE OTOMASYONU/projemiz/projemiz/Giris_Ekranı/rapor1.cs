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
    public partial class rapor1 : Form
    {
        DataTable tablo = new DataTable();
        public rapor1()
        {
            InitializeComponent();
        }

        private void rapor1_Load(object sender, EventArgs e)
        {
            try
            {
                // SqlHelper sınıfından bağlantıyı al
                using (SqlConnection baglanti = Giris_Ekranı.SqlHelper.GetConnection())
                {
                    // SQL komut nesnesi
                    SqlDataAdapter komut = new SqlDataAdapter(@"SELECT 
                        uyeID, uyeKullaniciAd, uyeKullaniciSoyad, uyeEposta, uyeCepTelefon, 
                        uyeTcNo, uyeCeza, uyeAdres 
                        FROM uye", baglanti);

                    // Veriyi DataTable'a doldur
                    komut.Fill(tablo);
                }

                // Crystal Report nesnesi oluştur ve veri kaynağını ayarla
                CrystalReport3 rapor = new CrystalReport3();
                rapor.SetDataSource(tablo);

                // CrystalReportViewer kontrolüne raporu bağla
                crystalReportViewer1.ReportSource = rapor;

                MessageBox.Show("Rapor başarıyla yüklendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
