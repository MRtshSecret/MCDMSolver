using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCDMSolver.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            //btnNew.btnImage = Image.FromFile(Directory.GetCurrentDirectory() + @"\Resource\new32x32.png");
            //btnLoad.btnImage = Image.FromFile(Directory.GetCurrentDirectory() + @"\Resource\folder32x32.png");
            //btnDashboard.btnImage = Image.FromFile(Directory.GetCurrentDirectory() + @"\Resource\home32x32.png");
            //btnDashboard.btnText = "داشبورد";
            //btnNew.btnText = "جدید";
            //btnLoad.btnText = "بارگزاری";
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            labelAccountName.Text = Classes.User.fullname;
            Classes.MainFormCaller.mainFormCallerVortex = this;
        }

        #region Move Window
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void panelToolbar_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion


        private Form activeForm = null;
        public void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel200.Controls.Add(childForm);
            panel200.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            openChildForm(new Forms.Due());
        }

        private void btnAccountManager_Click(object sender, EventArgs e)
        {
            openChildForm(new Forms.AccountManager());
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            openChildForm(new Forms.newTemplateSuggestion());
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

    }
}
