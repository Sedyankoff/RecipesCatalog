namespace RecipesCatalog.Forms
{
    partial class SaladsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaladsForm));
            this.dataSalads = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOpenSalad = new System.Windows.Forms.Button();
            this.btnRemoveSalad = new System.Windows.Forms.Button();
            this.btnAddSalad = new System.Windows.Forms.Button();
            this.btnSaladUnfavourite = new System.Windows.Forms.Button();
            this.btnSaladFavourite = new System.Windows.Forms.Button();
            this.picBoxSalads = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataSalads)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSalads)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSalads
            // 
            this.dataSalads.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSalads.Location = new System.Drawing.Point(450, 72);
            this.dataSalads.Name = "dataSalads";
            this.dataSalads.Size = new System.Drawing.Size(322, 365);
            this.dataSalads.TabIndex = 0;
            this.dataSalads.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataSalads_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(500, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 47);
            this.label1.TabIndex = 1;
            this.label1.Text = "Salads Recipes:";
            // 
            // btnOpenSalad
            // 
            this.btnOpenSalad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenSalad.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOpenSalad.Location = new System.Drawing.Point(18, 397);
            this.btnOpenSalad.Name = "btnOpenSalad";
            this.btnOpenSalad.Size = new System.Drawing.Size(95, 40);
            this.btnOpenSalad.TabIndex = 2;
            this.btnOpenSalad.Text = "Open";
            this.btnOpenSalad.UseVisualStyleBackColor = true;
            this.btnOpenSalad.Click += new System.EventHandler(this.btnOpenSalad_Click);
            // 
            // btnRemoveSalad
            // 
            this.btnRemoveSalad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveSalad.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRemoveSalad.Location = new System.Drawing.Point(255, 397);
            this.btnRemoveSalad.Name = "btnRemoveSalad";
            this.btnRemoveSalad.Size = new System.Drawing.Size(95, 40);
            this.btnRemoveSalad.TabIndex = 3;
            this.btnRemoveSalad.Text = "Remove";
            this.btnRemoveSalad.UseVisualStyleBackColor = true;
            this.btnRemoveSalad.Click += new System.EventHandler(this.btnRemoveSalad_Click_1);
            // 
            // btnAddSalad
            // 
            this.btnAddSalad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddSalad.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddSalad.Location = new System.Drawing.Point(137, 397);
            this.btnAddSalad.Name = "btnAddSalad";
            this.btnAddSalad.Size = new System.Drawing.Size(95, 40);
            this.btnAddSalad.TabIndex = 4;
            this.btnAddSalad.Text = "Add";
            this.btnAddSalad.UseVisualStyleBackColor = true;
            this.btnAddSalad.Click += new System.EventHandler(this.btnAddSalad_Click);
            // 
            // btnSaladUnfavourite
            // 
            this.btnSaladUnfavourite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaladUnfavourite.FlatAppearance.BorderSize = 0;
            this.btnSaladUnfavourite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaladUnfavourite.Image = ((System.Drawing.Image)(resources.GetObject("btnSaladUnfavourite.Image")));
            this.btnSaladUnfavourite.Location = new System.Drawing.Point(370, 398);
            this.btnSaladUnfavourite.Name = "btnSaladUnfavourite";
            this.btnSaladUnfavourite.Size = new System.Drawing.Size(50, 40);
            this.btnSaladUnfavourite.TabIndex = 7;
            this.btnSaladUnfavourite.UseVisualStyleBackColor = true;
            this.btnSaladUnfavourite.Visible = false;
            this.btnSaladUnfavourite.Click += new System.EventHandler(this.btnSaladUnfavourite_Click);
            // 
            // btnSaladFavourite
            // 
            this.btnSaladFavourite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaladFavourite.FlatAppearance.BorderSize = 0;
            this.btnSaladFavourite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaladFavourite.Image = ((System.Drawing.Image)(resources.GetObject("btnSaladFavourite.Image")));
            this.btnSaladFavourite.Location = new System.Drawing.Point(370, 397);
            this.btnSaladFavourite.Name = "btnSaladFavourite";
            this.btnSaladFavourite.Size = new System.Drawing.Size(50, 40);
            this.btnSaladFavourite.TabIndex = 6;
            this.btnSaladFavourite.UseVisualStyleBackColor = true;
            this.btnSaladFavourite.Click += new System.EventHandler(this.btnSaladFavourite_Click);
            // 
            // picBoxSalads
            // 
            this.picBoxSalads.Image = ((System.Drawing.Image)(resources.GetObject("picBoxSalads.Image")));
            this.picBoxSalads.Location = new System.Drawing.Point(88, 79);
            this.picBoxSalads.Name = "picBoxSalads";
            this.picBoxSalads.Size = new System.Drawing.Size(258, 278);
            this.picBoxSalads.TabIndex = 5;
            this.picBoxSalads.TabStop = false;
            // 
            // SaladsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(820, 471);
            this.Controls.Add(this.btnSaladUnfavourite);
            this.Controls.Add(this.btnSaladFavourite);
            this.Controls.Add(this.picBoxSalads);
            this.Controls.Add(this.btnAddSalad);
            this.Controls.Add(this.btnRemoveSalad);
            this.Controls.Add(this.btnOpenSalad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataSalads);
            this.Name = "SaladsForm";
            this.Text = "SaladsForm";
            this.Load += new System.EventHandler(this.SaladsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSalads)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSalads)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataSalads;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOpenSalad;
        private System.Windows.Forms.Button btnRemoveSalad;
        private System.Windows.Forms.Button btnAddSalad;
        private System.Windows.Forms.PictureBox picBoxSalads;
        private System.Windows.Forms.Button btnSaladFavourite;
        private System.Windows.Forms.Button btnSaladUnfavourite;
    }
}