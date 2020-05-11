namespace MCDMSolver.UserControls
{
    partial class itemDescription
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelDescriptions = new System.Windows.Forms.Label();
            this.pbIcon = new System.Windows.Forms.PictureBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelMiniDescription = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Controls.Add(this.labelDescriptions, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pbIcon, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelName, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelMiniDescription, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelPrice, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(883, 95);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Click += new System.EventHandler(this.itemChosen);
            // 
            // labelDescriptions
            // 
            this.labelDescriptions.AutoSize = true;
            this.labelDescriptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelDescriptions.Font = new System.Drawing.Font("Vazir FD-WOL", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescriptions.Location = new System.Drawing.Point(139, 7);
            this.labelDescriptions.Margin = new System.Windows.Forms.Padding(7);
            this.labelDescriptions.Name = "labelDescriptions";
            this.labelDescriptions.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tableLayoutPanel1.SetRowSpan(this.labelDescriptions, 2);
            this.labelDescriptions.Size = new System.Drawing.Size(471, 81);
            this.labelDescriptions.TabIndex = 4;
            this.labelDescriptions.Text = "توضیحات محصول";
            this.labelDescriptions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelDescriptions.Click += new System.EventHandler(this.itemChosen);
            // 
            // pbIcon
            // 
            this.pbIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbIcon.Location = new System.Drawing.Point(796, 3);
            this.pbIcon.Name = "pbIcon";
            this.tableLayoutPanel1.SetRowSpan(this.pbIcon, 2);
            this.pbIcon.Size = new System.Drawing.Size(84, 89);
            this.pbIcon.TabIndex = 0;
            this.pbIcon.TabStop = false;
            this.pbIcon.Click += new System.EventHandler(this.itemChosen);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelName.Font = new System.Drawing.Font("Vazir FD-WOL", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(624, 7);
            this.labelName.Margin = new System.Windows.Forms.Padding(7);
            this.labelName.Name = "labelName";
            this.labelName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelName.Size = new System.Drawing.Size(162, 33);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "نام محصول";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.labelName.Click += new System.EventHandler(this.itemChosen);
            // 
            // labelMiniDescription
            // 
            this.labelMiniDescription.AutoSize = true;
            this.labelMiniDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMiniDescription.Font = new System.Drawing.Font("Vazir FD-WOL", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMiniDescription.Location = new System.Drawing.Point(624, 54);
            this.labelMiniDescription.Margin = new System.Windows.Forms.Padding(7);
            this.labelMiniDescription.Name = "labelMiniDescription";
            this.labelMiniDescription.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelMiniDescription.Size = new System.Drawing.Size(162, 34);
            this.labelMiniDescription.TabIndex = 2;
            this.labelMiniDescription.Text = "توضیحات زیر نام";
            this.labelMiniDescription.Click += new System.EventHandler(this.itemChosen);
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelPrice.Font = new System.Drawing.Font("Vazir FD-WOL", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.Location = new System.Drawing.Point(3, 0);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tableLayoutPanel1.SetRowSpan(this.labelPrice, 2);
            this.labelPrice.Size = new System.Drawing.Size(126, 95);
            this.labelPrice.TabIndex = 5;
            this.labelPrice.Text = "2 میلیون تومان";
            this.labelPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelPrice.Click += new System.EventHandler(this.itemChosen);
            // 
            // itemDescription
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Vazir FD-WOL", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(10);
            this.Name = "itemDescription";
            this.Size = new System.Drawing.Size(883, 95);
            this.Load += new System.EventHandler(this.itemDescription_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pbIcon;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelMiniDescription;
        private System.Windows.Forms.Label labelDescriptions;
        private System.Windows.Forms.Label labelPrice;
    }
}
