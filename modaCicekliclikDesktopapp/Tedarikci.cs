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
    public partial class Tedarikci : Form
    {
        private DBconnect dbconnect = new DBconnect();

        #region Pagination
        private int currentPage = 1;
        private int recordsPerPage = 10;
        private int totalRecords = 0;
        private int totalPages = 0;
        #endregion

        public Tedarikci()
        {
            InitializeComponent();
            LoadTedarikciler();
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

        public void LoadTedarikciler()
        {
            try
            {
                using (MySqlConnection connection = dbconnect.GetConnection())
                {
                    connection.Open();

                    // Get total record count for pagination
                    using (MySqlCommand countCommand = new MySqlCommand(
                        "SELECT COUNT(*) FROM tedarikciler WHERE " +
                        "firma_adi LIKE @search OR " +
                        "iletisim_adi LIKE @search OR " +
                        "telefon LIKE @search OR " +
                        "email LIKE @search OR " +
                        "adres LIKE @search", connection))
                    {
                        countCommand.Parameters.AddWithValue("@search", "%" + araTextbox.Text + "%");
                        totalRecords = Convert.ToInt32(countCommand.ExecuteScalar());
                        totalPages = (int)Math.Ceiling((double)totalRecords / recordsPerPage);
                    }

                    // Get paginated data
                    using (MySqlCommand dataCommand = new MySqlCommand(
                        "SELECT tedarikci_id, firma_adi, iletisim_adi, telefon, email, adres FROM tedarikciler WHERE " +
                        "firma_adi LIKE @search OR " +
                        "iletisim_adi LIKE @search OR " +
                        "telefon LIKE @search OR " +
                        "email LIKE @search OR " +
                        "adres LIKE @search " +
                        "LIMIT @Offset, @RecordsPerPage", connection))
                    {
                        dataCommand.Parameters.AddWithValue("@search", "%" + araTextbox.Text + "%");
                        dataCommand.Parameters.AddWithValue("@Offset", (currentPage - 1) * recordsPerPage);
                        dataCommand.Parameters.AddWithValue("@RecordsPerPage", recordsPerPage);

                        MySqlDataAdapter adapter = new MySqlDataAdapter(dataCommand);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        TedarikciDgv.DataSource = dataTable;
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
            frmTedarikci frmTedarikci = new frmTedarikci(this);
            frmTedarikci.ClearFields();
            frmTedarikci.btnTedarikciEkle.Enabled = true;
            frmTedarikci.btnTedarikciGuncelle.Enabled = false;
            frmTedarikci.ShowDialog();
        }

        private void araTextbox_TextChanged(object sender, EventArgs e)
        {
            currentPage = 1; // Reset to first page on search
            LoadTedarikciler();
        }

        private void tedarikciDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < TedarikciDgv.Rows.Count)
            {
                DataGridViewRow row = TedarikciDgv.Rows[e.RowIndex];
                frmTedarikci frmTedarikci = new frmTedarikci(this);
                frmTedarikci.IDlabel.Text = TedarikciDgv.Rows[e.RowIndex].Cells[0].Value.ToString();
                frmTedarikci.firmaAdiTextbox.Text = TedarikciDgv.Rows[e.RowIndex].Cells[1].Value.ToString();
                frmTedarikci.yetkiliKisiTextbox.Text = TedarikciDgv.Rows[e.RowIndex].Cells[2].Value.ToString();
                frmTedarikci.telefonTextbox.Text = TedarikciDgv.Rows[e.RowIndex].Cells[3].Value.ToString();
                frmTedarikci.emailTextbox.Text = TedarikciDgv.Rows[e.RowIndex].Cells[4].Value.ToString();
                frmTedarikci.adresTextbox.Text = TedarikciDgv.Rows[e.RowIndex].Cells[5].Value.ToString();

                frmTedarikci.btnTedarikciEkle.Enabled = false;
                frmTedarikci.btnTedarikciGuncelle.Enabled = true;
                frmTedarikci.ShowDialog();
            }
        }

        private void recordsPerPagecbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            String selectedValue = recordsPerPagecbx.SelectedItem.ToString();
            if (selectedValue == "all")
            {
                recordsPerPage = totalRecords;
            }
            else
            {
                recordsPerPage = Convert.ToInt32(selectedValue);
            }
            currentPage = 1;
            LoadTedarikciler();
        }

        private void FirstBtn_Click(object sender, EventArgs e)
        {
            currentPage = 1;
            LoadTedarikciler();
        }

        private void PreviousBtn_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                LoadTedarikciler();
            }
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPages)
            {
                currentPage++;
                LoadTedarikciler();
            }
        }

        private void LastBtn_Click(object sender, EventArgs e)
        {
            currentPage = totalPages;
            LoadTedarikciler();
        }

        private void PrintTedarikciBtn_Click(object sender, EventArgs e)
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
            e.PageSettings.PaperSize = new PaperSize("A4", 827, 1169);

            int leftMargin = 50;
            int topMargin = 50;
            int rightMargin = 50;
            int bottomMargin = 50;

            int usableWidth = e.PageSettings.PaperSize.Width - leftMargin - rightMargin;
            int usableHeight = e.PageSettings.PaperSize.Height - topMargin - bottomMargin;

            Bitmap bitmap = Properties.Resources.samsunmodacicekciliklogo11;
            System.Drawing.Image image = bitmap;
            e.Graphics.DrawImage(image, new Point(leftMargin, topMargin));

            string title = "Tedarikçi Listesi";
            Font titleFont = new Font("Arial", 14, FontStyle.Bold);
            SizeF titleSize = e.Graphics.MeasureString(title, titleFont);
            e.Graphics.DrawString(title, titleFont, Brushes.Black, 
                new PointF(leftMargin + (usableWidth - titleSize.Width) / 2, topMargin + 100));

            Font headerFont = new Font("Arial", 10, FontStyle.Bold);
            int yPosition = topMargin + 150;
            int[] columnWidths = { 50, 150, 100, 100, 150, 200 };
            string[] headers = { "No", "Firma Adı", "Yetkili Kişi", "Telefon", "Email", "Adres" };
            
            int xPosition = leftMargin;
            for (int i = 0; i < headers.Length; i++)
            {
                e.Graphics.DrawString(headers[i], headerFont, Brushes.Black, new PointF(xPosition, yPosition));
                xPosition += columnWidths[i];
            }

            yPosition += 20;
            e.Graphics.DrawLine(Pens.Black, leftMargin, yPosition, leftMargin + usableWidth, yPosition);

            Font dataFont = new Font("Arial", 9);
            yPosition += 10;

            for (int i = currentPrintRow; i < TedarikciDgv.Rows.Count; i++)
            {
                if (yPosition > usableHeight + topMargin)
                {
                    e.HasMorePages = true;
                    currentPrintRow = i;
                    return;
                }

                DataGridViewRow row = TedarikciDgv.Rows[i];
                xPosition = leftMargin;

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

            string footer = $"Sayfa: {currentPage + 1} | Tarih: {DateTime.Now.ToString("dd/MM/yyyy")}";
            Font footerFont = new Font("Arial", 8);
            e.Graphics.DrawString(footer, footerFont, Brushes.Black, 
                new PointF(leftMargin, usableHeight + topMargin - 20));

            e.HasMorePages = false;
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tedarikçiyi silmek istediğinizden emin misiniz?", "Onay", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sql = "DELETE FROM tedarikciler WHERE tedarikci_id = @tedarikci_id";
                try
                {
                    using (MySqlConnection connection = dbconnect.GetConnection())
                    {
                        connection.Open();
                        using (MySqlCommand command = new MySqlCommand(sql, connection))
                        {
                            command.Parameters.AddWithValue("@tedarikci_id", TedarikciDgv.CurrentRow.Cells[0].Value);
                            int result = command.ExecuteNonQuery();
                            if (result > 0)
                            {
                                MessageBox.Show("Tedarikçi başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadTedarikciler();
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
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (TedarikciDgv.SelectedRows.Count > 0)
            {
                DataGridViewRow row = TedarikciDgv.SelectedRows[0];
                frmTedarikci frmTedarikci = new frmTedarikci(this);
                
                frmTedarikci.IDlabel.Text = row.Cells["tedarikci_id"].Value.ToString();
                frmTedarikci.firmaAdiTextbox.Text = row.Cells["firma_adi"].Value.ToString();
                frmTedarikci.yetkiliKisiTextbox.Text = row.Cells["iletisim_adi"].Value.ToString();
                frmTedarikci.telefonTextbox.Text = row.Cells["telefon"].Value.ToString();
                frmTedarikci.emailTextbox.Text = row.Cells["email"].Value.ToString();
                frmTedarikci.adresTextbox.Text = row.Cells["adres"].Value.ToString();

                frmTedarikci.btnTedarikciEkle.Enabled = false;
                frmTedarikci.btnTedarikciGuncelle.Enabled = true;
                
                frmTedarikci.ShowDialog();
            }
            else
            {
                MessageBox.Show("Lütfen güncellemek istediğiniz tedarikçiyi seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
