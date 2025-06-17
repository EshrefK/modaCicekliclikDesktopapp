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
    public partial class frmSatis : Form
    {
        private Satislar fSatislar;
        private DBconnect dbconnect = new DBconnect();

        public frmSatis(Satislar satislar)
        {
            InitializeComponent();
            fSatislar = satislar;
            LoadMusteriler();
            LoadUrunler();
        }

        private void LoadMusteriler()
        {
            try
            {
                using (MySqlConnection connection = dbconnect.GetConnection())
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand("SELECT musteri_id, CONCAT(ad, ' ', soyad) as musteri_adi FROM musteriler", connection))
                    {
                        MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        musteriComboBox.DisplayMember = "musteri_adi";
                        musteriComboBox.ValueMember = "musteri_id";
                        musteriComboBox.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadUrunler()
        {
            try
            {
                using (MySqlConnection connection = dbconnect.GetConnection())
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand("SELECT urun_id, urun_adi FROM urunler", connection))
                    {
                        MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        urunComboBox.DisplayMember = "urun_adi";
                        urunComboBox.ValueMember = "urun_id";
                        urunComboBox.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateInputSave()
        {
            if (musteriComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen müşteri seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (urunComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen ürün seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(miktarTextbox.Text))
            {
                MessageBox.Show("Lütfen miktar girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(toplamFiyatTextbox.Text))
            {
                MessageBox.Show("Lütfen toplam fiyat girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        public void ClearFields()
        {
            musteriComboBox.SelectedIndex = -1;
            urunComboBox.SelectedIndex = -1;
            satisTarihiDateTimePicker.Value = DateTime.Now;
            miktarTextbox.Text = "";
            toplamFiyatTextbox.Text = "";
        }

        private void btnSatisEkle_Click(object sender, EventArgs e)
        {
            using(MySqlConnection cmd = dbconnect.GetConnection())
            {
                try
                {
                    if (ValidateInputSave())
                    {
                        cmd.Open();
                        MySqlCommand command = new MySqlCommand(
                            "INSERT INTO satislar (musteri_id, urun_id, satis_tarihi, miktar, toplam_fiyat) " +
                            "VALUES (@musteri_id, @urun_id, @satis_tarihi, @miktar, @toplam_fiyat)", cmd);
                        
                        command.Parameters.AddWithValue("@musteri_id", musteriComboBox.SelectedValue);
                        command.Parameters.AddWithValue("@urun_id", urunComboBox.SelectedValue);
                        command.Parameters.AddWithValue("@satis_tarihi", satisTarihiDateTimePicker.Value);
                        command.Parameters.AddWithValue("@miktar", miktarTextbox.Text);
                        command.Parameters.AddWithValue("@toplam_fiyat", toplamFiyatTextbox.Text);

                        int result = command.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Satış başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearFields();
                            fSatislar.LoadSatislar();
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

        public void btnSatisGuncelle_Click(object sender, EventArgs e)
        {
            using(MySqlConnection cmd = dbconnect.GetConnection())
            {
                try
                {
                    if (ValidateInputSave())
                    {
                        cmd.Open();
                        MySqlCommand command = new MySqlCommand(
                            "UPDATE satislar SET musteri_id = @musteri_id, urun_id = @urun_id, " +
                            "satis_tarihi = @satis_tarihi, miktar = @miktar, toplam_fiyat = @toplam_fiyat " +
                            "WHERE satis_id = @id", cmd);
                        
                        command.Parameters.AddWithValue("@musteri_id", musteriComboBox.SelectedValue);
                        command.Parameters.AddWithValue("@urun_id", urunComboBox.SelectedValue);
                        command.Parameters.AddWithValue("@satis_tarihi", satisTarihiDateTimePicker.Value);
                        command.Parameters.AddWithValue("@miktar", miktarTextbox.Text);
                        command.Parameters.AddWithValue("@toplam_fiyat", toplamFiyatTextbox.Text);
                        command.Parameters.AddWithValue("@id", IDlabel.Text);

                        int result = command.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Satış başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearFields();
                            this.Close();
                            fSatislar.LoadSatislar();
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