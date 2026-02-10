using asshole.Properties;
using Npgsql;
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
        public int id { get; set; }
        public string status { get; set; }
        public string address { get; set; }
        public string dateOrder { get; set; }
        public string dateDelivery { get; set; }






        public Order()
        {
            InitializeComponent();
        }
        public void SetOrder()
        {
            labelArticul.Text = "Артикул заказа: " + id;
            labelStatus.Text = "Статус заказа: " + status;
            labelAddress.Text = "Адрес пункта выдачи: " + address;
            labelDateOrder.Text = "Дата заказа: " + dateOrder;
            labelDateDelivery.Text = "Дата доставки: " + dateDelivery;
        }


        private void button1_Click(object sender, EventArgs e)//редактировать
        {
            Main mainform = this.FindForm() as Main;

            mainform.LoadEditAddOrder(id);
        }

        private void button2_Click(object sender, EventArgs e)//удаление
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(Resources.connectionDB))
            {
                connection.Open();
                string query = $@"DELETE FROM ""order"" WHERE id = '{id}'; ";
                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                    {
                        connection.Close();
                    }
                    this.Parent.Controls.Remove(this);//TODO:?
                    MessageBox.Show("Заказ успешно удален из базы данных.", "Удаление товара", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            } // /надо запомнить
        }
    }
}



