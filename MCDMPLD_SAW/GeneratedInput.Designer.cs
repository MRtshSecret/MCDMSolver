namespace MCDMPLD_SAW
{
    partial class GeneratedInput
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelGenerate = new System.Windows.Forms.TableLayoutPanel();
            this.labelRows = new System.Windows.Forms.Label();
            this.txtBoxReadName = new System.Windows.Forms.TextBox();
            this.panelGenerate.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelGenerate
            // 
            this.panelGenerate.ColumnCount = 1;
            this.panelGenerate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelGenerate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panelGenerate.Controls.Add(this.labelRows, 0, 0);
            this.panelGenerate.Controls.Add(this.txtBoxReadName, 0, 1);
            this.panelGenerate.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelGenerate.Location = new System.Drawing.Point(0, 0);
            this.panelGenerate.Margin = new System.Windows.Forms.Padding(25, 75, 25, 3);
            this.panelGenerate.Name = "panelGenerate";
            this.panelGenerate.RowCount = 2;
            this.panelGenerate.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.panelGenerate.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.panelGenerate.Size = new System.Drawing.Size(709, 63);
            this.panelGenerate.TabIndex = 2;
            // 
            // labelRows
            // 
            this.labelRows.AutoSize = true;
            this.labelRows.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelRows.Location = new System.Drawing.Point(3, 0);
            this.labelRows.Name = "labelRows";
            this.labelRows.Size = new System.Drawing.Size(703, 25);
            this.labelRows.TabIndex = 0;
            this.labelRows.Text = "نام ردیف:";
            this.labelRows.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtBoxReadName
            // 
            this.txtBoxReadName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBoxReadName.Location = new System.Drawing.Point(10, 35);
            this.txtBoxReadName.Margin = new System.Windows.Forms.Padding(10);
            this.txtBoxReadName.Name = "txtBoxReadName";
            this.txtBoxReadName.Size = new System.Drawing.Size(689, 20);
            this.txtBoxReadName.TabIndex = 0;
            // 
            // GeneratedInput
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panelGenerate);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name = "GeneratedInput";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(709, 62);
            this.Load += new System.EventHandler(this.GeneratedInput_Load);
            this.panelGenerate.ResumeLayout(false);
            this.panelGenerate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel panelGenerate;
        private System.Windows.Forms.Label labelRows;
        public System.Windows.Forms.TextBox txtBoxReadName;
    }
}
