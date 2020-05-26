using MCDMSolver.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCDMSolver.Forms
{
    public partial class MainAlgorithm : Form
    {
        public string AlgorithmName { get; set; }
        public MainAlgorithm(string AlgName)
        {
            InitializeComponent();
            AlgorithmName = AlgName;
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


        private void MainAlgorithm_Load(object sender, EventArgs e)
        {
            txtAlgorithmName.Text = AlgorithmName;
        }

        private Form activeForm = null;
        public void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlPluginLoader.Controls.Add(childForm);
            pnlPluginLoader.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void iconHome_Click(object sender, EventArgs e)
        {
            this.Close();
            MainFormCaller.mainFormCallerVortex.Show();
        }
    }
}
