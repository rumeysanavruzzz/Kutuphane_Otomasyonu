
using Microsoft.SqlServer.Management.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


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
                yedek_button.Enabled = false;
                yedekdon_button.Enabled = false;
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
            //this.Close();
            Application.Exit();
        }

        private void yedek_button_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "SQL Yedek Dosyası (.bak)|*.bak"; // Yedek dosyası filtresi
                saveFileDialog.Title = "Yedekleme Dosyasını Kaydet";
                saveFileDialog.DefaultExt = "bak"; // Varsayılan uzantı

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string backupPath = saveFileDialog.FileName;

                    // Uzantıyı kontrol et ve ekle
                    if (!backupPath.EndsWith(".bak"))
                    {
                        backupPath += ".bak";
                    }

                    string databaseName = "kütüphane_otomasyonu_sql"; // Yedeklenecek veritabanı adı

                    try
                    {
                        using (SqlConnection connection = SqlHelper.GetConnection()) // SqlHelper'dan bağlantıyı al
                        {
                            string query = $"BACKUP DATABASE {databaseName} TO DISK = '{backupPath}'";
                            using (SqlCommand command = new SqlCommand(query, connection))
                            {
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

        private void yedekdon_button_Click(object sender, EventArgs e)
        {

            //         Yedek dosyasının sabit yolu
            //        string backupPath = @"C:\YEDEKLER\sude.bak"; // Buraya kendi yedek dosyanızın tam yolunu yazın
            //        string connectionString = "Server=DESKTOP-JLM9DM4\\HANIFESQL;Database=HAHAHA;Integrated Security=True;"; // Sunucu adını ve bağlantı bilgilerini düzenleyin

            //        try
            //        {
            //            using (SqlConnection connection = new SqlConnection(connectionString))
            //            {
            //                 Aktif kullanıcı bağlantılarını sonlandır
            //                string killConnections = @"
            //            DECLARE @kill varchar(8000) = '';
            //            SELECT @kill = @kill + 'KILL ' + CONVERT(varchar(5), session_id) + ';'
            //            FROM sys.dm_exec_sessions
            //            WHERE database_id = DB_ID('please');
            //            EXEC(@kill);";

            //                using (SqlCommand killCommand = new SqlCommand(killConnections, connection))
            //                {
            //                    connection.Open();
            //                    killCommand.ExecuteNonQuery();
            //                }

            //                 Veritabanını geri yükle
            //                string restoreQuery = $@"
            //RESTORE DATABASE please 
            //FROM DISK = '{backupPath}' 
            //WITH MOVE 'Logical_Data' TO 'C:\Program Files\Microsoft SQL Server\MSSQL16.HANIFESQL\MSSQL\DATA\sonsonson.mdf',
            //     MOVE 'Logical_Log' TO 'C:\Program Files\Microsoft SQL Server\MSSQL16.HANIFESQL\MSSQL\DATA\sonsonson_log.ldf',
            //     REPLACE";

            //                using (SqlCommand restoreCommand = new SqlCommand(restoreQuery, connection))
            //                {
            //                    restoreCommand.ExecuteNonQuery();
            //                    MessageBox.Show("Geri yükleme başarılı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //                }
            //            }
            //        }
            //        catch (Exception ex)
            //        {
            //            MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        }

            // Yedek dosyasını seçmek için OpenFileDialog açıyoruz
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "SQL Yedek Dosyası (.bak)|*.bak";
                openFileDialog.Title = "Yedek Dosyasını Seçin";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string backupPath = openFileDialog.FileName;
                    string connectionString = "Server=DESKTOP-K7MCDTS\\RUMEYSA;Integrated Security=True;"; // Sunucu adı ve bağlantı

                    try
                    {
                        // Bağlantıyı açıyoruz
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            connection.Open(); // Bağlantıyı açıyoruz

                            // Kullanıcı bağlantılarını sonlandır
                            string killConnections = @"
                    DECLARE @kill varchar(8000) = '';
                    SELECT @kill = @kill + 'KILL ' + CONVERT(varchar(5), session_id) + ';'
                    FROM sys.dm_exec_sessions
                    WHERE database_id = DB_ID('kütüphane_otomasyonu_sql') AND session_id <> @@SPID; -- Kendi oturumumuzu dışarıda bırakıyoruz
                    EXEC(@kill);";

                            using (SqlCommand killCommand = new SqlCommand(killConnections, connection))
                            {
                                killCommand.ExecuteNonQuery(); // Bağlantıları sonlandırıyoruz
                            }

                            // Şimdi master veritabanına geçiş yapıyoruz
                            string useMaster = "USE master;"; // master veritabanını kullanma komutu
                            using (SqlCommand useMasterCommand = new SqlCommand(useMaster, connection))
                            {
                                useMasterCommand.ExecuteNonQuery(); // master veritabanına geçiyoruz
                            }

                            // Geri yükleme sorgusunu oluşturuyoruz
                            string restoreQuery = $@"
                    RESTORE DATABASE kütüphane_otomasyonu_sql 
                    FROM DISK = '{backupPath}' 
                    WITH REPLACE, 
                         MOVE 'kütüphane_otomasyonu_sql' TO 'C:\Program Files\Microsoft SQL Server\MSSQL16.RUMEYSA\MSSQL\DATA\kütüphane_otomasyonu_sql.mdf', 
                         MOVE 'kütüphane_otomasyonu_sql_log' TO 'C:\Program Files\Microsoft SQL Server\MSSQL16.RUMEYSA\MSSQL\DATA\kütüphane_otomasyonu_sql_log.ldf'";

                            using (SqlCommand restoreCommand = new SqlCommand(restoreQuery, connection))
                            {
                                restoreCommand.ExecuteNonQuery(); // Geri yükleme işlemi
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






        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}









