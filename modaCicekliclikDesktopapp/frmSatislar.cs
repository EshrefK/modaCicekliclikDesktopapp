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
    public partial class frmSatislar : Form
    {
        #region Mysqlconnection
        DBconnect dbconnect = new DBconnect();
        #endregion

        // Win32 API constants and methods for moving the form
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private bool ValidateInputSave()
        {
            try
            {
                var validationControls = new Dictionary<string, Control>
        {
            { "Lütfen müşteri adını giriniz", musteriadTextbox },
            { "Lütfen ürün adını giriniz", urunAdiTextbox },
            { "Lütfen miktar giriniz", satismiktarTextbox },
            { "Lütfen toplam tutarı giriniz", toplamtutarTextbox },
        };

                foreach (var control in validationControls)
                {
                    if (string.IsNullOrWhiteSpace(control.Value.Text))
                    {
                        MessageBox.Show(control.Key, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        control.Value.Focus();
                        return false;
                    }
                }
                return true; // Added this line
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public void ClearFields()
        {
            musteriadTextbox.Clear();
            urunAdiTextbox.Clear();
            satismiktarTextbox.Clear();
            toplamtutarTextbox.Clear();
            
        }
        Satislar fSatis;
        public frmSatislar(Satislar satislarList)
        {
            InitializeComponent();
            fSatis = satislarList;
        }

        private void pnlHeader_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void btnsatisEkle_Click(object sender, EventArgs e)
        {
            using (MySqlConnection cmd = dbconnect.GetConnection())
            {
                try
                {
                    if (ValidateInputSave())
                    {
                        cmd.Open();
                        MySqlCommand command = new MySqlCommand(
                        "INSERT INTO satislar (satis_tarihi, musteri_adi, urun_adi, miktar, toplam_fiyat) VALUES (@satis_tarihi, @musteri_adi, @urun_adi, @miktar, @toplam_fiyat)", cmd);

                        command.Parameters.AddWithValue("@satis_tarihi", DateTime.Now);
                        command.Parameters.AddWithValue("@musteri_adi", musteriadTextbox.Text);
                        command.Parameters.AddWithValue("@urun_adi", urunAdiTextbox.Text);
                        command.Parameters.AddWithValue("@miktar", satismiktarTextbox.Text);
                        command.Parameters.AddWithValue("@toplam_fiyat", toplamtutarTextbox.Text);

                        int result = command.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Satış başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearFields();
                            fSatis.LoadSatislar();
                            this.Close(); // Close the form after successful addition
                        }
                        else
                        {
                            MessageBox.Show("Satış eklenemedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void btnsatisGuncelle_Click(object sender, EventArgs e)
        {
            using (MySqlConnection cmd = dbconnect.GetConnection())
            {
                try
                {
                    if (ValidateInputSave())
                    {
                        cmd.Open();
                        MySqlCommand command = new MySqlCommand("UPDATE satislar SET musteri_adi = @musteri_adi, urun_adi = @urun_adi, miktar = @miktar, toplam_fiyat = @toplam_fiyat WHERE satis_id = @id", cmd);
                        command.Parameters.AddWithValue("@musteri_adi", musteriadTextbox.Text);
                        command.Parameters.AddWithValue("@urun_adi", urunAdiTextbox.Text);
                        command.Parameters.AddWithValue("@miktar", satismiktarTextbox.Text);
                        command.Parameters.AddWithValue("@toplam_fiyat", toplamtutarTextbox.Text);
                        command.Parameters.AddWithValue("@id", IDlabel.Text);
                        int result = command.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Satış başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearFields();
                            this.Close();
                            fSatis.LoadSatislar();
                        }
                        else
                        {
                            MessageBox.Show("Satış güncellenemedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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
