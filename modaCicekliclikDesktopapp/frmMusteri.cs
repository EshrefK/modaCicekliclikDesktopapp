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
    public partial class frmMusteri : Form
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
            { "lütfen adınızı giriniz", musteriadTextbox },
            { "lütfen soyadınızı giriniz", musterisoyadTextbox },
            { "lütfen telefon numaranızı giriniz", musteritelefonTextbox },
            { "lütfen email", musteriemailTextbox },
            { "lütfen il giriniz", musteriilTextbox },
            { "lütfen ilçe giriniz", musteriilceTextbox },
            { "lütfen adres giriniz", musteriadresTextbox },
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
            musterisoyadTextbox.Clear();
            musteritelefonTextbox.Clear();
            musteriemailTextbox.Clear();
            musteriilTextbox.Clear();
            musteriilceTextbox.Clear();
            musteriadresTextbox.Clear();
        }
        Musteriler fMusteri;
        public frmMusteri(Musteriler musterilerList)
        {
            InitializeComponent();
            fMusteri = musterilerList;

        }

        private void pnlHeader_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void btnmusteriEkle_Click(object sender, EventArgs e)
        {
            using(MySqlConnection cmd = dbconnect.GetConnection())
            {
                try
                {
                    if (ValidateInputSave())
                    {
                        cmd.Open();
                        MySqlCommand command = new MySqlCommand("INSERT INTO musteriler (ad, soyad, telefon, email, il, ilce, adres) VALUES (@ad, @soyad, @telefon, @email, @il, @ilce, @adres)", cmd);
                        command.Parameters.AddWithValue("@ad", musteriadTextbox.Text);
                        command.Parameters.AddWithValue("@soyad", musterisoyadTextbox.Text);
                        command.Parameters.AddWithValue("@telefon", musteritelefonTextbox.Text);
                        command.Parameters.AddWithValue("@email", musteriemailTextbox.Text);
                        command.Parameters.AddWithValue("@il", musteriilTextbox.Text);
                        command.Parameters.AddWithValue("@ilce", musteriilceTextbox.Text);
                        command.Parameters.AddWithValue("@adres", musteriadresTextbox.Text);
                        int result = command.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Müşteri başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearFields();
                            fMusteri.LoadMusteri();
                        }
                        else
                        {
                            MessageBox.Show("Müşteri eklenemedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void btnmusteriGuncelle_Click(object sender, EventArgs e)
        {
            using(MySqlConnection cmd = dbconnect.GetConnection())
            {
                try
                {
                    if (ValidateInputSave())
                    {
                        cmd.Open();
                        MySqlCommand command = new MySqlCommand("UPDATE musteriler SET ad = @ad, soyad = @soyad, telefon = @telefon, email = @email, il = @il, ilce = @ilce, adres = @adres WHERE musteri_id = @id", cmd);
                        command.Parameters.AddWithValue("@ad", musteriadTextbox.Text);
                        command.Parameters.AddWithValue("@soyad", musterisoyadTextbox.Text);
                        command.Parameters.AddWithValue("@telefon", musteritelefonTextbox.Text);
                        command.Parameters.AddWithValue("@email", musteriemailTextbox.Text);
                        command.Parameters.AddWithValue("@il", musteriilTextbox.Text);
                        command.Parameters.AddWithValue("@ilce", musteriilceTextbox.Text);
                        command.Parameters.AddWithValue("@adres", musteriadresTextbox.Text);
                        command.Parameters.AddWithValue("@id", IDlabel.Text);
                        int result = command.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Müşteri başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearFields();
                            this.Close();
                            fMusteri.LoadMusteri();
                        }
                        else
                        {
                            MessageBox.Show("Müşteri güncellenemedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
