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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Satislar));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.satislarprintPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.PrintSatislarBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.printBtn = new Guna.UI2.WinForms.Guna2Button();
            this.araTextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.closeBtn = new Guna.UI2.WinForms.Guna2ControlBox();
            this.NextBtn = new System.Windows.Forms.Button();
            this.PreviousBtn = new System.Windows.Forms.Button();
            this.FirstBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.LastBtn = new System.Windows.Forms.Button();
            this.satislarprintDocument1 = new System.Drawing.Printing.PrintDocument();
            this.satislarprintDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.satislarprintDocument1_PrintPage);
            this.totalPagesLabel = new System.Windows.Forms.Label();
            this.currentPageLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.recordsPerPagecbx = new System.Windows.Forms.ComboBox();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.addnewBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SatislarDgv = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SatislarDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // satislarprintPreviewDialog1
            // 
            this.satislarprintPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.satislarprintPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.satislarprintPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.satislarprintPreviewDialog1.Enabled = true;
            this.satislarprintPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("satislarprintPreviewDialog1.Icon")));
            this.satislarprintPreviewDialog1.Name = "printPreviewDialog1";
            this.satislarprintPreviewDialog1.Visible = false;
            // 
            // PrintSatislarBtn
            // 
            this.PrintSatislarBtn.Image = global::modaCicekliclikDesktopapp.Properties.Resources.printicon;
            this.PrintSatislarBtn.Location = new System.Drawing.Point(577, 4);
            this.PrintSatislarBtn.Name = "PrintSatislarBtn";
            this.PrintSatislarBtn.Size = new System.Drawing.Size(51, 38);
            this.PrintSatislarBtn.TabIndex = 8;
            this.PrintSatislarBtn.UseVisualStyleBackColor = true;
            this.PrintSatislarBtn.Click += new System.EventHandler(this.PrintSatislarBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::modaCicekliclikDesktopapp.Properties.Resources._975a4738_a851_423d_a5a7_6275719e7c9a;
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(247)))), ((int)(((byte)(216)))));
            this.panel1.Controls.Add(this.PrintSatislarBtn);
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
            this.panel1.TabIndex = 7;
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
            this.label1.Size = new System.Drawing.Size(137, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Satışlar Listesi";
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
            this.NextBtn.Click += new System.EventHandler(this.NextBtn_Click);
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
            this.PreviousBtn.Click += new System.EventHandler(this.PreviousBtn_Click);
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
            this.FirstBtn.Click += new System.EventHandler(this.FirstBtn_Click);
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
            this.LastBtn.Click += new System.EventHandler(this.LastBtn_Click);
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
            this.recordsPerPagecbx.SelectedIndexChanged += new System.EventHandler(this.recordsPerPagecbx_SelectedIndexChanged);
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
            this.panel2.TabIndex = 8;
            // 
            // SatislarDgv
            // 
            this.SatislarDgv.AllowUserToAddRows = false;
            this.SatislarDgv.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.SatislarDgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.SatislarDgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SatislarDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.SatislarDgv.ColumnHeadersHeight = 18;
            this.SatislarDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SatislarDgv.DefaultCellStyle = dataGridViewCellStyle3;
            this.SatislarDgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SatislarDgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.SatislarDgv.Location = new System.Drawing.Point(0, 45);
            this.SatislarDgv.Name = "SatislarDgv";
            this.SatislarDgv.ReadOnly = true;
            this.SatislarDgv.RowHeadersVisible = false;
            this.SatislarDgv.RowHeadersWidth = 51;
            this.SatislarDgv.RowTemplate.Height = 24;
            this.SatislarDgv.Size = new System.Drawing.Size(906, 456);
            this.SatislarDgv.TabIndex = 9;
            this.SatislarDgv.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.SatislarDgv.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.SatislarDgv.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.SatislarDgv.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.SatislarDgv.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.SatislarDgv.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
            this.SatislarDgv.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.SatislarDgv.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.SatislarDgv.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.SatislarDgv.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SatislarDgv.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.SatislarDgv.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.SatislarDgv.ThemeStyle.HeaderStyle.Height = 18;
            this.SatislarDgv.ThemeStyle.ReadOnly = true;
            this.SatislarDgv.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.SatislarDgv.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.SatislarDgv.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SatislarDgv.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.SatislarDgv.ThemeStyle.RowsStyle.Height = 24;
            this.SatislarDgv.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.SatislarDgv.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Satislar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 541);
            this.Controls.Add(this.SatislarDgv);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Satislar";
            this.Text = "Satislar";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SatislarDgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PrintPreviewDialog satislarprintPreviewDialog1;
        private System.Windows.Forms.Button PrintSatislarBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button printBtn;
        private Guna.UI2.WinForms.Guna2TextBox araTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ControlBox closeBtn;
        private System.Windows.Forms.Button NextBtn;
        private System.Windows.Forms.Button PreviousBtn;
        private System.Windows.Forms.Button FirstBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button LastBtn;
        private System.Drawing.Printing.PrintDocument satislarprintDocument1;
        private System.Windows.Forms.Label totalPagesLabel;
        private System.Windows.Forms.Label currentPageLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox recordsPerPagecbx;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button addnewBtn;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2DataGridView SatislarDgv;
    }
}