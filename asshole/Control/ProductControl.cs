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
        public void SetLabel()
        {
            LabelCategory.Text = "Категория товара: " + Category; //если делать назвать label как Category он не будет работать ссылки ломаютсы
            LabelProduct_name.Text = "Наименование товара: "+ Product_name;
            LabelDescription.Text = "Описание товара: " + Description;
            LabelMFG.Text = "Производитель: " + MFG;

            LabelSUP.Text = "Постовщик: " + SUP;

            LabelPrice.Text = "Цена: " + Price.ToString();

            LabelMS.Text = "Единица измерения: " + MS;
            LabelAmount.Text = "Количество на складе: "+ Amount;




        }




    }
}
