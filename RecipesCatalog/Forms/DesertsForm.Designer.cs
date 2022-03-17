namespace RecipesCatalog.Forms
{
    partial class DesertsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DesertsForm));
            this.btnDesertUnfavourite = new System.Windows.Forms.Button();
            this.btnDesertFavourite = new System.Windows.Forms.Button();
            this.picBoxSalads = new System.Windows.Forms.PictureBox();
            this.btnAddDesert = new System.Windows.Forms.Button();
            this.btnRemoveDesert = new System.Windows.Forms.Button();
            this.btnOpenDesert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataDeserts = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSalads)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDeserts)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDesertUnfavourite
            // 
            this.btnDesertUnfavourite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDesertUnfavourite.FlatAppearance.BorderSize = 0;
            this.btnDesertUnfavourite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesertUnfavourite.Image = ((System.Drawing.Image)(resources.GetObject("btnDesertUnfavourite.Image")));
            this.btnDesertUnfavourite.Location = new System.Drawing.Point(370, 397);
            this.btnDesertUnfavourite.Name = "btnDesertUnfavourite";
            this.btnDesertUnfavourite.Size = new System.Drawing.Size(50, 40);
            this.btnDesertUnfavourite.TabIndex = 15;
            this.btnDesertUnfavourite.UseVisualStyleBackColor = true;
            this.btnDesertUnfavourite.Visible = false;
            this.btnDesertUnfavourite.Click += new System.EventHandler(this.btnDesertUnfavourite_Click);
            // 
            // btnDesertFavourite
            // 
            this.btnDesertFavourite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDesertFavourite.FlatAppearance.BorderSize = 0;
            this.btnDesertFavourite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesertFavourite.Image = ((System.Drawing.Image)(resources.GetObject("btnDesertFavourite.Image")));
            this.btnDesertFavourite.Location = new System.Drawing.Point(370, 397);
            this.btnDesertFavourite.Name = "btnDesertFavourite";
            this.btnDesertFavourite.Size = new System.Drawing.Size(50, 40);
            this.btnDesertFavourite.TabIndex = 14;
            this.btnDesertFavourite.UseVisualStyleBackColor = true;
            this.btnDesertFavourite.Click += new System.EventHandler(this.btnDesertFavourite_Click);
            // 
            // picBoxSalads
            // 
            this.picBoxSalads.Image = ((System.Drawing.Image)(resources.GetObject("picBoxSalads.Image")));
            this.picBoxSalads.Location = new System.Drawing.Point(88, 79);
            this.picBoxSalads.Name = "picBoxSalads";
            this.picBoxSalads.Size = new System.Drawing.Size(258, 278);
            this.picBoxSalads.TabIndex = 13;
            this.picBoxSalads.TabStop = false;
            // 
            // btnAddDesert
            // 
            this.btnAddDesert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddDesert.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddDesert.Location = new System.Drawing.Point(137, 397);
            this.btnAddDesert.Name = "btnAddDesert";
            this.btnAddDesert.Size = new System.Drawing.Size(95, 40);
            this.btnAddDesert.TabIndex = 12;
            this.btnAddDesert.Text = "Add";
            this.btnAddDesert.UseVisualStyleBackColor = true;
            this.btnAddDesert.Click += new System.EventHandler(this.btnAddDesert_Click);
            // 
            // btnRemoveDesert
            // 
            this.btnRemoveDesert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveDesert.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRemoveDesert.Location = new System.Drawing.Point(255, 397);
            this.btnRemoveDesert.Name = "btnRemoveDesert";
            this.btnRemoveDesert.Size = new System.Drawing.Size(95, 40);
            this.btnRemoveDesert.TabIndex = 11;
            this.btnRemoveDesert.Text = "Remove";
            this.btnRemoveDesert.UseVisualStyleBackColor = true;
            this.btnRemoveDesert.Click += new System.EventHandler(this.btnRemoveDesert_Click_1);
            // 
            // btnOpenDesert
            // 
            this.btnOpenDesert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenDesert.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOpenDesert.Location = new System.Drawing.Point(18, 397);
            this.btnOpenDesert.Name = "btnOpenDesert";
            this.btnOpenDesert.Size = new System.Drawing.Size(95, 40);
            this.btnOpenDesert.TabIndex = 10;
            this.btnOpenDesert.Text = "Open";
            this.btnOpenDesert.UseVisualStyleBackColor = true;
            this.btnOpenDesert.Click += new System.EventHandler(this.btnOpenDesert_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(495, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 47);
            this.label1.TabIndex = 9;
            this.label1.Text = "Deserts Recipes:";
            // 
            // dataDeserts
            // 
            this.dataDeserts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDeserts.Location = new System.Drawing.Point(450, 72);
            this.dataDeserts.Name = "dataDeserts";
            this.dataDeserts.Size = new System.Drawing.Size(322, 365);
            this.dataDeserts.TabIndex = 8;
            this.dataDeserts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataDeserts_CellContentClick);
            // 
            // DesertsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(820, 471);
            this.Controls.Add(this.btnDesertUnfavourite);
            this.Controls.Add(this.btnDesertFavourite);
            this.Controls.Add(this.picBoxSalads);
            this.Controls.Add(this.btnAddDesert);
            this.Controls.Add(this.btnRemoveDesert);
            this.Controls.Add(this.btnOpenDesert);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataDeserts);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "DesertsForm";
            this.Text = "DesertsForm";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSalads)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDeserts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDesertUnfavourite;
        private System.Windows.Forms.Button btnDesertFavourite;
        private System.Windows.Forms.PictureBox picBoxSalads;
        private System.Windows.Forms.Button btnAddDesert;
        private System.Windows.Forms.Button btnRemoveDesert;
        private System.Windows.Forms.Button btnOpenDesert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataDeserts;
    }
}