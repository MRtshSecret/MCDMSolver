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
    public partial class Due : Form
    {
        public Due()
        {
            InitializeComponent();
        }
        
        private void loadRecents()
        {
            for (int i = 0; i < 30; i++)
            {
                UserControls.userControlRecentlyProjects recentProjects = new UserControls.userControlRecentlyProjects();
                recentProjects.Dock = DockStyle.Top;
                recentProjects.projectName = "امیر";
                recentProjects.projectDate = "امیر";
                recentProjects.projectDetails = "امیر";
                panelRecntProjects.Controls.Add(recentProjects);
            }
        }

        private void Due_Load(object sender, EventArgs e)
        {
            loadRecents();
        }
    }
}
