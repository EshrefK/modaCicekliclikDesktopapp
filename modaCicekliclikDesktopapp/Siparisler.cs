using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Runtime.InteropServices;
using System.Drawing.Printing;

namespace modaCicekliclikDesktopapp
{
    public partial class Siparisler : Form
    {
        private DBconnect dbconnect = new DBconnect();

        #region Pagination
        private int currentPage = 1;
        private int recordsPerPage = 10;
        private int totalRecords = 0;
        private int totalPages = 0;
        #endregion

        public Siparisler()
        {
            InitializeComponent();
            LoadSiparisler();
            LoadRecordsPerPageOptions();
        }

        private void LoadRecordsPerPageOptions()
        {
            recordsPerPagecbx.Items.Add("all");
            recordsPerPagecbx.Items.Add("10");
            recordsPerPagecbx.Items.Add("20");
            recordsPerPagecbx.Items.Add("50");
            recordsPerPagecbx.SelectedIndex = 1; // Default to 10
        }

        private void UpdateNavigationLabels()
        {
            int totalPages = (int)Math.Ceiling((double)totalRecords / recordsPerPage);
            currentPageLabel.Text = $"Sayfa {currentPage} / {totalPages}";
            totalPagesLabel.Text = $"Toplam Kayıt: {totalRecords}";
        }

        private void UpdatePaginationControls()
        {
            NextBtn.Enabled = currentPage < totalPages;
            PreviousBtn.Enabled = currentPage > 1;
            FirstBtn.Enabled = currentPage > 1;
            LastBtn.Enabled = currentPage < totalPages;
        }

        public void LoadSiparisler()
        {
            try
            {
                using (MySqlConnection connection = dbconnect.GetConnection())
                {
                    connection.Open();

                    // Get total record count for pagination
                    using (MySqlCommand countCommand = new MySqlCommand(
                        "SELECT COUNT(*) FROM satin_almalar sa " +
                        "INNER JOIN tedarikciler t ON sa.tedarikci_id = t.tedarikci_id " +
                        "INNER JOIN urunler u ON sa.urun_id = u.urun_id " +
                        "WHERE t.firma_adi LIKE @search OR " +
                        "u.urun_adi LIKE @search OR " +
                        "sa.siparis_no LIKE @search", connection))
                    {
                        countCommand.Parameters.AddWithValue("@search", "%" + araTextbox.Text + "%");
                        totalRecords = Convert.ToInt32(countCommand.ExecuteScalar());
                        totalPages = (int)Math.Ceiling((double)totalRecords / recordsPerPage);
                    }

                    // Get paginated data
                    using (MySqlCommand dataCommand = new MySqlCommand(
                        "SELECT sa.satin_alma_id, sa.siparis_no, sa.siparis_tarih, t.firma_adi, " +
                        "u.urun_adi, sa.miktar, sa.birim_fiyat, " +
                        "CASE WHEN sa.teslim_tarihi IS NULL THEN 'Beklemede' ELSE 'Teslim Edildi' END as durum " +
                        "FROM satin_almalar sa " +
                        "INNER JOIN tedarikciler t ON sa.tedarikci_id = t.tedarikci_id " +
                        "INNER JOIN urunler u ON sa.urun_id = u.urun_id " +
                        "WHERE t.firma_adi LIKE @search OR " +
                        "u.urun_adi LIKE @search OR " +
                        "sa.siparis_no LIKE @search " +
                        "ORDER BY sa.siparis_tarih DESC " +
                        "LIMIT @Offset, @RecordsPerPage", connection))
                    {
                        dataCommand.Parameters.AddWithValue("@search", "%" + araTextbox.Text + "%");
                        dataCommand.Parameters.AddWithValue("@Offset", (currentPage - 1) * recordsPerPage);
                        dataCommand.Parameters.AddWithValue("@RecordsPerPage", recordsPerPage);

                        MySqlDataAdapter adapter = new MySqlDataAdapter(dataCommand);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        SiparisDgv.DataSource = dataTable;
                    }

                    UpdateNavigationLabels();
                    UpdatePaginationControls();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSiparisEkle_Click(object sender, EventArgs e)
        {
            frmSiparis frmSiparis = new frmSiparis(this);
            frmSiparis.ShowDialog();
        }

        private void btnSiparisGuncelle_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                frmSiparis frmSiparis = new frmSiparis(this);
                
                // Set the form title
                frmSiparis.Text = "Sipariş Güncelle";
                frmSiparis.lblTitle.Text = "Sipariş Güncelle";

                // Hide the add button and show the update button
                frmSiparis.btnSiparisEkle.Visible = false;
                frmSiparis.btnSiparisGuncelle.Visible = true;

                // Set the ID for update
                frmSiparis.IDlabel.Text = row.Cells["siparis_id"].Value.ToString();

                // Load the data
                frmSiparis.tedarikciComboBox.Text = row.Cells["tedarikci_adi"].Value.ToString();
                frmSiparis.urunComboBox.Text = row.Cells["urun_adi"].Value.ToString();
                frmSiparis.siparisTarihiDateTimePicker.Value = Convert.ToDateTime(row.Cells["siparis_tarihi"].Value);
                frmSiparis.teslimTarihiDateTimePicker.Value = Convert.ToDateTime(row.Cells["teslim_tarihi"].Value);
                frmSiparis.miktarTextbox.Text = row.Cells["miktar"].Value.ToString();
                frmSiparis.birimFiyatTextbox.Text = row.Cells["birim_fiyat"].Value.ToString();
                frmSiparis.durumComboBox.Text = row.Cells["durum"].Value.ToString();

                frmSiparis.ShowDialog();
            }
            else
            {
                MessageBox.Show("Lütfen güncellenecek siparişi seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSiparisSil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Seçili siparişi silmek istediğinize emin misiniz?", "Onay", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        using (MySqlConnection connection = dbconnect.GetConnection())
                        {
                            connection.Open();
                            using (MySqlCommand command = new MySqlCommand(
                                "DELETE FROM siparisler WHERE siparis_id = @id", connection))
                            {
                                command.Parameters.AddWithValue("@id", 
                                    dataGridView1.SelectedRows[0].Cells["siparis_id"].Value);
                                
                                int result = command.ExecuteNonQuery();
                                if (result > 0)
                                {
                                    MessageBox.Show("Sipariş başarıyla silindi.", "Bilgi", 
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    LoadSiparisler();
                                }
                                else
                                {
                                    MessageBox.Show("Sipariş silinemedi.", "Hata", 
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen silinecek siparişi seçin.", "Uyarı", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void araTextbox_TextChanged(object sender, EventArgs e)
        {
            currentPage = 1; // Reset to first page on search
            LoadSiparisler();
        }

        private void recordsPerPagecbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            String selectedValue = recordsPerPagecbx.SelectedItem.ToString();
            if (selectedValue == "all")
            {
                recordsPerPage = totalRecords; // Show all records
            }
            else
            {
                recordsPerPage = Convert.ToInt32(selectedValue);
            }
            currentPage = 1; // Reset to first page on change
            LoadSiparisler();
        }

        private void FirstBtn_Click(object sender, EventArgs e)
        {
            currentPage = 1;
            LoadSiparisler();
        }

        private void PreviousBtn_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                LoadSiparisler();
            }
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPages)
            {
                currentPage++;
                LoadSiparisler();
            }
        }

        private void LastBtn_Click(object sender, EventArgs e)
        {
            currentPage = totalPages;
            LoadSiparisler();
        }

        private void PrintSiparisBtn_Click(object sender, EventArgs e)
        {
            try
            {
                PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
                printPreviewDialog.Document = printDocument1;
                printPreviewDialog.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int currentPrintRow = 0;

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            // A4 size in hundredths of millimeters (827 x 1169)
            e.PageSettings.PaperSize = new PaperSize("A4", 827, 1169);

            // Margins
            int leftMargin = 50;
            int topMargin = 50;
            int rightMargin = 50;
            int bottomMargin = 50;

            // Calculate usable area
            int usableWidth = e.PageSettings.PaperSize.Width - leftMargin - rightMargin;
            int usableHeight = e.PageSettings.PaperSize.Height - topMargin - bottomMargin;

            // Draw logo
            Bitmap bitmap = Properties.Resources.samsunmodacicekciliklogo11;
            System.Drawing.Image image = bitmap;
            e.Graphics.DrawImage(image, new Point(leftMargin, topMargin));

            // Title
            string title = "Sipariş Listesi";
            Font titleFont = new Font("Arial", 14, FontStyle.Bold);
            SizeF titleSize = e.Graphics.MeasureString(title, titleFont);
            e.Graphics.DrawString(title, titleFont, Brushes.Black, 
                new PointF(leftMargin + (usableWidth - titleSize.Width) / 2, topMargin + 100));

            // Column headers
            Font headerFont = new Font("Arial", 10, FontStyle.Bold);
            int yPosition = topMargin + 150;
            int[] columnWidths = { 50, 100, 100, 150, 150, 80, 80, 100 }; // Adjusted for actual columns
            string[] headers = { "No", "Sipariş No", "Tarih", "Tedarikçi", "Ürün", "Miktar", "Birim Fiyat", "Durum" };
            
            // Draw headers
            int xPosition = leftMargin;
            for (int i = 0; i < headers.Length; i++)
            {
                e.Graphics.DrawString(headers[i], headerFont, Brushes.Black, new PointF(xPosition, yPosition));
                xPosition += columnWidths[i];
            }

            // Draw line under headers
            yPosition += 20;
            e.Graphics.DrawLine(Pens.Black, leftMargin, yPosition, leftMargin + usableWidth, yPosition);

            // Draw data
            Font dataFont = new Font("Arial", 9);
            yPosition += 10;

            for (int i = currentPrintRow; i < dataGridView1.Rows.Count; i++)
            {
                if (yPosition > usableHeight + topMargin)
                {
                    e.HasMorePages = true;
                    currentPrintRow = i;
                    return;
                }

                DataGridViewRow row = dataGridView1.Rows[i];
                xPosition = leftMargin;

                // Draw each cell
                for (int j = 0; j < row.Cells.Count; j++)
                {
                    if (row.Cells[j].Value != null)
                    {
                        string cellValue = row.Cells[j].Value.ToString();
                        e.Graphics.DrawString(cellValue, dataFont, Brushes.Black, 
                            new RectangleF(xPosition, yPosition, columnWidths[j], 20));
                    }
                    xPosition += columnWidths[j];
                }

                yPosition += 20;
            }

            // Draw footer
            string footer = $"Sayfa: {currentPage + 1} | Tarih: {DateTime.Now.ToString("dd/MM/yyyy")}";
            Font footerFont = new Font("Arial", 8);
            e.Graphics.DrawString(footer, footerFont, Brushes.Black, 
                new PointF(leftMargin, usableHeight + topMargin - 20));

            e.HasMorePages = false;
        }

        private void pnlHeader_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;
    }
}
