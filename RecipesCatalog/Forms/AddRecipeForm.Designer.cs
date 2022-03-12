namespace RecipesCatalog.Forms
{
    partial class AddRecipeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddRecipeForm));
            this.label1 = new System.Windows.Forms.Label();
            this.cboxRecipeType = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRecipeName = new System.Windows.Forms.TextBox();
            this.lblSelectProduct = new System.Windows.Forms.Label();
            this.cboxRecipeProducts = new System.Windows.Forms.ComboBox();
            this.btnAddProductRecipe = new System.Windows.Forms.Button();
            this.btnAddRecipe = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProductAmount = new System.Windows.Forms.TextBox();
            this.lblOutputAddedRecipe = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(433, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Type: ";
            // 
            // cboxRecipeType
            // 
            this.cboxRecipeType.BackColor = System.Drawing.Color.White;
            this.cboxRecipeType.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxRecipeType.FormattingEnabled = true;
            this.cboxRecipeType.Items.AddRange(new object[] {
            "Salad",
            "Appetizer",
            "Main Course",
            "Desert"});
            this.cboxRecipeType.Location = new System.Drawing.Point(595, 81);
            this.cboxRecipeType.Name = "cboxRecipeType";
            this.cboxRecipeType.Size = new System.Drawing.Size(121, 31);
            this.cboxRecipeType.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(72, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(264, 262);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(433, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Recipe Name: ";
            // 
            // txtRecipeName
            // 
            this.txtRecipeName.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecipeName.Location = new System.Drawing.Point(595, 129);
            this.txtRecipeName.Multiline = true;
            this.txtRecipeName.Name = "txtRecipeName";
            this.txtRecipeName.Size = new System.Drawing.Size(121, 31);
            this.txtRecipeName.TabIndex = 4;
            // 
            // lblSelectProduct
            // 
            this.lblSelectProduct.AutoSize = true;
            this.lblSelectProduct.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectProduct.Location = new System.Drawing.Point(433, 177);
            this.lblSelectProduct.Name = "lblSelectProduct";
            this.lblSelectProduct.Size = new System.Drawing.Size(142, 28);
            this.lblSelectProduct.TabIndex = 5;
            this.lblSelectProduct.Text = "Select Products:";
            // 
            // cboxRecipeProducts
            // 
            this.cboxRecipeProducts.BackColor = System.Drawing.Color.White;
            this.cboxRecipeProducts.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxRecipeProducts.FormattingEnabled = true;
            this.cboxRecipeProducts.Location = new System.Drawing.Point(595, 177);
            this.cboxRecipeProducts.Name = "cboxRecipeProducts";
            this.cboxRecipeProducts.Size = new System.Drawing.Size(121, 31);
            this.cboxRecipeProducts.TabIndex = 6;
            // 
            // btnAddProductRecipe
            // 
            this.btnAddProductRecipe.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddProductRecipe.Location = new System.Drawing.Point(438, 276);
            this.btnAddProductRecipe.Name = "btnAddProductRecipe";
            this.btnAddProductRecipe.Size = new System.Drawing.Size(129, 37);
            this.btnAddProductRecipe.TabIndex = 7;
            this.btnAddProductRecipe.Text = "Add Product";
            this.btnAddProductRecipe.UseVisualStyleBackColor = true;
            // 
            // btnAddRecipe
            // 
            this.btnAddRecipe.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddRecipe.Location = new System.Drawing.Point(587, 276);
            this.btnAddRecipe.Name = "btnAddRecipe";
            this.btnAddRecipe.Size = new System.Drawing.Size(129, 37);
            this.btnAddRecipe.TabIndex = 8;
            this.btnAddRecipe.Text = "Add Recipe";
            this.btnAddRecipe.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(433, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 28);
            this.label3.TabIndex = 9;
            this.label3.Text = "Product amount:";
            // 
            // txtProductAmount
            // 
            this.txtProductAmount.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductAmount.Location = new System.Drawing.Point(595, 227);
            this.txtProductAmount.Multiline = true;
            this.txtProductAmount.Name = "txtProductAmount";
            this.txtProductAmount.Size = new System.Drawing.Size(121, 31);
            this.txtProductAmount.TabIndex = 11;
            // 
            // lblOutputAddedRecipe
            // 
            this.lblOutputAddedRecipe.AutoSize = true;
            this.lblOutputAddedRecipe.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutputAddedRecipe.Location = new System.Drawing.Point(39, 353);
            this.lblOutputAddedRecipe.Name = "lblOutputAddedRecipe";
            this.lblOutputAddedRecipe.Size = new System.Drawing.Size(20, 33);
            this.lblOutputAddedRecipe.TabIndex = 12;
            this.lblOutputAddedRecipe.Text = "l";
            // 
            // AddRecipeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(820, 471);
            this.Controls.Add(this.lblOutputAddedRecipe);
            this.Controls.Add(this.txtProductAmount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAddRecipe);
            this.Controls.Add(this.btnAddProductRecipe);
            this.Controls.Add(this.cboxRecipeProducts);
            this.Controls.Add(this.lblSelectProduct);
            this.Controls.Add(this.txtRecipeName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cboxRecipeType);
            this.Controls.Add(this.label1);
            this.Name = "AddRecipeForm";
            this.Text = "AddRecipeForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboxRecipeType;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRecipeName;
        private System.Windows.Forms.Label lblSelectProduct;
        private System.Windows.Forms.ComboBox cboxRecipeProducts;
        private System.Windows.Forms.Button btnAddProductRecipe;
        private System.Windows.Forms.Button btnAddRecipe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProductAmount;
        private System.Windows.Forms.Label lblOutputAddedRecipe;
    }
}