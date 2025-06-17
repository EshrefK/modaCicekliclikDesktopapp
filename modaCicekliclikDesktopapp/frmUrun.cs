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
    public partial class frmUrun : Form
    {
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;

        private DBconnect dbconnect = new DBconnect();
        private Urunler parentForm;

        public frmUrun(Urunler parent)
        {
            InitializeComponent();
            parentForm = parent;
        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            if (ValidateInputSave())
            {
                string sql = "INSERT INTO urunler (urun_adi, alisFiyati, satisFiyati, stok_miktari) VALUES (@urun_adi, @alisFiyati, @satisFiyati, @stok_miktari)";
                try
                {
                    using (MySqlConnection connection = dbconnect.GetConnection())
                    {
                        connection.Open();
                        using (MySqlCommand command = new MySqlCommand(sql, connection))
                        {
                            command.Parameters.AddWithValue("@urun_adi", urunAdiTextbox.Text);
                            command.Parameters.AddWithValue("@alisFiyati", Convert.ToDecimal(alisFiyatiTextbox.Text));
                            command.Parameters.AddWithValue("@satisFiyati", Convert.ToDecimal(satisFiyatiTextbox.Text));
                            command.Parameters.AddWithValue("@stok_miktari", Convert.ToInt32(stokMiktariTextbox.Text));

                            int result = command.ExecuteNonQuery();
                            if (result > 0)
                            {
                                MessageBox.Show("Ürün başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                ClearFields();
                                parentForm.LoadUrunler();
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Ürün eklenemedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnUrunGuncelle_Click(object sender, EventArgs e)
        {
            if (ValidateInputSave())
            {
                string sql = "UPDATE urunler SET urun_adi = @urun_adi, alisFiyati = @alisFiyati, satisFiyati = @satisFiyati, stok_miktari = @stok_miktari WHERE urun_id = @urun_id";
                try
                {
                    using (MySqlConnection connection = dbconnect.GetConnection())
                    {
                        connection.Open();
                        using (MySqlCommand command = new MySqlCommand(sql, connection))
                        {
                            command.Parameters.AddWithValue("@urun_id", IDlabel.Text);
                            command.Parameters.AddWithValue("@urun_adi", urunAdiTextbox.Text);
                            command.Parameters.AddWithValue("@alisFiyati", Convert.ToDecimal(alisFiyatiTextbox.Text));
                            command.Parameters.AddWithValue("@satisFiyati", Convert.ToDecimal(satisFiyatiTextbox.Text));
                            command.Parameters.AddWithValue("@stok_miktari", Convert.ToInt32(stokMiktariTextbox.Text));

                            int result = command.ExecuteNonQuery();
                            if (result > 0)
                            {
                                MessageBox.Show("Ürün başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                parentForm.LoadUrunler();
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Ürün güncellenemedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (string.IsNullOrWhiteSpace(urunAdiTextbox.Text))
            {
                MessageBox.Show("Lütfen ürün adını giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(alisFiyatiTextbox.Text))
            {
                MessageBox.Show("Lütfen alış fiyatını giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(satisFiyatiTextbox.Text))
            {
                MessageBox.Show("Lütfen satış fiyatını giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(stokMiktariTextbox.Text))
            {
                MessageBox.Show("Lütfen stok miktarını giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validate numeric fields
            if (!decimal.TryParse(alisFiyatiTextbox.Text, out _))
            {
                MessageBox.Show("Lütfen geçerli bir alış fiyatı giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!decimal.TryParse(satisFiyatiTextbox.Text, out _))
            {
                MessageBox.Show("Lütfen geçerli bir satış fiyatı giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!int.TryParse(stokMiktariTextbox.Text, out _))
            {
                MessageBox.Show("Lütfen geçerli bir stok miktarı giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        public void ClearFields()
        {
            urunAdiTextbox.Text = "";
            alisFiyatiTextbox.Text = "";
            satisFiyatiTextbox.Text = "";
            stokMiktariTextbox.Text = "";
            IDlabel.Text = "";
        }

        private void pnlHeader_MouseDown_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }
    }
} 