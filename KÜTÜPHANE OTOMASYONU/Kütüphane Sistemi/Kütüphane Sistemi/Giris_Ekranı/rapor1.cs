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
        private DataTable filteredTable = new DataTable();
        public rapor1()
        {
            InitializeComponent();
        }
        // Filtrelenmiş tabloyu almak için bu metot kullanılacak
        public void SetFilteredDataTable(DataTable table)
        {
            filteredTable = table;
        }
        private void rapor1_Load(object sender, EventArgs e)
        {



            try
            {
                if (filteredTable.Rows.Count > 0) // Filtrelenmiş tablo boş değilse
                {
                    // Crystal Report nesnesi oluştur ve veri kaynağını ayarla
                    CrystalReport3 rapor = new CrystalReport3();
                    rapor.SetDataSource(filteredTable);

                    // CrystalReportViewer kontrolüne raporu bağla
                    crystalReportViewer1.ReportSource = rapor;

                    MessageBox.Show("Rapor başarıyla yüklendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Rapor göstermek için geçerli bir veri yok!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
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

