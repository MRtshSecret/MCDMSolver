using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCDMPLD_SAW
{
    public partial class Form1 : Form
    {
        int Columns, Rows;

        private void btnNextStep_Click(object sender, EventArgs e)
        {
            //tabControl.SelectedIndex = tabControl.
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmitRows_Click(object sender, EventArgs e)
        {
            Columns = Convert.ToInt32(cbbColumns.Text);
            Rows = Convert.ToInt32(cbbRows.Text);
            for (int i = 0; i < Rows; i++)
            {
                GeneratedInput generated = new GeneratedInput();
                generated.Row = Rows - i;
                generated.numberLabel = "ردیف شماره " + (Rows - i).ToString();
                panelGenerateditems.Controls.Add(generated);
            }
            for (int i = 0; i < Columns; i++)
            {
                GeneratedInput generated = new GeneratedInput();
                generated.Col = Columns - i;
                generated.numberLabel = "ستون شماره " + (Columns - i).ToString();
                panelGenerateditems.Controls.Add(generated);
            }
        }
    }
}
