using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCDMPLD_Topsis
{
    public partial class PLGTOPSOSMain : Form
    {
        public PLGTOPSOSMain()
        {
            InitializeComponent();
        }
        List<reporter> reports = new List<reporter>();
        int Columns, Rows;
        DataTable dtStep3 = new DataTable();
        List<decimal> inputSign = new List<decimal>();
        List<double> inputWeight = new List<double>();
        public string foldername = "";

        private void MainForm_Load(object sender, EventArgs e)
        {
            foreach (TabPage tab in tabControl.TabPages)
            {
                tab.Enabled = false;
            }
            (tabControl.TabPages[0] as TabPage).Enabled = true;
            foldername = $"{DateTime.Now.Year}\\{DateTime.Now.Month}\\{DateTime.Now.Day}\\Topsis\\{DateTime.Now.Ticks}";

            Directory.CreateDirectory(foldername);
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

            dtStep3.Columns.Add("*");
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
            int aa = dataGridViewStep3.Columns.Count;

            dataGridViewStep3.DataSource = dtStep3;
            for (int i = 0; i < dataGridViewStep3.Rows.Count; i++)
            {
                dataGridViewStep3.Rows[i].Cells[1].ReadOnly = true;
                dataGridViewStep3.Rows[i].Cells[1].Style.BackColor = Color.Gray;
            }
            dataGridViewStep3.Refresh();
            dataGridViewStep3.Update();
            //for(int col =0; col < dataGridViewStep3.Columns.Count; col++)
            //{

            //    dataGridViewStep3.Columns[col].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //}


            //Disable Other Tabs
            if (tabControl.TabCount - 1 == tabControl.SelectedIndex)
                return; // No more tabs to show!

            tabControl.SelectedTab.Enabled = false;
            var nextTab = tabControl.TabPages[tabControl.SelectedIndex + 1] as TabPage;
            nextTab.Enabled = true;
            dataGridViewStep3.Columns[0].ReadOnly = true;
            tabControl.SelectedTab = nextTab;
        }


        private void btnNextStep3_Click(object sender, EventArgs e)
        {
            Calculate_SAW(inputSign, inputWeight, dtStep3);
            //Disable Other Tabs
            if (tabControl.TabCount - 1 == tabControl.SelectedIndex)
                return; // No more tabs to show!

            tabControl.SelectedTab.Enabled = false;
            var nextTab = tabControl.TabPages[tabControl.SelectedIndex + 1] as TabPage;
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

        private void btnNextStep4_Click(object sender, EventArgs e)
        {
            //Disable Other Tabs
            if (tabControl.TabCount - 1 == tabControl.SelectedIndex)
                return; // No more tabs to show!

            tabControl.SelectedTab.Enabled = false;
            var nextTab = tabControl.TabPages[tabControl.SelectedIndex + 1] as TabPage;
            nextTab.Enabled = true;
            tabControl.SelectedTab = nextTab;
        }

        private void btnPreviousStep4_Click(object sender, EventArgs e)
        {
            dataGridViewStep4.DataSource = null;
            //Disable Other Tabs
            if (tabControl.TabCount - 1 == tabControl.SelectedIndex)
                return; // No more tabs to show!

            tabControl.SelectedTab.Enabled = false;
            var nextTab = tabControl.TabPages[tabControl.SelectedIndex - 1] as TabPage;
            nextTab.Enabled = true;
            tabControl.SelectedTab = nextTab;
        }

        private void btnPreviousStep5_Click(object sender, EventArgs e)
        {
            dataGridViewStep4.DataSource = null;
            //Disable Other Tabs
            if (tabControl.TabCount - 1 == tabControl.SelectedIndex)
                return; // No more tabs to show!

            tabControl.SelectedTab.Enabled = false;
            var nextTab = tabControl.TabPages[tabControl.SelectedIndex - 1] as TabPage;
            nextTab.Enabled = true;
            tabControl.SelectedTab = nextTab;
        }

        public void Calculate_SAW(List<decimal> sign1, List<double> weight1, DataTable dt)
        {
            try
            {

                List<reporter> reports = new List<reporter>();
                //file start

                File.WriteAllText(foldername + "\\sign.panda", JsonConvert.SerializeObject(sign1));
                File.WriteAllText(foldername + "\\weight1.panda", JsonConvert.SerializeObject(weight1));
                File.WriteAllText(foldername + "\\dt.panda", JsonConvert.SerializeObject(dt));
                // file end
                //Configurate Datatable :
                List<string> RowNames = new List<string>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    RowNames.Add(dt.Rows[i][0].ToString());
                }
                int dtrowscount = dt.Rows.Count + 1;
                int dtColcount = dt.Columns.Count;
                DataTable dt1 = new DataTable();
                for (int i = 1; i < dtColcount; i++)
                {
                    dt1.Columns.Add();
                }
                var cell = new object[dtColcount - 1];
                for (int j = 0; j < dtrowscount; j++)
                {

                    for (int i = 1; i < dt.Columns.Count; i++)
                    {
                        try
                        {
                            cell[i - 1] = dt.Rows[j][i].ToString();

                        }
                        catch
                        {
                            cell[i - 1] = "";
                        }
                    }
                    dt1.Rows.Add(cell);
                }
                List<double> Taghsimehar_sotoon = new List<double>();
                List<List<double>> harsotoon = new List<List<double>>();
                reporter repo = new reporter();
                repo.NameOfReport = "step 1 Datatable ";
                repo.reportdatatable = dt1;
                reports.Add(repo);
                File.WriteAllText(foldername + "\\reports1.panda", JsonConvert.SerializeObject(reports));
                //======================================================= END
                List<double> RadikalZigmaTavan2 = new List<double>();
                for (int i = 0; i < dt1.Columns.Count; i++)
                {
                    double ReslutOfColumn = 0;
                    for (int j = 0; j < dt1.Rows.Count - 1; j++)
                    {
                        ReslutOfColumn += Math.Pow(Convert.ToDouble(dt1.Rows[j][i].ToString()), 2);
                    }
                    RadikalZigmaTavan2.Add(Math.Pow(ReslutOfColumn, 0.5));
                }
                for (int i = 0; i < dt1.Columns.Count; i++)
                {
                    for (int j = 0; j < dt1.Rows.Count - 1; j++)
                    {
                        dt1.Rows[j][i] = ((Convert.ToDouble(dt1.Rows[j][i]) / RadikalZigmaTavan2[i]) * weight1[i]).ToString();
                    }
                }
                List<List<double>> Meeyaar = new List<List<double>>();
                for (int i = 0; i < dt1.Columns.Count; i++)
                {
                    List<double> MeyarOfColumn = new List<double>();
                    for (int j = 0; j < dt1.Rows.Count - 1; j++)
                    {
                        MeyarOfColumn.Add(Convert.ToDouble(dt1.Rows[j][i].ToString()));
                    }
                    Meeyaar.Add(MeyarOfColumn);
                }
                List<double> IdeAlMosbat = new List<double>();
                for (int i = 0; i < Meeyaar.Count; i++)
                {
                    if (sign1[i] == 1)
                    {
                        IdeAlMosbat.Add(Meeyaar[i].Max());
                    }
                    else
                    {
                        IdeAlMosbat.Add(Meeyaar[i].Min());
                    }
                }
                List<double> IdeAlManfi = new List<double>();
                for (int i = 0; i < Meeyaar.Count; i++)
                {
                    if (sign1[i] == 1)
                    {
                        IdeAlManfi.Add(Meeyaar[i].Min());
                    }
                    else
                    {
                        IdeAlManfi.Add(Meeyaar[i].Max());
                    }
                }
                //========================================================

                List<double> SiPlus = new List<double>();
                for (int j = 0; j < dt1.Rows.Count - 1; j++)
                {
                    double ZigmaPluspow2 = 0;
                    for (int i = 0; i < dt1.Columns.Count; i++)
                    {
                        double Results1 = Convert.ToDouble(dt1.Rows[j][i].ToString()) - IdeAlMosbat[i];
                        ZigmaPluspow2 += Math.Pow(Results1, 2);
                    }
                    SiPlus.Add(Math.Pow(ZigmaPluspow2, 0.5));
                }

                List<double> Siminus = new List<double>();
                for (int j = 0; j < dt1.Rows.Count - 1; j++)
                {
                    double ZigmaPluspow2 = 0;
                    for (int i = 0; i < dt1.Columns.Count; i++)
                    {
                        double Results1 = Convert.ToDouble(dt1.Rows[j][i].ToString()) - IdeAlManfi[i];
                        ZigmaPluspow2 += Math.Pow(Results1, 2);
                    }
                    Siminus.Add(Math.Pow(ZigmaPluspow2, 0.5));
                }
                List<double> ResultsOfSiPlusandMinus = new List<double>();
                for (int i = 0; i < Siminus.Count; i++)
                {
                    ResultsOfSiPlusandMinus.Add((Siminus[i] / (Siminus[i] + SiPlus[i])));
                }

                DataTable Final = new DataTable();
                for (int i = 0; i < RowNames.Count; i++)
                {
                    Final.Columns.Add(RowNames[i]);
                }
                var cellsFinal = new object[RowNames.Count];

                for (int i = 0; i < RowNames.Count; i++)
                {
                    cellsFinal[i] = ResultsOfSiPlusandMinus[i].ToString();
                }
                Final.Rows.Add(cellsFinal);
                dataGridViewStep4.DataSource = Final;
                ResultsOfSiPlusandMinus.Sort();
                string AAA = "";
                for (int i = 0; i < ResultsOfSiPlusandMinus.Count; i++)
                {
                    AAA += "Topsis==> Num " + i.ToString() + " : " + ResultsOfSiPlusandMinus[i] + "\n";
                }
                labelResult.Text = AAA;

                File.WriteAllText(foldername + "\\reports3.panda", JsonConvert.SerializeObject(ResultsOfSiPlusandMinus));
                File.WriteAllText(foldername + "\\DonePaper.panda", "1");
            }
            catch (Exception ex)
            {
                File.WriteAllText(foldername + "\\FailPaper.panda", ex.ToString());
            }

        }

        #endregion

    }
}
