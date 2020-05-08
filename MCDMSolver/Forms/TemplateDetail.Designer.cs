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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnNext = new System.Windows.Forms.PictureBox();
            this.btnPrevious = new System.Windows.Forms.PictureBox();
            this.templateImage = new System.Windows.Forms.PictureBox();
            this.textBoxDetails = new System.Windows.Forms.RichTextBox();
            this.btnAddAlgorythm = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrevious)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.templateImage)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.Controls.Add(this.btnNext, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnPrevious, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.templateImage, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxDetails, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnAddAlgorythm, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnClose, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(600, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnNext
            // 
            this.btnNext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.Location = new System.Drawing.Point(3, 183);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(69, 84);
            this.btnNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnNext.TabIndex = 0;
            this.btnNext.TabStop = false;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPrevious.Image = ((System.Drawing.Image)(resources.GetObject("btnPrevious.Image")));
            this.btnPrevious.Location = new System.Drawing.Point(528, 183);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(69, 84);
            this.btnPrevious.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnPrevious.TabIndex = 1;
            this.btnPrevious.TabStop = false;
            // 
            // templateImage
            // 
            this.templateImage.Image = ((System.Drawing.Image)(resources.GetObject("templateImage.Image")));
            this.templateImage.Location = new System.Drawing.Point(303, 93);
            this.templateImage.Name = "templateImage";
            this.tableLayoutPanel1.SetRowSpan(this.templateImage, 3);
            this.templateImage.Size = new System.Drawing.Size(219, 264);
            this.templateImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.templateImage.TabIndex = 2;
            this.templateImage.TabStop = false;
            // 
            // textBoxDetails
            // 
            this.textBoxDetails.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDetails.Location = new System.Drawing.Point(78, 93);
            this.textBoxDetails.Name = "textBoxDetails";
            this.textBoxDetails.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tableLayoutPanel1.SetRowSpan(this.textBoxDetails, 2);
            this.textBoxDetails.Size = new System.Drawing.Size(219, 174);
            this.textBoxDetails.TabIndex = 3;
            this.textBoxDetails.Text = "متن مورد نظر در اینجا قرار میگیره!";
            // 
            // btnAddAlgorythm
            // 
            this.btnAddAlgorythm.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnAddAlgorythm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddAlgorythm.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAddAlgorythm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAlgorythm.Location = new System.Drawing.Point(200, 272);
            this.btnAddAlgorythm.Margin = new System.Windows.Forms.Padding(125, 2, 10, 2);
            this.btnAddAlgorythm.Name = "btnAddAlgorythm";
            this.btnAddAlgorythm.Size = new System.Drawing.Size(90, 86);
            this.btnAddAlgorythm.TabIndex = 0;
            this.btnAddAlgorythm.Text = "انتخاب الگوریتم";
            this.btnAddAlgorythm.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Yu Gothic UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(580, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(17, 30);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click_1);
            // 
            // TemplateDetail
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("A Iranian Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TemplateDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TemplateDetail";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrevious)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.templateImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox btnNext;
        private System.Windows.Forms.PictureBox btnPrevious;
        private System.Windows.Forms.PictureBox templateImage;
        private System.Windows.Forms.RichTextBox textBoxDetails;
        private System.Windows.Forms.Button btnAddAlgorythm;
        private System.Windows.Forms.Button btnClose;
    }
}