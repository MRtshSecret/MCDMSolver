namespace MCDMSolver.Forms
{
    partial class DashboardPage
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnRecently01 = new System.Windows.Forms.Button();
            this.btnRecently02 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelRecntProjects = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.btnRecently01);
            this.flowLayoutPanel1.Controls.Add(this.btnRecently02);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1024, 175);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // btnRecently01
            // 
            this.btnRecently01.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(197)))), ((int)(((byte)(47)))));
            this.btnRecently01.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecently01.FlatAppearance.BorderSize = 0;
            this.btnRecently01.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecently01.Location = new System.Drawing.Point(835, 13);
            this.btnRecently01.Name = "btnRecently01";
            this.btnRecently01.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnRecently01.Size = new System.Drawing.Size(166, 140);
            this.btnRecently01.TabIndex = 6;
            this.btnRecently01.Text = "الگوریتم SAW";
            this.btnRecently01.UseVisualStyleBackColor = false;
            this.btnRecently01.Click += new System.EventHandler(this.BtnRecently01_Click);
            this.btnRecently01.MouseEnter += new System.EventHandler(this.btnRecently_MouseEnter);
            this.btnRecently01.MouseLeave += new System.EventHandler(this.btnRecently_MouseLeave);
            // 
            // btnRecently02
            // 
            this.btnRecently02.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(197)))), ((int)(((byte)(47)))));
            this.btnRecently02.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecently02.FlatAppearance.BorderSize = 0;
            this.btnRecently02.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecently02.Location = new System.Drawing.Point(663, 13);
            this.btnRecently02.Name = "btnRecently02";
            this.btnRecently02.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnRecently02.Size = new System.Drawing.Size(166, 140);
            this.btnRecently02.TabIndex = 7;
            this.btnRecently02.Text = "الگوریتم Topsis";
            this.btnRecently02.UseVisualStyleBackColor = false;
            this.btnRecently02.Click += new System.EventHandler(this.BtnRecently02_Click);
            this.btnRecently02.MouseEnter += new System.EventHandler(this.btnRecently_MouseEnter);
            this.btnRecently02.MouseLeave += new System.EventHandler(this.btnRecently_MouseLeave);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelRecntProjects, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 175);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1024, 593);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 0, 55, 0);
            this.label1.Size = new System.Drawing.Size(1018, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = " اخیرا استفاده کرده اید";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelRecntProjects
            // 
            this.panelRecntProjects.AutoScroll = true;
            this.panelRecntProjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRecntProjects.Location = new System.Drawing.Point(3, 28);
            this.panelRecntProjects.Name = "panelRecntProjects";
            this.panelRecntProjects.Size = new System.Drawing.Size(1018, 562);
            this.panelRecntProjects.TabIndex = 2;
            // 
            // DashboardPage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Vazir FD-WOL", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashboardPage";
            this.Text = "Due";
            this.Load += new System.EventHandler(this.Due_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelRecntProjects;
        private System.Windows.Forms.Button btnRecently01;
        private System.Windows.Forms.Button btnRecently02;
    }
}