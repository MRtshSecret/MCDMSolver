namespace MCDMSolver.Forms
{
    partial class TemplateDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TemplateDetail));
            this.panelMain = new System.Windows.Forms.Panel();
            this.btnStartProject = new System.Windows.Forms.Button();
            this.labelDetails = new System.Windows.Forms.Label();
            this.picBoxTemplateDetail = new System.Windows.Forms.PictureBox();
            this.picboxNext = new System.Windows.Forms.PictureBox();
            this.picboxPrevious = new System.Windows.Forms.PictureBox();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTemplateDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxPrevious)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMain.Controls.Add(this.btnStartProject);
            this.panelMain.Controls.Add(this.labelDetails);
            this.panelMain.Controls.Add(this.picBoxTemplateDetail);
            this.panelMain.Controls.Add(this.picboxNext);
            this.panelMain.Controls.Add(this.picboxPrevious);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(600, 450);
            this.panelMain.TabIndex = 0;
            // 
            // btnStartProject
            // 
            this.btnStartProject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStartProject.Location = new System.Drawing.Point(244, 301);
            this.btnStartProject.Name = "btnStartProject";
            this.btnStartProject.Size = new System.Drawing.Size(78, 24);
            this.btnStartProject.TabIndex = 4;
            this.btnStartProject.Text = "ایجاد";
            this.btnStartProject.UseVisualStyleBackColor = true;
            // 
            // labelDetails
            // 
            this.labelDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDetails.Location = new System.Drawing.Point(106, 108);
            this.labelDetails.Name = "labelDetails";
            this.labelDetails.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.labelDetails.Size = new System.Drawing.Size(216, 175);
            this.labelDetails.TabIndex = 3;
            this.labelDetails.Text = "متن مورد نظر";
            this.labelDetails.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // picBoxTemplateDetail
            // 
            this.picBoxTemplateDetail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picBoxTemplateDetail.Location = new System.Drawing.Point(328, 89);
            this.picBoxTemplateDetail.Name = "picBoxTemplateDetail";
            this.picBoxTemplateDetail.Size = new System.Drawing.Size(163, 236);
            this.picBoxTemplateDetail.TabIndex = 2;
            this.picBoxTemplateDetail.TabStop = false;
            // 
            // picboxNext
            // 
            this.picboxNext.Image = ((System.Drawing.Image)(resources.GetObject("picboxNext.Image")));
            this.picboxNext.Location = new System.Drawing.Point(12, 181);
            this.picboxNext.Name = "picboxNext";
            this.picboxNext.Size = new System.Drawing.Size(54, 60);
            this.picboxNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxNext.TabIndex = 1;
            this.picboxNext.TabStop = false;
            // 
            // picboxPrevious
            // 
            this.picboxPrevious.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picboxPrevious.Image = ((System.Drawing.Image)(resources.GetObject("picboxPrevious.Image")));
            this.picboxPrevious.Location = new System.Drawing.Point(532, 181);
            this.picboxPrevious.Name = "picboxPrevious";
            this.picboxPrevious.Size = new System.Drawing.Size(54, 60);
            this.picboxPrevious.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxPrevious.TabIndex = 0;
            this.picboxPrevious.TabStop = false;
            // 
            // TemplateDetail
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.panelMain);
            this.Font = new System.Drawing.Font("Vazir FD-WOL", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TemplateDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TemplateDetail";
            this.panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTemplateDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxPrevious)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.PictureBox picboxPrevious;
        private System.Windows.Forms.PictureBox picboxNext;
        private System.Windows.Forms.PictureBox picBoxTemplateDetail;
        private System.Windows.Forms.Label labelDetails;
        private System.Windows.Forms.Button btnStartProject;
    }
}