using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCDMPLD_Topsis
{
    public partial class GeneratedInputColumns : UserControl
    {
        public int Col { get; set; }

        public GeneratedInputColumns()
        {
            InitializeComponent();
        }

        private void txtBoxWeight_Leave(object sender, EventArgs e)
        {
            double parsedValue;
            if (!double.TryParse(txtBoxWeight.Text, out parsedValue))
            {
                txtBoxWeight.Text = "";
                MessageBox.Show("This is a number only field");
                return;
            }
            else if(Convert.ToDouble(txtBoxWeight.Text) <= 0 && Convert.ToDouble(txtBoxWeight.Text) >= 1)
            {
                txtBoxWeight.Text = "";
            }
            else
            {
            }
        }
    }
}
