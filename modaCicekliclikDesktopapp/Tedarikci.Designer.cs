namespace modaCicekliclikDesktopapp
{
    partial class Tedarikci
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
            this.components = new System.ComponentModel.Container();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.TedarikciDgv = new System.Windows.Forms.DataGridView();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.araTextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.PrintTedarikciBtn = new Guna.UI2.WinForms.Guna2Button();
            this.deleteBtn = new Guna.UI2.WinForms.Guna2Button();
            this.updateBtn = new Guna.UI2.WinForms.Guna2Button();
            this.addnewBtn = new Guna.UI2.WinForms.Guna2Button();
            this.pnlPagination = new System.Windows.Forms.Panel();
            this.recordsPerPagecbx = new System.Windows.Forms.ComboBox();
            this.LastBtn = new System.Windows.Forms.Button();
            this.NextBtn = new System.Windows.Forms.Button();
            this.PreviousBtn = new System.Windows.Forms.Button();
            this.FirstBtn = new System.Windows.Forms.Button();
            this.currentPageLabel = new System.Windows.Forms.Label();
            this.totalPagesLabel = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument(this.components);
            this.pnlHeader.SuspendLayout();
            this.pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TedarikciDgv)).BeginInit();
            this.pnlSearch.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.pnlPagination.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(214)))), ((int)(((byte)(157)))));
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.btnClose);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(800, 42);
            this.pnlHeader.TabIndex = 0;
            this.pnlHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseDown);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(82, 20);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Tedarikçiler";
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClose.IconColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(755, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(45, 42);
            this.btnClose.TabIndex = 0;
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.TedarikciDgv);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 42);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Padding = new System.Windows.Forms.Padding(10);
            this.pnlContent.Size = new System.Drawing.Size(800, 408);
            this.pnlContent.TabIndex = 1;
            // 
            // TedarikciDgv
            // 
            this.TedarikciDgv.AllowUserToAddRows = false;
            this.TedarikciDgv.AllowUserToDeleteRows = false;
            this.TedarikciDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TedarikciDgv.BackgroundColor = System.Drawing.Color.White;
            this.TedarikciDgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TedarikciDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TedarikciDgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TedarikciDgv.Location = new System.Drawing.Point(10, 10);
            this.TedarikciDgv.Name = "TedarikciDgv";
            this.TedarikciDgv.ReadOnly = true;
            this.TedarikciDgv.RowHeadersWidth = 51;
            this.TedarikciDgv.RowTemplate.Height = 24;
            this.TedarikciDgv.Size = new System.Drawing.Size(780, 388);
            this.TedarikciDgv.TabIndex = 0;
            this.TedarikciDgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tedarikciDgv_CellClick);
            // 
            // pnlSearch
            // 
            this.pnlSearch.Controls.Add(this.araTextbox);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearch.Location = new System.Drawing.Point(0, 42);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Padding = new System.Windows.Forms.Padding(10);
            this.pnlSearch.Size = new System.Drawing.Size(800, 60);
            this.pnlSearch.TabIndex = 2;
            // 
            // araTextbox
            // 
            this.araTextbox.BorderColor = System.Drawing.Color.IndianRed;
            this.araTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.araTextbox.DefaultText = "";
            this.araTextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.araTextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.araTextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.araTextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.araTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.araTextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.araTextbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.araTextbox.ForeColor = System.Drawing.Color.Black;
            this.araTextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.araTextbox.Location = new System.Drawing.Point(10, 10);
            this.araTextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.araTextbox.Name = "araTextbox";
            this.araTextbox.PasswordChar = '\0';
            this.araTextbox.PlaceholderText = "Ara...";
            this.araTextbox.SelectedText = "";
            this.araTextbox.Size = new System.Drawing.Size(780, 40);
            this.araTextbox.TabIndex = 0;
            this.araTextbox.TextChanged += new System.EventHandler(this.araTextbox_TextChanged);
            // 
            // pnlButtons
            // 
            this.pnlButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(214)))), ((int)(((byte)(157)))));
            this.pnlButtons.Controls.Add(this.PrintTedarikciBtn);
            this.pnlButtons.Controls.Add(this.deleteBtn);
            this.pnlButtons.Controls.Add(this.updateBtn);
            this.pnlButtons.Controls.Add(this.addnewBtn);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButtons.Location = new System.Drawing.Point(0, 450);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(800, 60);
            this.pnlButtons.TabIndex = 3;
            // 
            // PrintTedarikciBtn
            // 
            this.PrintTedarikciBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.PrintTedarikciBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.PrintTedarikciBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.PrintTedarikciBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.PrintTedarikciBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.PrintTedarikciBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PrintTedarikciBtn.ForeColor = System.Drawing.Color.White;
            this.PrintTedarikciBtn.Location = new System.Drawing.Point(0, 0);
            this.PrintTedarikciBtn.Name = "PrintTedarikciBtn";
            this.PrintTedarikciBtn.Size = new System.Drawing.Size(200, 60);
            this.PrintTedarikciBtn.TabIndex = 3;
            this.PrintTedarikciBtn.Text = "Yazdır";
            this.PrintTedarikciBtn.Click += new System.EventHandler(this.PrintTedarikciBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.deleteBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.deleteBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.deleteBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.deleteBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.deleteBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.deleteBtn.ForeColor = System.Drawing.Color.White;
            this.deleteBtn.Location = new System.Drawing.Point(200, 0);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(200, 60);
            this.deleteBtn.TabIndex = 2;
            this.deleteBtn.Text = "Sil";
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.updateBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.updateBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.updateBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.updateBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.updateBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.updateBtn.ForeColor = System.Drawing.Color.White;
            this.updateBtn.Location = new System.Drawing.Point(400, 0);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(200, 60);
            this.updateBtn.TabIndex = 1;
            this.updateBtn.Text = "Güncelle";
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // addnewBtn
            // 
            this.addnewBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addnewBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addnewBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addnewBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addnewBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.addnewBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.addnewBtn.ForeColor = System.Drawing.Color.White;
            this.addnewBtn.Location = new System.Drawing.Point(600, 0);
            this.addnewBtn.Name = "addnewBtn";
            this.addnewBtn.Size = new System.Drawing.Size(200, 60);
            this.addnewBtn.TabIndex = 0;
            this.addnewBtn.Text = "Yeni Ekle";
            this.addnewBtn.Click += new System.EventHandler(this.addnewBtn_Click);
            // 
            // pnlPagination
            // 
            this.pnlPagination.Controls.Add(this.recordsPerPagecbx);
            this.pnlPagination.Controls.Add(this.LastBtn);
            this.pnlPagination.Controls.Add(this.NextBtn);
            this.pnlPagination.Controls.Add(this.PreviousBtn);
            this.pnlPagination.Controls.Add(this.FirstBtn);
            this.pnlPagination.Controls.Add(this.currentPageLabel);
            this.pnlPagination.Controls.Add(this.totalPagesLabel);
            this.pnlPagination.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlPagination.Location = new System.Drawing.Point(0, 390);
            this.pnlPagination.Name = "pnlPagination";
            this.pnlPagination.Size = new System.Drawing.Size(800, 60);
            this.pnlPagination.TabIndex = 4;
            // 
            // recordsPerPagecbx
            // 
            this.recordsPerPagecbx.FormattingEnabled = true;
            this.recordsPerPagecbx.Location = new System.Drawing.Point(12, 20);
            this.recordsPerPagecbx.Name = "recordsPerPagecbx";
            this.recordsPerPagecbx.Size = new System.Drawing.Size(121, 24);
            this.recordsPerPagecbx.TabIndex = 6;
            this.recordsPerPagecbx.SelectedIndexChanged += new System.EventHandler(this.recordsPerPagecbx_SelectedIndexChanged);
            // 
            // LastBtn
            // 
            this.LastBtn.Location = new System.Drawing.Point(713, 20);
            this.LastBtn.Name = "LastBtn";
            this.LastBtn.Size = new System.Drawing.Size(75, 23);
            this.LastBtn.TabIndex = 5;
            this.LastBtn.Text = "Son";
            this.LastBtn.UseVisualStyleBackColor = true;
            this.LastBtn.Click += new System.EventHandler(this.LastBtn_Click);
            // 
            // NextBtn
            // 
            this.NextBtn.Location = new System.Drawing.Point(632, 20);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Size = new System.Drawing.Size(75, 23);
            this.NextBtn.TabIndex = 4;
            this.NextBtn.Text = "İleri";
            this.NextBtn.UseVisualStyleBackColor = true;
            this.NextBtn.Click += new System.EventHandler(this.NextBtn_Click);
            // 
            // PreviousBtn
            // 
            this.PreviousBtn.Location = new System.Drawing.Point(551, 20);
            this.PreviousBtn.Name = "PreviousBtn";
            this.PreviousBtn.Size = new System.Drawing.Size(75, 23);
            this.PreviousBtn.TabIndex = 3;
            this.PreviousBtn.Text = "Geri";
            this.PreviousBtn.UseVisualStyleBackColor = true;
            this.PreviousBtn.Click += new System.EventHandler(this.PreviousBtn_Click);
            // 
            // FirstBtn
            // 
            this.FirstBtn.Location = new System.Drawing.Point(470, 20);
            this.FirstBtn.Name = "FirstBtn";
            this.FirstBtn.Size = new System.Drawing.Size(75, 23);
            this.FirstBtn.TabIndex = 2;
            this.FirstBtn.Text = "İlk";
            this.FirstBtn.UseVisualStyleBackColor = true;
            this.FirstBtn.Click += new System.EventHandler(this.FirstBtn_Click);
            // 
            // currentPageLabel
            // 
            this.currentPageLabel.AutoSize = true;
            this.currentPageLabel.Location = new System.Drawing.Point(139, 23);
            this.currentPageLabel.Name = "currentPageLabel";
            this.currentPageLabel.Size = new System.Drawing.Size(44, 16);
            this.currentPageLabel.TabIndex = 1;
            this.currentPageLabel.Text = "Sayfa:";
            // 
            // totalPagesLabel
            // 
            this.totalPagesLabel.AutoSize = true;
            this.totalPagesLabel.Location = new System.Drawing.Point(189, 23);
            this.totalPagesLabel.Name = "totalPagesLabel";
            this.totalPagesLabel.Size = new System.Drawing.Size(44, 16);
            this.totalPagesLabel.TabIndex = 0;
            this.totalPagesLabel.Text = "Toplam";
            // 
            // Tedarikci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 510);
            this.Controls.Add(this.pnlPagination);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Tedarikci";
            this.Text = "Tedarikci";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TedarikciDgv)).EndInit();
            this.pnlSearch.ResumeLayout(false);
            this.pnlButtons.ResumeLayout(false);
            this.pnlPagination.ResumeLayout(false);
            this.pnlPagination.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2ControlBox btnClose;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.DataGridView TedarikciDgv;
        private System.Windows.Forms.Panel pnlSearch;
        private Guna.UI2.WinForms.Guna2TextBox araTextbox;
        private System.Windows.Forms.Panel pnlButtons;
        private Guna.UI2.WinForms.Guna2Button PrintTedarikciBtn;
        private Guna.UI2.WinForms.Guna2Button deleteBtn;
        private Guna.UI2.WinForms.Guna2Button updateBtn;
        private Guna.UI2.WinForms.Guna2Button addnewBtn;
        private System.Windows.Forms.Panel pnlPagination;
        private System.Windows.Forms.ComboBox recordsPerPagecbx;
        private System.Windows.Forms.Button LastBtn;
        private System.Windows.Forms.Button NextBtn;
        private System.Windows.Forms.Button PreviousBtn;
        private System.Windows.Forms.Button FirstBtn;
        private System.Windows.Forms.Label currentPageLabel;
        private System.Windows.Forms.Label totalPagesLabel;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}