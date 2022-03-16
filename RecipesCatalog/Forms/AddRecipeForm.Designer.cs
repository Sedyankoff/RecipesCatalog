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
            this.lblOutputAddedRecipe = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPreparation = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(447, 122);
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
            this.cboxRecipeType.Location = new System.Drawing.Point(609, 119);
            this.cboxRecipeType.Name = "cboxRecipeType";
            this.cboxRecipeType.Size = new System.Drawing.Size(121, 31);
            this.cboxRecipeType.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(86, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(264, 262);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(447, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Recipe Name: ";
            // 
            // txtRecipeName
            // 
            this.txtRecipeName.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecipeName.Location = new System.Drawing.Point(609, 167);
            this.txtRecipeName.Multiline = true;
            this.txtRecipeName.Name = "txtRecipeName";
            this.txtRecipeName.Size = new System.Drawing.Size(121, 31);
            this.txtRecipeName.TabIndex = 4;
            // 
            // lblSelectProduct
            // 
            this.lblSelectProduct.AutoSize = true;
            this.lblSelectProduct.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectProduct.Location = new System.Drawing.Point(447, 215);
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
            this.cboxRecipeProducts.Location = new System.Drawing.Point(609, 215);
            this.cboxRecipeProducts.Name = "cboxRecipeProducts";
            this.cboxRecipeProducts.Size = new System.Drawing.Size(121, 31);
            this.cboxRecipeProducts.TabIndex = 6;
            this.cboxRecipeProducts.SelectedIndexChanged += new System.EventHandler(this.cboxRecipeProducts_SelectedIndexChanged);
            // 
            // btnAddProductRecipe
            // 
            this.btnAddProductRecipe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddProductRecipe.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddProductRecipe.Location = new System.Drawing.Point(452, 276);
            this.btnAddProductRecipe.Name = "btnAddProductRecipe";
            this.btnAddProductRecipe.Size = new System.Drawing.Size(129, 37);
            this.btnAddProductRecipe.TabIndex = 7;
            this.btnAddProductRecipe.Text = "Add Product";
            this.btnAddProductRecipe.UseVisualStyleBackColor = true;
            this.btnAddProductRecipe.Click += new System.EventHandler(this.btnAddProductRecipe_Click);
            // 
            // btnAddRecipe
            // 
            this.btnAddRecipe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddRecipe.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddRecipe.Location = new System.Drawing.Point(601, 276);
            this.btnAddRecipe.Name = "btnAddRecipe";
            this.btnAddRecipe.Size = new System.Drawing.Size(129, 37);
            this.btnAddRecipe.TabIndex = 8;
            this.btnAddRecipe.Text = "Add Recipe";
            this.btnAddRecipe.UseVisualStyleBackColor = true;
            this.btnAddRecipe.Click += new System.EventHandler(this.btnAddRecipe_Click);
            // 
            // lblOutputAddedRecipe
            // 
            this.lblOutputAddedRecipe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOutputAddedRecipe.AutoSize = true;
            this.lblOutputAddedRecipe.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutputAddedRecipe.Location = new System.Drawing.Point(254, 28);
            this.lblOutputAddedRecipe.Name = "lblOutputAddedRecipe";
            this.lblOutputAddedRecipe.Size = new System.Drawing.Size(0, 33);
            this.lblOutputAddedRecipe.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(81, 326);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 28);
            this.label3.TabIndex = 13;
            this.label3.Text = "Preparation:";
            // 
            // txtPreparation
            // 
            this.txtPreparation.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPreparation.Location = new System.Drawing.Point(86, 360);
            this.txtPreparation.Multiline = true;
            this.txtPreparation.Name = "txtPreparation";
            this.txtPreparation.Size = new System.Drawing.Size(644, 105);
            this.txtPreparation.TabIndex = 14;
            // 
            // AddRecipeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(820, 471);
            this.Controls.Add(this.txtPreparation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblOutputAddedRecipe);
            this.Controls.Add(this.btnAddRecipe);
            this.Controls.Add(this.btnAddProductRecipe);
            this.Controls.Add(this.cboxRecipeProducts);
            this.Controls.Add(this.lblSelectProduct);
            this.Controls.Add(this.txtRecipeName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cboxRecipeType);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(836, 510);
            this.MinimumSize = new System.Drawing.Size(836, 510);
            this.Name = "AddRecipeForm";
            this.Text = "AddRecipeForm";
            this.Load += new System.EventHandler(this.AddRecipeForm_Load);
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
        private System.Windows.Forms.Label lblOutputAddedRecipe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPreparation;
    }
}