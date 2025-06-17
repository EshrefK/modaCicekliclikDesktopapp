namespace modaCicekliclikDesktopapp
{
    partial class frmSiparis
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.durumComboBox = new System.Windows.Forms.ComboBox();
            this.teslimTarihiDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.siparisTarihiDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.birimFiyatTextbox = new System.Windows.Forms.TextBox();
            this.miktarTextbox = new System.Windows.Forms.TextBox();
            this.urunComboBox = new System.Windows.Forms.ComboBox();
            this.tedarikciComboBox = new System.Windows.Forms.ComboBox();
            this.lblDurum = new System.Windows.Forms.Label();
            this.lblTeslimTarihi = new System.Windows.Forms.Label();
            this.lblSiparisTarihi = new System.Windows.Forms.Label();
            this.lblBirimFiyat = new System.Windows.Forms.Label();
            this.lblMiktar = new System.Windows.Forms.Label();
            this.lblUrun = new System.Windows.Forms.Label();
            this.lblTedarikci = new System.Windows.Forms.Label();
            this.btnSiparisEkle = new System.Windows.Forms.Button();
            this.btnSiparisGuncelle = new System.Windows.Forms.Button();
            this.IDlabel = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.btnClose);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(484, 40);
            this.pnlHeader.TabIndex = 0;
            this.pnlHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseDown_1);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(102, 21);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Sipariş Ekle";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(442, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(42, 40);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.White;
            this.pnlContent.Controls.Add(this.durumComboBox);
            this.pnlContent.Controls.Add(this.teslimTarihiDateTimePicker);
            this.pnlContent.Controls.Add(this.siparisTarihiDateTimePicker);
            this.pnlContent.Controls.Add(this.birimFiyatTextbox);
            this.pnlContent.Controls.Add(this.miktarTextbox);
            this.pnlContent.Controls.Add(this.urunComboBox);
            this.pnlContent.Controls.Add(this.tedarikciComboBox);
            this.pnlContent.Controls.Add(this.lblDurum);
            this.pnlContent.Controls.Add(this.lblTeslimTarihi);
            this.pnlContent.Controls.Add(this.lblSiparisTarihi);
            this.pnlContent.Controls.Add(this.lblBirimFiyat);
            this.pnlContent.Controls.Add(this.lblMiktar);
            this.pnlContent.Controls.Add(this.lblUrun);
            this.pnlContent.Controls.Add(this.lblTedarikci);
            this.pnlContent.Controls.Add(this.btnSiparisEkle);
            this.pnlContent.Controls.Add(this.btnSiparisGuncelle);
            this.pnlContent.Controls.Add(this.IDlabel);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 40);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Padding = new System.Windows.Forms.Padding(20);
            this.pnlContent.Size = new System.Drawing.Size(484, 421);
            this.pnlContent.TabIndex = 1;
            // 
            // durumComboBox
            // 
            this.durumComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.durumComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.durumComboBox.FormattingEnabled = true;
            this.durumComboBox.Items.AddRange(new object[] {
            "Beklemede",
            "Onaylandı",
            "İptal Edildi",
            "Tamamlandı"});
            this.durumComboBox.Location = new System.Drawing.Point(150, 300);
            this.durumComboBox.Name = "durumComboBox";
            this.durumComboBox.Size = new System.Drawing.Size(300, 29);
            this.durumComboBox.TabIndex = 6;
            // 
            // teslimTarihiDateTimePicker
            // 
            this.teslimTarihiDateTimePicker.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.teslimTarihiDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.teslimTarihiDateTimePicker.Location = new System.Drawing.Point(150, 250);
            this.teslimTarihiDateTimePicker.Name = "teslimTarihiDateTimePicker";
            this.teslimTarihiDateTimePicker.Size = new System.Drawing.Size(300, 29);
            this.teslimTarihiDateTimePicker.TabIndex = 5;
            // 
            // siparisTarihiDateTimePicker
            // 
            this.siparisTarihiDateTimePicker.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.siparisTarihiDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.siparisTarihiDateTimePicker.Location = new System.Drawing.Point(150, 200);
            this.siparisTarihiDateTimePicker.Name = "siparisTarihiDateTimePicker";
            this.siparisTarihiDateTimePicker.Size = new System.Drawing.Size(300, 29);
            this.siparisTarihiDateTimePicker.TabIndex = 4;
            // 
            // birimFiyatTextbox
            // 
            this.birimFiyatTextbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.birimFiyatTextbox.Location = new System.Drawing.Point(150, 150);
            this.birimFiyatTextbox.Name = "birimFiyatTextbox";
            this.birimFiyatTextbox.Size = new System.Drawing.Size(300, 29);
            this.birimFiyatTextbox.TabIndex = 3;
            // 
            // miktarTextbox
            // 
            this.miktarTextbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.miktarTextbox.Location = new System.Drawing.Point(150, 100);
            this.miktarTextbox.Name = "miktarTextbox";
            this.miktarTextbox.Size = new System.Drawing.Size(300, 29);
            this.miktarTextbox.TabIndex = 2;
            // 
            // urunComboBox
            // 
            this.urunComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.urunComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.urunComboBox.FormattingEnabled = true;
            this.urunComboBox.Location = new System.Drawing.Point(150, 50);
            this.urunComboBox.Name = "urunComboBox";
            this.urunComboBox.Size = new System.Drawing.Size(300, 29);
            this.urunComboBox.TabIndex = 1;
            // 
            // tedarikciComboBox
            // 
            this.tedarikciComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tedarikciComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tedarikciComboBox.FormattingEnabled = true;
            this.tedarikciComboBox.Location = new System.Drawing.Point(150, 0);
            this.tedarikciComboBox.Name = "tedarikciComboBox";
            this.tedarikciComboBox.Size = new System.Drawing.Size(300, 29);
            this.tedarikciComboBox.TabIndex = 0;
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDurum.Location = new System.Drawing.Point(20, 303);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(60, 21);
            this.lblDurum.TabIndex = 6;
            this.lblDurum.Text = "Durum:";
            // 
            // lblTeslimTarihi
            // 
            this.lblTeslimTarihi.AutoSize = true;
            this.lblTeslimTarihi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTeslimTarihi.Location = new System.Drawing.Point(20, 253);
            this.lblTeslimTarihi.Name = "lblTeslimTarihi";
            this.lblTeslimTarihi.Size = new System.Drawing.Size(100, 21);
            this.lblTeslimTarihi.TabIndex = 5;
            this.lblTeslimTarihi.Text = "Teslim Tarihi:";
            // 
            // lblSiparisTarihi
            // 
            this.lblSiparisTarihi.AutoSize = true;
            this.lblSiparisTarihi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSiparisTarihi.Location = new System.Drawing.Point(20, 203);
            this.lblSiparisTarihi.Name = "lblSiparisTarihi";
            this.lblSiparisTarihi.Size = new System.Drawing.Size(100, 21);
            this.lblSiparisTarihi.TabIndex = 4;
            this.lblSiparisTarihi.Text = "Sipariş Tarihi:";
            // 
            // lblBirimFiyat
            // 
            this.lblBirimFiyat.AutoSize = true;
            this.lblBirimFiyat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBirimFiyat.Location = new System.Drawing.Point(20, 153);
            this.lblBirimFiyat.Name = "lblBirimFiyat";
            this.lblBirimFiyat.Size = new System.Drawing.Size(90, 21);
            this.lblBirimFiyat.TabIndex = 3;
            this.lblBirimFiyat.Text = "Birim Fiyat:";
            // 
            // lblMiktar
            // 
            this.lblMiktar.AutoSize = true;
            this.lblMiktar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMiktar.Location = new System.Drawing.Point(20, 103);
            this.lblMiktar.Name = "lblMiktar";
            this.lblMiktar.Size = new System.Drawing.Size(58, 21);
            this.lblMiktar.TabIndex = 2;
            this.lblMiktar.Text = "Miktar:";
            // 
            // lblUrun
            // 
            this.lblUrun.AutoSize = true;
            this.lblUrun.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrun.Location = new System.Drawing.Point(20, 53);
            this.lblUrun.Name = "lblUrun";
            this.lblUrun.Size = new System.Drawing.Size(48, 21);
            this.lblUrun.TabIndex = 1;
            this.lblUrun.Text = "Ürün:";
            // 
            // lblTedarikci
            // 
            this.lblTedarikci.AutoSize = true;
            this.lblTedarikci.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTedarikci.Location = new System.Drawing.Point(20, 3);
            this.lblTedarikci.Name = "lblTedarikci";
            this.lblTedarikci.Size = new System.Drawing.Size(77, 21);
            this.lblTedarikci.TabIndex = 0;
            this.lblTedarikci.Text = "Tedarikçi:";
            // 
            // btnSiparisEkle
            // 
            this.btnSiparisEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnSiparisEkle.FlatAppearance.BorderSize = 0;
            this.btnSiparisEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiparisEkle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSiparisEkle.ForeColor = System.Drawing.Color.White;
            this.btnSiparisEkle.Location = new System.Drawing.Point(150, 350);
            this.btnSiparisEkle.Name = "btnSiparisEkle";
            this.btnSiparisEkle.Size = new System.Drawing.Size(140, 40);
            this.btnSiparisEkle.TabIndex = 7;
            this.btnSiparisEkle.Text = "Sipariş Ekle";
            this.btnSiparisEkle.UseVisualStyleBackColor = false;
            this.btnSiparisEkle.Click += new System.EventHandler(this.btnSiparisEkle_Click);
            // 
            // btnSiparisGuncelle
            // 
            this.btnSiparisGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnSiparisGuncelle.FlatAppearance.BorderSize = 0;
            this.btnSiparisGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiparisGuncelle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSiparisGuncelle.ForeColor = System.Drawing.Color.White;
            this.btnSiparisGuncelle.Location = new System.Drawing.Point(310, 350);
            this.btnSiparisGuncelle.Name = "btnSiparisGuncelle";
            this.btnSiparisGuncelle.Size = new System.Drawing.Size(140, 40);
            this.btnSiparisGuncelle.TabIndex = 8;
            this.btnSiparisGuncelle.Text = "Güncelle";
            this.btnSiparisGuncelle.UseVisualStyleBackColor = false;
            this.btnSiparisGuncelle.Visible = false;
            this.btnSiparisGuncelle.Click += new System.EventHandler(this.btnSiparisGuncelle_Click);
            // 
            // IDlabel
            // 
            this.IDlabel.AutoSize = true;
            this.IDlabel.Location = new System.Drawing.Point(20, 400);
            this.IDlabel.Name = "IDlabel";
            this.IDlabel.Size = new System.Drawing.Size(0, 13);
            this.IDlabel.TabIndex = 9;
            this.IDlabel.Visible = false;
            // 
            // frmSiparis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSiparis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sipariş Ekle";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.ComboBox durumComboBox;
        private System.Windows.Forms.DateTimePicker teslimTarihiDateTimePicker;
        private System.Windows.Forms.DateTimePicker siparisTarihiDateTimePicker;
        private System.Windows.Forms.TextBox birimFiyatTextbox;
        private System.Windows.Forms.TextBox miktarTextbox;
        private System.Windows.Forms.ComboBox urunComboBox;
        private System.Windows.Forms.ComboBox tedarikciComboBox;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.Label lblTeslimTarihi;
        private System.Windows.Forms.Label lblSiparisTarihi;
        private System.Windows.Forms.Label lblBirimFiyat;
        private System.Windows.Forms.Label lblMiktar;
        private System.Windows.Forms.Label lblUrun;
        private System.Windows.Forms.Label lblTedarikci;
        private System.Windows.Forms.Button btnSiparisEkle;
        private System.Windows.Forms.Button btnSiparisGuncelle;
        private System.Windows.Forms.Label IDlabel;
    }
} 