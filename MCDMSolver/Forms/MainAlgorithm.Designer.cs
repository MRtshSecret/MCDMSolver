﻿namespace MCDMSolver.Forms
{
    partial class MainAlgorithm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainAlgorithm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.toolbarPanel = new System.Windows.Forms.Panel();
            this.labelAlgorithmType = new System.Windows.Forms.Label();
            this.labelFileDate = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelAlgorithmName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.iconHome = new System.Windows.Forms.PictureBox();
            this.labelHome = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.labelHistory = new System.Windows.Forms.Label();
            this.iconHistory = new System.Windows.Forms.PictureBox();
            this.pnlPluginLoader = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.toolbarPanel.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconHome)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.toolbarPanel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlPluginLoader, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1008, 768);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // toolbarPanel
            // 
            this.toolbarPanel.Controls.Add(this.labelAlgorithmType);
            this.toolbarPanel.Controls.Add(this.labelFileDate);
            this.toolbarPanel.Controls.Add(this.label5);
            this.toolbarPanel.Controls.Add(this.labelAlgorithmName);
            this.toolbarPanel.Controls.Add(this.label3);
            this.toolbarPanel.Controls.Add(this.tableLayoutPanel3);
            this.toolbarPanel.Controls.Add(this.tableLayoutPanel2);
            this.toolbarPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.toolbarPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolbarPanel.Location = new System.Drawing.Point(3, 3);
            this.toolbarPanel.Name = "toolbarPanel";
            this.toolbarPanel.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.toolbarPanel.Size = new System.Drawing.Size(1002, 76);
            this.toolbarPanel.TabIndex = 0;
            // 
            // labelAlgorithmType
            // 
            this.labelAlgorithmType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAlgorithmType.AutoSize = true;
            this.labelAlgorithmType.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelAlgorithmType.Font = new System.Drawing.Font("A Iranian Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelAlgorithmType.Location = new System.Drawing.Point(501, 27);
            this.labelAlgorithmType.Name = "labelAlgorithmType";
            this.labelAlgorithmType.Size = new System.Drawing.Size(35, 19);
            this.labelAlgorithmType.TabIndex = 6;
            this.labelAlgorithmType.Text = "SAW";
            // 
            // labelFileDate
            // 
            this.labelFileDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFileDate.AutoSize = true;
            this.labelFileDate.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelFileDate.Font = new System.Drawing.Font("Vazir FD-WOL", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFileDate.Location = new System.Drawing.Point(813, 49);
            this.labelFileDate.Name = "labelFileDate";
            this.labelFileDate.Size = new System.Drawing.Size(59, 18);
            this.labelFileDate.TabIndex = 5;
            this.labelFileDate.Text = "2020/11/12";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label5.Font = new System.Drawing.Font("Vazir FD-WOL", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(926, 49);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(58, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "تاریخ ایجاد:";
            // 
            // labelAlgorithmName
            // 
            this.labelAlgorithmName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAlgorithmName.AutoEllipsis = true;
            this.labelAlgorithmName.AutoSize = true;
            this.labelAlgorithmName.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelAlgorithmName.Font = new System.Drawing.Font("Vazir FD-WOL", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlgorithmName.Location = new System.Drawing.Point(813, 13);
            this.labelAlgorithmName.Name = "labelAlgorithmName";
            this.labelAlgorithmName.Size = new System.Drawing.Size(75, 18);
            this.labelAlgorithmName.TabIndex = 3;
            this.labelAlgorithmName.Text = "فایل شماره 23";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label3.Font = new System.Drawing.Font("Vazir FD-WOL", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(937, 13);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(47, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "نام فایل:";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.iconHome, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.labelHome, 0, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(13, 9);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(63, 60);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // iconHome
            // 
            this.iconHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iconHome.Image = ((System.Drawing.Image)(resources.GetObject("iconHome.Image")));
            this.iconHome.Location = new System.Drawing.Point(3, 3);
            this.iconHome.Name = "iconHome";
            this.iconHome.Size = new System.Drawing.Size(57, 34);
            this.iconHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconHome.TabIndex = 0;
            this.iconHome.TabStop = false;
            // 
            // labelHome
            // 
            this.labelHome.AutoSize = true;
            this.labelHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelHome.Location = new System.Drawing.Point(3, 40);
            this.labelHome.Name = "labelHome";
            this.labelHome.Size = new System.Drawing.Size(57, 20);
            this.labelHome.TabIndex = 1;
            this.labelHome.Text = "خانه";
            this.labelHome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.labelHistory, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.iconHistory, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(93, 9);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(63, 60);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // labelHistory
            // 
            this.labelHistory.AutoSize = true;
            this.labelHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelHistory.Location = new System.Drawing.Point(3, 40);
            this.labelHistory.Name = "labelHistory";
            this.labelHistory.Size = new System.Drawing.Size(57, 20);
            this.labelHistory.TabIndex = 3;
            this.labelHistory.Text = "سوابق";
            this.labelHistory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iconHistory
            // 
            this.iconHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iconHistory.Image = ((System.Drawing.Image)(resources.GetObject("iconHistory.Image")));
            this.iconHistory.Location = new System.Drawing.Point(3, 3);
            this.iconHistory.Name = "iconHistory";
            this.iconHistory.Size = new System.Drawing.Size(57, 34);
            this.iconHistory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconHistory.TabIndex = 2;
            this.iconHistory.TabStop = false;
            // 
            // pnlPluginLoader
            // 
            this.pnlPluginLoader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPluginLoader.Location = new System.Drawing.Point(3, 85);
            this.pnlPluginLoader.Name = "pnlPluginLoader";
            this.pnlPluginLoader.Size = new System.Drawing.Size(1002, 680);
            this.pnlPluginLoader.TabIndex = 1;
            // 
            // MainAlgorithm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1008, 768);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Vazir FD-WOL", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainAlgorithm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.toolbarPanel.ResumeLayout(false);
            this.toolbarPanel.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconHome)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel toolbarPanel;
        private System.Windows.Forms.Panel pnlPluginLoader;
        private System.Windows.Forms.PictureBox iconHome;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label labelHome;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.PictureBox iconHistory;
        private System.Windows.Forms.Label labelHistory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelAlgorithmName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelFileDate;
        private System.Windows.Forms.Label labelAlgorithmType;
    }
}