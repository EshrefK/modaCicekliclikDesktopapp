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

    public partial class Musteriler : Form
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
        public Musteriler()
        {
            InitializeComponent();

            LoadMusteri();

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

        public void LoadMusteri()
        {
            try
            {
                using (MySqlConnection connection = dbconnect.GetConnection())
                {
                    connection.Open();

                    // Get total record count for pagination
                    using (MySqlCommand countCommand = new MySqlCommand(
                        "SELECT COUNT(*) FROM musteriler WHERE " +
                        "ad LIKE @search OR " +
                        "soyad LIKE @search OR " +
                        "telefon LIKE @search OR " +
                        "email LIKE @search OR " +
                        "il LIKE @search OR " +
                        "ilce LIKE @search OR " +
                        "adres LIKE @search", connection))
                    {
                        countCommand.Parameters.AddWithValue("@search", "%" + araTextbox.Text + "%");
                        totalRecords = Convert.ToInt32(countCommand.ExecuteScalar());
                        totalPages = (int)Math.Ceiling((double)totalRecords / recordsPerPage);
                    }

                    // Get paginated data
                    using (MySqlCommand dataCommand = new MySqlCommand(
                        "SELECT musteri_id, ad, soyad, telefon, email, il, ilce, adres FROM musteriler WHERE " +
                        "ad LIKE @search OR " +
                        "soyad LIKE @search OR " +
                        "telefon LIKE @search OR " +
                        "email LIKE @search OR " +
                        "il LIKE @search OR " +
                        "ilce LIKE @search OR " +
                        "adres LIKE @search " +
                        "LIMIT @Offset, @RecordsPerPage", connection))
                    {
                        dataCommand.Parameters.AddWithValue("@search", "%" + araTextbox.Text + "%");
                        dataCommand.Parameters.AddWithValue("@Offset", (currentPage - 1) * recordsPerPage);
                        dataCommand.Parameters.AddWithValue("@RecordsPerPage", recordsPerPage);

                        MySqlDataAdapter adapter = new MySqlDataAdapter(dataCommand);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        MusteriDgv.DataSource = dataTable;
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
            frmMusteri frmMusteri = new frmMusteri(this);
            
            // Clear any existing data
            frmMusteri.ClearFields();
            // Enable add button and disable update button
            frmMusteri.btnmusteriEkle.Enabled = true;
            frmMusteri.btnmusteriGuncelle.Enabled = false;
            
            frmMusteri.ShowDialog();
        }

        private void araTextbox_TextChanged(object sender, EventArgs e)
        {
            currentPage = 1; // Reset to first page on search
            LoadMusteri();
        }

        private System.Windows.Forms.Timer searchTimer;

        private void musteriDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < MusteriDgv.Rows.Count)
            {
                DataGridViewRow row = MusteriDgv.Rows[e.RowIndex];
                int musteriId = Convert.ToInt32(row.Cells["musteri_id"].Value);
                frmMusteri frmMusteri = new frmMusteri(this);
                frmMusteri.IDlabel.Text = MusteriDgv.Rows[e.RowIndex].Cells[0].Value.ToString();
                frmMusteri.musteriadTextbox.Text = MusteriDgv.Rows[e.RowIndex].Cells[1].Value.ToString();
                frmMusteri.musterisoyadTextbox.Text = MusteriDgv.Rows[e.RowIndex].Cells[2].Value.ToString();
                frmMusteri.musteritelefonTextbox.Text = MusteriDgv.Rows[e.RowIndex].Cells[3].Value.ToString();
                frmMusteri.musteriemailTextbox.Text = MusteriDgv.Rows[e.RowIndex].Cells[4].Value.ToString();
                frmMusteri.musteriilTextbox.Text = MusteriDgv.Rows[e.RowIndex].Cells[5].Value.ToString();
                frmMusteri.musteriilceTextbox.Text = MusteriDgv.Rows[e.RowIndex].Cells[6].Value.ToString();
                frmMusteri.musteriadresTextbox.Text = MusteriDgv.Rows[e.RowIndex].Cells[7].Value.ToString();

                frmMusteri.btnmusteriEkle.Enabled = false; // Disable add button
                frmMusteri.btnmusteriGuncelle.Enabled = true; // Enable update button
                frmMusteri.ShowDialog();
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
            LoadMusteri();
        }

        private void FirstBtn_Click(object sender, EventArgs e)
        {
            currentPage = 1;
            LoadMusteri();
        }

        private void PreviousBtn_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                LoadMusteri();
            }
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPages)
            {
                currentPage++;
                LoadMusteri();
            }
        }
        private void LastBtn_Click(object sender, EventArgs e)
        {
            currentPage = totalPages;
            LoadMusteri();
        }

        private void PrintMusteriBtn_Click(object sender, EventArgs e)
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
            string title = "Müşteri Listesi";
            Font titleFont = new Font("Arial", 14, FontStyle.Bold);
            SizeF titleSize = e.Graphics.MeasureString(title, titleFont);
            e.Graphics.DrawString(title, titleFont, Brushes.Black, 
                new PointF(leftMargin + (usableWidth - titleSize.Width) / 2, topMargin + 100));

            // Column headers
            Font headerFont = new Font("Arial", 10, FontStyle.Bold);
            int yPosition = topMargin + 150;
            int[] columnWidths = { 50, 100, 100, 100, 150, 80, 80, 150 }; // Adjust these values as needed
            string[] headers = { "No", "Ad", "Soyad", "Telefon", "Email", "İl", "İlçe", "Adres" };
            
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

            for (int i = currentPrintRow; i < MusteriDgv.Rows.Count; i++)
            {
                if (yPosition > usableHeight + topMargin)
                {
                    e.HasMorePages = true;
                    currentPrintRow = i;
                    return;
                }

                DataGridViewRow row = MusteriDgv.Rows[i];
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

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM musteriler WHERE musteri_id = @musteri_id";
            try
            {
                using (MySqlConnection connection = dbconnect.GetConnection())
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@musteri_id", MusteriDgv.CurrentRow.Cells[0].Value);
                        int result = command.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Müşteri başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadMusteri(); // Refresh the data grid
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
            if (MusteriDgv.SelectedRows.Count > 0)
            {
                DataGridViewRow row = MusteriDgv.SelectedRows[0];
                frmMusteri frmMusteri = new frmMusteri(this);
                
                // Set the ID and other fields
                frmMusteri.IDlabel.Text = row.Cells["musteri_id"].Value.ToString();
                frmMusteri.musteriadTextbox.Text = row.Cells["ad"].Value.ToString();
                frmMusteri.musterisoyadTextbox.Text = row.Cells["soyad"].Value.ToString();
                frmMusteri.musteritelefonTextbox.Text = row.Cells["telefon"].Value.ToString();
                frmMusteri.musteriemailTextbox.Text = row.Cells["email"].Value.ToString();
                frmMusteri.musteriilTextbox.Text = row.Cells["il"].Value.ToString();
                frmMusteri.musteriilceTextbox.Text = row.Cells["ilce"].Value.ToString();
                frmMusteri.musteriadresTextbox.Text = row.Cells["adres"].Value.ToString();

                // Disable add button and enable update button
                frmMusteri.btnmusteriEkle.Enabled = false;
                frmMusteri.btnmusteriGuncelle.Enabled = true;
                
                frmMusteri.ShowDialog();
            }
            else
            {
                MessageBox.Show("Lütfen güncellemek istediğiniz müşteriyi seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
