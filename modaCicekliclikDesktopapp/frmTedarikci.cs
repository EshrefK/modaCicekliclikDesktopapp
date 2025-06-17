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

namespace modaCicekliclikDesktopapp
{
    public partial class frmTedarikci : Form
    {
        private DBconnect dbconnect = new DBconnect();
        private Tedarikci parentForm;

        public frmTedarikci(Tedarikci parent)
        {
            InitializeComponent();
            parentForm = parent;
        }

        private void btnTedarikciEkle_Click(object sender, EventArgs e)
        {
            if (ValidateInputSave())
            {
                string sql = "INSERT INTO tedarikciler (firma_adi, iletisim_adi, telefon, email, adres) VALUES (@firma_adi, @iletisim_adi, @telefon, @email, @adres)";
                try
                {
                    using (MySqlConnection connection = dbconnect.GetConnection())
                    {
                        connection.Open();
                        using (MySqlCommand command = new MySqlCommand(sql, connection))
                        {
                            command.Parameters.AddWithValue("@firma_adi", firmaAdiTextbox.Text);
                            command.Parameters.AddWithValue("@iletisim_adi", yetkiliKisiTextbox.Text);
                            command.Parameters.AddWithValue("@telefon", telefonTextbox.Text);
                            command.Parameters.AddWithValue("@email", emailTextbox.Text);
                            command.Parameters.AddWithValue("@adres", adresTextbox.Text);

                            int result = command.ExecuteNonQuery();
                            if (result > 0)
                            {
                                MessageBox.Show("Tedarikçi başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                ClearFields();
                                parentForm.LoadTedarikciler();
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Tedarikçi eklenemedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnTedarikciGuncelle_Click(object sender, EventArgs e)
        {
            if (ValidateInputSave())
            {
                string sql = "UPDATE tedarikciler SET firma_adi = @firma_adi, iletisim_adi = @iletisim_adi, telefon = @telefon, email = @email, adres = @adres WHERE tedarikci_id = @tedarikci_id";
                try
                {
                    using (MySqlConnection connection = dbconnect.GetConnection())
                    {
                        connection.Open();
                        using (MySqlCommand command = new MySqlCommand(sql, connection))
                        {
                            command.Parameters.AddWithValue("@tedarikci_id", IDlabel.Text);
                            command.Parameters.AddWithValue("@firma_adi", firmaAdiTextbox.Text);
                            command.Parameters.AddWithValue("@iletisim_adi", yetkiliKisiTextbox.Text);
                            command.Parameters.AddWithValue("@telefon", telefonTextbox.Text);
                            command.Parameters.AddWithValue("@email", emailTextbox.Text);
                            command.Parameters.AddWithValue("@adres", adresTextbox.Text);

                            int result = command.ExecuteNonQuery();
                            if (result > 0)
                            {
                                MessageBox.Show("Tedarikçi başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                parentForm.LoadTedarikciler();
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Tedarikçi güncellenemedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private bool ValidateInputSave()
        {
            if (string.IsNullOrWhiteSpace(firmaAdiTextbox.Text))
            {
                MessageBox.Show("Lütfen firma adını giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                firmaAdiTextbox.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(yetkiliKisiTextbox.Text))
            {
                MessageBox.Show("Lütfen yetkili kişiyi giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                yetkiliKisiTextbox.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(telefonTextbox.Text))
            {
                MessageBox.Show("Lütfen telefon numarasını giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                telefonTextbox.Focus();
                return false;
            }
            return true;
        }

        public void ClearFields()
        {
            firmaAdiTextbox.Text = "";
            yetkiliKisiTextbox.Text = "";
            telefonTextbox.Text = "";
            emailTextbox.Text = "";
            ilTextbox.Text = "";
            ilceTextbox.Text = "";
            adresTextbox.Text = "";
            IDlabel.Text = "";
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