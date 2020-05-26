using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MCDMSolver.UserControls
{
    public partial class Templates : UserControl
    {
        public string Details { get; set; }
        public Image algorythmImage { set; get; }
        public string AlgorithmName { get; set; }

        public Templates()
        {
            InitializeComponent();
        }

        private void openDetails(object sender, EventArgs e)
        {
            switch (AlgorithmName)
            {
                case "SAW":
                    Forms.TemplateDetail algorithm = new Forms.TemplateDetail("SAW");
                    algorythmImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\Resource\\directional.png");
                    algorithm.ShowDialog();
                    break;
            }
        }
    }
}
