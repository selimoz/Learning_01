namespace EntityFramworkDemo2
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txb_ProductName = new System.Windows.Forms.TextBox();
            this.txb_ProductDesc = new System.Windows.Forms.TextBox();
            this.txb_ProductPrice = new System.Windows.Forms.TextBox();
            this.txb_ProductAmount = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dgv_Product = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Product)).BeginInit();
            this.SuspendLayout();
            // 
            // txb_ProductName
            // 
            this.txb_ProductName.Location = new System.Drawing.Point(98, 57);
            this.txb_ProductName.Name = "txb_ProductName";
            this.txb_ProductName.Size = new System.Drawing.Size(100, 20);
            this.txb_ProductName.TabIndex = 0;
            // 
            // txb_ProductDesc
            // 
            this.txb_ProductDesc.Location = new System.Drawing.Point(98, 97);
            this.txb_ProductDesc.Name = "txb_ProductDesc";
            this.txb_ProductDesc.Size = new System.Drawing.Size(100, 20);
            this.txb_ProductDesc.TabIndex = 1;
            // 
            // txb_ProductPrice
            // 
            this.txb_ProductPrice.Location = new System.Drawing.Point(98, 138);
            this.txb_ProductPrice.Name = "txb_ProductPrice";
            this.txb_ProductPrice.Size = new System.Drawing.Size(100, 20);
            this.txb_ProductPrice.TabIndex = 2;
            // 
            // txb_ProductAmount
            // 
            this.txb_ProductAmount.Location = new System.Drawing.Point(98, 180);
            this.txb_ProductAmount.Name = "txb_ProductAmount";
            this.txb_ProductAmount.Size = new System.Drawing.Size(100, 20);
            this.txb_ProductAmount.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(123, 222);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dgv_Product
            // 
            this.dgv_Product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Product.Location = new System.Drawing.Point(35, 284);
            this.dgv_Product.Name = "dgv_Product";
            this.dgv_Product.Size = new System.Drawing.Size(820, 245);
            this.dgv_Product.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ürün Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Açıklama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ücret";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Adet";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 555);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_Product);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txb_ProductAmount);
            this.Controls.Add(this.txb_ProductPrice);
            this.Controls.Add(this.txb_ProductDesc);
            this.Controls.Add(this.txb_ProductName);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Product)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb_ProductName;
        private System.Windows.Forms.TextBox txb_ProductDesc;
        private System.Windows.Forms.TextBox txb_ProductPrice;
        private System.Windows.Forms.TextBox txb_ProductAmount;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgv_Product;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

