using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCDMSolver.UserControls
{
    public partial class CustomButton : UserControl
    {

        public string btnText { get; set; }
        public Image btnImage{ get; set; }

        public CustomButton()
        {
            InitializeComponent();
        }

        private void CustomButton_Load(object sender, EventArgs e)
        {
            pictureBox.Image = btnImage;
            textUnderPicture.Text = btnText;
        }
    }
}
