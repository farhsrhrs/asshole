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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace asshole.Control
{
    public partial class AddProductControl : UserControl
    {
        public Boolean isEditMode = false;
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
        public AddProductControl(Boolean isEditMode)
        {
            InitializeComponent();
                        this.isEditMode = isEditMode;
            if (isEditMode)
            {
                this.label10.Text = "Редактирование товара";
                button3.Text = "Сохранить изменения";
            }
            else
            {
                this.label10.Text = "Добавление товара";
                button3.Text = "Добавить товар";
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public void setAddProduct()
        {
            textBoxAmount.Text = Amount.ToString();
            textBoxDiscount.Text = Discount.ToString();
            textBoxPrice.Text = Price.ToString();
            textBoxART.Text = ART;
            comboBoxCategory.Text = Category;
            comboBoxMFG.Text = MFG;
            comboBoxName.Text = Product_name;
            comboBoxSUP.Text = SUP;
        }
        public void LoadAddProductData(string ArticleTovar)//добавить 
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(Resources.connectionDB))
            {
                connection.Open();
                string query = $@"SELECT category.category_name,product_name.product,description,""MFG"".""MFG"",""SUP"".sup_name, price, amount,""MS"", art,      discount,   photo
                FROM public.Product
                Join product_name on public.product_name.id = product.product_name_fk
                Join ""SUP"" on ""SUP"".id = product.""SUP""
                Join category on category.id = product.category
                Join ""MFG"" on public.""MFG"".id = product.""MFG""
                WHERE art = '{ArticleTovar}' ";
                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            textBoxAmount.Text = Amount.ToString();
                            textBoxDiscount.Text = Discount.ToString();
                            textBoxPrice.Text = Price.ToString();
                            textBoxART.Text = ART;
                            comboBoxCategory.Text = Category;
                            comboBoxMFG.Text = MFG;
                            comboBoxName.Text = Product_name;
                            comboBoxSUP.Text = SUP;

                            comboBoxCategory.Text = reader.GetString(0);
                            comboBoxName.Text = reader.GetString(1);
                            richTextBoxDescription.Text = reader.GetString(2);
                            comboBoxMFG.Text = reader.GetString(3);
                            comboBoxSUP.Text = reader.GetString(4);
                            textBoxPrice.Text = reader.GetInt32(5).ToString();
                            textBoxAmount.Text = reader.GetInt32(6).ToString();
                            //AddProductControl.MS = reader.GetString(7);
                            textBoxART.Text = reader.GetString(8);
                            textBoxDiscount.Text = reader.GetInt32(9).ToString();

                        }
                    }
                }
            }
        }



        public void UpdateProduct()
        {

            using(NpgsqlConnection connection = new NpgsqlConnection(Resources.connectionDB))
            {
                connection.Open();
                string query = $@"UPDATE public.product
	SET
art = @art,
product_name_fk = (Select id from product_name Where product = @product_name),
""MS"" = @MS,
price = @price, 
""SUP"" = (Select id from ""SUP"" Where sup_name = @SUP), 
""MFG"" = (Select id from ""MFG"" Where ""MFG"" = @MFG ),
category = (select id from category Where category_name = @category), 
discount = @discount,
amount = @amount,
description = @description, 
photo = @picture
	WHERE art = @art";

                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MS", "шт.");
                    command.Parameters.AddWithValue("@price", Convert.ToInt32(textBoxPrice.Text));
                    command.Parameters.AddWithValue("@art", textBoxART.Text);
                    command.Parameters.AddWithValue("@product_name", comboBoxName.Text);
                    command.Parameters.AddWithValue("@SUP", comboBoxSUP.Text);
                    command.Parameters.AddWithValue("@MFG", comboBoxMFG.Text);
                    command.Parameters.AddWithValue("@category", comboBoxCategory.Text);
                    command.Parameters.AddWithValue("@discount", Convert.ToInt32(textBoxDiscount.Text));
                    command.Parameters.AddWithValue("@amount", Convert.ToInt32(textBoxAmount.Text));
                    command.Parameters.AddWithValue("@description", richTextBoxDescription.Text);

                    command.Parameters.AddWithValue("@picture", "HI");

                    command.ExecuteNonQuery();




                }
            }
        }
        public void AddProduct()
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(Resources.connectionDB))
            {
                connection.Open(); //photo
                string query = $@"INSERT INTO public.product(
	 art, product_name_fk, ""MS"",  price, ""SUP"", ""MFG"", category, discount, amount, description )
	VALUES (
            @art,
            (select id FROM product_name WHERE product = @product_name),
            @MS,
            @price,
            (select id FROM ""SUP"" WHERE sup_name = @SUP),
            (select id FROM ""MFG"" WHERE ""MFG"" = @MFG),
            (select id FROM category WHERE category_name = @category),
            @discount,
            @amount,
            @description
            );";//@photo
                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MS", "шт.");
                    command.Parameters.AddWithValue("@price", Convert.ToInt32(textBoxPrice.Text));
                    command.Parameters.AddWithValue("@art", textBoxART.Text);
                    command.Parameters.AddWithValue("@product_name", comboBoxName.Text);
                    command.Parameters.AddWithValue("@SUP", comboBoxSUP.Text);
                    command.Parameters.AddWithValue("@MFG", comboBoxMFG.Text);
                    command.Parameters.AddWithValue("@category", comboBoxCategory.Text);
                    command.Parameters.AddWithValue("@discount", Convert.ToInt32(textBoxDiscount.Text));
                    command.Parameters.AddWithValue("@amount", Convert.ToInt32(textBoxAmount.Text));
                    command.Parameters.AddWithValue("@description", richTextBoxDescription.Text);
                    //command.Parameters.AddWithValue("@photo", textBoxDiscount.Text);
                    command.ExecuteNonQuery();




                }
            connection.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)//добавить
        {
            if (isEditMode)
            {
                UpdateProduct();
                MessageBox.Show("Товар успешно сохранен!", "Информация", MessageBoxButtons.OK);
                Main main = this.FindForm() as Main;
                main.LoadProduct();
            }
            else
            {
                AddProduct();
                MessageBox.Show("Товар успешно добавлен!", "Информация", MessageBoxButtons.OK);
                Main main = this.FindForm() as Main;
                main.LoadProduct();

            }
            
        }

        private void button2_Click(object sender, EventArgs e)//назад
        {
            Main main = this.FindForm() as Main;
            main.LoadProduct();
        }
    }

}

