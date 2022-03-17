namespace RecipesCatalog.Forms
{
    partial class ProductsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductsForm));
            this.btnInsertProduct = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUpdateProduct = new System.Windows.Forms.Button();
            this.btnRemoveProduct = new System.Windows.Forms.Button();
            this.txtBoxProductName = new System.Windows.Forms.TextBox();
            this.txtBoxProductType = new System.Windows.Forms.TextBox();
            this.dataProducts = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblOutputProducts = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInsertProduct
            // 
            this.btnInsertProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInsertProduct.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertProduct.Location = new System.Drawing.Point(40, 374);
            this.btnInsertProduct.Name = "btnInsertProduct";
            this.btnInsertProduct.Size = new System.Drawing.Size(95, 40);
            this.btnInsertProduct.TabIndex = 0;
            this.btnInsertProduct.Text = "Insert";
            this.btnInsertProduct.UseVisualStyleBackColor = true;
            this.btnInsertProduct.Click += new System.EventHandler(this.btnInsertProduct_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Product Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 318);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Product Type";
            // 
            // btnUpdateProduct
            // 
            this.btnUpdateProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateProduct.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateProduct.Location = new System.Drawing.Point(168, 374);
            this.btnUpdateProduct.Name = "btnUpdateProduct";
            this.btnUpdateProduct.Size = new System.Drawing.Size(95, 40);
            this.btnUpdateProduct.TabIndex = 3;
            this.btnUpdateProduct.Text = "Update";
            this.btnUpdateProduct.UseVisualStyleBackColor = true;
            this.btnUpdateProduct.Click += new System.EventHandler(this.btnUpdateProduct_Click);
            // 
            // btnRemoveProduct
            // 
            this.btnRemoveProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveProduct.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveProduct.Location = new System.Drawing.Point(294, 374);
            this.btnRemoveProduct.Name = "btnRemoveProduct";
            this.btnRemoveProduct.Size = new System.Drawing.Size(95, 40);
            this.btnRemoveProduct.TabIndex = 4;
            this.btnRemoveProduct.Text = "Remove";
            this.btnRemoveProduct.UseVisualStyleBackColor = true;
            this.btnRemoveProduct.Click += new System.EventHandler(this.btnRemoveProduct_Click);
            // 
            // txtBoxProductName
            // 
            this.txtBoxProductName.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxProductName.Location = new System.Drawing.Point(263, 283);
            this.txtBoxProductName.Multiline = true;
            this.txtBoxProductName.Name = "txtBoxProductName";
            this.txtBoxProductName.Size = new System.Drawing.Size(126, 31);
            this.txtBoxProductName.TabIndex = 5;
            // 
            // txtBoxProductType
            // 
            this.txtBoxProductType.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxProductType.Location = new System.Drawing.Point(263, 330);
            this.txtBoxProductType.Multiline = true;
            this.txtBoxProductType.Name = "txtBoxProductType";
            this.txtBoxProductType.Size = new System.Drawing.Size(126, 29);
            this.txtBoxProductType.TabIndex = 6;
            // 
            // dataProducts
            // 
            this.dataProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataProducts.Location = new System.Drawing.Point(450, 72);
            this.dataProducts.Name = "dataProducts";
            this.dataProducts.Size = new System.Drawing.Size(322, 365);
            this.dataProducts.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(489, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(239, 31);
            this.label3.TabIndex = 8;
            this.label3.Text = "Available Products";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(239, 47);
            this.label4.TabIndex = 1;
            this.label4.Text = "Product Name: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(224, 47);
            this.label5.TabIndex = 2;
            this.label5.Text = "Product Type: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(469, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(292, 47);
            this.label6.TabIndex = 8;
            this.label6.Text = "Available Products: ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(89, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(257, 230);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // lblOutputProducts
            // 
            this.lblOutputProducts.AutoSize = true;
            this.lblOutputProducts.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutputProducts.Location = new System.Drawing.Point(35, 434);
            this.lblOutputProducts.Name = "lblOutputProducts";
            this.lblOutputProducts.Size = new System.Drawing.Size(0, 28);
            this.lblOutputProducts.TabIndex = 10;
            // 
            // ProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(820, 471);
            this.Controls.Add(this.lblOutputProducts);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataProducts);
            this.Controls.Add(this.txtBoxProductType);
            this.Controls.Add(this.txtBoxProductName);
            this.Controls.Add(this.btnRemoveProduct);
            this.Controls.Add(this.btnUpdateProduct);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInsertProduct);
            this.Name = "ProductsForm";
            this.Text = "ProductsForm";
            this.Load += new System.EventHandler(this.ProductsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInsertProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUpdateProduct;
        private System.Windows.Forms.Button btnRemoveProduct;
        private System.Windows.Forms.TextBox txtBoxProductName;
        private System.Windows.Forms.TextBox txtBoxProductType;
        private System.Windows.Forms.DataGridView dataProducts;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblOutputProducts;
    }
}