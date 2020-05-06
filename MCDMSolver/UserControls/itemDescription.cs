using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MCDMSolver.Forms;

namespace MCDMSolver.UserControls
{
    public partial class itemDescription : UserControl
    {
        public string itemIcon { get; set; }
        public string itemName { get; set; }
        public string itemMiniDescription { get; set; }
        public string itemDescriptions { get; set; }
        public string itemPrice { get; set; }
        public itemDescription()
        {
            InitializeComponent();
        }

        private void itemDescription_Load(object sender, EventArgs e)
        {
            //pbIcon.Image = Image.FromFile(itemIcon);
            labelName.Text = itemName;
            labelMiniDescription.Text = itemMiniDescription;
            labelDescriptions.Text = itemDescriptions;
            labelPrice.Text = itemPrice + "تومان";
        }

        private void itemChosen(object sender, EventArgs e)
        {
            Forms.itemPage iPage = new Forms.itemPage();
            iPage._itemName = itemName;
            iPage._itemMiniDescription = itemMiniDescription;
            iPage._itemDescription = itemDescriptions;
            iPage.ShowDialog();
        }
    }
}
