using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCDMPLD_SAW
{
    public partial class Form1 : Form
    {

        int Columns, Rows;
        DataTable dtStep2 = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (TabPage tab in tabControl.TabPages)
            {
                tab.Enabled = false;
            }
            (tabControl.TabPages[0] as TabPage).Enabled = true;
        }

        private void btnSubmitRows_Click(object sender, EventArgs e)
        {
            //Step 1 
            panelGenerateditems.Controls.Clear();
            //Step 2
            Columns = Convert.ToInt32(cbbColumns.Text);
            Rows = Convert.ToInt32(cbbRows.Text);
            for (int i = 1; i <= Columns; i++)
            {
                GeneratedInput generated = new GeneratedInput();
                generated.Col = i;
                generated.numberLabel = "ستون شماره " + i.ToString();
                generated.Name = "column_" + i;
                panelGenerateditems.Controls.Add(generated);
            }
            for (int i = 1; i <= Rows ; i++)
            {
                GeneratedInput generated = new GeneratedInput();
                generated.Row = i;
                generated.numberLabel = "ردیف شماره " + i.ToString();
                generated.Name = "row_" + i;
                panelGenerateditems.Controls.Add(generated);
            }
        }

        private void btnNextStep_Click(object sender, EventArgs e)
        {
            foreach (GeneratedInput item in panelGenerateditems.Controls)
            {
                if (item.Name.Contains("column"))
                {
                    dtStep2.Columns.Add(item.ReadName);
                }
                else
                {
                    DataRow newRow = dtStep2.NewRow();
                    newRow[0] = item.ReadName;
                    dtStep2.Rows.Add(newRow);
                }
            }
            dataGridViewStep2.DataSource = dtStep2;

            //Disable Other Tabs
            if (tabControl.TabCount - 1 == tabControl.SelectedIndex)
                return; // No more tabs to show!

            tabControl.SelectedTab.Enabled = false;
            var nextTab = tabControl.TabPages[tabControl.SelectedIndex + 1] as TabPage;
            nextTab.Enabled = true;
            tabControl.SelectedTab = nextTab;
            //tabControl.SelectedIndex = tabControl.SelectedIndex + 1;
        }

        private void btnNextStep3_Click(object sender, EventArgs e)
        {
            //Disable Other Tabs
            if (tabControl.TabCount - 1 == tabControl.SelectedIndex)
                return; // No more tabs to show!

            tabControl.SelectedTab.Enabled = false;
            var nextTab = tabControl.TabPages[tabControl.SelectedIndex + 1] as TabPage;
            nextTab.Enabled = true;
            tabControl.SelectedTab = nextTab;
        }

        private void btnPreviousStep1_Click(object sender, EventArgs e)
        {
            dtStep2.Clear();
            dtStep2.Rows.Clear();
            dtStep2.Columns.Clear();
            dataGridViewStep2.DataSource = null;

            //Disable Other Tabs
            if (tabControl.TabCount - 1 == tabControl.SelectedIndex)
                return; // No more tabs to show!

            tabControl.SelectedTab.Enabled = false;
            var nextTab = tabControl.TabPages[tabControl.SelectedIndex - 1] as TabPage;
            nextTab.Enabled = true;
            tabControl.SelectedTab = nextTab;
        }

    }
}
