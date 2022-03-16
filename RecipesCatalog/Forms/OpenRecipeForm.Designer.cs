namespace RecipesCatalog.Forms
{
    partial class OpenRecipeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OpenRecipeForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOpenType = new System.Windows.Forms.TextBox();
            this.txtOpenName = new System.Windows.Forms.TextBox();
            this.txtOpenProducts = new System.Windows.Forms.TextBox();
            this.txtOpenPreparation = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(497, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(248, 245);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(80, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Recipe Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(80, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 33);
            this.label2.TabIndex = 2;
            this.label2.Text = "Recipe Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(80, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 33);
            this.label3.TabIndex = 3;
            this.label3.Text = "Products:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(80, 314);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 33);
            this.label4.TabIndex = 4;
            this.label4.Text = "Preparation:";
            // 
            // txtOpenType
            // 
            this.txtOpenType.Enabled = false;
            this.txtOpenType.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtOpenType.Location = new System.Drawing.Point(252, 67);
            this.txtOpenType.Multiline = true;
            this.txtOpenType.Name = "txtOpenType";
            this.txtOpenType.ReadOnly = true;
            this.txtOpenType.Size = new System.Drawing.Size(201, 41);
            this.txtOpenType.TabIndex = 5;
            this.txtOpenType.TextChanged += new System.EventHandler(this.txtOpenType_TextChanged);
            // 
            // txtOpenName
            // 
            this.txtOpenName.Enabled = false;
            this.txtOpenName.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtOpenName.Location = new System.Drawing.Point(252, 130);
            this.txtOpenName.Multiline = true;
            this.txtOpenName.Name = "txtOpenName";
            this.txtOpenName.ReadOnly = true;
            this.txtOpenName.Size = new System.Drawing.Size(201, 41);
            this.txtOpenName.TabIndex = 6;
            // 
            // txtOpenProducts
            // 
            this.txtOpenProducts.Enabled = false;
            this.txtOpenProducts.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtOpenProducts.Location = new System.Drawing.Point(86, 237);
            this.txtOpenProducts.Multiline = true;
            this.txtOpenProducts.Name = "txtOpenProducts";
            this.txtOpenProducts.ReadOnly = true;
            this.txtOpenProducts.Size = new System.Drawing.Size(367, 56);
            this.txtOpenProducts.TabIndex = 7;
            // 
            // txtOpenPreparation
            // 
            this.txtOpenPreparation.Enabled = false;
            this.txtOpenPreparation.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtOpenPreparation.Location = new System.Drawing.Point(86, 366);
            this.txtOpenPreparation.Multiline = true;
            this.txtOpenPreparation.Name = "txtOpenPreparation";
            this.txtOpenPreparation.ReadOnly = true;
            this.txtOpenPreparation.Size = new System.Drawing.Size(644, 105);
            this.txtOpenPreparation.TabIndex = 8;
            // 
            // OpenRecipeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(794, 506);
            this.Controls.Add(this.txtOpenPreparation);
            this.Controls.Add(this.txtOpenProducts);
            this.Controls.Add(this.txtOpenName);
            this.Controls.Add(this.txtOpenType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(810, 545);
            this.MinimumSize = new System.Drawing.Size(810, 545);
            this.Name = "OpenRecipeForm";
            this.Text = "OpenRecipeForm";
            this.Load += new System.EventHandler(this.OpenRecipeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOpenType;
        private System.Windows.Forms.TextBox txtOpenName;
        private System.Windows.Forms.TextBox txtOpenProducts;
        private System.Windows.Forms.TextBox txtOpenPreparation;
    }
}