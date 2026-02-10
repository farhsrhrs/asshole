using asshole.Properties;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace asshole.Control
{
    public partial class AddOrder : UserControl

    {
        public string articul { get; set; }
        public string status { get; set; }
        public string address { get; set; }
        public string dateOrder { get; set; }
        public string dateDelivery { get; set; }
        public bool isEditOrder { get; set; }
        public AddOrder(bool isEditOrder)
        {
            InitializeComponent();
            if (isEditOrder)
            {
                label10.Text = "Редактировать заказ";
                button3.Text = "Сохранить";
            }
            else
            {
                label10.Text = "Добавить заказ";
                button3.Text = "Добавить";
            }
        }
        public void AddOrders()//todo:
        {
            int orderID;
            using (NpgsqlConnection connection = new NpgsqlConnection(Resources.connectionDB))
            {
                connection.Open();  
                string query3 = $@"SELECT nextval(pg_get_serial_sequence('public.""order""', 'id'))";     //

                using (NpgsqlCommand command = new NpgsqlCommand(query3, connection))
                {

                    orderID = Convert.ToInt32(command.ExecuteScalar());

                }
                


                  //@code, code
                string query = $@"INSERT INTO public.""order""(
	 date_order, date_delivery, address, fio, status)
	VALUES (
            @date_order,
            @date_delivery,
            @address,
            @fio,
            @status);";     //

                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@date_order", dateTimePicker1.Value);
                    command.Parameters.AddWithValue("@date_delivery", dateTimePicker2.Value);
                    command.Parameters.AddWithValue("@address", comboBox2.SelectedIndex + 1);
                    command.Parameters.AddWithValue("@fio", comboBox1.SelectedIndex + 1);
                    command.Parameters.AddWithValue("@status", comboBox3.SelectedIndex + 1);
                    //orderID = Convert.ToInt32(command.ExecuteScalar());
                }
        
                string queryProductOrder = $@"INSERT INTO public.product_order(
	id_order, art, amount)
	VALUES ((SELECT id from ""order"" Where id = @id),
            @art,
            @amount
);";

                using (NpgsqlCommand command1 = new NpgsqlCommand(queryProductOrder, connection))
                {
                    foreach (var item in listBoxAdd.Items)
                    {
                        command1.Parameters.AddWithValue("@id", orderID);
                        command1.Parameters.AddWithValue("@art", item.ToString().Split(' ')[0]);
                        command1.Parameters.AddWithValue("@amount", Convert.ToInt32(item.ToString().Split(' ')[1]));
                        command1.ExecuteNonQuery();
                    }
                    connection.Close();
                }
            }
        }
        

        private void button2_Click(object sender, EventArgs e)//назад
        {
            Main main = this.FindForm() as Main;
            main.LoadProduct();
        }

        private void button3_Click(object sender, EventArgs e)//добавить
        {
            if (isEditOrder)
            {
                //Upda
            }
            else
            {
                AddOrders();

            }

        }

        private void button1_Click(object sender, EventArgs e)//добавить товар
        {
            if (comboBox4.Text != null & numericUpDownAddQuantity.Value > 0)
            {
                listBoxAdd.Items.Add(comboBox4.Text + " " + numericUpDownAddQuantity.Value.ToString());
            }
        }
    }
}
