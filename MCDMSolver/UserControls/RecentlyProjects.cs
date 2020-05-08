using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCDMSolver.UserControls
{
    public partial class userControlRecentlyProjects : UserControl
    {
        public string projectName { set; get; }
        public string projectDetails { set; get; }
        public string projectDate { set; get; }

        public userControlRecentlyProjects()
        {
            InitializeComponent();
        }

        private void UserControlRecentlyProjects_Load(object sender, EventArgs e)
        {
            labelProjectName.Text = projectName;
            labelProjectDetails.Text = projectDetails;
            labelProjectDate.Text = projectDate;
        }
    }
}
