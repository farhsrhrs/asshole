namespace asshole
{
    partial class ProductControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LabelCategory = new System.Windows.Forms.Label();
            this.LabelDescription = new System.Windows.Forms.Label();
            this.LabelMFG = new System.Windows.Forms.Label();
            this.LabelPrice = new System.Windows.Forms.Label();
            this.LabelMS = new System.Windows.Forms.Label();
            this.LabelAmount = new System.Windows.Forms.Label();
            this.labelDiscount = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.LabelSUP = new System.Windows.Forms.Label();
            this.LabelProduct_name = new System.Windows.Forms.Label();
            this.LabelPriceName = new System.Windows.Forms.Label();
            this.labelPriceWithDiscount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 165);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // LabelCategory
            // 
            this.LabelCategory.AutoSize = true;
            this.LabelCategory.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCategory.Location = new System.Drawing.Point(183, 7);
            this.LabelCategory.Name = "LabelCategory";
            this.LabelCategory.Size = new System.Drawing.Size(156, 21);
            this.LabelCategory.TabIndex = 1;
            this.LabelCategory.Text = "Категория товара:";
            // 
            // LabelDescription
            // 
            this.LabelDescription.AutoSize = true;
            this.LabelDescription.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDescription.Location = new System.Drawing.Point(183, 31);
            this.LabelDescription.Name = "LabelDescription";
            this.LabelDescription.Size = new System.Drawing.Size(151, 21);
            this.LabelDescription.TabIndex = 2;
            this.LabelDescription.Text = "Описание товара:";
            // 
            // LabelMFG
            // 
            this.LabelMFG.AutoSize = true;
            this.LabelMFG.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMFG.Location = new System.Drawing.Point(183, 56);
            this.LabelMFG.Name = "LabelMFG";
            this.LabelMFG.Size = new System.Drawing.Size(137, 21);
            this.LabelMFG.TabIndex = 3;
            this.LabelMFG.Text = "Производитель:";
            // 
            // LabelPrice
            // 
            this.LabelPrice.AutoSize = true;
            this.LabelPrice.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPrice.Location = new System.Drawing.Point(242, 99);
            this.LabelPrice.Name = "LabelPrice";
            this.LabelPrice.Size = new System.Drawing.Size(53, 21);
            this.LabelPrice.TabIndex = 4;
            this.LabelPrice.Text = "Цена:";
            // 
            // LabelMS
            // 
            this.LabelMS.AutoSize = true;
            this.LabelMS.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMS.Location = new System.Drawing.Point(183, 120);
            this.LabelMS.Name = "LabelMS";
            this.LabelMS.Size = new System.Drawing.Size(173, 21);
            this.LabelMS.TabIndex = 5;
            this.LabelMS.Text = "Единица измерения:";
            // 
            // LabelAmount
            // 
            this.LabelAmount.AutoSize = true;
            this.LabelAmount.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAmount.Location = new System.Drawing.Point(183, 141);
            this.LabelAmount.Name = "LabelAmount";
            this.LabelAmount.Size = new System.Drawing.Size(190, 21);
            this.LabelAmount.TabIndex = 6;
            this.LabelAmount.Text = "Количество на складе:";
            // 
            // labelDiscount
            // 
            this.labelDiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDiscount.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDiscount.Location = new System.Drawing.Point(874, 6);
            this.labelDiscount.Name = "labelDiscount";
            this.labelDiscount.Size = new System.Drawing.Size(165, 164);
            this.labelDiscount.TabIndex = 7;
            this.labelDiscount.Text = "Скидка:";
            this.labelDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(755, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 29);
            this.button1.TabIndex = 8;
            this.button1.Text = "Редактировать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(755, 137);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 29);
            this.button2.TabIndex = 9;
            this.button2.Text = "Удалить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // LabelSUP
            // 
            this.LabelSUP.AutoSize = true;
            this.LabelSUP.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSUP.Location = new System.Drawing.Point(183, 77);
            this.LabelSUP.Name = "LabelSUP";
            this.LabelSUP.Size = new System.Drawing.Size(106, 21);
            this.LabelSUP.TabIndex = 10;
            this.LabelSUP.Text = "Постовщик:";
            // 
            // LabelProduct_name
            // 
            this.LabelProduct_name.AutoSize = true;
            this.LabelProduct_name.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelProduct_name.Location = new System.Drawing.Point(506, 7);
            this.LabelProduct_name.Name = "LabelProduct_name";
            this.LabelProduct_name.Size = new System.Drawing.Size(188, 21);
            this.LabelProduct_name.TabIndex = 11;
            this.LabelProduct_name.Text = "Наименование товара:";
            // 
            // LabelPriceName
            // 
            this.LabelPriceName.AutoSize = true;
            this.LabelPriceName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPriceName.Location = new System.Drawing.Point(183, 99);
            this.LabelPriceName.Name = "LabelPriceName";
            this.LabelPriceName.Size = new System.Drawing.Size(53, 21);
            this.LabelPriceName.TabIndex = 12;
            this.LabelPriceName.Text = "Цена:";
            // 
            // labelPriceWithDiscount
            // 
            this.labelPriceWithDiscount.AutoSize = true;
            this.labelPriceWithDiscount.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPriceWithDiscount.Location = new System.Drawing.Point(389, 99);
            this.labelPriceWithDiscount.Name = "labelPriceWithDiscount";
            this.labelPriceWithDiscount.Size = new System.Drawing.Size(148, 21);
            this.labelPriceWithDiscount.TabIndex = 13;
            this.labelPriceWithDiscount.Text = "Цена со скидкой:";
            // 
            // ProductControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.labelPriceWithDiscount);
            this.Controls.Add(this.LabelPriceName);
            this.Controls.Add(this.LabelProduct_name);
            this.Controls.Add(this.LabelSUP);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelDiscount);
            this.Controls.Add(this.LabelAmount);
            this.Controls.Add(this.LabelMS);
            this.Controls.Add(this.LabelPrice);
            this.Controls.Add(this.LabelMFG);
            this.Controls.Add(this.LabelDescription);
            this.Controls.Add(this.LabelCategory);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ProductControl";
            this.Size = new System.Drawing.Size(1042, 173);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LabelCategory;
        private System.Windows.Forms.Label LabelDescription;
        private System.Windows.Forms.Label LabelMFG;
        private System.Windows.Forms.Label LabelPrice;
        private System.Windows.Forms.Label LabelMS;
        private System.Windows.Forms.Label LabelAmount;
        private System.Windows.Forms.Label labelDiscount;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label LabelSUP;
        private System.Windows.Forms.Label LabelProduct_name;
        private System.Windows.Forms.Label LabelPriceName;
        private System.Windows.Forms.Label labelPriceWithDiscount;
    }
}
