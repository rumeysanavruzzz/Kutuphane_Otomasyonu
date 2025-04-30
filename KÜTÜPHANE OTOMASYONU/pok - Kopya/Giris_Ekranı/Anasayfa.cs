
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
using System.Data.Sql;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Common;



namespace Giris_Ekranı
{
    public partial class Anasayfa : Form
    {
        public string kullaniciTipi { get; set; }  // Kullanıcı tipi (Admin veya Personel)
        public Anasayfa()
        {
            InitializeComponent();
        }
        //public string kullaniciadi;
        private void kullanıcı_button_Click(object sender, EventArgs e)
        {

            kullanici_islemleri kullanici = new kullanici_islemleri();
            kullanici.kullaniciTipi = "Admin";
            kullanici.Show();
            this.Hide();
        }



        private void uye_button_Click(object sender, EventArgs e)
        {
            uye uyefrm = new uye();
            uyefrm.kullaniciTipi = this.kullaniciTipi;
            uyefrm.Show();
            this.Hide();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "SQL Yedek Dosyası (*.bak)|*.bak";
                openFileDialog.Title = "Yedek Dosyasını Seçin";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string backupPath = openFileDialog.FileName;
                    string connectionString = "Server=DESKTOP-K7MCDTS\\RUMEYSA;Database=master;Integrated Security=True;";

                    try
                    {
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            // Aktif kullanıcı bağlantılarını sonlandır
                            string killConnections = @"
                        DECLARE @kill varchar(8000) = '';
                        SELECT @kill = @kill + 'KILL ' + CONVERT(varchar(5), session_id) + ';'
                        FROM sys.dm_exec_sessions
                        WHERE database_id  = DB_ID('please');
                        EXEC(@kill);";

                            using (SqlCommand killCommand = new SqlCommand(killConnections, connection))
                            {
                                connection.Open();
                                killCommand.ExecuteNonQuery();
                            }

                            // Veritabanını geri yükle
                            string restoreQuery = $"RESTORE DATABASE please FROM DISK = '{backupPath}' WITH REPLACE";

                            using (SqlCommand restoreCommand = new SqlCommand(restoreQuery, connection))
                            {
                                restoreCommand.ExecuteNonQuery();
                                MessageBox.Show("Geri yükleme başarılı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        private void odunc_button_Click(object sender, EventArgs e)
        {
            odunc_islemleri odunc = new odunc_islemleri();
            odunc.Show();
            this.Hide();

        }

        private void Anasayfa_Load(object sender, EventArgs e)
        {

            if (kullaniciTipi == "Personel")
            {
                kullanıcı_button.Enabled = false; // Kullanıcı İşlemleri butonunu devre dışı bırak
                uye_button.Enabled = true;
                kitap_button.Enabled = true;
                odunc_button.Enabled = true;
                yedek_button.Enabled = true;
                yedekdon_button.Enabled = true;
                cikis_button.Enabled = true;
            }

            else if (kullaniciTipi == "Admin")
            {
                kullanıcı_button.Enabled = true; // Kullanıcı İşlemleri butonunu devre dışı bırak
                uye_button.Enabled = true;
                kitap_button.Enabled = true;
                odunc_button.Enabled = true;
                yedek_button.Enabled = true;
                yedekdon_button.Enabled = true;
                cikis_button.Enabled = true;
            }

        }

        private void kitap_button_Click(object sender, EventArgs e)
        {
            kitap_islemleri kitap = new kitap_islemleri();
            kitap.kullaniciTipi = this.kullaniciTipi;
            kitap.Show();
            this.Hide();
        }

        private void cikis_button_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void yedek_button_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "SQL Yedek Dosyası (*.bak)|*.bak";
                saveFileDialog.Title = "Yedekleme Yapılacak Dosya Yolunu Seçin";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string backupPath = saveFileDialog.FileName;
                    string connectionString = "Server=DESKTOP-K7MCDTS\\RUMEYSA;Database=please;Integrated Security=True;";

                    try
                    {
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            string query = $"BACKUP DATABASE please TO DISK = '{backupPath}'";

                            using (SqlCommand command = new SqlCommand(query, connection))
                            {
                                connection.Open();
                                command.ExecuteNonQuery();
                                MessageBox.Show("Yedekleme başarılı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
