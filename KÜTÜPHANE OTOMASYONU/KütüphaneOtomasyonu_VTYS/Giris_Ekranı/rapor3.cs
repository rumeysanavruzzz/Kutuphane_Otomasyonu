using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Giris_Ekranı
{
    public partial class rapor3 : Form
    {
        private DataTable filteredTable = new DataTable();
        public rapor3()
        {
            InitializeComponent();
        }

        // Ana formdan filtrelenmiş tabloyu almak için metot
        public void SetFilteredDataTable(DataTable table)
        {
            filteredTable = table;
        }

        private void rapor3_Load(object sender, EventArgs e)
        {
            try
            {
                if (filteredTable.Rows.Count > 0) // Tablo doluysa raporu göster
                {
                    CrystalReport4 rapor = new CrystalReport4();
                    rapor.SetDataSource(filteredTable);

                    crystalReportViewer1.ReportSource = rapor;
                }
                else
                {
                    MessageBox.Show("Gösterilecek veri bulunamadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    }

