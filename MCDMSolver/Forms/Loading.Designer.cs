namespace MCDMSolver.Forms
{
    partial class Loading
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
            this.components = new System.ComponentModel.Container();
            this.progressBarBottom = new System.Windows.Forms.ProgressBar();
            this.labelClose = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.labelProgressBar = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelMainText = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressBarBottom
            // 
            this.progressBarBottom.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.progressBarBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBarBottom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.progressBarBottom.Location = new System.Drawing.Point(0, 224);
            this.progressBarBottom.Name = "progressBarBottom";
            this.progressBarBottom.RightToLeftLayout = true;
            this.progressBarBottom.Size = new System.Drawing.Size(538, 10);
            this.progressBarBottom.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarBottom.TabIndex = 1;
            this.progressBarBottom.Value = 50;
            // 
            // labelClose
            // 
            this.labelClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelClose.BackColor = System.Drawing.Color.Transparent;
            this.labelClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelClose.ForeColor = System.Drawing.Color.White;
            this.labelClose.Location = new System.Drawing.Point(511, 0);
            this.labelClose.Name = "labelClose";
            this.labelClose.Size = new System.Drawing.Size(28, 31);
            this.labelClose.TabIndex = 5;
            this.labelClose.Text = "X";
            this.labelClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelClose.Click += new System.EventHandler(this.labelClose_Click);
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(55)))), ((int)(((byte)(57)))));
            this.panelMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMain.Controls.Add(this.labelMainText);
            this.panelMain.Controls.Add(this.label2);
            this.panelMain.Controls.Add(this.labelProgressBar);
            this.panelMain.Controls.Add(this.labelClose);
            this.panelMain.Controls.Add(this.progressBarBottom);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(540, 236);
            this.panelMain.TabIndex = 0;
            this.panelMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelToolbar_MouseDown);
            // 
            // labelProgressBar
            // 
            this.labelProgressBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelProgressBar.ForeColor = System.Drawing.Color.White;
            this.labelProgressBar.Location = new System.Drawing.Point(0, 203);
            this.labelProgressBar.Name = "labelProgressBar";
            this.labelProgressBar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelProgressBar.Size = new System.Drawing.Size(538, 21);
            this.labelProgressBar.TabIndex = 6;
            this.labelProgressBar.Text = "متن مورد نظر بصورت رندوم برای LOADING";
            this.labelProgressBar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(11, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "P A N D A ";
            // 
            // labelMainText
            // 
            this.labelMainText.ForeColor = System.Drawing.Color.White;
            this.labelMainText.Location = new System.Drawing.Point(211, 94);
            this.labelMainText.Name = "labelMainText";
            this.labelMainText.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelMainText.Size = new System.Drawing.Size(115, 54);
            this.labelMainText.TabIndex = 8;
            this.labelMainText.Text = "درحال بارگزاری...";
            this.labelMainText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 15000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Loading
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(540, 236);
            this.Controls.Add(this.panelMain);
            this.Font = new System.Drawing.Font("Vazir FD-WOL", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Loading";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBarBottom;
        private System.Windows.Forms.Label labelClose;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label labelProgressBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelMainText;
        private System.Windows.Forms.Timer timer;
    }
}