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
            this.btnCreate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lablClose = new System.Windows.Forms.Label();
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
            this.panelMain.BackColor = System.Drawing.SystemColors.Control;
            this.panelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMain.Controls.Add(this.btnCreate);
            this.panelMain.Controls.Add(this.label3);
            this.panelMain.Controls.Add(this.linkLabel1);
            this.panelMain.Controls.Add(this.label2);
            this.panelMain.Controls.Add(this.label1);
            this.panelMain.Controls.Add(this.lablClose);
            this.panelMain.Controls.Add(this.picBoxTemplateDetail);
            this.panelMain.Controls.Add(this.picboxNext);
            this.panelMain.Controls.Add(this.picboxPrevious);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(597, 293);
            this.panelMain.TabIndex = 0;
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.Silver;
            this.btnCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreate.Image = ((System.Drawing.Image)(resources.GetObject("btnCreate.Image")));
            this.btnCreate.Location = new System.Drawing.Point(246, 175);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(69, 58);
            this.btnCreate.TabIndex = 10;
            this.btnCreate.Text = "انتخاب";
            this.btnCreate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCreate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(102, 101);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(216, 71);
            this.label3.TabIndex = 9;
            this.label3.Text = "متن کوتاه سه خطی که جزئیات یک الگوریتم را توضیح میدهد";
            // 
            // linkLabel1
            // 
            this.linkLabel1.Location = new System.Drawing.Point(61, 79);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.linkLabel1.Size = new System.Drawing.Size(189, 22);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "توسعه سیستم هوشمند پاندا";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(247, 79);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(82, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "تهیه شده توسط:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Vazir FD-WOL", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(174, 61);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(141, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "عنوان";
            // 
            // lablClose
            // 
            this.lablClose.AutoSize = true;
            this.lablClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lablClose.Location = new System.Drawing.Point(568, 8);
            this.lablClose.Name = "lablClose";
            this.lablClose.Size = new System.Drawing.Size(16, 18);
            this.lablClose.TabIndex = 5;
            this.lablClose.Text = "X";
            this.lablClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lablClose.Click += new System.EventHandler(this.lablClose_Click);
            // 
            // picBoxTemplateDetail
            // 
            this.picBoxTemplateDetail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picBoxTemplateDetail.Location = new System.Drawing.Point(335, 61);
            this.picBoxTemplateDetail.Name = "picBoxTemplateDetail";
            this.picBoxTemplateDetail.Size = new System.Drawing.Size(163, 172);
            this.picBoxTemplateDetail.TabIndex = 2;
            this.picBoxTemplateDetail.TabStop = false;
            // 
            // picboxNext
            // 
            this.picboxNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picboxNext.Image = ((System.Drawing.Image)(resources.GetObject("picboxNext.Image")));
            this.picboxNext.Location = new System.Drawing.Point(11, 123);
            this.picboxNext.Name = "picboxNext";
            this.picboxNext.Size = new System.Drawing.Size(40, 40);
            this.picboxNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxNext.TabIndex = 1;
            this.picboxNext.TabStop = false;
            // 
            // picboxPrevious
            // 
            this.picboxPrevious.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picboxPrevious.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picboxPrevious.Image = ((System.Drawing.Image)(resources.GetObject("picboxPrevious.Image")));
            this.picboxPrevious.Location = new System.Drawing.Point(544, 123);
            this.picboxPrevious.Name = "picboxPrevious";
            this.picboxPrevious.Size = new System.Drawing.Size(40, 40);
            this.picboxPrevious.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxPrevious.TabIndex = 0;
            this.picboxPrevious.TabStop = false;
            // 
            // TemplateDetail
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(597, 293);
            this.Controls.Add(this.panelMain);
            this.Font = new System.Drawing.Font("Vazir FD-WOL", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TemplateDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TemplateDetail";
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
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
        private System.Windows.Forms.Label lablClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCreate;
    }
}