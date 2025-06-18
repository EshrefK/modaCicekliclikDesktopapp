using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Org.BouncyCastle.Asn1.BC;
using MySql.Data.MySqlClient;
using System.Drawing.Text;
using System.Drawing.Printing;

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
            // Add options for records per page
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
                        "SELECT COUNT(*) FROM satislar WHERE " +
                        "musteri_adi LIKE @search OR " +
                        "urun_adi LIKE @search OR " +
                        "miktar LIKE @search OR " +
                        "toplam_fiyat LIKE @search", connection))
                    {
                        countCommand.Parameters.AddWithValue("@search", "%" + araTextbox.Text + "%");
                        totalRecords = Convert.ToInt32(countCommand.ExecuteScalar());
                        totalPages = (int)Math.Ceiling((double)totalRecords / recordsPerPage);
                    }

                    // Get paginated data - select all columns that exist in the table with proper aliases
                    string sqlQuery = "SELECT satis_id AS 'Satış No', satis_tarihi AS 'Tarih', musteri_adi AS 'Müşteri Adı', urun_adi AS 'Ürün Adı', miktar AS 'Miktar', toplam_fiyat AS 'Toplam Fiyat' FROM satislar WHERE " +
                        "musteri_adi LIKE @search OR " +
                        "urun_adi LIKE @search OR " +
                        "miktar LIKE @search OR " +
                        "toplam_fiyat LIKE @search " +
                        "ORDER BY satis_tarihi DESC " +
                        "LIMIT @Offset, @RecordsPerPage";

                    using (MySqlCommand dataCommand = new MySqlCommand(sqlQuery, connection))
                    {
                        dataCommand.Parameters.AddWithValue("@search", "%" + araTextbox.Text + "%");
                        dataCommand.Parameters.AddWithValue("@Offset", (currentPage - 1) * recordsPerPage);
                        dataCommand.Parameters.AddWithValue("@RecordsPerPage", recordsPerPage);

                        MySqlDataAdapter adapter = new MySqlDataAdapter(dataCommand);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        SatislarDgv.DataSource = dataTable;
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

        private void addnewBtn_Click(object sender, EventArgs e)
        {
            frmSatislar frmSatislar = new frmSatislar(this);

            // Clear any existing data
            frmSatislar.ClearFields();
            // Enable add button and disable update button
            frmSatislar.btnsatisEkle.Enabled = true;
            frmSatislar.btnsatisGuncelle.Enabled = false;

            frmSatislar.ShowDialog();
        }

        private void araTextbox_TextChanged(object sender, EventArgs e)
        {
            currentPage = 1; // Reset to first page on search
            LoadSatislar();
        }

        private void SatislarDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < SatislarDgv.Rows.Count)
            {
                DataGridViewRow row = SatislarDgv.Rows[e.RowIndex];
                frmSatislar frmSatislar = new frmSatislar(this);
                frmSatislar.IDlabel.Text = SatislarDgv.Rows[e.RowIndex].Cells[0].Value.ToString(); // Satış No
                frmSatislar.musteriadTextbox.Text = SatislarDgv.Rows[e.RowIndex].Cells[2].Value.ToString(); // Müşteri Adı
                frmSatislar.urunAdiTextbox.Text = SatislarDgv.Rows[e.RowIndex].Cells[3].Value.ToString(); // Ürün Adı
                frmSatislar.satismiktarTextbox.Text = SatislarDgv.Rows[e.RowIndex].Cells[4].Value.ToString(); // Miktar
                frmSatislar.toplamtutarTextbox.Text = SatislarDgv.Rows[e.RowIndex].Cells[5].Value.ToString(); // Toplam Fiyat

                frmSatislar.btnsatisEkle.Enabled = false; // Disable add button
                frmSatislar.btnsatisGuncelle.Enabled = true; // Enable update button
                frmSatislar.ShowDialog();
            }
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
            LoadSatislar();
        }
        private void FirstBtn_Click(object sender, EventArgs e)
        {
            currentPage = 1;
            LoadSatislar();
        }

        private void PreviousBtn_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                LoadSatislar();
            }
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPages)
            {
                currentPage++;
                LoadSatislar();
            }
        }

        private void LastBtn_Click(object sender, EventArgs e)
        {
            currentPage = totalPages;
            LoadSatislar();
        }

        private void PrintSatislarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                currentPrintRow = 0; // Reset to start from the beginning
                PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
                printPreviewDialog.Document = satislarprintDocument1;
                printPreviewDialog.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private int currentPrintRow = 0; // Track the current row being printed

        private void satislarprintDocument1_PrintPage(object sender, PrintPageEventArgs e)
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
            string title = "Satışlar Listesi";
            Font titleFont = new Font("Arial", 14, FontStyle.Bold);
            SizeF titleSize = e.Graphics.MeasureString(title, titleFont);
            e.Graphics.DrawString(title, titleFont, Brushes.Black,
                new PointF(leftMargin + (usableWidth - titleSize.Width) / 2, topMargin + 100));

            // Column headers
            Font headerFont = new Font("Arial", 10, FontStyle.Bold);
            int yPosition = topMargin + 150;
            int[] columnWidths = { 50, 80, 100, 100, 60, 80 }; // Adjust these values as needed
            string[] headers = { "No", "Tarih", "Müşteri Adı", "Ürün Adı", "Miktar", "Tutar" };

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

            for (int i = currentPrintRow; i < SatislarDgv.Rows.Count; i++)
            {
                if (yPosition > usableHeight + topMargin)
                {
                    e.HasMorePages = true;
                    currentPrintRow = i;
                    return;
                }

                DataGridViewRow row = SatislarDgv.Rows[i];
                xPosition = leftMargin;

                // Draw each cell
                for (int j = 0; j < row.Cells.Count; j++)
                {
                    if (row.Cells[j].Value != null)
                    {
                        string cellValue = row.Cells[j].Value.ToString();
                        
                        // Format date if it's the date column
                        if (j == 1 && DateTime.TryParse(cellValue, out DateTime dateValue))
                        {
                            cellValue = dateValue.ToString("dd/MM/yyyy");
                        }
                        
                        e.Graphics.DrawString(cellValue, dataFont, Brushes.Black,
                            new RectangleF(xPosition, yPosition, columnWidths[j], 20));
                    }
                    xPosition += columnWidths[j];
                }

                yPosition += 20;
            }

            // Draw footer
            string footer = $"Sayfa: 1 | Tarih: {DateTime.Now.ToString("dd/MM/yyyy")}";
            Font footerFont = new Font("Arial", 8);
            e.Graphics.DrawString(footer, footerFont, Brushes.Black,
                new PointF(leftMargin, usableHeight + topMargin - 20));

            e.HasMorePages = false;
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM satislar WHERE satis_id = @satis_id";
            try
            {
                using (MySqlConnection connection = dbconnect.GetConnection())
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@satis_id", SatislarDgv.CurrentRow.Cells[0].Value);
                        int result = command.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Satış başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadSatislar(); // Refresh the data grid
                        }
                        else
                        {
                            MessageBox.Show("Silme işlemi başarısız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (SatislarDgv.SelectedRows.Count > 0)
            {
                DataGridViewRow row = SatislarDgv.SelectedRows[0];
                frmSatislar frmSatislar = new frmSatislar(this);

                // Set the ID and other fields using column indices
                frmSatislar.IDlabel.Text = row.Cells[0].Value.ToString(); // Satış No
                frmSatislar.musteriadTextbox.Text = row.Cells[2].Value.ToString(); // Müşteri Adı
                frmSatislar.urunAdiTextbox.Text = row.Cells[3].Value.ToString(); // Ürün Adı
                frmSatislar.satismiktarTextbox.Text = row.Cells[4].Value.ToString(); // Miktar
                frmSatislar.toplamtutarTextbox.Text = row.Cells[5].Value.ToString(); // Toplam Fiyat
                
                // Disable add button and enable update button
                frmSatislar.btnsatisEkle.Enabled = false;
                frmSatislar.btnsatisGuncelle.Enabled = true;

                frmSatislar.ShowDialog();
            }
            else
            {
                MessageBox.Show("Lütfen güncellemek istediğiniz sırayı seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


    }
}
