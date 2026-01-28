using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace asshole
{
    public partial class Order : UserControl
    {
        public string articul { get; set; }
        public string status { get; set; }
        public string address {  get; set; }
        public string dateOrder { get; set; }
        public string dateDelivery { get; set; }

        public Order()
        {
            InitializeComponent();
        }
        public void SetOrder()
        {
            labelArticul.Text = articul;
                labelStatus.Text = status;
                labelAddress.Text = address;
                labelDateOrder.Text = dateOrder;
                labelDateDelivery.Text = dateDelivery;
        }

    }
}
