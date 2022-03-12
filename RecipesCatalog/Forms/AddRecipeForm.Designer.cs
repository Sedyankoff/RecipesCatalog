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
            this.comboBoxRecipeType = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxRecipeName = new System.Windows.Forms.TextBox();
            this.lblSelectProduct = new System.Windows.Forms.Label();
            this.comboBoxRecipeProducts = new System.Windows.Forms.ComboBox();
            this.btnAddProductRecipe = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblOutput = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(439, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Type: ";
            // 
            // comboBoxRecipeType
            // 
            this.comboBoxRecipeType.BackColor = System.Drawing.Color.White;
            this.comboBoxRecipeType.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxRecipeType.FormattingEnabled = true;
            this.comboBoxRecipeType.Items.AddRange(new object[] {
            "Salad",
            "Appetizer",
            "Main Course",
            "Desert"});
            this.comboBoxRecipeType.Location = new System.Drawing.Point(595, 27);
            this.comboBoxRecipeType.Name = "comboBoxRecipeType";
            this.comboBoxRecipeType.Size = new System.Drawing.Size(121, 31);
            this.comboBoxRecipeType.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(45, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(264, 262);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(437, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Recipe Name: ";
            // 
            // txtBoxRecipeName
            // 
            this.txtBoxRecipeName.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxRecipeName.Location = new System.Drawing.Point(595, 71);
            this.txtBoxRecipeName.Multiline = true;
            this.txtBoxRecipeName.Name = "txtBoxRecipeName";
            this.txtBoxRecipeName.Size = new System.Drawing.Size(121, 28);
            this.txtBoxRecipeName.TabIndex = 4;
            // 
            // lblSelectProduct
            // 
            this.lblSelectProduct.AutoSize = true;
            this.lblSelectProduct.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectProduct.Location = new System.Drawing.Point(437, 123);
            this.lblSelectProduct.Name = "lblSelectProduct";
            this.lblSelectProduct.Size = new System.Drawing.Size(142, 28);
            this.lblSelectProduct.TabIndex = 5;
            this.lblSelectProduct.Text = "Select Products:";
            // 
            // comboBoxRecipeProducts
            // 
            this.comboBoxRecipeProducts.BackColor = System.Drawing.Color.White;
            this.comboBoxRecipeProducts.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxRecipeProducts.FormattingEnabled = true;
            this.comboBoxRecipeProducts.Items.AddRange(new object[] {
            "Salad",
            "Appetizer",
            "Main Course",
            "Desert"});
            this.comboBoxRecipeProducts.Location = new System.Drawing.Point(595, 120);
            this.comboBoxRecipeProducts.Name = "comboBoxRecipeProducts";
            this.comboBoxRecipeProducts.Size = new System.Drawing.Size(121, 31);
            this.comboBoxRecipeProducts.TabIndex = 6;
            // 
            // btnAddProductRecipe
            // 
            this.btnAddProductRecipe.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProductRecipe.Location = new System.Drawing.Point(438, 222);
            this.btnAddProductRecipe.Name = "btnAddProductRecipe";
            this.btnAddProductRecipe.Size = new System.Drawing.Size(129, 37);
            this.btnAddProductRecipe.TabIndex = 7;
            this.btnAddProductRecipe.Text = "Add Product";
            this.btnAddProductRecipe.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(587, 222);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 37);
            this.button2.TabIndex = 8;
            this.button2.Text = "Add Recipe";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(433, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 28);
            this.label3.TabIndex = 9;
            this.label3.Text = "Product amount:";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(595, 173);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 28);
            this.textBox2.TabIndex = 11;
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput.Location = new System.Drawing.Point(39, 308);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(20, 33);
            this.lblOutput.TabIndex = 12;
            this.lblOutput.Text = "l";
            // 
            // AddRecipeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(820, 471);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAddProductRecipe);
            this.Controls.Add(this.comboBoxRecipeProducts);
            this.Controls.Add(this.lblSelectProduct);
            this.Controls.Add(this.txtBoxRecipeName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBoxRecipeType);
            this.Controls.Add(this.label1);
            this.Name = "AddRecipeForm";
            this.Text = "AddRecipeForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxRecipeType;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxRecipeName;
        private System.Windows.Forms.Label lblSelectProduct;
        private System.Windows.Forms.ComboBox comboBoxRecipeProducts;
        private System.Windows.Forms.Button btnAddProductRecipe;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblOutput;
    }
}