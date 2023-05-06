using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface.CostomerControl
{
    public partial class CartItem : UserControl
    {
        public string ItemID { get; set; }
        public string ItemPerUnitPrice
        {
            get { return lblPerPrice.Text; }
            set { lblPerPrice.Text = value; }
        }
        public string ItemName
        {
            get { return lblItemName.Text; }
            set { lblItemName.Text = value; }
        }
        public string ItemPrice
        {
            get { return lblPrice.Text; }
            set { lblPrice.Text = value; }
        }
        public string ItemQuantity
        {
            get { return btnQuantity.Text; }
            set { btnQuantity.Text = value; }
        }
        public CartItem()
        {
            InitializeComponent();
        }

        private void guna2CustomGradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
