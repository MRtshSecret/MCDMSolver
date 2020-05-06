using System;
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

        [DllImport("user32.dll")]
        static extern bool HideCaret(IntPtr hWnd);

        private void itemPage_Load(object sender, EventArgs e)
        {
            labelName.Text = _itemName;
            labelMiniDescription.Text = _itemMiniDescription;
            labelDescription.Text = _itemDescription;
            HideCaret(labelDescription.Handle);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
