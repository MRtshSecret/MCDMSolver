using MCDMPLD_SAW;
using MCDMPLD_Topsis;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace MCDMSolver.Forms
{
    public partial class DashboardPage : Form
    {
        public DashboardPage()
        {
            InitializeComponent();
        }
        
        private void loadRecents()
        {
            for (int i = 0; i < 2; i++)
            {
                UserControls.userControlRecentlyProjects recentProjects = new UserControls.userControlRecentlyProjects();
                recentProjects.Dock = DockStyle.Top;
                recentProjects.projectName = "نام الگوریتم";
                recentProjects.projectDate = "تاریخ ایجاد";
                recentProjects.projectDetails = "توضیحات";
                panelRecntProjects.Controls.Add(recentProjects);
            }
        }

        private void Due_Load(object sender, EventArgs e)
        {
            loadRecents();
        }

        private void btnRecently_MouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.Font = new Font("Vazir FD-WOL", 9.25f);
        }

        private void btnRecently_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.Font = new Font("Vazir FD-WOL", 8.25f);
        }

        private void BtnRecently01_Click(object sender, EventArgs e)
        {
            MainAlgorithm mAlgorithm = new MainAlgorithm("SAW");
            Classes.MainAlgorithmCaller.mainAlgorithmCallerVortex = mAlgorithm;
            Classes.MainAlgorithmCaller.mainAlgorithmCallerVortex.openChildForm(new PLGSAWMain());
            Classes.MainAlgorithmCaller.mainAlgorithmCallerVortex.Show();
            this.Close();
            Classes.MainFormCaller.mainFormCallerVortex.Hide();
        }

        private void BtnRecently02_Click(object sender, EventArgs e)
        {
            MainAlgorithm mAlgorithm = new MainAlgorithm("Topsis");
            Classes.MainAlgorithmCaller.mainAlgorithmCallerVortex = mAlgorithm;
            Classes.MainAlgorithmCaller.mainAlgorithmCallerVortex.openChildForm(new PLGTOPSOSMain());
            Classes.MainAlgorithmCaller.mainAlgorithmCallerVortex.Show();
            this.Close();
            Classes.MainFormCaller.mainFormCallerVortex.Hide();
        }
    }
}
