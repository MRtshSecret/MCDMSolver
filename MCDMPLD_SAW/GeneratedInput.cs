using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCDMPLD_SAW
{
    public partial class GeneratedInput : UserControl
    {
        public int Col { get; set; }
        public int Row { get; set; }
        public string numberLabel { get; set; }
        public string ReadName { get; set; }

        public GeneratedInput()
        {
            InitializeComponent();
        }

        private void GeneratedInput_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Top;
            labelRowAndCols.Text = numberLabel;
        }
    }
}
