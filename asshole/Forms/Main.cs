using asshole.Control;
using asshole.Properties;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace asshole
{
    public partial class Main : Form
    {
        public Main(string Fio, string Role)
        {
            InitializeComponent();
            LoadProduct();
            if (Role == "Гость")
            {
                labelRole.Hide();
                labelfio.Hide();
                label1.Hide();
                button1.Hide();
                button2.Hide();
                textBox1.Hide();
                button3.Hide();
                button4.Hide();
            }
            labelRole.Text = "Роль: " + Role;
            labelfio.Text = "ФИО: " + Fio;


        }

        public string Role { get; private set; }
        public string Fio { get; private set; }
        public void LoadEditProduct(string ArticleTovar)//string ArticleTovar
        {
            flowLayoutPanel1.Controls.Clear();
            AddProductControl addProductControl = new AddProductControl(true);
            addProductControl.ART = ArticleTovar;
           
            addProductControl.setAddProduct();
            addProductControl.LoadAddProductData(ArticleTovar);//

            this.flowLayoutPanel1.Controls.Add(addProductControl);
        }

        public void LoadProduct()
        {

            flowLayoutPanel1.Controls.Clear(); // Очистка текущих элементов перед загрузкой новых
            using (NpgsqlConnection connection = new NpgsqlConnection(Resources.connectionDB))
            {
                connection.Open();
                string query = $@"SELECT category.category_name,product_name.product,description,""MFG"".""MFG"",""SUP"".sup_name, price, amount,""MS"", art,      discount,   photo
                FROM public.Product
                Join product_name on public.product_name.id = product.product_name_fk
                Join ""SUP"" on ""SUP"".id = product.""SUP""
                Join category on category.id = product.category
                Join ""MFG"" on public.""MFG"".id = product.""MFG""";

                //               string query = $@"SELECT id, art, product_name_fk, ""MS"", price, ""SUP"", ""MFG"", category, discount, amount, description, photo
                //FROM public.product;";
                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {

                        flowLayoutPanel1.SuspendLayout();//остоновить
                        while (reader.Read())
                        {
                            ProductControl productControl = new ProductControl();
                            productControl.Category = reader.GetString(0);
                            productControl.Product_name = reader.GetString(1);
                            productControl.Description = reader.GetString(2);
                            productControl.MFG = reader.GetString(3);
                            productControl.SUP = reader.GetString(4);
                            productControl.Price = reader.GetInt32(5);
                            productControl.Amount = reader.GetInt32(6);
                            productControl.MS = reader.GetString(7);
                            productControl.ART = reader.GetString(8);
                            productControl.Discount = reader.GetInt32(9);



                            productControl.SetLabel();//переданые переменные присваевает к label
                            flowLayoutPanel1.Controls.Add(productControl);
                        }
                        flowLayoutPanel1.ResumeLayout(false);//продолжить
                        flowLayoutPanel1.PerformLayout();
                    }


                }

               
                connection.Close();
            }
        }

        public void LoadOrder()
        {
            flowLayoutPanel1.Controls.Clear();
            using (NpgsqlConnection connection = new NpgsqlConnection(Resources.connectionDB))
            {
                connection.Open();
                string query = $@"SELECT  date_order, date_delivery, ""address"".address_name, ""User"".fio, code, ""status"".status_name ,""order"".id
	FROM public.""order""
	Join ""User"" on ""User"".id = ""order"".fio
	Join address on address.id = ""order"".address
	Join status on status.id = ""order"".status";
                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))

                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Order order = new Order();
                            order.dateOrder = reader.GetDateTime(0).ToString("d");
                            order.dateDelivery = reader.GetDateTime(1).ToString("d");
                            order.address = reader.GetString(2);
                            order.status = reader.GetString(5);
                            order.articul = reader.GetInt32(6).ToString();
                            order.SetOrder();
                            flowLayoutPanel1.Controls.Add(order);




                        }
                    }
                }
            }
        }

        public void LoadProductAdd()
        {
            flowLayoutPanel1.Controls.Clear();
            AddProductControl addProductControl = new AddProductControl(false);
            flowLayoutPanel1.Controls.Add(addProductControl);
        }
        public void LoadAddOrder()
        {
            flowLayoutPanel1.Controls.Clear();
            AddOrder addorder = new AddOrder(false);
            flowLayoutPanel1.Controls.Add(addorder);
        }
        private void button2_Click(object sender, EventArgs e)//заказы
        {
            LoadOrder();
        }

        private void button1_Click(object sender, EventArgs e)//товары
        {
            LoadProduct();
        }

        private void button3_Click(object sender, EventArgs e)//добавить товар
        {
            LoadProductAdd();
        }

        private void button4_Click(object sender, EventArgs e)//добавить заказ
        {
            LoadAddOrder();
        }
    }
}
