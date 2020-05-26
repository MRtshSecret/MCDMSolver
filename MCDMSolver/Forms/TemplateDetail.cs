using MCDMPLD_SAW;
using MCDMPLD_Topsis;
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
            string onvan = "الگوریتم : " + AlgorithmName;
            label1.Text = onvan;
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
            MainAlgorithm mAlgorithm = new MainAlgorithm(AlgorithmName);
            Classes.MainAlgorithmCaller.mainAlgorithmCallerVortex = mAlgorithm;

            switch (AlgorithmName)
            {
                case "SAW":
                     Classes.MainAlgorithmCaller.mainAlgorithmCallerVortex.openChildForm(new PLGSAWMain());
                    Classes.MainAlgorithmCaller.mainAlgorithmCallerVortex.Show();
                    this.Close();
                    Classes.MainFormCaller.mainFormCallerVortex.Hide();
                    break;
                case "Topsis":
                    
                    Classes.MainAlgorithmCaller.mainAlgorithmCallerVortex.openChildForm(new PLGTOPSOSMain());
                    Classes.MainAlgorithmCaller.mainAlgorithmCallerVortex.Show();
                    this.Close();
                    Classes.MainFormCaller.mainFormCallerVortex.Hide();
                    break;
            }
            this.Close();
        }
    }
}
