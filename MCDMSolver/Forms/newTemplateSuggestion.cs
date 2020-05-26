using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Animations;
using MaterialSkin.Controls;
using MCDMSolver.UserControls;

namespace MCDMSolver.Forms
{
    public partial class newTemplateSuggestion : Form
    {
        public newTemplateSuggestion()
        {
            InitializeComponent();
        }

        private void NewTemplateSuggestion_Load(object sender, EventArgs e)
        {
            Templates SAW = new UserControls.Templates();
            SAW.Name = "SAW";
            SAW.AlgorithmName = "SAW";
            flowLayoutPanel1.Controls.Add(SAW);

            Templates Topsis = new UserControls.Templates();
            Topsis.Name = "Topsis"; 
            Topsis.AlgorithmName = "Topsis";
            flowLayoutPanel1.Controls.Add(Topsis);
        }
    }
}
