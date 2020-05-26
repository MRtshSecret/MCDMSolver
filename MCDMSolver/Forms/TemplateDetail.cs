﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCDMSolver.Forms
{
    public partial class TemplateDetail : Form
    {
        public TemplateDetail()
        {
            InitializeComponent();
        }

        private void lablClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreate_Load(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Classes.MainFormCaller.mainFormCallerVortex.openChildForm(new Forms.MainAlgorithm());
            this.Close();
        }
    }
}
