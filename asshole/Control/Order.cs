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
            labelArticul.Text = "Артикул заказа: "+  articul;
                labelStatus.Text = "Статус заказа: " + status;
                labelAddress.Text = "Адрес пункта выдачи: "+ address;
                labelDateOrder.Text = "Дата заказа: " + dateOrder;
                labelDateDelivery.Text = "Дата доставки: "+ dateDelivery;
        }


        private void button1_Click(object sender, EventArgs e)//редактировать
        {
            Main main = this.FindForm() as Main;
            //main.
        }
    }
}
