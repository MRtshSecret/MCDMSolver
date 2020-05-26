using MCDMPLD_SAW;
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
    public partial class TemplateDetail : Form
    {
        public string AlgorithmName { get; set; }
        public TemplateDetail(string type)
        {
            InitializeComponent();
            AlgorithmName = type;
        }

        private void lablClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreate_Load(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            //Classes.MainFormCaller.mainFormCallerVortex.openChildForm(mAlgorithm);
            switch (AlgorithmName)
            {
                case "SAW":
                    MainAlgorithm mAlgorithm = new MainAlgorithm(AlgorithmName);
                    Classes.MainAlgorithmCaller.mainAlgorithmCallerVortex = mAlgorithm;
                    Classes.MainAlgorithmCaller.mainAlgorithmCallerVortex.openChildForm(new PLGSAWMain());
                    Classes.MainAlgorithmCaller.mainAlgorithmCallerVortex.Show();
                    this.Close();
                    Classes.MainFormCaller.mainFormCallerVortex.Hide();
                    break;
                case "Topsis":
                    break;
            }
            this.Close();
        }
    }
}
