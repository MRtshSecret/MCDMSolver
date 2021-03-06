﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCDMSolver.Forms
{
    public partial class itemPage : Form
    {
        public string _itemName { get; set; }
        public string _itemMiniDescription { get; set; }
        public string _itemDescription { get; set; }

        public itemPage()
        {
            InitializeComponent();
        }

        private void itemPage_Load(object sender, EventArgs e)
        {
            labelName.Text = _itemName;
            labelMiniDescription.Text = _itemMiniDescription;
            labelDescription.Text = _itemDescription;
        }
        #region Move Window
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void panelToolbar_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
