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
        DataTable dtStep3 = new DataTable();
        List<decimal> inputSign = new List<decimal>();
        List<double> inputWeight = new List<double>();
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
            panelGenerateRowItems.Controls.Clear();
            //Step 2
            Rows = Convert.ToInt32(cbbRows.SelectedItem);
            for (int i = 1; i <= Rows; i++)
            {
                GeneratedInput generated = new GeneratedInput();
                generated.Row = i;
                generated.Name = "row_" + i;
                panelGenerateRowItems.Controls.Add(generated);
            }
        }

        private void btnSubmitCols_Click(object sender, EventArgs e)
        {
            //Step 1 
            panelGeneratedColItems.Controls.Clear();
            //Step 2
            Columns = Convert.ToInt32(cbbColumns.SelectedItem.ToString());
            for (int i = 1; i <= Columns; i++)
            {
                GeneratedInputColumns generated = new GeneratedInputColumns();
                generated.Col = i;
                generated.Name = "column_" + i;
                panelGeneratedColItems.Controls.Add(generated);
            }
        }

        private void btnNextStep_Click(object sender, EventArgs e)
        {
            //Disable Other Tabs
            if (tabControl.TabCount - 1 == tabControl.SelectedIndex)
                return; // No more tabs to show!

            tabControl.SelectedTab.Enabled = false;
            var nextTab = tabControl.TabPages[tabControl.SelectedIndex + 1] as TabPage;
            nextTab.Enabled = true;
            tabControl.SelectedTab = nextTab;
            //tabControl.SelectedIndex = tabControl.SelectedIndex + 1;
        }

        private void btnNextStep2_Click(object sender, EventArgs e)
        {

            dtStep3.Columns.Add(" ");
            foreach (GeneratedInputColumns item in panelGeneratedColItems.Controls)
            {
                dtStep3.Columns.Add(item.txtBoxColName.Text);
                inputWeight.Add(Convert.ToDouble(item.txtBoxWeight.Text));
                inputSign.Add(item.numSign.Value);
            }

            foreach (GeneratedInput item in panelGenerateRowItems.Controls)
            {
                DataRow newRow = dtStep3.NewRow();
                newRow[0] = item.txtBoxReadName.Text;
                dtStep3.Rows.Add(newRow);
            }

            dataGridViewStep3.DataSource = dtStep3;

            //Disable Other Tabs
            if (tabControl.TabCount - 1 == tabControl.SelectedIndex)
                return; // No more tabs to show!

            tabControl.SelectedTab.Enabled = false;
            var nextTab = tabControl.TabPages[tabControl.SelectedIndex + 1] as TabPage;
            nextTab.Enabled = true;
            tabControl.SelectedTab = nextTab;
        }


        private void btnNextStep3_Click(object sender, EventArgs e)
        {
            Calculate_SAW(inputSign,inputWeight,dtStep3);
            //Disable Other Tabs
            if (tabControl.TabCount - 1 == tabControl.SelectedIndex)
                return; // No more tabs to show!

            tabControl.SelectedTab.Enabled = false;
            var nextTab = tabControl.TabPages[tabControl.SelectedIndex + 2] as TabPage;
            nextTab.Enabled = true;
            tabControl.SelectedTab = nextTab;
        }

        private void btnPreviousStep3_Click(object sender, EventArgs e)
        {
            dtStep3.Clear();
            dtStep3.Rows.Clear();
            dtStep3.Columns.Clear();
            dataGridViewStep3.DataSource = null;

            //Disable Other Tabs
            if (tabControl.TabCount - 1 == tabControl.SelectedIndex)
                return; // No more tabs to show!

            tabControl.SelectedTab.Enabled = false;
            var nextTab = tabControl.TabPages[tabControl.SelectedIndex - 1] as TabPage;
            nextTab.Enabled = true;
            tabControl.SelectedTab = nextTab;
        }


        #region Algorithm

        private DataTable ToDataTable(DataGridView dataGridView)
        {
            var dt = new DataTable();
            foreach (DataGridViewColumn dataGridViewColumn in dataGridView.Columns)
            {
                if (dataGridViewColumn.Visible)
                {
                    dt.Columns.Add();
                }
            }
            var cell = new object[dataGridView.Columns.Count];
            foreach (DataGridViewRow dataGridViewRow in dataGridView.Rows)
            {
                for (int i = 0; i < dataGridViewRow.Cells.Count; i++)
                {
                    cell[i] = dataGridViewRow.Cells[i].Value;
                }
                dt.Rows.Add(cell);
            }
            return dt;
        }

    
        public void Calculate_SAW(List<decimal> sign1, List<double> weight1, DataTable dt1)
        {
            List<double> Taghsimehar_sotoon = new List<double>();
            List<List<double>> harsotoon = new List<List<double>>();
            for (int i = 1; i < dt1.Columns.Count - 1; i++)
            {
                List<double> Sotoons = new List<double>();
                for (int j = 1; j < dt1.Rows.Count; j++)
                {
                    Sotoons.Add(Convert.ToDouble(dt1.Rows[j][i]));
                }
                harsotoon.Add(Sotoons);
            }
            List<double> Meyar = new List<double>();
            for (int i = 0; i < harsotoon.Count; i++)
            {
                if (sign1[i] == 1)
                {
                    Meyar.Add(harsotoon[i].Max());
                }
                else
                {
                    Meyar.Add(harsotoon[i].Min());
                }
            }

            for (int i = 1; i < dt1.Columns.Count - 1; i++)
            {
                for (int j = 1; j < dt1.Rows.Count; j++)
                {
                    if (sign1[i] == 1)
                    {
                        double Result = ((Convert.ToDouble(dt1.Rows[j][i].ToString())) / Meyar[i]) * weight1[i];
                        dt1.Rows[j][i] = Result.ToString();
                    }
                    else
                    {
                        double Result = (Meyar[i] / (Convert.ToDouble(dt1.Rows[j][i].ToString()))) * weight1[i];
                        dt1.Rows[j][i] = Result.ToString();
                    }
                }
            }
            List<double> Sorts = new List<double>();
            for (int i = 1; i < dt1.Rows.Count; i++)
            {
                double Sum = 0;
                for (int j = 1; j < dt1.Columns.Count - 1; j++)
                {
                    Sum += Convert.ToDouble(dt1.Rows[i][j].ToString());
                }
                Sorts.Add(Sum);
            }
            Sorts.Sort();
            string AAA = "";
            for (int i = 0; i < Sorts.Count; i++)
            {
                AAA += "SAW ==> Num " + i.ToString() + " ==> " + Sorts[i] + "\n";
            }
            labelResult.Text = AAA;
        }

        #endregion
    }
}
