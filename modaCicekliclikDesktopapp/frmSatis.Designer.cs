namespace modaCicekliclikDesktopapp
{
    partial class frmSatis
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
            this.toplamFiyatTextbox = new System.Windows.Forms.TextBox();
            this.miktarTextbox = new System.Windows.Forms.TextBox();
            this.satisTarihiDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.urunComboBox = new System.Windows.Forms.ComboBox();
            this.musteriComboBox = new System.Windows.Forms.ComboBox();
            this.lblToplamFiyat = new System.Windows.Forms.Label();
            this.lblMiktar = new System.Windows.Forms.Label();
            this.lblSatisTarihi = new System.Windows.Forms.Label();
            this.lblUrun = new System.Windows.Forms.Label();
            this.lblMusteri = new System.Windows.Forms.Label();
            this.btnSatisEkle = new System.Windows.Forms.Button();
            this.btnSatisGuncelle = new System.Windows.Forms.Button();
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
            this.lblTitle.Size = new System.Drawing.Size(89, 21);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Satış Ekle";
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
            this.pnlContent.Controls.Add(this.toplamFiyatTextbox);
            this.pnlContent.Controls.Add(this.miktarTextbox);
            this.pnlContent.Controls.Add(this.satisTarihiDateTimePicker);
            this.pnlContent.Controls.Add(this.urunComboBox);
            this.pnlContent.Controls.Add(this.musteriComboBox);
            this.pnlContent.Controls.Add(this.lblToplamFiyat);
            this.pnlContent.Controls.Add(this.lblMiktar);
            this.pnlContent.Controls.Add(this.lblSatisTarihi);
            this.pnlContent.Controls.Add(this.lblUrun);
            this.pnlContent.Controls.Add(this.lblMusteri);
            this.pnlContent.Controls.Add(this.btnSatisEkle);
            this.pnlContent.Controls.Add(this.btnSatisGuncelle);
            this.pnlContent.Controls.Add(this.IDlabel);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 40);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Padding = new System.Windows.Forms.Padding(20);
            this.pnlContent.Size = new System.Drawing.Size(484, 321);
            this.pnlContent.TabIndex = 1;
            // 
            // toplamFiyatTextbox
            // 
            this.toplamFiyatTextbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toplamFiyatTextbox.Location = new System.Drawing.Point(150, 200);
            this.toplamFiyatTextbox.Name = "toplamFiyatTextbox";
            this.toplamFiyatTextbox.Size = new System.Drawing.Size(300, 29);
            this.toplamFiyatTextbox.TabIndex = 4;
            // 
            // miktarTextbox
            // 
            this.miktarTextbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.miktarTextbox.Location = new System.Drawing.Point(150, 150);
            this.miktarTextbox.Name = "miktarTextbox";
            this.miktarTextbox.Size = new System.Drawing.Size(300, 29);
            this.miktarTextbox.TabIndex = 3;
            // 
            // satisTarihiDateTimePicker
            // 
            this.satisTarihiDateTimePicker.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.satisTarihiDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.satisTarihiDateTimePicker.Location = new System.Drawing.Point(150, 100);
            this.satisTarihiDateTimePicker.Name = "satisTarihiDateTimePicker";
            this.satisTarihiDateTimePicker.Size = new System.Drawing.Size(300, 29);
            this.satisTarihiDateTimePicker.TabIndex = 2;
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
            // musteriComboBox
            // 
            this.musteriComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.musteriComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.musteriComboBox.FormattingEnabled = true;
            this.musteriComboBox.Location = new System.Drawing.Point(150, 0);
            this.musteriComboBox.Name = "musteriComboBox";
            this.musteriComboBox.Size = new System.Drawing.Size(300, 29);
            this.musteriComboBox.TabIndex = 0;
            // 
            // lblToplamFiyat
            // 
            this.lblToplamFiyat.AutoSize = true;
            this.lblToplamFiyat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamFiyat.Location = new System.Drawing.Point(20, 203);
            this.lblToplamFiyat.Name = "lblToplamFiyat";
            this.lblToplamFiyat.Size = new System.Drawing.Size(100, 21);
            this.lblToplamFiyat.TabIndex = 4;
            this.lblToplamFiyat.Text = "Toplam Fiyat:";
            // 
            // lblMiktar
            // 
            this.lblMiktar.AutoSize = true;
            this.lblMiktar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMiktar.Location = new System.Drawing.Point(20, 153);
            this.lblMiktar.Name = "lblMiktar";
            this.lblMiktar.Size = new System.Drawing.Size(58, 21);
            this.lblMiktar.TabIndex = 3;
            this.lblMiktar.Text = "Miktar:";
            // 
            // lblSatisTarihi
            // 
            this.lblSatisTarihi.AutoSize = true;
            this.lblSatisTarihi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSatisTarihi.Location = new System.Drawing.Point(20, 103);
            this.lblSatisTarihi.Name = "lblSatisTarihi";
            this.lblSatisTarihi.Size = new System.Drawing.Size(89, 21);
            this.lblSatisTarihi.TabIndex = 2;
            this.lblSatisTarihi.Text = "Satış Tarihi:";
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
            // lblMusteri
            // 
            this.lblMusteri.AutoSize = true;
            this.lblMusteri.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMusteri.Location = new System.Drawing.Point(20, 3);
            this.lblMusteri.Name = "lblMusteri";
            this.lblMusteri.Size = new System.Drawing.Size(67, 21);
            this.lblMusteri.TabIndex = 0;
            this.lblMusteri.Text = "Müşteri:";
            // 
            // btnSatisEkle
            // 
            this.btnSatisEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnSatisEkle.FlatAppearance.BorderSize = 0;
            this.btnSatisEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSatisEkle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSatisEkle.ForeColor = System.Drawing.Color.White;
            this.btnSatisEkle.Location = new System.Drawing.Point(150, 250);
            this.btnSatisEkle.Name = "btnSatisEkle";
            this.btnSatisEkle.Size = new System.Drawing.Size(140, 40);
            this.btnSatisEkle.TabIndex = 5;
            this.btnSatisEkle.Text = "Satış Ekle";
            this.btnSatisEkle.UseVisualStyleBackColor = false;
            this.btnSatisEkle.Click += new System.EventHandler(this.btnSatisEkle_Click);
            // 
            // btnSatisGuncelle
            // 
            this.btnSatisGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnSatisGuncelle.FlatAppearance.BorderSize = 0;
            this.btnSatisGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSatisGuncelle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSatisGuncelle.ForeColor = System.Drawing.Color.White;
            this.btnSatisGuncelle.Location = new System.Drawing.Point(310, 250);
            this.btnSatisGuncelle.Name = "btnSatisGuncelle";
            this.btnSatisGuncelle.Size = new System.Drawing.Size(140, 40);
            this.btnSatisGuncelle.TabIndex = 6;
            this.btnSatisGuncelle.Text = "Güncelle";
            this.btnSatisGuncelle.UseVisualStyleBackColor = false;
            this.btnSatisGuncelle.Visible = false;
            this.btnSatisGuncelle.Click += new System.EventHandler(this.btnSatisGuncelle_Click);
            // 
            // IDlabel
            // 
            this.IDlabel.AutoSize = true;
            this.IDlabel.Location = new System.Drawing.Point(20, 300);
            this.IDlabel.Name = "IDlabel";
            this.IDlabel.Size = new System.Drawing.Size(0, 13);
            this.IDlabel.TabIndex = 7;
            this.IDlabel.Visible = false;
            // 
            // frmSatis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSatis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Satış Ekle";
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
        private System.Windows.Forms.TextBox toplamFiyatTextbox;
        private System.Windows.Forms.TextBox miktarTextbox;
        private System.Windows.Forms.DateTimePicker satisTarihiDateTimePicker;
        private System.Windows.Forms.ComboBox urunComboBox;
        private System.Windows.Forms.ComboBox musteriComboBox;
        private System.Windows.Forms.Label lblToplamFiyat;
        private System.Windows.Forms.Label lblMiktar;
        private System.Windows.Forms.Label lblSatisTarihi;
        private System.Windows.Forms.Label lblUrun;
        private System.Windows.Forms.Label lblMusteri;
        private System.Windows.Forms.Button btnSatisEkle;
        private System.Windows.Forms.Button btnSatisGuncelle;
        private System.Windows.Forms.Label IDlabel;
    }
} 