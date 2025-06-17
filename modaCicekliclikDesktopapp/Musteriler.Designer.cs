namespace modaCicekliclikDesktopapp
{
    partial class Musteriler
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Musteriler));
            this.totalPagesLabel = new System.Windows.Forms.Label();
            this.currentPageLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.recordsPerPagecbx = new System.Windows.Forms.ComboBox();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.addnewBtn = new System.Windows.Forms.Button();
            this.printBtn = new Guna.UI2.WinForms.Guna2Button();
            this.araTextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.closeBtn = new Guna.UI2.WinForms.Guna2ControlBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LastBtn = new System.Windows.Forms.Button();
            this.NextBtn = new System.Windows.Forms.Button();
            this.PreviousBtn = new System.Windows.Forms.Button();
            this.FirstBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PrintMusteriBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MusteriDgv = new Guna.UI2.WinForms.Guna2DataGridView();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.updateBtn = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MusteriDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // totalPagesLabel
            // 
            this.totalPagesLabel.AutoSize = true;
            this.totalPagesLabel.Location = new System.Drawing.Point(454, 12);
            this.totalPagesLabel.Name = "totalPagesLabel";
            this.totalPagesLabel.Size = new System.Drawing.Size(91, 16);
            this.totalPagesLabel.TabIndex = 5;
            this.totalPagesLabel.Text = "Toplam kayıt: ";
            // 
            // currentPageLabel
            // 
            this.currentPageLabel.AutoSize = true;
            this.currentPageLabel.Location = new System.Drawing.Point(351, 12);
            this.currentPageLabel.Name = "currentPageLabel";
            this.currentPageLabel.Size = new System.Drawing.Size(45, 16);
            this.currentPageLabel.TabIndex = 4;
            this.currentPageLabel.Text = "Sayfa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(171, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Göster";
            // 
            // recordsPerPagecbx
            // 
            this.recordsPerPagecbx.FormattingEnabled = true;
            this.recordsPerPagecbx.Location = new System.Drawing.Point(224, 6);
            this.recordsPerPagecbx.Name = "recordsPerPagecbx";
            this.recordsPerPagecbx.Size = new System.Drawing.Size(121, 24);
            this.recordsPerPagecbx.TabIndex = 2;
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.White;
            this.deleteBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.deleteBtn.Location = new System.Drawing.Point(721, 0);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(88, 40);
            this.deleteBtn.TabIndex = 1;
            this.deleteBtn.Text = "Sil";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // addnewBtn
            // 
            this.addnewBtn.BackColor = System.Drawing.Color.White;
            this.addnewBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.addnewBtn.Location = new System.Drawing.Point(809, 0);
            this.addnewBtn.Name = "addnewBtn";
            this.addnewBtn.Size = new System.Drawing.Size(97, 40);
            this.addnewBtn.TabIndex = 1;
            this.addnewBtn.Text = "Ekle";
            this.addnewBtn.UseVisualStyleBackColor = false;
            this.addnewBtn.Click += new System.EventHandler(this.addnewBtn_Click);
            // 
            // printBtn
            // 
            this.printBtn.BorderRadius = 1;
            this.printBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.printBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.printBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.printBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.printBtn.FillColor = System.Drawing.Color.Transparent;
            this.printBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.printBtn.ForeColor = System.Drawing.Color.White;
            this.printBtn.Location = new System.Drawing.Point(563, 4);
            this.printBtn.Name = "printBtn";
            this.printBtn.Size = new System.Drawing.Size(41, 41);
            this.printBtn.TabIndex = 6;
            // 
            // araTextbox
            // 
            this.araTextbox.BorderColor = System.Drawing.Color.Black;
            this.araTextbox.BorderRadius = 1;
            this.araTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.araTextbox.DefaultText = "";
            this.araTextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.araTextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.araTextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.araTextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.araTextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.araTextbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.araTextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.araTextbox.Location = new System.Drawing.Point(317, 11);
            this.araTextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.araTextbox.Name = "araTextbox";
            this.araTextbox.PlaceholderText = "";
            this.araTextbox.SelectedText = "";
            this.araTextbox.Size = new System.Drawing.Size(214, 30);
            this.araTextbox.TabIndex = 5;
            this.araTextbox.TextChanged += new System.EventHandler(this.araTextbox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(277, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ara:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Müşteri Listesi";
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.closeBtn.IconColor = System.Drawing.Color.White;
            this.closeBtn.Location = new System.Drawing.Point(859, 4);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(44, 38);
            this.closeBtn.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(247)))), ((int)(((byte)(216)))));
            this.panel2.Controls.Add(this.updateBtn);
            this.panel2.Controls.Add(this.LastBtn);
            this.panel2.Controls.Add(this.NextBtn);
            this.panel2.Controls.Add(this.PreviousBtn);
            this.panel2.Controls.Add(this.FirstBtn);
            this.panel2.Controls.Add(this.totalPagesLabel);
            this.panel2.Controls.Add(this.currentPageLabel);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.recordsPerPagecbx);
            this.panel2.Controls.Add(this.deleteBtn);
            this.panel2.Controls.Add(this.addnewBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 501);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(906, 40);
            this.panel2.TabIndex = 4;
            // 
            // LastBtn
            // 
            this.LastBtn.BackColor = System.Drawing.Color.PeachPuff;
            this.LastBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.LastBtn.Location = new System.Drawing.Point(117, 0);
            this.LastBtn.Name = "LastBtn";
            this.LastBtn.Size = new System.Drawing.Size(39, 40);
            this.LastBtn.TabIndex = 9;
            this.LastBtn.Text = ">>";
            this.LastBtn.UseVisualStyleBackColor = false;
            // 
            // NextBtn
            // 
            this.NextBtn.BackColor = System.Drawing.Color.PeachPuff;
            this.NextBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.NextBtn.Location = new System.Drawing.Point(78, 0);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Size = new System.Drawing.Size(39, 40);
            this.NextBtn.TabIndex = 8;
            this.NextBtn.Text = ">";
            this.NextBtn.UseVisualStyleBackColor = false;
            // 
            // PreviousBtn
            // 
            this.PreviousBtn.BackColor = System.Drawing.Color.PeachPuff;
            this.PreviousBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.PreviousBtn.Location = new System.Drawing.Point(39, 0);
            this.PreviousBtn.Name = "PreviousBtn";
            this.PreviousBtn.Size = new System.Drawing.Size(39, 40);
            this.PreviousBtn.TabIndex = 7;
            this.PreviousBtn.Text = "<";
            this.PreviousBtn.UseVisualStyleBackColor = false;
            // 
            // FirstBtn
            // 
            this.FirstBtn.BackColor = System.Drawing.Color.PeachPuff;
            this.FirstBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.FirstBtn.Location = new System.Drawing.Point(0, 0);
            this.FirstBtn.Name = "FirstBtn";
            this.FirstBtn.Size = new System.Drawing.Size(39, 40);
            this.FirstBtn.TabIndex = 6;
            this.FirstBtn.Text = "<<";
            this.FirstBtn.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(247)))), ((int)(((byte)(216)))));
            this.panel1.Controls.Add(this.PrintMusteriBtn);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.printBtn);
            this.panel1.Controls.Add(this.araTextbox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.closeBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(906, 45);
            this.panel1.TabIndex = 3;
            // 
            // PrintMusteriBtn
            // 
            this.PrintMusteriBtn.Image = global::modaCicekliclikDesktopapp.Properties.Resources.printicon;
            this.PrintMusteriBtn.Location = new System.Drawing.Point(577, 4);
            this.PrintMusteriBtn.Name = "PrintMusteriBtn";
            this.PrintMusteriBtn.Size = new System.Drawing.Size(51, 38);
            this.PrintMusteriBtn.TabIndex = 8;
            this.PrintMusteriBtn.UseVisualStyleBackColor = true;
            this.PrintMusteriBtn.Click += new System.EventHandler(this.PrintMusteriBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::modaCicekliclikDesktopapp.Properties.Resources.download_removebg_preview__1_;
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // MusteriDgv
            // 
            this.MusteriDgv.AllowUserToAddRows = false;
            this.MusteriDgv.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.MusteriDgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.MusteriDgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MusteriDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.MusteriDgv.ColumnHeadersHeight = 18;
            this.MusteriDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MusteriDgv.DefaultCellStyle = dataGridViewCellStyle3;
            this.MusteriDgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MusteriDgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.MusteriDgv.Location = new System.Drawing.Point(0, 45);
            this.MusteriDgv.MultiSelect = false;
            this.MusteriDgv.Name = "MusteriDgv";
            this.MusteriDgv.ReadOnly = true;
            this.MusteriDgv.RowHeadersVisible = false;
            this.MusteriDgv.RowHeadersWidth = 51;
            this.MusteriDgv.RowTemplate.Height = 24;
            this.MusteriDgv.Size = new System.Drawing.Size(906, 456);
            this.MusteriDgv.TabIndex = 6;
            this.MusteriDgv.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.MusteriDgv.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.MusteriDgv.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.MusteriDgv.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.MusteriDgv.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.MusteriDgv.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
            this.MusteriDgv.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.MusteriDgv.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.MusteriDgv.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.MusteriDgv.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MusteriDgv.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.MusteriDgv.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.MusteriDgv.ThemeStyle.HeaderStyle.Height = 18;
            this.MusteriDgv.ThemeStyle.ReadOnly = true;
            this.MusteriDgv.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.MusteriDgv.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.MusteriDgv.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MusteriDgv.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.MusteriDgv.ThemeStyle.RowsStyle.Height = 24;
            this.MusteriDgv.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.MusteriDgv.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.Color.White;
            this.updateBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.updateBtn.Location = new System.Drawing.Point(624, 0);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(97, 40);
            this.updateBtn.TabIndex = 10;
            this.updateBtn.Text = "Güncelle";
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // Musteriler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 541);
            this.Controls.Add(this.MusteriDgv);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Musteriler";
            this.Text = "Musteriler";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MusteriDgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label totalPagesLabel;
        private System.Windows.Forms.Label currentPageLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox recordsPerPagecbx;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button addnewBtn;
        private Guna.UI2.WinForms.Guna2Button printBtn;
        private Guna.UI2.WinForms.Guna2TextBox araTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ControlBox closeBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button LastBtn;
        private System.Windows.Forms.Button NextBtn;
        private System.Windows.Forms.Button PreviousBtn;
        private System.Windows.Forms.Button FirstBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button PrintMusteriBtn;
        private Guna.UI2.WinForms.Guna2DataGridView MusteriDgv;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button updateBtn;
    }
}