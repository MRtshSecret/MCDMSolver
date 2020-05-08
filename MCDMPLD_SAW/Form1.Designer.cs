namespace MCDMPLD_SAW
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbColumns = new System.Windows.Forms.ComboBox();
            this.cbbRows = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewStep2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewStep3 = new System.Windows.Forms.DataGridView();
            this.btnSubmitRows = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnNextStep = new System.Windows.Forms.Button();
            this.panelGenerateditems = new System.Windows.Forms.Panel();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStep2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStep3)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Controls.Add(this.tabPage4);
            this.tabControl.Controls.Add(this.tabPage5);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.ItemSize = new System.Drawing.Size(75, 25);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.RightToLeftLayout = true;
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1002, 680);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(994, 647);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "مرحله اول";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridViewStep2);
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(994, 647);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "مرحله دوم";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridViewStep3);
            this.tabPage3.Location = new System.Drawing.Point(4, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(994, 647);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "مرحله سوم";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(994, 647);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "مرحله چهارم";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 4);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(994, 647);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "مرحله پنجم";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(988, 641);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSubmitRows);
            this.panel1.Controls.Add(this.cbbRows);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbbColumns);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(794, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(191, 635);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Location = new System.Drawing.Point(106, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "تعداد ستون ها:";
            // 
            // cbbColumns
            // 
            this.cbbColumns.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbColumns.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbColumns.FormattingEnabled = true;
            this.cbbColumns.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cbbColumns.Location = new System.Drawing.Point(3, 79);
            this.cbbColumns.Name = "cbbColumns";
            this.cbbColumns.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbbColumns.Size = new System.Drawing.Size(182, 21);
            this.cbbColumns.TabIndex = 1;
            // 
            // cbbRows
            // 
            this.cbbRows.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbRows.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbRows.FormattingEnabled = true;
            this.cbbRows.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cbbRows.Location = new System.Drawing.Point(3, 171);
            this.cbbRows.Name = "cbbRows";
            this.cbbRows.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbbRows.Size = new System.Drawing.Size(182, 21);
            this.cbbRows.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Location = new System.Drawing.Point(106, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "تعداد ردیف ها:";
            // 
            // dataGridViewStep2
            // 
            this.dataGridViewStep2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStep2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewStep2.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewStep2.Name = "dataGridViewStep2";
            this.dataGridViewStep2.Size = new System.Drawing.Size(988, 641);
            this.dataGridViewStep2.TabIndex = 0;
            // 
            // dataGridViewStep3
            // 
            this.dataGridViewStep3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStep3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewStep3.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewStep3.Name = "dataGridViewStep3";
            this.dataGridViewStep3.Size = new System.Drawing.Size(994, 647);
            this.dataGridViewStep3.TabIndex = 1;
            // 
            // btnSubmitRows
            // 
            this.btnSubmitRows.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubmitRows.Location = new System.Drawing.Point(61, 242);
            this.btnSubmitRows.Name = "btnSubmitRows";
            this.btnSubmitRows.Size = new System.Drawing.Size(75, 23);
            this.btnSubmitRows.TabIndex = 4;
            this.btnSubmitRows.Text = "انجام";
            this.btnSubmitRows.UseVisualStyleBackColor = true;
            this.btnSubmitRows.Click += new System.EventHandler(this.btnSubmitRows_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.btnNextStep, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.panelGenerateditems, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(785, 635);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // btnNextStep
            // 
            this.btnNextStep.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnNextStep.Location = new System.Drawing.Point(10, 598);
            this.btnNextStep.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.btnNextStep.Name = "btnNextStep";
            this.btnNextStep.Size = new System.Drawing.Size(75, 34);
            this.btnNextStep.TabIndex = 0;
            this.btnNextStep.Text = "مرحله بعدی";
            this.btnNextStep.UseVisualStyleBackColor = true;
            this.btnNextStep.Click += new System.EventHandler(this.btnNextStep_Click);
            // 
            // panelGenerateditems
            // 
            this.panelGenerateditems.AutoScroll = true;
            this.panelGenerateditems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGenerateditems.Location = new System.Drawing.Point(3, 3);
            this.panelGenerateditems.Name = "panelGenerateditems";
            this.panelGenerateditems.Padding = new System.Windows.Forms.Padding(25, 75, 25, 3);
            this.panelGenerateditems.Size = new System.Drawing.Size(779, 589);
            this.panelGenerateditems.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1002, 680);
            this.Controls.Add(this.tabControl);
            this.Font = new System.Drawing.Font("A Iranian Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1002, 680);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStep2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStep3)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbRows;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbColumns;
        private System.Windows.Forms.DataGridView dataGridViewStep2;
        private System.Windows.Forms.DataGridView dataGridViewStep3;
        private System.Windows.Forms.Button btnSubmitRows;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnNextStep;
        private System.Windows.Forms.Panel panelGenerateditems;
    }
}

