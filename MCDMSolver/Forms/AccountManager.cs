using MCDMSolver.UserControls;
using System;
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
    public partial class AccountManager : Form
    {
        public AccountManager()
        {
            InitializeComponent();
        }

        private void AccountManager_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 2; i++)
            {
                itemDescription Ides = new itemDescription();
                Ides.Dock = DockStyle.Top;
                //Ides.itemIcon = null;
                Ides.itemName = "عنوان";
                Ides.itemMiniDescription = "متن کوتاه";
                Ides.itemDescriptions = "متن بلند و توضیحات درمورد آیتم";
                Ides.itemPrice = "2,000,000";
                itemsPanel.Controls.Add(Ides);
            }
        }
    }
}
