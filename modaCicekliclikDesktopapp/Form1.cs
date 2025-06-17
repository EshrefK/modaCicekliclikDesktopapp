using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Guna.UI2.WinForms.Suite;

namespace modaCicekliclikDesktopapp
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;

        public Form1()
        {
            InitializeComponent();
            Baslikpanel.MouseDown += Baslikpanel_MouseDown;
            InitializeForm(); // Initialize the form and open the default child form

        }

        private void InitializeForm()
        {
            this.DoubleBuffered = true; // Enable double buffering to reduce flickering  

            
            OpenChildForm(new frmDashboard());
        }

        private Form activeForm = null;

        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel1.Controls.Add(childForm);
            panel1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void Baslikpanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void btnSatislar_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Satislar());
            
        }

        private void btnSatinalimlar_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Siparisler());
        }

        private void btnMusteriler_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Musteriler());
        }

        private void btnTedarikciler_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Tedarikci());
        }

        private void btnUrunler_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Urunler());
        }
    }
}
