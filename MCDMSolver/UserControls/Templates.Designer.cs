namespace MCDMSolver.UserControls
{
    partial class Templates
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelDetails = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label25 = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.labelName);
            this.panel1.Controls.Add(this.label25);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.labelDetails);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(335, 139);
            this.panel1.TabIndex = 0;
            this.panel1.Click += new System.EventHandler(this.openDetails);
            // 
            // labelDetails
            // 
            this.labelDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelDetails.Font = new System.Drawing.Font("Vazir FD-WOL", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelDetails.Location = new System.Drawing.Point(5, 42);
            this.labelDetails.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.labelDetails.Name = "labelDetails";
            this.labelDetails.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelDetails.Size = new System.Drawing.Size(217, 94);
            this.labelDetails.TabIndex = 2;
            this.labelDetails.Text = "متن توضیحات";
            this.labelDetails.Click += new System.EventHandler(this.openDetails);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(230, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 131);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.openDetails);
            // 
            // label25
            // 
            this.label25.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label25.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label25.Location = new System.Drawing.Point(155, 10);
            this.label25.Name = "label25";
            this.label25.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label25.Size = new System.Drawing.Size(63, 29);
            this.label25.TabIndex = 4;
            this.label25.Text = "نام الگوریتم:";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label25.Click += new System.EventHandler(this.openDetails);
            // 
            // labelName
            // 
            this.labelName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelName.Location = new System.Drawing.Point(11, 10);
            this.labelName.Name = "labelName";
            this.labelName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelName.Size = new System.Drawing.Size(138, 29);
            this.labelName.TabIndex = 5;
            this.labelName.Text = "Test";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelName.Click += new System.EventHandler(this.openDetails);
            // 
            // Templates
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Vazir FD-WOL", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Templates";
            this.Size = new System.Drawing.Size(335, 139);
            this.Click += new System.EventHandler(this.openDetails);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelDetails;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label labelName;
    }
}
