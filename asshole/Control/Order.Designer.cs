namespace asshole
{
    partial class Order
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelArticul = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelDateOrder = new System.Windows.Forms.Label();
            this.labelDateDelivery = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Артикул заказа";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Статус заказа";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Адркс пункта выдачи";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Дата заказа";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Дата заказа";
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Location = new System.Drawing.Point(390, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 141);
            this.label6.TabIndex = 4;
            this.label6.Text = "Дата заказа";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelArticul
            // 
            this.labelArticul.AutoSize = true;
            this.labelArticul.Location = new System.Drawing.Point(21, 33);
            this.labelArticul.Name = "labelArticul";
            this.labelArticul.Size = new System.Drawing.Size(87, 13);
            this.labelArticul.TabIndex = 0;
            this.labelArticul.Text = "Артикул заказа";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(21, 56);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(80, 13);
            this.labelStatus.TabIndex = 1;
            this.labelStatus.Text = "Статус заказа";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(21, 79);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(115, 13);
            this.labelAddress.TabIndex = 2;
            this.labelAddress.Text = "Адрес пункта выдачи";
            // 
            // labelDateOrder
            // 
            this.labelDateOrder.AutoSize = true;
            this.labelDateOrder.Location = new System.Drawing.Point(21, 102);
            this.labelDateOrder.Name = "labelDateOrder";
            this.labelDateOrder.Size = new System.Drawing.Size(72, 13);
            this.labelDateOrder.TabIndex = 3;
            this.labelDateOrder.Text = "Дата заказа";
            // 
            // labelDateDelivery
            // 
            this.labelDateDelivery.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDateDelivery.Location = new System.Drawing.Point(386, 4);
            this.labelDateDelivery.Name = "labelDateDelivery";
            this.labelDateDelivery.Size = new System.Drawing.Size(153, 142);
            this.labelDateDelivery.TabIndex = 4;
            this.labelDateDelivery.Text = "Дата доставки";
            this.labelDateDelivery.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Order
            // 
            this.Controls.Add(this.labelDateDelivery);
            this.Controls.Add(this.labelDateOrder);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.labelArticul);
            this.Name = "Order";
            this.Size = new System.Drawing.Size(543, 150);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelArticul;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelDateOrder;
        private System.Windows.Forms.Label labelDateDelivery;
    }
}
