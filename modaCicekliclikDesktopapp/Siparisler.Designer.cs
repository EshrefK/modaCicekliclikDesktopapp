namespace modaCicekliclikDesktopapp
{
    partial class Siparisler
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.araTextbox = new System.Windows.Forms.TextBox();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnSiparisSil = new System.Windows.Forms.Button();
            this.btnSiparisGuncelle = new System.Windows.Forms.Button();
            this.btnSiparisEkle = new System.Windows.Forms.Button();
            this.pnlPagination = new System.Windows.Forms.Panel();
            this.LastBtn = new System.Windows.Forms.Button();
            this.NextBtn = new System.Windows.Forms.Button();
            this.PreviousBtn = new System.Windows.Forms.Button();
            this.FirstBtn = new System.Windows.Forms.Button();
            this.currentPageLabel = new System.Windows.Forms.Label();
            this.totalPagesLabel = new System.Windows.Forms.Label();
            this.recordsPerPagecbx = new System.Windows.Forms.ComboBox();
            this.PrintSiparisBtn = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.pnlHeader.SuspendLayout();
            this.pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnlSearch.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.pnlPagination.SuspendLayout();
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
            this.pnlHeader.Size = new System.Drawing.Size(984, 40);
            this.pnlHeader.TabIndex = 0;
            this.pnlHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseDown);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(77, 21);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Siparişler";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(944, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 40);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.White;
            this.pnlContent.Controls.Add(this.dataGridView1);
            this.pnlContent.Controls.Add(this.pnlSearch);
            this.pnlContent.Controls.Add(this.pnlButtons);
            this.pnlContent.Controls.Add(this.pnlPagination);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 40);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Padding = new System.Windows.Forms.Padding(10);
            this.pnlContent.Size = new System.Drawing.Size(984, 521);
            this.pnlContent.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(958, 407);
            this.dataGridView1.TabIndex = 2;
            // 
            // pnlSearch
            // 
            this.pnlSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSearch.Controls.Add(this.araTextbox);
            this.pnlSearch.Location = new System.Drawing.Point(13, 13);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(958, 34);
            this.pnlSearch.TabIndex = 1;
            // 
            // araTextbox
            // 
            this.araTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.araTextbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.araTextbox.Location = new System.Drawing.Point(0, 0);
            this.araTextbox.Name = "araTextbox";
            this.araTextbox.Size = new System.Drawing.Size(958, 29);
            this.araTextbox.TabIndex = 0;
            this.araTextbox.TextChanged += new System.EventHandler(this.araTextbox_TextChanged);
            // 
            // pnlButtons
            // 
            this.pnlButtons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlButtons.Controls.Add(this.btnSiparisSil);
            this.pnlButtons.Controls.Add(this.btnSiparisGuncelle);
            this.pnlButtons.Controls.Add(this.btnSiparisEkle);
            this.pnlButtons.Location = new System.Drawing.Point(13, 466);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(958, 42);
            this.pnlButtons.TabIndex = 0;
            // 
            // btnSiparisSil
            // 
            this.btnSiparisSil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSiparisSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnSiparisSil.FlatAppearance.BorderSize = 0;
            this.btnSiparisSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiparisSil.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSiparisSil.ForeColor = System.Drawing.Color.White;
            this.btnSiparisSil.Location = new System.Drawing.Point(862, 0);
            this.btnSiparisSil.Name = "btnSiparisSil";
            this.btnSiparisSil.Size = new System.Drawing.Size(96, 42);
            this.btnSiparisSil.TabIndex = 2;
            this.btnSiparisSil.Text = "Sil";
            this.btnSiparisSil.UseVisualStyleBackColor = false;
            this.btnSiparisSil.Click += new System.EventHandler(this.btnSiparisSil_Click);
            // 
            // btnSiparisGuncelle
            // 
            this.btnSiparisGuncelle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSiparisGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnSiparisGuncelle.FlatAppearance.BorderSize = 0;
            this.btnSiparisGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiparisGuncelle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSiparisGuncelle.ForeColor = System.Drawing.Color.White;
            this.btnSiparisGuncelle.Location = new System.Drawing.Point(760, 0);
            this.btnSiparisGuncelle.Name = "btnSiparisGuncelle";
            this.btnSiparisGuncelle.Size = new System.Drawing.Size(96, 42);
            this.btnSiparisGuncelle.TabIndex = 1;
            this.btnSiparisGuncelle.Text = "Güncelle";
            this.btnSiparisGuncelle.UseVisualStyleBackColor = false;
            this.btnSiparisGuncelle.Click += new System.EventHandler(this.btnSiparisGuncelle_Click);
            // 
            // btnSiparisEkle
            // 
            this.btnSiparisEkle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSiparisEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnSiparisEkle.FlatAppearance.BorderSize = 0;
            this.btnSiparisEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiparisEkle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSiparisEkle.ForeColor = System.Drawing.Color.White;
            this.btnSiparisEkle.Location = new System.Drawing.Point(658, 0);
            this.btnSiparisEkle.Name = "btnSiparisEkle";
            this.btnSiparisEkle.Size = new System.Drawing.Size(96, 42);
            this.btnSiparisEkle.TabIndex = 0;
            this.btnSiparisEkle.Text = "Ekle";
            this.btnSiparisEkle.UseVisualStyleBackColor = false;
            this.btnSiparisEkle.Click += new System.EventHandler(this.btnSiparisEkle_Click);
            // 
            // pnlPagination
            // 
            this.pnlPagination.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPagination.Controls.Add(this.LastBtn);
            this.pnlPagination.Controls.Add(this.NextBtn);
            this.pnlPagination.Controls.Add(this.PreviousBtn);
            this.pnlPagination.Controls.Add(this.FirstBtn);
            this.pnlPagination.Controls.Add(this.currentPageLabel);
            this.pnlPagination.Controls.Add(this.totalPagesLabel);
            this.pnlPagination.Controls.Add(this.recordsPerPagecbx);
            this.pnlPagination.Controls.Add(this.PrintSiparisBtn);
            this.pnlPagination.Location = new System.Drawing.Point(13, 466);
            this.pnlPagination.Name = "pnlPagination";
            this.pnlPagination.Size = new System.Drawing.Size(958, 42);
            this.pnlPagination.TabIndex = 3;
            // 
            // LastBtn
            // 
            this.LastBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LastBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.LastBtn.FlatAppearance.BorderSize = 0;
            this.LastBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LastBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LastBtn.ForeColor = System.Drawing.Color.White;
            this.LastBtn.Location = new System.Drawing.Point(862, 0);
            this.LastBtn.Name = "LastBtn";
            this.LastBtn.Size = new System.Drawing.Size(96, 42);
            this.LastBtn.TabIndex = 7;
            this.LastBtn.Text = "Son";
            this.LastBtn.UseVisualStyleBackColor = false;
            this.LastBtn.Click += new System.EventHandler(this.LastBtn_Click);
            // 
            // NextBtn
            // 
            this.NextBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.NextBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.NextBtn.FlatAppearance.BorderSize = 0;
            this.NextBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.NextBtn.ForeColor = System.Drawing.Color.White;
            this.NextBtn.Location = new System.Drawing.Point(760, 0);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Size = new System.Drawing.Size(96, 42);
            this.NextBtn.TabIndex = 6;
            this.NextBtn.Text = "İleri";
            this.NextBtn.UseVisualStyleBackColor = false;
            this.NextBtn.Click += new System.EventHandler(this.NextBtn_Click);
            // 
            // PreviousBtn
            // 
            this.PreviousBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PreviousBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.PreviousBtn.FlatAppearance.BorderSize = 0;
            this.PreviousBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PreviousBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PreviousBtn.ForeColor = System.Drawing.Color.White;
            this.PreviousBtn.Location = new System.Drawing.Point(658, 0);
            this.PreviousBtn.Name = "PreviousBtn";
            this.PreviousBtn.Size = new System.Drawing.Size(96, 42);
            this.PreviousBtn.TabIndex = 5;
            this.PreviousBtn.Text = "Geri";
            this.PreviousBtn.UseVisualStyleBackColor = false;
            this.PreviousBtn.Click += new System.EventHandler(this.PreviousBtn_Click);
            // 
            // FirstBtn
            // 
            this.FirstBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.FirstBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.FirstBtn.FlatAppearance.BorderSize = 0;
            this.FirstBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FirstBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FirstBtn.ForeColor = System.Drawing.Color.White;
            this.FirstBtn.Location = new System.Drawing.Point(556, 0);
            this.FirstBtn.Name = "FirstBtn";
            this.FirstBtn.Size = new System.Drawing.Size(96, 42);
            this.FirstBtn.TabIndex = 4;
            this.FirstBtn.Text = "İlk";
            this.FirstBtn.UseVisualStyleBackColor = false;
            this.FirstBtn.Click += new System.EventHandler(this.FirstBtn_Click);
            // 
            // currentPageLabel
            // 
            this.currentPageLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.currentPageLabel.AutoSize = true;
            this.currentPageLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.currentPageLabel.Location = new System.Drawing.Point(456, 15);
            this.currentPageLabel.Name = "currentPageLabel";
            this.currentPageLabel.Size = new System.Drawing.Size(94, 15);
            this.currentPageLabel.TabIndex = 3;
            this.currentPageLabel.Text = "Sayfa 1 / 1";
            // 
            // totalPagesLabel
            // 
            this.totalPagesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.totalPagesLabel.AutoSize = true;
            this.totalPagesLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.totalPagesLabel.Location = new System.Drawing.Point(356, 15);
            this.totalPagesLabel.Name = "totalPagesLabel";
            this.totalPagesLabel.Size = new System.Drawing.Size(94, 15);
            this.totalPagesLabel.TabIndex = 2;
            this.totalPagesLabel.Text = "Toplam: 0";
            // 
            // recordsPerPagecbx
            // 
            this.recordsPerPagecbx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.recordsPerPagecbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.recordsPerPagecbx.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.recordsPerPagecbx.FormattingEnabled = true;
            this.recordsPerPagecbx.Location = new System.Drawing.Point(256, 12);
            this.recordsPerPagecbx.Name = "recordsPerPagecbx";
            this.recordsPerPagecbx.Size = new System.Drawing.Size(94, 23);
            this.recordsPerPagecbx.TabIndex = 1;
            this.recordsPerPagecbx.SelectedIndexChanged += new System.EventHandler(this.recordsPerPagecbx_SelectedIndexChanged);
            // 
            // PrintSiparisBtn
            // 
            this.PrintSiparisBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PrintSiparisBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.PrintSiparisBtn.FlatAppearance.BorderSize = 0;
            this.PrintSiparisBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrintSiparisBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PrintSiparisBtn.ForeColor = System.Drawing.Color.White;
            this.PrintSiparisBtn.Location = new System.Drawing.Point(0, 0);
            this.PrintSiparisBtn.Name = "PrintSiparisBtn";
            this.PrintSiparisBtn.Size = new System.Drawing.Size(96, 42);
            this.PrintSiparisBtn.TabIndex = 0;
            this.PrintSiparisBtn.Text = "Yazdır";
            this.PrintSiparisBtn.UseVisualStyleBackColor = false;
            this.PrintSiparisBtn.Click += new System.EventHandler(this.PrintSiparisBtn_Click);
            // 
            // Siparisler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Siparisler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Siparişler";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            this.pnlPagination.ResumeLayout(false);
            this.pnlPagination.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.TextBox araTextbox;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btnSiparisSil;
        private System.Windows.Forms.Button btnSiparisGuncelle;
        private System.Windows.Forms.Button btnSiparisEkle;
        private System.Windows.Forms.Panel pnlPagination;
        private System.Windows.Forms.Button LastBtn;
        private System.Windows.Forms.Button NextBtn;
        private System.Windows.Forms.Button PreviousBtn;
        private System.Windows.Forms.Button FirstBtn;
        private System.Windows.Forms.Label currentPageLabel;
        private System.Windows.Forms.Label totalPagesLabel;
        private System.Windows.Forms.ComboBox recordsPerPagecbx;
        private System.Windows.Forms.Button PrintSiparisBtn;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}