namespace modaCicekliclikDesktopapp
{
    partial class Satislar
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
            this.lblAra = new System.Windows.Forms.Label();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnSatisSil = new System.Windows.Forms.Button();
            this.btnSatisGuncelle = new System.Windows.Forms.Button();
            this.btnSatisEkle = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnlSearch.SuspendLayout();
            this.pnlButtons.SuspendLayout();
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
            this.lblTitle.Size = new System.Drawing.Size(58, 21);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Satışlar";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(942, 0);
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
            this.pnlContent.Controls.Add(this.dataGridView1);
            this.pnlContent.Controls.Add(this.pnlSearch);
            this.pnlContent.Controls.Add(this.pnlButtons);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 40);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Padding = new System.Windows.Forms.Padding(20);
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
            this.dataGridView1.Location = new System.Drawing.Point(20, 100);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(944, 401);
            this.dataGridView1.TabIndex = 2;
            // 
            // pnlSearch
            // 
            this.pnlSearch.Controls.Add(this.araTextbox);
            this.pnlSearch.Controls.Add(this.lblAra);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearch.Location = new System.Drawing.Point(20, 20);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(944, 40);
            this.pnlSearch.TabIndex = 1;
            // 
            // araTextbox
            // 
            this.araTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.araTextbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.araTextbox.Location = new System.Drawing.Point(100, 0);
            this.araTextbox.Name = "araTextbox";
            this.araTextbox.Size = new System.Drawing.Size(844, 29);
            this.araTextbox.TabIndex = 1;
            this.araTextbox.TextChanged += new System.EventHandler(this.araTextbox_TextChanged);
            // 
            // lblAra
            // 
            this.lblAra.AutoSize = true;
            this.lblAra.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAra.Location = new System.Drawing.Point(0, 3);
            this.lblAra.Name = "lblAra";
            this.lblAra.Size = new System.Drawing.Size(94, 21);
            this.lblAra.TabIndex = 0;
            this.lblAra.Text = "Arama Yap:";
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.btnSatisSil);
            this.pnlButtons.Controls.Add(this.btnSatisGuncelle);
            this.pnlButtons.Controls.Add(this.btnSatisEkle);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlButtons.Location = new System.Drawing.Point(20, 60);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(944, 40);
            this.pnlButtons.TabIndex = 0;
            // 
            // btnSatisSil
            // 
            this.btnSatisSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnSatisSil.FlatAppearance.BorderSize = 0;
            this.btnSatisSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSatisSil.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSatisSil.ForeColor = System.Drawing.Color.White;
            this.btnSatisSil.Location = new System.Drawing.Point(200, 0);
            this.btnSatisSil.Name = "btnSatisSil";
            this.btnSatisSil.Size = new System.Drawing.Size(90, 40);
            this.btnSatisSil.TabIndex = 2;
            this.btnSatisSil.Text = "Sil";
            this.btnSatisSil.UseVisualStyleBackColor = false;
            this.btnSatisSil.Click += new System.EventHandler(this.btnSatisSil_Click);
            // 
            // btnSatisGuncelle
            // 
            this.btnSatisGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnSatisGuncelle.FlatAppearance.BorderSize = 0;
            this.btnSatisGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSatisGuncelle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSatisGuncelle.ForeColor = System.Drawing.Color.White;
            this.btnSatisGuncelle.Location = new System.Drawing.Point(100, 0);
            this.btnSatisGuncelle.Name = "btnSatisGuncelle";
            this.btnSatisGuncelle.Size = new System.Drawing.Size(90, 40);
            this.btnSatisGuncelle.TabIndex = 1;
            this.btnSatisGuncelle.Text = "Güncelle";
            this.btnSatisGuncelle.UseVisualStyleBackColor = false;
            this.btnSatisGuncelle.Click += new System.EventHandler(this.btnSatisGuncelle_Click);
            // 
            // btnSatisEkle
            // 
            this.btnSatisEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnSatisEkle.FlatAppearance.BorderSize = 0;
            this.btnSatisEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSatisEkle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSatisEkle.ForeColor = System.Drawing.Color.White;
            this.btnSatisEkle.Location = new System.Drawing.Point(0, 0);
            this.btnSatisEkle.Name = "btnSatisEkle";
            this.btnSatisEkle.Size = new System.Drawing.Size(90, 40);
            this.btnSatisEkle.TabIndex = 0;
            this.btnSatisEkle.Text = "Ekle";
            this.btnSatisEkle.UseVisualStyleBackColor = false;
            this.btnSatisEkle.Click += new System.EventHandler(this.btnSatisEkle_Click);
            // 
            // Satislar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Satislar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Satışlar";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
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
        private System.Windows.Forms.Label lblAra;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btnSatisSil;
        private System.Windows.Forms.Button btnSatisGuncelle;
        private System.Windows.Forms.Button btnSatisEkle;
    }
}