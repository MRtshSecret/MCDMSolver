﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Animations;
using MaterialSkin.Controls;

namespace MCDMSolver.Forms
{
    public partial class newTemplateSuggestion : Form
    {
        public newTemplateSuggestion()
        {
            InitializeComponent();
        }

        private void NewTemplateSuggestion_Load(object sender, EventArgs e)
        {
            for(int i = 0; i < 2; i++)
            {
                flowLayoutPanel1.Controls.Add(new UserControls.Templates());
            }
        }
    }
}
