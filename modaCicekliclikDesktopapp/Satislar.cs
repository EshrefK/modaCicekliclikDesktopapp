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
using System.Drawing.Printing;
using System.Runtime.InteropServices;

namespace modaCicekliclikDesktopapp
{
    public partial class Satislar : Form
    {
        #region Mysqlconnection
        DBconnect dbconnect = new DBconnect();
        #endregion

        #region Pagination
        private int currentPage = 1;
        private int recordsPerPage = 10;
        private int totalRecords = 0;
        private int totalPages = 0;
        #endregion

        public Satislar()
        {
            InitializeComponent();
            LoadSatislar();
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

        public void LoadSatislar()
        {
            try
            {
                using (MySqlConnection connection = dbconnect.GetConnection())
                {
                    connection.Open();

                    // Get total record count for pagination
                    using (MySqlCommand countCommand = new MySqlCommand(
                        "SELECT COUNT(*) FROM satislar s " +
                        "INNER JOIN musteriler m ON s.musteri_id = m.musteri_id " +
                        "INNER JOIN urunler u ON s.urun_id = u.urun_id " +
                        "WHERE m.ad LIKE @search OR " +
                        "m.soyad LIKE @search OR " +
                        "u.urun_adi LIKE @search", connection))
                    {
                        countCommand.Parameters.AddWithValue("@search", "%" + araTextbox.Text + "%");
                        totalRecords = Convert.ToInt32(countCommand.ExecuteScalar());
                        totalPages = (int)Math.Ceiling((double)totalRecords / recordsPerPage);
                    }

                    // Get paginated data
                    using (MySqlCommand dataCommand = new MySqlCommand(
                        "SELECT s.satis_id, s.satis_tarihi, CONCAT(m.ad, ' ', m.soyad) as musteri_adi, " +
                        "u.urun_adi, s.miktar, s.satis_fiyat " +
                        "FROM satislar s " +
                        "INNER JOIN musteriler m ON s.musteri_id = m.musteri_id " +
                        "INNER JOIN urunler u ON s.urun_id = u.urun_id " +
                        "WHERE m.ad LIKE @search OR " +
                        "m.soyad LIKE @search OR " +
                        "u.urun_adi LIKE @search " +
                        "ORDER BY s.satis_tarihi DESC " +
                        "LIMIT @Offset, @RecordsPerPage", connection))
                    {
                        dataCommand.Parameters.AddWithValue("@search", "%" + araTextbox.Text + "%");
                        dataCommand.Parameters.AddWithValue("@Offset", (currentPage - 1) * recordsPerPage);
                        dataCommand.Parameters.AddWithValue("@RecordsPerPage", recordsPerPage);

                        MySqlDataAdapter adapter = new MySqlDataAdapter(dataCommand);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        SatisDgv.DataSource = dataTable;
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

        private void btnSatisEkle_Click(object sender, EventArgs e)
        {
            frmSatis frmSatis = new frmSatis(this);
            frmSatis.ShowDialog();
        }

        private void btnSatisGuncelle_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                frmSatis frmSatis = new frmSatis(this);
                
                // Set the form title
                frmSatis.Text = "Satış Güncelle";
                frmSatis.lblTitle.Text = "Satış Güncelle";

                // Hide the add button and show the update button
                frmSatis.btnSatisEkle.Visible = false;
                frmSatis.btnSatisGuncelle.Visible = true;

                // Set the ID for update
                frmSatis.IDlabel.Text = row.Cells["satis_id"].Value.ToString();

                // Load the data
                frmSatis.musteriComboBox.Text = row.Cells["musteri_adi"].Value.ToString();
                frmSatis.urunComboBox.Text = row.Cells["urun_adi"].Value.ToString();
                frmSatis.satisTarihiDateTimePicker.Value = Convert.ToDateTime(row.Cells["satis_tarihi"].Value);
                frmSatis.miktarTextbox.Text = row.Cells["miktar"].Value.ToString();
                frmSatis.toplamFiyatTextbox.Text = row.Cells["satis_fiyat"].Value.ToString();

                frmSatis.ShowDialog();
            }
            else
            {
                MessageBox.Show("Lütfen güncellenecek satışı seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSatisSil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Seçili satışı silmek istediğinize emin misiniz?", "Onay", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        using (MySqlConnection connection = dbconnect.GetConnection())
                        {
                            connection.Open();
                            using (MySqlCommand command = new MySqlCommand(
                                "DELETE FROM satislar WHERE satis_id = @id", connection))
                            {
                                command.Parameters.AddWithValue("@id", 
                                    dataGridView1.SelectedRows[0].Cells["satis_id"].Value);
                                
                                int result = command.ExecuteNonQuery();
                                if (result > 0)
                                {
                                    MessageBox.Show("Satış başarıyla silindi.", "Bilgi", 
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    LoadSatislar();
                                }
                                else
                                {
                                    MessageBox.Show("Satış silinemedi.", "Hata", 
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
                MessageBox.Show("Lütfen silinecek satışı seçin.", "Uyarı", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void araTextbox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection connection = dbconnect.GetConnection())
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(
                        "SELECT s.satis_id, CONCAT(m.ad, ' ', m.soyad) as musteri_adi, u.urun_adi, " +
                        "s.satis_tarihi, s.miktar, s.toplam_fiyat " +
                        "FROM satislar s " +
                        "INNER JOIN musteriler m ON s.musteri_id = m.musteri_id " +
                        "INNER JOIN urunler u ON s.urun_id = u.urun_id " +
                        "WHERE CONCAT(m.ad, ' ', m.soyad) LIKE @search " +
                        "OR u.urun_adi LIKE @search " +
                        "ORDER BY s.satis_tarihi DESC", connection))
                    {
                        command.Parameters.AddWithValue("@search", "%" + araTextbox.Text + "%");
                        MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridView1.DataSource = dataTable;

                        // Hide the satis_id column
                        dataGridView1.Columns["satis_id"].Visible = false;

                        // Set column headers
                        dataGridView1.Columns["musteri_adi"].HeaderText = "Müşteri";
                        dataGridView1.Columns["urun_adi"].HeaderText = "Ürün";
                        dataGridView1.Columns["satis_tarihi"].HeaderText = "Satış Tarihi";
                        dataGridView1.Columns["miktar"].HeaderText = "Miktar";
                        dataGridView1.Columns["toplam_fiyat"].HeaderText = "Toplam Fiyat";

                        // Format the date column
                        dataGridView1.Columns["satis_tarihi"].DefaultCellStyle.Format = "dd.MM.yyyy";

                        // Format the price column
                        dataGridView1.Columns["toplam_fiyat"].DefaultCellStyle.Format = "N2";
                        dataGridView1.Columns["toplam_fiyat"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void PrintSatisBtn_Click(object sender, EventArgs e)
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

        private int currentPrintRow = 0; // Track the current row being printed
        
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
            string title = "Satış Listesi";
            Font titleFont = new Font("Arial", 14, FontStyle.Bold);
            SizeF titleSize = e.Graphics.MeasureString(title, titleFont);
            e.Graphics.DrawString(title, titleFont, Brushes.Black, 
                new PointF(leftMargin + (usableWidth - titleSize.Width) / 2, topMargin + 100));

            // Column headers
            Font headerFont = new Font("Arial", 10, FontStyle.Bold);
            int yPosition = topMargin + 150;
            int[] columnWidths = { 50, 100, 150, 150, 80, 100 }; // Adjusted for actual columns
            string[] headers = { "No", "Tarih", "Müşteri", "Ürün", "Miktar", "Satış Fiyatı" };
            
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
    }
}
