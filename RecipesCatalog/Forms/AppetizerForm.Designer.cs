
namespace RecipesCatalog.Forms
{
    partial class AppetizerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppetizerForm));
            this.label1 = new System.Windows.Forms.Label();
            this.dataAppetizer = new System.Windows.Forms.DataGridView();
            this.btnAddAppetizer = new System.Windows.Forms.Button();
            this.btnRemoveAppetizer = new System.Windows.Forms.Button();
            this.btnOpenAppetizer = new System.Windows.Forms.Button();
            this.btnAppetizerUnfavourite = new System.Windows.Forms.Button();
            this.picBoxAppetizer = new System.Windows.Forms.PictureBox();
            this.btnAppetizerFavourite = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataAppetizer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAppetizer)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(475, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 47);
            this.label1.TabIndex = 3;
            this.label1.Text = "Appetizers Recipes:";
            // 
            // dataAppetizer
            // 
            this.dataAppetizer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataAppetizer.Location = new System.Drawing.Point(450, 72);
            this.dataAppetizer.Name = "dataAppetizer";
            this.dataAppetizer.Size = new System.Drawing.Size(322, 365);
            this.dataAppetizer.TabIndex = 2;
            // 
            // btnAddAppetizer
            // 
            this.btnAddAppetizer.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddAppetizer.Location = new System.Drawing.Point(137, 397);
            this.btnAddAppetizer.Name = "btnAddAppetizer";
            this.btnAddAppetizer.Size = new System.Drawing.Size(95, 40);
            this.btnAddAppetizer.TabIndex = 10;
            this.btnAddAppetizer.Text = "Add";
            this.btnAddAppetizer.UseVisualStyleBackColor = true;
            // 
            // btnRemoveAppetizer
            // 
            this.btnRemoveAppetizer.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRemoveAppetizer.Location = new System.Drawing.Point(255, 397);
            this.btnRemoveAppetizer.Name = "btnRemoveAppetizer";
            this.btnRemoveAppetizer.Size = new System.Drawing.Size(95, 40);
            this.btnRemoveAppetizer.TabIndex = 9;
            this.btnRemoveAppetizer.Text = "Remove";
            this.btnRemoveAppetizer.UseVisualStyleBackColor = true;
            // 
            // btnOpenAppetizer
            // 
            this.btnOpenAppetizer.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOpenAppetizer.Location = new System.Drawing.Point(18, 397);
            this.btnOpenAppetizer.Name = "btnOpenAppetizer";
            this.btnOpenAppetizer.Size = new System.Drawing.Size(95, 40);
            this.btnOpenAppetizer.TabIndex = 8;
            this.btnOpenAppetizer.Text = "Open";
            this.btnOpenAppetizer.UseVisualStyleBackColor = true;
            // 
            // btnAppetizerUnfavourite
            // 
            this.btnAppetizerUnfavourite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.btnAppetizerUnfavourite.FlatAppearance.BorderSize = 0;
            this.btnAppetizerUnfavourite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAppetizerUnfavourite.Image = global::RecipesCatalog.Properties.Resources.star;
            this.btnAppetizerUnfavourite.Location = new System.Drawing.Point(370, 397);
            this.btnAppetizerUnfavourite.Name = "btnAppetizerUnfavourite";
            this.btnAppetizerUnfavourite.Size = new System.Drawing.Size(50, 40);
            this.btnAppetizerUnfavourite.TabIndex = 12;
            this.btnAppetizerUnfavourite.UseVisualStyleBackColor = false;
            this.btnAppetizerUnfavourite.Visible = false;
            // 
            // picBoxAppetizer
            // 
            this.picBoxAppetizer.Image = global::RecipesCatalog.Properties.Resources.logoFinished;
            this.picBoxAppetizer.Location = new System.Drawing.Point(88, 79);
            this.picBoxAppetizer.Name = "picBoxAppetizer";
            this.picBoxAppetizer.Size = new System.Drawing.Size(258, 278);
            this.picBoxAppetizer.TabIndex = 11;
            this.picBoxAppetizer.TabStop = false;
            // 
            // btnAppetizerFavourite
            // 
            this.btnAppetizerFavourite.FlatAppearance.BorderSize = 0;
            this.btnAppetizerFavourite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAppetizerFavourite.Image = ((System.Drawing.Image)(resources.GetObject("btnAppetizerFavourite.Image")));
            this.btnAppetizerFavourite.Location = new System.Drawing.Point(370, 397);
            this.btnAppetizerFavourite.Name = "btnAppetizerFavourite";
            this.btnAppetizerFavourite.Size = new System.Drawing.Size(50, 40);
            this.btnAppetizerFavourite.TabIndex = 13;
            this.btnAppetizerFavourite.UseVisualStyleBackColor = true;
            // 
            // AppetizerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(820, 471);
            this.Controls.Add(this.btnAppetizerFavourite);
            this.Controls.Add(this.btnAppetizerUnfavourite);
            this.Controls.Add(this.picBoxAppetizer);
            this.Controls.Add(this.btnAddAppetizer);
            this.Controls.Add(this.btnRemoveAppetizer);
            this.Controls.Add(this.btnOpenAppetizer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataAppetizer);
            this.Name = "AppetizerForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.AppetizerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataAppetizer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAppetizer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataAppetizer;
        private System.Windows.Forms.Button btnAppetizerUnfavourite;
        private System.Windows.Forms.PictureBox picBoxAppetizer;
        private System.Windows.Forms.Button btnAddAppetizer;
        private System.Windows.Forms.Button btnRemoveAppetizer;
        private System.Windows.Forms.Button btnOpenAppetizer;
        private System.Windows.Forms.Button btnAppetizerFavourite;
    }
}