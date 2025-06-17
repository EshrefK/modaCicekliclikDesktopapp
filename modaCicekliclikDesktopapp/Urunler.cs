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

namespace modaCicekliclikDesktopapp
{
    public partial class Urunler : Form
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

        public Urunler()
        {
            InitializeComponent();
            LoadUrunler();
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

        public void LoadUrunler()
        {
            try
            {
                using (MySqlConnection connection = dbconnect.GetConnection())
                {
                    connection.Open();

                    // Get total record count for pagination
                    using (MySqlCommand countCommand = new MySqlCommand(
                        "SELECT COUNT(*) FROM urunler WHERE " +
                        "urun_adi LIKE @search OR " +
                        "alisFiyati LIKE @search OR " +
                        "satisFiyati LIKE @search OR " +
                        "stok_miktari LIKE @search", connection))
                    {
                        countCommand.Parameters.AddWithValue("@search", "%" + araTextbox.Text + "%");
                        totalRecords = Convert.ToInt32(countCommand.ExecuteScalar());
                        totalPages = (int)Math.Ceiling((double)totalRecords / recordsPerPage);
                    }

                    // Get paginated data
                    using (MySqlCommand dataCommand = new MySqlCommand(
                        "SELECT urun_id, urun_adi, alisFiyati, satisFiyati, stok_miktari FROM urunler WHERE " +
                        "urun_adi LIKE @search OR " +
                        "alisFiyati LIKE @search OR " +
                        "satisFiyati LIKE @search OR " +
                        "stok_miktari LIKE @search " +
                        "LIMIT @Offset, @RecordsPerPage", connection))
                    {
                        dataCommand.Parameters.AddWithValue("@search", "%" + araTextbox.Text + "%");
                        dataCommand.Parameters.AddWithValue("@Offset", (currentPage - 1) * recordsPerPage);
                        dataCommand.Parameters.AddWithValue("@RecordsPerPage", recordsPerPage);

                        MySqlDataAdapter adapter = new MySqlDataAdapter(dataCommand);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        UrunDgv.DataSource = dataTable;
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
            frmUrun frmUrun = new frmUrun(this);
            
            // Clear any existing data
            frmUrun.ClearFields();
            // Enable add button and disable update button
            frmUrun.btnUrunEkle.Enabled = true;
            frmUrun.btnUrunGuncelle.Enabled = false;
            
            frmUrun.ShowDialog();
        }

        private void araTextbox_TextChanged(object sender, EventArgs e)
        {
            currentPage = 1; // Reset to first page on search
            LoadUrunler();
        }

        private void urunDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < UrunDgv.Rows.Count)
            {
                DataGridViewRow row = UrunDgv.Rows[e.RowIndex];
                frmUrun frmUrun = new frmUrun(this);
                frmUrun.IDlabel.Text = UrunDgv.Rows[e.RowIndex].Cells[0].Value.ToString();
                frmUrun.urunAdiTextbox.Text = UrunDgv.Rows[e.RowIndex].Cells[1].Value.ToString();
                frmUrun.alisFiyatiTextbox.Text = UrunDgv.Rows[e.RowIndex].Cells[2].Value.ToString();
                frmUrun.satisFiyatiTextbox.Text = UrunDgv.Rows[e.RowIndex].Cells[3].Value.ToString();
                frmUrun.stokMiktariTextbox.Text = UrunDgv.Rows[e.RowIndex].Cells[4].Value.ToString();

                frmUrun.btnUrunEkle.Enabled = false; // Disable add button
                frmUrun.btnUrunGuncelle.Enabled = true; // Enable update button
                frmUrun.ShowDialog();
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
            LoadUrunler();
        }

        private void FirstBtn_Click(object sender, EventArgs e)
        {
            currentPage = 1;
            LoadUrunler();
        }

        private void PreviousBtn_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                LoadUrunler();
            }
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPages)
            {
                currentPage++;
                LoadUrunler();
            }
        }

        private void LastBtn_Click(object sender, EventArgs e)
        {
            currentPage = totalPages;
            LoadUrunler();
        }

        private void PrintUrunBtn_Click(object sender, EventArgs e)
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
            string title = "Ürün Listesi";
            Font titleFont = new Font("Arial", 14, FontStyle.Bold);
            SizeF titleSize = e.Graphics.MeasureString(title, titleFont);
            e.Graphics.DrawString(title, titleFont, Brushes.Black, 
                new PointF(leftMargin + (usableWidth - titleSize.Width) / 2, topMargin + 100));

            // Column headers
            Font headerFont = new Font("Arial", 10, FontStyle.Bold);
            int yPosition = topMargin + 150;
            int[] columnWidths = { 50, 200, 100, 100, 100 }; // Adjusted for actual columns
            string[] headers = { "No", "Ürün Adı", "Alış Fiyatı", "Satış Fiyatı", "Stok Miktarı" };
            
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

            for (int i = currentPrintRow; i < UrunDgv.Rows.Count; i++)
            {
                if (yPosition > usableHeight + topMargin)
                {
                    e.HasMorePages = true;
                    currentPrintRow = i;
                    return;
                }

                DataGridViewRow row = UrunDgv.Rows[i];
                xPosition = leftMargin;

                // Draw each cell
                for (int j = 0; j < row.Cells.Count; j++)
                {
                    if (row.Cells[j].Value != null)
                    {
                        string cellValue = row.Cells[j].Value.ToString();
                        if (j == 2 || j == 3) // Format price columns
                        {
                            cellValue = string.Format("{0:N2} ₺", Convert.ToDecimal(cellValue));
                        }
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

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM urunler WHERE urun_id = @urun_id";
            try
            {
                using (MySqlConnection connection = dbconnect.GetConnection())
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@urun_id", UrunDgv.CurrentRow.Cells[0].Value);
                        int result = command.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Ürün başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadUrunler(); // Refresh the data grid
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
            if (UrunDgv.SelectedRows.Count > 0)
            {
                DataGridViewRow row = UrunDgv.SelectedRows[0];
                frmUrun frmUrun = new frmUrun(this);
                
                // Set the ID and other fields
                frmUrun.IDlabel.Text = row.Cells["urun_id"].Value.ToString();
                frmUrun.urunAdiTextbox.Text = row.Cells["urun_adi"].Value.ToString();
                frmUrun.alisFiyatiTextbox.Text = row.Cells["alisFiyati"].Value.ToString();
                frmUrun.satisFiyatiTextbox.Text = row.Cells["satisFiyati"].Value.ToString();
                frmUrun.stokMiktariTextbox.Text = row.Cells["stok_miktari"].Value.ToString();

                // Disable add button and enable update button
                frmUrun.btnUrunEkle.Enabled = false;
                frmUrun.btnUrunGuncelle.Enabled = true;
                
                frmUrun.ShowDialog();
            }
            else
            {
                MessageBox.Show("Lütfen güncellemek istediğiniz ürünü seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
