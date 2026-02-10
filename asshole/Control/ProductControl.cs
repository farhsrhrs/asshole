using asshole.Properties;
using Npgsql;
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

    public partial class ProductControl : UserControl
    {
        public string ART { get; set; }
        public string Category { get; set; } //Категория товара:
        public string Product_name { get; set; }//Наименование товара:
        public string Description { get; set; }//Описание товара:
        public string MFG { get; set; }//Производитель:
        public string SUP { get; set; }//Постовщик:
        public int Amount { get; set; }//Количество на складе:
        public int Price { get; set; }//Цена:
        public string MS { get; set; }//Единица измерения:
        public int Discount { get; set; }
        public string Photo { get; set; }


        public ProductControl()
        {
            InitializeComponent();
        }
        //public void DiscountCount()
        //{   
        //    if (Price > )
        //    {

        //    }
        //    labelDiscount.Text = ;
        //}
        public void SetLabel()
        {
            LabelCategory.Text = "Категория товара: " + Category; //если делать назвать label как Category он не будет работать ссылки ломаютсы
            LabelProduct_name.Text = "Наименование товара: "+ Product_name;
            LabelDescription.Text = "Описание товара: " + Description;
            LabelMFG.Text = "Производитель: " + MFG;

            LabelSUP.Text = "Постовщик: " + SUP;

            LabelPrice.Text =  Price.ToString() + " руб.";
            //if 






            LabelMS.Text = "Единица измерения: " + MS;
            LabelAmount.Text = "Количество на складе: "+ Amount;
            if(Amount == 0)//0 на складе цвет голубой
            {
                LabelAmount.ForeColor = Color.Aqua;

            }

            labelDiscount.Text = "Скидка: "+ Discount + " %";


            if (Discount > 15)//цвет скидки
            {
                labelDiscount.BackColor = ColorTranslator.FromHtml("#2E8B57");
            }
            if(Discount == 0)
            {
                labelPriceWithDiscount.Visible = false;
            }
            else
            {
                labelPriceWithDiscount.Visible = true;
                LabelPrice.Font = new Font(LabelPrice.Font, FontStyle.Strikeout);
                LabelPrice.ForeColor = Color.Red;

                labelPriceWithDiscount.Text = ((100 - Discount) / 100f * Price).ToString("F2") + " руб.";
            }



        }

        private void button1_Click(object sender, EventArgs e)//редактирование
        {
            Main mainform = this.FindForm() as Main;
            mainform.LoadEditProduct(ART);
        }

        private void button2_Click(object sender, EventArgs e)//удалить
        {
            using(NpgsqlConnection connection = new NpgsqlConnection(Resources.connectionDB))
            {
                connection.Open();
                string queryCheckOrders = $@"SELECT COUNT(*) FROM product_order WHERE art = '{ART}'; ";
                using (NpgsqlCommand commandCheck = new NpgsqlCommand(queryCheckOrders, connection))
                {
                    int orderCount = Convert.ToInt32(commandCheck.ExecuteScalar());//надо запомнить

                    if (orderCount > 0)
                    {
                        MessageBox.Show("Невозможно удалить товар, так как он связан с существующими заказами.", "Ошибка удаления", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        if (MessageBox.Show("Вы уверены, что хотите удалить этот товар?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            string query = $@"DELETE FROM product WHERE art = '{ART}'; ";
                            using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                            {
                                command.ExecuteNonQuery();
                                {
                                    connection.Close();
                                }
                                this.Parent.Controls.Remove(this);//TODO:?
                                MessageBox.Show("Товар успешно удален из базы данных.", "Удаление товара", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }
                        } // /надо запомнить
                    }
                }
            }

        }
    }
}
