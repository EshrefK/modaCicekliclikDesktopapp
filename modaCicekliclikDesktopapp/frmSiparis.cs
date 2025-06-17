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
    public partial class frmSiparis : Form
    {
        private Siparisler fSiparisler;
        private DBconnect dbconnect = new DBconnect();

        public frmSiparis(Siparisler siparisler)
        {
            InitializeComponent();
            fSiparisler = siparisler;
            LoadTedarikciler();
            LoadUrunler();
        }

        private void LoadTedarikciler()
        {
            try
            {
                using (MySqlConnection connection = dbconnect.GetConnection())
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand("SELECT tedarikci_id, firma_adi FROM tedarikciler", connection))
                    {
                        MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        tedarikciComboBox.DisplayMember = "firma_adi";
                        tedarikciComboBox.ValueMember = "tedarikci_id";
                        tedarikciComboBox.DataSource = dataTable;
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
            if (tedarikciComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen tedarikçi seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            if (string.IsNullOrWhiteSpace(birimFiyatTextbox.Text))
            {
                MessageBox.Show("Lütfen birim fiyat girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        public void ClearFields()
        {
            tedarikciComboBox.SelectedIndex = -1;
            urunComboBox.SelectedIndex = -1;
            siparisTarihiDateTimePicker.Value = DateTime.Now;
            teslimTarihiDateTimePicker.Value = DateTime.Now.AddDays(7);
            miktarTextbox.Text = "";
            birimFiyatTextbox.Text = "";
            durumComboBox.SelectedIndex = 0;
        }

        private void btnSiparisEkle_Click(object sender, EventArgs e)
        {
            using(MySqlConnection cmd = dbconnect.GetConnection())
            {
                try
                {
                    if (ValidateInputSave())
                    {
                        cmd.Open();
                        MySqlCommand command = new MySqlCommand(
                            "INSERT INTO siparisler (tedarikci_id, urun_id, siparis_tarihi, teslim_tarihi, " +
                            "miktar, birim_fiyat, durum) " +
                            "VALUES (@tedarikci_id, @urun_id, @siparis_tarihi, @teslim_tarihi, " +
                            "@miktar, @birim_fiyat, @durum)", cmd);
                        
                        command.Parameters.AddWithValue("@tedarikci_id", tedarikciComboBox.SelectedValue);
                        command.Parameters.AddWithValue("@urun_id", urunComboBox.SelectedValue);
                        command.Parameters.AddWithValue("@siparis_tarihi", siparisTarihiDateTimePicker.Value);
                        command.Parameters.AddWithValue("@teslim_tarihi", teslimTarihiDateTimePicker.Value);
                        command.Parameters.AddWithValue("@miktar", miktarTextbox.Text);
                        command.Parameters.AddWithValue("@birim_fiyat", birimFiyatTextbox.Text);
                        command.Parameters.AddWithValue("@durum", durumComboBox.SelectedItem.ToString());

                        int result = command.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Sipariş başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearFields();
                            fSiparisler.LoadSiparisler();
                        }
                        else
                        {
                            MessageBox.Show("Sipariş eklenemedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void btnSiparisGuncelle_Click(object sender, EventArgs e)
        {
            using(MySqlConnection cmd = dbconnect.GetConnection())
            {
                try
                {
                    if (ValidateInputSave())
                    {
                        cmd.Open();
                        MySqlCommand command = new MySqlCommand(
                            "UPDATE siparisler SET tedarikci_id = @tedarikci_id, urun_id = @urun_id, " +
                            "siparis_tarihi = @siparis_tarihi, teslim_tarihi = @teslim_tarihi, " +
                            "miktar = @miktar, birim_fiyat = @birim_fiyat, durum = @durum " +
                            "WHERE siparis_id = @id", cmd);
                        
                        command.Parameters.AddWithValue("@tedarikci_id", tedarikciComboBox.SelectedValue);
                        command.Parameters.AddWithValue("@urun_id", urunComboBox.SelectedValue);
                        command.Parameters.AddWithValue("@siparis_tarihi", siparisTarihiDateTimePicker.Value);
                        command.Parameters.AddWithValue("@teslim_tarihi", teslimTarihiDateTimePicker.Value);
                        command.Parameters.AddWithValue("@miktar", miktarTextbox.Text);
                        command.Parameters.AddWithValue("@birim_fiyat", birimFiyatTextbox.Text);
                        command.Parameters.AddWithValue("@durum", durumComboBox.SelectedItem.ToString());
                        command.Parameters.AddWithValue("@id", IDlabel.Text);

                        int result = command.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Sipariş başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearFields();
                            this.Close();
                            fSiparisler.LoadSiparisler();
                        }
                        else
                        {
                            MessageBox.Show("Sipariş güncellenemedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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