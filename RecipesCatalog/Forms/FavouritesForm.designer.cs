
namespace RecipesCatalog.Forms
{
    partial class FavouritesForm
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
            this.dataFavourites = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnOpenFavourite = new System.Windows.Forms.Button();
            this.btnRemoveFavourite = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataFavourites)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataFavourites
            // 
            this.dataFavourites.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataFavourites.Location = new System.Drawing.Point(450, 72);
            this.dataFavourites.Name = "dataFavourites";
            this.dataFavourites.Size = new System.Drawing.Size(322, 365);
            this.dataFavourites.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RecipesCatalog.Properties.Resources.logoFinished;
            this.pictureBox1.Location = new System.Drawing.Point(84, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(257, 232);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnOpenFavourite
            // 
            this.btnOpenFavourite.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOpenFavourite.Location = new System.Drawing.Point(84, 394);
            this.btnOpenFavourite.Name = "btnOpenFavourite";
            this.btnOpenFavourite.Size = new System.Drawing.Size(100, 43);
            this.btnOpenFavourite.TabIndex = 3;
            this.btnOpenFavourite.Text = "Open";
            this.btnOpenFavourite.UseVisualStyleBackColor = true;
            this.btnOpenFavourite.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRemoveFavourite
            // 
            this.btnRemoveFavourite.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRemoveFavourite.Location = new System.Drawing.Point(241, 394);
            this.btnRemoveFavourite.Name = "btnRemoveFavourite";
            this.btnRemoveFavourite.Size = new System.Drawing.Size(100, 43);
            this.btnRemoveFavourite.TabIndex = 4;
            this.btnRemoveFavourite.Text = "Remove";
            this.btnRemoveFavourite.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(443, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 47);
            this.label1.TabIndex = 5;
            this.label1.Text = "Your Favourite Recipes:";
            // 
            // FavouritesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(820, 471);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRemoveFavourite);
            this.Controls.Add(this.btnOpenFavourite);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataFavourites);
            this.Name = "FavouritesForm";
            this.Text = "FavouritesForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataFavourites)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataFavourites;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnOpenFavourite;
        private System.Windows.Forms.Button btnRemoveFavourite;
        private System.Windows.Forms.Label label1;
    }
}