namespace MCDMSolver.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.btnLoad = new MCDMSolver.UserControls.CustomButton();
            this.btnNew = new MCDMSolver.UserControls.CustomButton();
            this.btnDashboard = new MCDMSolver.UserControls.CustomButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAccountManager = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panel200 = new System.Windows.Forms.Panel();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.panelToolbar = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnMinimize = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Label();
            this.btnAccountName = new System.Windows.Forms.Label();
            this.panelSideMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel200.SuspendLayout();
            this.panelToolbar.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(55)))), ((int)(((byte)(57)))));
            this.panelSideMenu.Controls.Add(this.btnLoad);
            this.panelSideMenu.Controls.Add(this.btnNew);
            this.panelSideMenu.Controls.Add(this.btnDashboard);
            this.panelSideMenu.Controls.Add(this.panel1);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelSideMenu.Location = new System.Drawing.Point(924, 25);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(98, 741);
            this.panelSideMenu.TabIndex = 2;
            // 
            // btnLoad
            // 
            this.btnLoad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnLoad.btnImage = ((System.Drawing.Image)(resources.GetObject("btnLoad.btnImage")));
            this.btnLoad.btnText = "بارگزاری";
            this.btnLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoad.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLoad.Font = new System.Drawing.Font("Vazir FD-WOL", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLoad.Location = new System.Drawing.Point(0, 274);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(98, 87);
            this.btnLoad.TabIndex = 9;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnNew
            // 
            this.btnNew.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnNew.btnImage = ((System.Drawing.Image)(resources.GetObject("btnNew.btnImage")));
            this.btnNew.btnText = "جدید";
            this.btnNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNew.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNew.Font = new System.Drawing.Font("Vazir FD-WOL", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.SystemColors.Control;
            this.btnNew.Location = new System.Drawing.Point(0, 187);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(98, 87);
            this.btnNew.TabIndex = 8;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnDashboard.btnImage = ((System.Drawing.Image)(resources.GetObject("btnDashboard.btnImage")));
            this.btnDashboard.btnText = "داشبورد";
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.Font = new System.Drawing.Font("Vazir FD-WOL", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDashboard.Location = new System.Drawing.Point(0, 100);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(98, 87);
            this.btnDashboard.TabIndex = 7;
            this.btnDashboard.Click += new System.EventHandler(this.BtnDashboard_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAccountManager);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 595);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(98, 146);
            this.panel1.TabIndex = 6;
            // 
            // btnAccountManager
            // 
            this.btnAccountManager.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccountManager.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAccountManager.FlatAppearance.BorderSize = 0;
            this.btnAccountManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccountManager.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAccountManager.Location = new System.Drawing.Point(0, 36);
            this.btnAccountManager.Name = "btnAccountManager";
            this.btnAccountManager.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnAccountManager.Size = new System.Drawing.Size(98, 55);
            this.btnAccountManager.TabIndex = 3;
            this.btnAccountManager.Text = "مدیریت حساب";
            this.btnAccountManager.UseVisualStyleBackColor = true;
            this.btnAccountManager.Click += new System.EventHandler(this.btnAccountManager_Click);
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.SystemColors.Control;
            this.btnExit.Location = new System.Drawing.Point(0, 91);
            this.btnExit.Name = "btnExit";
            this.btnExit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnExit.Size = new System.Drawing.Size(98, 55);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "خروج";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(98, 100);
            this.panelLogo.TabIndex = 0;
            // 
            // panel200
            // 
            this.panel200.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel200.Controls.Add(this.panelChildForm);
            this.panel200.Controls.Add(this.panelSideMenu);
            this.panel200.Controls.Add(this.panelToolbar);
            this.panel200.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel200.Location = new System.Drawing.Point(0, 0);
            this.panel200.Name = "panel200";
            this.panel200.Size = new System.Drawing.Size(1024, 768);
            this.panel200.TabIndex = 1;
            // 
            // panelChildForm
            // 
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(0, 25);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(924, 741);
            this.panelChildForm.TabIndex = 3;
            // 
            // panelToolbar
            // 
            this.panelToolbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(55)))), ((int)(((byte)(57)))));
            this.panelToolbar.Controls.Add(this.tableLayoutPanel1);
            this.panelToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelToolbar.Location = new System.Drawing.Point(0, 0);
            this.panelToolbar.Name = "panelToolbar";
            this.panelToolbar.Padding = new System.Windows.Forms.Padding(10, 1, 10, 0);
            this.panelToolbar.Size = new System.Drawing.Size(1022, 25);
            this.panelToolbar.TabIndex = 0;
            this.panelToolbar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelToolbar_MouseDown);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 190F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Controls.Add(this.btnMinimize, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnClose, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnAccountName, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1002, 24);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelToolbar_MouseDown);
            // 
            // btnMinimize
            // 
            this.btnMinimize.AutoSize = true;
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMinimize.Font = new System.Drawing.Font("A Iranian Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnMinimize.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMinimize.Location = new System.Drawing.Point(955, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(19, 24);
            this.btnMinimize.TabIndex = 3;
            this.btnMinimize.Text = "-";
            this.btnMinimize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            this.btnClose.AutoSize = true;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClose.Font = new System.Drawing.Font("A Iranian Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClose.Location = new System.Drawing.Point(980, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(19, 24);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "X";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClose.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // btnAccountName
            // 
            this.btnAccountName.AutoSize = true;
            this.btnAccountName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAccountName.Font = new System.Drawing.Font("A Iranian Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnAccountName.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAccountName.Location = new System.Drawing.Point(765, 0);
            this.btnAccountName.Name = "btnAccountName";
            this.btnAccountName.Size = new System.Drawing.Size(184, 24);
            this.btnAccountName.TabIndex = 4;
            this.btnAccountName.Text = "مرتضی هوشنگ منش";
            this.btnAccountName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAccountName.UseCompatibleTextRendering = true;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.panel200);
            this.Font = new System.Drawing.Font("A Iranian Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panelSideMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel200.ResumeLayout(false);
            this.panelToolbar.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panel200;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Button btnAccountManager;
        private System.Windows.Forms.Panel panelToolbar;
        private System.Windows.Forms.Label btnMinimize;
        private System.Windows.Forms.Label btnClose;
        private System.Windows.Forms.Label btnAccountName;
        private UserControls.CustomButton btnDashboard;
        private UserControls.CustomButton btnNew;
        private UserControls.CustomButton btnLoad;
        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}