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
    public partial class btnProduct : UserControl
    {
        public string ItemID { get; set; }
        public string ItemCategory
        {
            get { return lblCattegory.Text; }
            set { lblCattegory.Text = value; }
        }
        public string ItemName
        {
            get { return lblProduceName.Text; }
            set { lblProduceName.Text = value; }
        }
        public string ItemPrice
        {
            get { return lblPrice.Text; }
            set { lblPrice.Text = value; }
        }
        public btnProduct()
        {
            InitializeComponent();
        }

        private void lable(object sender, EventArgs e)
        {
            this.OnClick(e);
        }
    }
}
